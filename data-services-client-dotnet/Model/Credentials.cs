using System;
using System.Collections.Generic;
using System.Text;

namespace Quadient.DataServices.Model
{
    public enum Region
    {
        US = 0,
        EU = 1
    }

    public interface ICredentials
    {
        Region Region {get; set;}
        string Company {get; set;}
        string Username {get; set;}
        string Password {get; set;}
    }

    public class Credentials: ICredentials
    {
        public Region Region {get;set;} = Region.US;
        public string Company {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}
    }
}
