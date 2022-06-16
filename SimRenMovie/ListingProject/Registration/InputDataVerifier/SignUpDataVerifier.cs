using SimRenMovie.DatabaseLoader.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimRenMovie.Registration.InputDataVerifier
{
    class SignUpDataVerifier:ISignUpDataVerifier
    {
        public bool IsCorrect { get; set; }
        private static dynamic User;
        public SignUpDataVerifier(IUser user)
        {
            User = user;
            bool registrationRequirements = (user.login.Length < 35 && user.login.Length > 3
               && user.password.Length < 35 && user.password.Length > 5);
            VerifierThroughRegex(user.email);
            if (registrationRequirements && IsCorrect)
            {
                IsCorrect = true;
            }
            else IsCorrect = false;
        }
        private void VerifierThroughRegex(string email)
        {
            
            string regexPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(regexPattern, RegexOptions.IgnoreCase);
            Match match = regex.Match(email);
            IsCorrect = match.Success;
        }


    }
}
