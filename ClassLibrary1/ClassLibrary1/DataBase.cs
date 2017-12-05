using System;
using Npgsql;


namespace Connections
{
    class DBConnection
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=db.fe.up.pt;Port=5432;UserId=up201306445;Password=obaptisteegay;Database=up201306445;");

        /**********************************funcoes gerais***************************************************************/
        public void OpenConn()
        {
            try
            {
                conn.Open();
                string query = "SET SCHEMA SEAI";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                Int64 result = (Int64)cmd.ExecuteScalar();
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
        public bool verifica_n_ordem(int workorder, string table)
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
       
        /****************************************************************************************************/

    }
}