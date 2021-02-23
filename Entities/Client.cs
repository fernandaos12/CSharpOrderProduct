using System;

namespace OrdemPedidos.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthdayDate { get; set; }
    
    
        public Client() { }

        public Client(string name, string email, DateTime birthdayDate)
        {
            Name = name;
            Email = email;
            BirthdayDate = birthdayDate;
        }

        public override string ToString()
        {
            return Name
                +", (" + BirthdayDate.ToString("dd/MM/yyyy") + ") - "
                + Email;

        }
    }


}
