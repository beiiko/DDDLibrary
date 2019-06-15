using Shared.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
        public class Name : ValueObject
        {
           
            public Name(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;

                if (!Validate())
                    throw new Exception("Nome ou sobrenome inválidos ou preenchidos incorretamente");
            }

            private bool Validate()
            {
                if (!string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName))
                    return true;

                return false;

            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return FirstName + " " + LastName;
            }
        }
}
