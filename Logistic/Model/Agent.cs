using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic.Model
{
    public class Agent
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int INN { get; set; }
        public int? KPP { get; set; }
        public string Adress { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        //public Agent() { }
        //public Agent(string Name, int INN, int KPP, string Adress, string Phone, string? Email)
        //{
        //    this.Name = Name;
        //    this.INN = INN;
        //    this.KPP = KPP;
        //    this.Adress = Adress;
        //    this.Phone = Phone;
        //    this.Email = Email;

        //}

    }
}
