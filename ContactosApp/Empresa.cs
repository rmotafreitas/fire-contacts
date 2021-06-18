using System;
using System.Data.OleDb;

namespace ContactosApp
{
    class Empresa
    {
        static string strProvider = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Database\Contactos.accdb;Persist Security Info=False";
        private static int ID;
        public static int iD
        {
            get { return ID; }
            set { ID = value; }
        }

        public static dynamic getEmpresaByNome(string nome)
        {
            int id = 0;
            string contacto = "";
            string morada = "";
            try
            {
                OleDbConnection bd = new OleDbConnection();
                bd.ConnectionString = strProvider;
                bd.Open();
                OleDbCommand ContactsTable = new OleDbCommand("select * from Empresas where Nome = @a", bd);
                ContactsTable.Parameters.AddWithValue("@a", nome);

                OleDbDataReader user = ContactsTable.ExecuteReader();


                while (user.Read())
                {
                    nome = user["Nome"].ToString(); //Read a value from query name  
                    contacto = user["Contacto"].ToString();
                    morada = user["Morada"].ToString();
                }

            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }

            var Empresa = new
            {
                id,
                nome,
                contacto = contacto,
                morada = morada,
            };

            return Empresa;
        }
        public static dynamic getEmpresaInfo(int ID)
        {
            string nome = "";
            string contacto = "";
            string morada = "";
            try
            {
                OleDbConnection bd = new OleDbConnection();
                bd.ConnectionString = strProvider;
                bd.Open();
                OleDbCommand ContactsTable = new OleDbCommand("select * from Empresas where ID = @a", bd);
                ContactsTable.Parameters.AddWithValue("@a", ID.ToString());

                OleDbDataReader user = ContactsTable.ExecuteReader();


                while (user.Read())
                {
                    nome = user["Nome"].ToString(); //Read a value from query name  
                    contacto = user["Contacto"].ToString();
                    morada = user["Morada"].ToString();
                }
                user.Close();
                bd.Close();

            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }

            var Empresa = new
            {
                id = ID,
                nome = nome,
                contacto = contacto,
                morada = morada,
            };


            return Empresa;
        }



        public static void update(string nome, string morada, string contacto, int IDEmpresa)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();
            OleDbCommand cmd = bd.CreateCommand();
            string strUpdate = ($"update Empresas set Nome = {"'" + nome + "'"}, Morada = {"'" + morada + "'"}, Contacto = {"'" + contacto + "'"} WHERE ID = {IDEmpresa}");

            cmd.CommandText = strUpdate;

            cmd.ExecuteNonQuery();
            bd.Close();
        }

        public static void add(string nome, string morada, string contacto)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();
            OleDbCommand cmd = bd.CreateCommand();
            string strDelete = ($"INSERT INTO Empresas (Nome, Morada, Contacto) VALUES('{nome}', '{morada}', '{contacto}')");

            cmd.CommandText = strDelete;

            cmd.ExecuteNonQuery();
            bd.Close();
        }

        public static string WhichContactsHaveThisCompany(int IDEmpresa)
        {
            string[] ids = DbFunctions.getAllIDs("ID", "Contactos");
            string output = "";
            for (int i = 0; i < ids.Length; i++)
            {
                dynamic info = Contacto.getContactoInfo(Int32.Parse(ids[i]));
                if (info.IDEmpresa == IDEmpresa)
                {
                    output += $" -> {info.nome}\n";
                }
            }
            return output;
        }
    }
}
