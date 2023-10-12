using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humansOwn
{
    internal class human
    {
        private string surname;
        private string forename;
        private int dateOfBirth;


        public human(string surename, string forename, int dateOfBirth)
        {
            this.surname = surename;
            this.forename = forename;
            this.dateOfBirth = dateOfBirth;
        }

        public string name()
        { 
        return surname + forename;
        }


    }
    
}
