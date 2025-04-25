using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models
{
    public static class Criptografia
    {
        public static string Criptografar(string senha)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(senha);
            return passwordHash;
        }
        
        public static bool verificar(string senha, string senhaCriptografada)
        {
            return BCrypt.Net.BCrypt.Verify(senha, senhaCriptografada);
        }
    }
}
