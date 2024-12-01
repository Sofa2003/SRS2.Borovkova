using System.Text;
using System.Security.Cryptography;
namespace SRS2.Borovkova
{
    public class hashPassword
    {
        public string HashingPassword(string paroli)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytePassw = Encoding.UTF8.GetBytes(paroli);
                byte[] hashSourceBytePassw = sha256Hash.ComputeHash(sourceBytePassw);
                string hashpassw = BitConverter.ToString(hashSourceBytePassw).Replace("-", string.Empty);
                return hashpassw;
            }
        }
    }
}
