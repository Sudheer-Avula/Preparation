using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    public class CodeGeneration
    {
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ2234567890".ToCharArray();
            byte[] data = new byte[maxSize];
            using (var crypto = RandomNumberGenerator.Create())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        /// <summary>
        /// Store the selector in the database, along with a cryptographic hash (e.g. SHA256) of the verifier (rather than the verifier itself).
        /// </summary>
        /// <returns></returns>
        public static string SecureToken()
        {
            var selector = GetUniqueKey(15);
            var verifier = GetUniqueKey(18);
            Console.WriteLine("Selector: {0}", selector);
            Console.WriteLine("Verifier: {0}", verifier);

            //Encoded - Send this in the link
            var encodedSelector = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(selector));
            Console.WriteLine("Encoded Selector: {0}", encodedSelector);
            var encodedVerifier = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(verifier));
            Console.WriteLine("Encoded Verifier: {0}", encodedVerifier);

            //Decoded - do this to get the selector and verifier to match against
            var decodedSelector = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(encodedSelector));
            Console.WriteLine("Decoded Selector: {0}", decodedSelector);
            var decodedVerifier = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(encodedVerifier));
            Console.WriteLine("Decoded Verifier: {0}", decodedVerifier);

            //store verifierHash and Selector in the DB, with a timestamp of hash creation in the DB
            var verifierHash = verifier.GetHashCode();
            Console.WriteLine("VerfierHash: {0}", verifierHash);
            return encodedSelector + encodedVerifier;
        }

    }
}
