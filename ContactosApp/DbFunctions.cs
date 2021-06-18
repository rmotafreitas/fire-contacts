using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ContactosApp
{
    class DbFunctions
    {
        static string strProvider = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Database\Contactos.accdb;Persist Security Info=False";


        public static string getFirtElement(string what, string from)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();

            string result = "";
            int count = 0;
            OleDbCommand cmd_table = new OleDbCommand($"select * from {from}", bd);
            OleDbDataReader DR_Table = cmd_table.ExecuteReader();


            while (DR_Table.Read())
            {
                if (count == 1) break;
                result = DR_Table[what].ToString();
                count++;
            }
            DR_Table.Close();
            bd.Close();

            return result;
        }

        public static string getLastElement(string what, string from)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();

            string result = "";
            OleDbCommand cmd_table = new OleDbCommand($"select * from {from}", bd);
            OleDbDataReader DR_Table = cmd_table.ExecuteReader();


            while (DR_Table.Read())
            {
                result = DR_Table[what].ToString();
            }
            DR_Table.Close();
            bd.Close();

            return result;
        }

        public static bool is1x(string what, string from, string value)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();

            string result = "";
            OleDbCommand cmd_table = new OleDbCommand($"select * from {from}", bd);
            OleDbDataReader DR_Table = cmd_table.ExecuteReader();

            int count = 0;
            while (DR_Table.Read())
            {
                result = DR_Table[what].ToString();
                if (result == value) count++;
            }
            DR_Table.Close();
            bd.Close();

            return (count > 0 ? true : false);
        }

        public static bool is2x(string what, string from, string value)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();

            string result = "";
            OleDbCommand cmd_table = new OleDbCommand($"select * from {from}", bd);
            OleDbDataReader DR_Table = cmd_table.ExecuteReader();

            int count = 0;
            while (DR_Table.Read())
            {
                result = DR_Table[what].ToString();
                if (result == value) count++;
            }
            DR_Table.Close();
            bd.Close();

            return (count > 1 ? true : false);
        }

        public static void deleteRecord(string from, string condition)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();
            OleDbCommand cmd = bd.CreateCommand();
            string strDelete = $"DELETE FROM {from} WHERE {condition}";

            cmd.CommandText = strDelete;

            cmd.ExecuteNonQuery();
            bd.Close();
        }

        public static string[] getAllIDs(string what, string from)
        {
            string[] ids = new string[0];

            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();


            OleDbCommand cmd_Table = new OleDbCommand($"select * from {from}", bd);
            OleDbDataReader DR_table = cmd_Table.ExecuteReader();


            while (DR_table.Read())
            {
                Array.Resize(ref ids, ids.Length + 1);
                ids[ids.GetUpperBound(0)] = DR_table[what].ToString();
            }

            DR_table.Close();
            bd.Close();
            return ids;

        }

        public static int Count(string table)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();

            OleDbCommand cmd = bd.CreateCommand();
            string comand = ($"SELECT * FROM {table}");
            cmd.CommandText = comand;
            int i = 0;
            OleDbDataReader count = cmd.ExecuteReader();
            while (count.Read())
            {
                i++;
            }
            count.Close();
            bd.Close();

            return i;
        }

    }
}
