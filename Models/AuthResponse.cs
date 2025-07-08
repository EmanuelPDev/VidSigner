using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidSigner.Models
{
    public class AuthResponse
    {
        public string Access_Token { get; set; } = string.Empty;
        public string Token_Type { get; set; } = string.Empty;
        public int Expires_In { get; set; }
        public string Scope { get; set; } = string.Empty;
    }
}
