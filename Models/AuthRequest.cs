using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidSigner.Models
{
    public class AuthRequest
    {
        public string Grant_Type { get; set; } = "password";
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Scope { get; set; } = "subscription";

        public AuthRequest(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}
