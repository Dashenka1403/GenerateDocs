using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace GenerateDocs
{
    public class AuthOptions
    {
        /// <summary>
        /// Издатель токена
        /// </summary>
        public const string ISSUER = "GenerateDocs_Server";
        /// <summary>
        /// Потребитель токена
        /// </summary>
        public const string AUDIENCE = "GenerateDocs_Client";
        /// <summary>
        /// Ключ шифрования
        /// </summary>
        public const string KEY = "7B7B2E3F-1BB7-4C8B-9EF7-7EA02B7DB09C";
        /// <summary>
        /// Время жизни токена
        /// </summary>
        public const int LIFETIME = 1;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
