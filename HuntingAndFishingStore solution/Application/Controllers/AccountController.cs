using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using Data;
using Models;
using Models.Dtos;
using static Application.Controllers.Validations.Validations;

namespace Application.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (IsUsernameExists(user.Username))
                {
                    ModelState.AddModelError("username", $"Username {user.Username} is already taken!");
                    return View();
                }
                if (IsEmailExists(user.Email))
                {
                    ModelState.AddModelError("email", $"Email {user.Email} is already taken!");
                    return View();
                }

                using (var context = new GunStoreContext())
                {
                    user.Password = EncryptPassword(user.Password);
                    context.Users.Add(user);
                    context.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDto user)
        {
            using (var context = new GunStoreContext())
            {
                var encryptPassword = EncryptPassword(user.Password);
                var member = context.Users
                    .FirstOrDefault(u => u.Email == user.Email &&
                                         u.Password == encryptPassword);

                if (member != null)
                {
                    Session["UserId"] = Convert.ToString(member.Id);
                    Session["Username"] = member.Username;
                    ModelState.Clear();
                    return RedirectToAction("LoggedinUserIndex", "Home");
                }
                ModelState.AddModelError("email and password", "Invalid email or password!");
                return View();
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            ModelState.Clear();
            return RedirectToAction("Index", "Home");
        }

        #region 

        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";

        private string EncryptPassword(string password)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(password);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }

            return Convert.ToBase64String(cipherTextBytes);
        }

        #endregion

        
    }
}