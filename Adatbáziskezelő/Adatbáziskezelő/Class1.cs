using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbáziskezelő
{
    public class Persons
    {
        public string? lastname { get; set; }
        public string? firstname { get; set; }
        public string? address { get; set; }
        public int id { get; set; }

        public Persons(string? lastName, string? firstName, string? Address, int Id)
        {
            lastname = lastName;
            firstname = firstName;
            address = Address;
            id = Id;
        }

    }
    public class id_person
    {
        public int Id_p { get; set; }
        public id_person(int ID)
        {
            Id_p = ID;
        }
    }

    

}

