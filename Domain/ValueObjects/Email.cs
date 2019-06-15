using Shared.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{

        public class Email : ValueObject
        {
            public Email(string email)
            {
                MailAdress = email;

                if (string.IsNullOrWhiteSpace(email))
                    throw new Exception("E-mail não pode ser em branco");
            }
            public string MailAdress { get; set; }
        }
}
