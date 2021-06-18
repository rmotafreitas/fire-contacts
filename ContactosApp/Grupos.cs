using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ContactosApp
{


    class Grupos
    {

        static string strProvider = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Database\Contactos.accdb;Persist Security Info=False";


        private static int ID;
        public static int iD
        {
            get { return ID; }
            set { ID = value; }
        }

        private static string getNomeDoGrupo(int IDGrupo)
        {
            string nome = "";
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();
            OleDbCommand ContactsTable = new OleDbCommand("select * from Grupos where ID = @a", bd);
            ContactsTable.Parameters.AddWithValue("@a", IDGrupo.ToString());

            OleDbDataReader user = ContactsTable.ExecuteReader();


            while (user.Read())
            {
                nome = user["Nome"].ToString();
            }
            user.Close();
            bd.Close();
            return nome;
        }

        public static string[] getGrupos(int IdPessa)
        {


            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();
            OleDbCommand ContactsTable = new OleDbCommand("select * from PessoasEmGrupos where IDPessoa = @a", bd);
            ContactsTable.Parameters.AddWithValue("@a", IdPessa.ToString());

            OleDbDataReader all = ContactsTable.ExecuteReader();
            string[] grupos = new string[0];

            while (all.Read())
            {
                int id = Int32.Parse(all["IDGrupo"].ToString());
                Array.Resize(ref grupos, grupos.Length + 1);
                grupos[grupos.GetUpperBound(0)] = getNomeDoGrupo(id);

            }
            all.Close();
            bd.Close();
            return grupos;


        }



        public static void DeletePersonGroups(int IdPessoa)
        {
            //Apagar os grupos em que a pessoa está na tabela
            string[] groupsInDB = getGrupos(IdPessoa);

            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();
            OleDbCommand cmd = bd.CreateCommand();
            string strDelte = ($"DELETE FROM PessoasEmGrupos WHERE IDPessoa = {IdPessoa}");

            cmd.CommandText = strDelte;

            cmd.ExecuteNonQuery();
            bd.Close();
        }


        public static void SaveContactGropups(string[] groupsInGpBOX, int IDPessoa)
        {
            DeletePersonGroups(IDPessoa);
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();

            //Adicionar os grupos em que a pessoa está na group box
            for (int i = 0; i < groupsInGpBOX.Length; i++)
            {
                OleDbCommand cmd = bd.CreateCommand();

                int IDdoGrupo = getGrupoIDByName(groupsInGpBOX[i]);

                string strAdd = ($"INSERT INTO PessoasEmGrupos (IDGrupo, IDPessoa) VALUES ({IDdoGrupo}, {IDPessoa})");

                cmd.CommandText = strAdd;

                cmd.ExecuteNonQuery();
            }
            bd.Close();
        }

        public static int getGrupoIDByName(string Name)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();
            OleDbCommand ContactsTable = new OleDbCommand("select * From Grupos where Nome = @a", bd);
            ContactsTable.Parameters.AddWithValue("@a", Name);

            OleDbDataReader user = ContactsTable.ExecuteReader();

            int id = 0;

            while (user.Read())
            {
                id = Int32.Parse(user["ID"].ToString());
            }
            user.Close();
            bd.Close();
            return id;
        }

        public static int[] getIdsOfPeopleInIDGroup(int IDGrupo)
        {
            int[] ids = new int[0];
            string[] idsPessoas = DbFunctions.getAllIDs("ID", "PessoasEmGrupos");
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;
            bd.Open();
            OleDbCommand ContactsTable = new OleDbCommand("select * from PessoasEmGrupos", bd);
            OleDbDataReader all = ContactsTable.ExecuteReader();

            while (all.Read())
            {
                int idgrupo = Int32.Parse(all["IDGrupo"].ToString());
                int idpessoa = Int32.Parse(all["IDPessoa"].ToString());
                if (idgrupo == IDGrupo)
                {
                    Array.Resize(ref ids, ids.Length + 1);
                    ids[ids.GetUpperBound(0)] = idpessoa;
                }


            }
            all.Close();
            bd.Close();


            return ids;
        }
    }
}
