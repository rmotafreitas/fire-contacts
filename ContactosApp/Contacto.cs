using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ContactosApp
{
    class Contacto
    {
        static string strProvider = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Database\Contactos.accdb;Persist Security Info=False";
        private static int ID;
        public static int iD
        {
            get { return ID; }
            set { ID = value; } 
        }


        //Contactos
        public static dynamic getContactoInfo(int ID)
        {
            string[] grupos = new string[0];
            string nome = "";
            string contacto = "";
            string email = "";
            string morada = "";
            string foto = "";
            bool favorito = false;
            int IDEmpresa = 0;
            try
            {   
                OleDbConnection bd = new OleDbConnection();
                bd.ConnectionString = strProvider;
                bd.Open();
                OleDbCommand ContactsTable = new OleDbCommand("select * from Contactos where ID = @a", bd);
                ContactsTable.Parameters.AddWithValue("@a", ID.ToString());

                OleDbDataReader user = ContactsTable.ExecuteReader();


                while (user.Read())
                {
                    nome = user["Nome"].ToString(); //Read a value from query name  
                    contacto = user["Contacto"].ToString();
                    email = user["Email"].ToString();
                    morada = user["Morada"].ToString();
                    foto = user["Foto"].ToString();
                    favorito = (user["Favorito"].ToString() == "True" ? true : false);
                    IDEmpresa = Int32.Parse(user["IDEmpresa"].ToString());
                }
                user.Close();
                bd.Close();
                grupos = Grupos.getGrupos(ID);

            } catch (Exception err)
            {
                Console.WriteLine(err);
            }

            var Contacto = new
            {
                nome = nome,
                contacto = contacto,
                email = email,
                morada = morada,
                foto = foto,
                favorito = favorito,
                grupos = grupos,
                IDEmpresa,
            };


            return Contacto;
            
        }

        public static void SaveAContact(dynamic Contact, int IDContacto)
        {
            try
            {
                
                OleDbConnection bd = new OleDbConnection();
                bd.ConnectionString = strProvider;
                bd.Open();
                OleDbCommand cmd = bd.CreateCommand();
                string strUpdate = ($"update Contactos set Nome = {"'" + Contact.nome + "'"}, Contacto = {"'" + Contact.contacto + "'"}, Email = {"'" + Contact.email + "'"}, Morada = {"'" + Contact.morada + "'"}, Foto = {"'" + Contact.foto + "'"}, Favorito = {"'" + (Contact.favorito ? "True" : "False") + "'"}, IDEmpresa = {Contact.IDEmpresa} WHERE ID = {IDContacto}");
                
                cmd.CommandText = strUpdate;

                cmd.ExecuteNonQuery();
                Grupos.SaveContactGropups(Contact.grupos, IDContacto);
                bd.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        public static void Adicionar(string nome, string contacto, string email, string morada, string foto, string favorito, int IDEmpresa)
        {
            try
            {

                OleDbConnection bd = new OleDbConnection();
                bd.ConnectionString = strProvider;
                bd.Open();
                OleDbCommand cmd = bd.CreateCommand();
                string strInsert = ($"INSERT INTO Contactos (Nome, Contacto, Email, Morada, Foto, Favorito, IDEmpresa) VALUES('{nome}', '{contacto}', '{email}', '{morada}', '{foto}', '{favorito}', {IDEmpresa}); ");

                cmd.CommandText = strInsert;

                cmd.ExecuteNonQuery();
                bd.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }


    }
}
