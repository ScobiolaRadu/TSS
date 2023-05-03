using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS
{
    public class Client
    {
        private string Username;
        private string Password;

        public Client(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Credentials(Client client)
        {
            return client.Username + client.Password;
        }
    }
}