using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace TasksApi.Helpers
{
    public class PasswordHelper
    {
        public static byte[] GetSecureSalt()
        {
            // Starting .NET 6, the Class RNGCryptoServiceProvider is obsolete,
            // so now we have to use the RandomNumberGenerator Class to generate a secure random number bytes

            return RandomNumberGenerator.GetBytes(32);
        }
        public static string HashUsingPbkdf2(string password, byte[] salt)
        {
            byte[] derivedKey = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA256, iterationCount: 100000, 32);

            return Convert.ToBase64String(derivedKey);
        }
    }
}




// using BCrypt;
// using System;

// namespace TasksApi.Helpers
// {
//     public class PasswordHelper
//     {
//         public static byte[] GetSecureSalt()
//         {
//             return new byte[0]; // This method is not used for bcrypt
//         }

//         public static string HashUsingBcrypt(string password)
//         {
//             // Generate a bcrypt hash using the specified work factor
//             string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12); // Adjust work factor as needed

//             return hashedPassword;
//         }

//         public static bool VerifyPassword(string password, string hashedPassword)
//         {
//             // Verify if a password matches its hashed version
//             return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
//         }
//     }
// }
