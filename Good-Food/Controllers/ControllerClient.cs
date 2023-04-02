using Good_Food.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food.Controllers
{
    internal class ControllerClient
    {

        private List<Client> clients;


        public ControllerClient()
        {

            clients = new List<Client>();

            load();

        }

        public void load()
        {

            StreamReader streamReader = new StreamReader(Application.StartupPath + @"/data/clients.txt");

            string textul = "";

            while((textul = streamReader.ReadLine()) != null)
            {

                Client client = new Client(textul);

                clients.Add(client);


            }

            streamReader.Close();

        }

        public bool verifEmail(string email)
        {

            for(int i=0;i<clients.Count; i++)
            {

                if (clients[i].getEmail() == email)
                {
                    return false;
                }

            }

            return true;
        }

        public void saveNewClient(string textul)
        {

            string path = Application.StartupPath + @"/data/clients.txt";

            File.AppendAllText(path, textul+"\n");


        }

        public Client getByid(int id)
        {

            for(int i = 0; i < clients.Count; i++)
            {
                if(id== clients[i].getid_Client())
                {
                    return clients[i];
                }
            }

            return null;
        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next();

            while (this.getByid(id) != null)
            {

                id = random.Next();


            }

            return id;
        }

        public bool verifAut(string email, string parola)
        {

            for (int i = 0; i < clients.Count; i++)
            {

                if (clients[i].getEmail() == email && clients[i].getparola() == parola)
                {
                    return true;
                }

            }

            return false;

        }

        public int idByEmaiParo(string email, string parola)
        {

            for (int i = 0; i < clients.Count; i++)
            {

                if (clients[i].getEmail() == email && clients[i].getparola() == parola)
                {
                    return clients[i].getid_Client();
                }

            }

            return -1;

        }

    }
}
