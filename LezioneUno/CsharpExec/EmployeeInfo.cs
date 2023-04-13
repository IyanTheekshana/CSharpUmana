using System;

namespace CsharpExec
{
    //    Implementare la seguente classe garantendo l'incapsulamento appropriato.

    // Employee(
    //  id
    //  firstName
    //  lastName
    //  age


    //  printInfo() {
    //        ..
    //  }
    //}

    //Il valore di id deve essere generato automaticamente in modo univoco, leggibile ma non scrivibile.
    //I campi firstName e lastName devono essere, una volta impostati, a sola lettura. 
    //L'età è leggibile e scrivibile con controllo dei valori ammissibili (ex.: age non può essere negativa)
    //Il metodo printInfo deve prevedere la stampa degli attributi di Employee.

    //Effettuare il test della classe dal main.



    public class Employee
    {
        public readonly int id;
        private static int employeeId;
        public readonly string FirstName;
        public readonly string LastName;
        private int _age;
        private Address _address { get; set; } = new Address();
        public Employee(string firstName, string lastName, int age, string home, string office)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            //_age = age; // Error
            _address.HomeAddress = home;
            _address.BillingAddress = office;
            id = employeeId++;
        }




        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Età non può essere negativa");
                    return;
                }
                else
                {
                    _age = value;
                }

            }
        }

        public void printInfo()
        {
            Console.WriteLine($"{id} - {FirstName} {LastName} is {Age} years old. {_address.HomeAddress} / {_address.BillingAddress}");
        }

        private class Address
        {
            public string HomeAddress { get; set; }
            public string BillingAddress { get; set; }

        }

    }
    internal class EmployeeInfo
    {
        static void Main222(string[] args)
        {
            Employee e = new Employee("Iyan", "Theekshana", 24, "a", "aa");
            Employee e1 = new Employee("Fluvio", "Caruna", -2, "b", "bb");

            e.printInfo();
            e1.printInfo();

            e1.Age = 40;
            e1.printInfo();

        }
    }
}
