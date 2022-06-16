using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimRenMovie.Registration.InputDataVerifier
{
    interface ISignUpDataVerifier
    {
        bool IsCorrect { get; set; }
    }
}
