using System.Security.Cryptography;
using System.Text;

namespace FirstPages.Models;

public class Password
{
    private const int _keySize = 64;
    private const int _iterations = 10000;
    private readonly HashAlgorithmName _hashAlgorithm = HashAlgorithmName.SHA512;
    
    public string HashPasword(string password, out byte[] salt)
    {
        salt = RandomNumberGenerator.GetBytes(_keySize);

        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            salt,
            _iterations,
            _hashAlgorithm,
            _keySize);

        return Convert.ToHexString(hash);
    }
    
    public bool VerifyPassword(string password, string hash, byte[] salt)
    {
        var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, _iterations, _hashAlgorithm, _keySize);
        return hashToCompare.SequenceEqual(Convert.FromHexString(hash));
    }
}