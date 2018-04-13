using System;
using System.Collections.Generic;
using System.Text;

namespace Quadient.DataServices.Model
{
    public interface ICredentials {}

    public class Credentials: ICredentials
    {
        public string Company {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}
    }
}
