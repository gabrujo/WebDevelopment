using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using PersonServiceDocker.Models;

namespace PersonServiceDocker.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }

    public class UserService : IUserService
    {
        // in practice, store following a db with hashed passwords
        private List<User> _users = new List<User>
 {
 new User { Id = 1000, FirstName = "apiuser", LastName = "apiuser",
Username = "apiuser", Password = "apiuser100" },
 new User { Id = 1001, FirstName = "superuser", LastName = "superuser",
Username = "admin", Password = "admin100" },
 };
        private readonly AppSettings _appSettings;
        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        public User Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username &&
           x.Password == password);

            // return null if user not found
            if (user == null)
                return null;
            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
            {
 new Claim(ClaimTypes.Name, user.Username.ToString())
            }),
                Expires = DateTime.UtcNow.AddMinutes(2), // for subscribers of API, it could be longer duration
                                                         // Sha256 with HMAC, secret as the key for Sha256
                SigningCredentials = new SigningCredentials(new
           SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);
            // remove password before returning
            user.Password = null;
            return user;
        }
        public IEnumerable<User> GetAll()
        {
            // return users without passwords
            return _users.Select(x => {
                x.Password = null;
                return x;
            });
        }
    }

