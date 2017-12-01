using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Conections
{
    class dbconnection
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=db.fe.up.pt;Port=5432;UserId=up201306445;Password=obaptisteegay;Database=up201306445;");

        /**********************************funcoes gerais***************************************************************/

        public void OpenConn()
        {
            try
            {
                conn.Open();

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error Na OpenConn()");
            }
        }

        public void CloseConn()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error :S");
            }
        }
        //verifica se ja existe esta ordem na base de dados
        // retorna verdadeiro se nao existir
        public bool verifica_n_ordem(string workorder, string table)
        {

            this.OpenConn();
            string query = "select count(*) from " + table + " where n_ordem ='" + workorder + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            Int64 result = (Int64)cmd.ExecuteScalar();
            //string result_s = result.ToString();
            //MessageBox.Show(result_s);
            if (result == 0)
            {
                this.CloseConn();
                return true;
            }
            else
            {
                this.CloseConn();
                return false;
            }

        }

        /**********************************Funcoes de inserção*******************************************/
        public void Insere_BD(string workorder, string quantidade, string pecai, string pecaf, string table)
        {
            DateTime date = DateTime.Now;
            //retorna uma string pequena com as horas e os minutos
            string hour = date.ToShortTimeString();

            // valores que vao para a base de dados
            //Console.WriteLine("Na base de dados irão ser escritos os seguintes valores : {0} - workorder \n {1} - Quantidade \n {2} - pecai \n {3} - pecaf \n {4} - hora de entrada", workorder, quantidade, pecai, pecaf, hour);

            //teste para ver se já existe esta ordem na BD
            if (verifica_n_ordem(workorder, table))
            {
                try
                {
                    this.OpenConn();
                    string query = " insert into " + table + " (n_ordem, peca_inicial, peca_final, quantidade, time_entry) values('" + workorder + "', '" + pecai + "', '" + pecaf + "', '" + quantidade + "','" + hour + "')";
                    // N é este comando que vai escrever na base de dados , este é so um "Bind"
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    // este é que escreve na BD
                    int result = cmd.ExecuteNonQuery();
                    this.CloseConn();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Erro na Inserção na tabela " + table + " ");
                }
            }
            //se a ordem ja existe avisa o user
            else
            {
                MessageBox.Show("Já existe uma ordem com este valor na base de dados");
                this.CloseConn();
                return;
            }

        }
        public void Insere_BD_descarga(string workorder, string quantidade, string pecai, string descarga, string table)
        {
            DateTime date = DateTime.Now;
            //retorna uma string pequena com as horas e os minutos
            string hour = date.ToShortTimeString();

            // valores que vao para a base de dados
            //Console.WriteLine("Na base de dados irão ser escritos os seguintes valores : {0} - workorder \n {1} - Quantidade \n {2} - pecai \n {3} - pecaf \n {4} - hora de entrada", workorder, quantidade, pecai, pecaf, hour);

            //teste para ver se já existe esta ordem na BD
            if (verifica_n_ordem(workorder, table))
            {
                try
                {
                    this.OpenConn();
                    string query = " insert into " + table + " (n_ordem, peca_inicial,quantidade,destino, time_entry) values('" + workorder + "', '" + pecai + "','" + quantidade + "','" + descarga + "','" + hour + "')";
                    // N é este comando que vai escrever na base de dados , este é so um "Bind"
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    // este é que escreve na BD
                    int result = cmd.ExecuteNonQuery();
                    this.CloseConn();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Erro na Inserção na tabela " + table + " ");
                }
            }
            //se a ordem ja existe avisa o user
            else
            {
                MessageBox.Show("Já existe uma ordem com este valor na base de dados");
                this.CloseConn();
                return;
            }

        }

        /******************************Funcoes de update**************************************************/

        //atualiza os valores na BD quando uma ordem passa para o nivel baixo
        public void ordem_start(string workorder, string table)
        {
            DateTime date = DateTime.Now;
            //retorna uma string pequena com as horas e os minutos
            string hour = date.ToShortTimeString();

            // valores que vao para a base de dados
            //Console.WriteLine("Na base de dados irão ser escritos os seguintes valores : {0} - workorder \n {1} - Quantidade \n {2} - pecai \n {3} - pecaf \n {4} - hora de entrada", workorder, quantidade, pecai, pecaf, hour);

            //teste para ver se já existe esta ordem na BD (retorna true se n existe)
            if (!verifica_n_ordem(workorder, table))
            {
                try
                {
                    this.OpenConn();
                    string query = " update " + table + " set curr_state='1',time_start='" + hour + "' where n_ordem='" + workorder + "'";
                    // N é este comando que vai escrever na base de dados , este é so um "Bind"
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    // este é que escreve na BD
                    int result = cmd.ExecuteNonQuery();
                    this.CloseConn();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Erro na Inserção na tabela " + table + " ");
                }
            }
            //se a ordem ja existe avisa o user
            else
            {
                MessageBox.Show("Não existe esta ordem na base de dados");
                this.CloseConn();
                return;
            }
        }

        // Quando uma ordem acaba o modbus avisa e essa informacao é guardada na BD
        public void ordem_end(string workorder, string table)
        {
            DateTime date = DateTime.Now;
            //retorna uma string pequena com as horas e os minutos
            string hour = date.ToShortTimeString();

            // valores que vao para a base de dados
            //Console.WriteLine("Na base de dados irão ser escritos os seguintes valores : {0} - workorder \n {1} - Quantidade \n {2} - pecai \n {3} - pecaf \n {4} - hora de entrada", workorder, quantidade, pecai, pecaf, hour);

            //teste para ver se já existe esta ordem na BD (retorna true se n existe)
            if (!verifica_n_ordem(workorder, table))
            {
                try
                {
                    this.OpenConn();
                    string query = " update " + table + " set curr_state='2',time_end='" + hour + "' where n_ordem='" + workorder + "'";
                    // N é este comando que vai escrever na base de dados , este é so um "Bind"
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    // este é que escreve na BD
                    int result = cmd.ExecuteNonQuery();
                    this.CloseConn();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Erro na Inserção na tabela " + table + " ");
                }
            }
            //se a ordem ja existe avisa o user
            else
            {
                MessageBox.Show("Não existe esta ordem na base de dados");
                this.CloseConn();
                return;
            }
        }


        /******************************Funcoes de listagem de pedidos***************************************/
        // lista dos pedidos
        // devolve a struct NpgsqlDataReader onde estão os valores todos retirados da DB para um certo estado 
        // e de uma das tabelas
        // um exemplo de leitura
        // while (dr.Read())
        // Console.Write("{0}\t{1} \n", dr[0], dr[1]);
        // enquanto existe algo para ler em dr
        // é escrito para a consola os valores da coluna 0 e 1
        public NpgsqlDataReader lista_pedidos_por_tabela_por_estado(string curr_state, string table)
        {
            this.OpenConn();
            string query = " select n_ordem, time_entry, time_start, time_end from " + table + " where curr_state='" + curr_state + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            this.CloseConn();
            return dr;
        }

        // faz o mesmo que a de cima mas apenas por tabela
        // muda apenas uma coisa
        // no dr tambem vai o estado da ordem
        public NpgsqlDataReader lista_pedidos_por_tabela(string table)
        {
            this.OpenConn();
            string query = " select n_ordem, time_entry, time_start, time_end, curr_state from " + table + " ";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            this.CloseConn();
            return dr;
        }

        /********************************Funcoes de peças totais*********************************************/

        //retorna o total ordens num determinado estado , recebe  a tabela e o estado atual
        public string numero_de_ordens_num_estado(string table, string curr_state)
        {
            this.OpenConn();
            string query = "select count(*) from " + table + " where curr_state ='" + curr_state + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            Int64 result = (Int64)cmd.ExecuteScalar();
            //string result_s = result.ToString();
            //MessageBox.Show(result_s);
            this.CloseConn();
            return result.ToString();
        }
        /****************************************************************************************************/

    }
}