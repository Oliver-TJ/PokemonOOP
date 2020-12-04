using System;
using System.Collections.Generic;


namespace PokemonOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon Player1 = new Pokemon("Test", 49, "Mystic", 203, "male");
            ReturnToConsole(Player1.ReturnValues());
        }

        public static void ReturnToConsole(string[] list1)
        {
            foreach (object o in list1)
            {
                Console.WriteLine(o);
            }
        }
        
        public void Fight()
        {

        }

        static string TempName()
        {
            while (true)
            {
                Console.WriteLine("Enter the name value of your Pokemon:  ");
                return Console.ReadLine();
            }
        }

        static int TempAttack()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the attack value of your Pokemon:   ");
                    return Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please try again");
                }
            }
        }

        static string TempType()
        {
            Console.WriteLine("Enter the type value of your Pokemon:  ");
            return Console.ReadLine();
        }

        static int TempHealth()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the health of your Pokemon:  ");
                    return Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please try again");
                }
            }

        }

        static string TempGender()
        {
            Console.WriteLine("Enter the gender of your Pokemon");
            return Console.ReadLine();
        }

        class Pokemon
        {
            // Creating the variables needed
            private int healthPoints;
            private string gender;
            private int age;
            private string type;
            private int attack;
            private string name;

            // constructor
            public Pokemon(string PokemonName, int PokemonAttack, string PokemonType, int PokemonHealth, string PokemonGender)
            {
                name = PokemonName;
                attack = PokemonAttack;
                type = PokemonType;
                healthPoints = PokemonHealth;
                gender = PokemonGender;
                age = 0;
            }

            public string[] ReturnValues()
            {
                string[] Values = new string[6];

                // string array elements
                Values[0] = (name);  
                Values[1] = (Convert.ToString(attack));     
                Values[2] = (type);    
                Values[3] = (Convert.ToString(healthPoints));
                Values[4] = (gender);  
                Values[5] = (Convert.ToString(age));  
                return Values;
            }

            // getters
            public int getAttack()
            {
                return attack;
            }
            public string getName()
            {
                return name;
            }
            public string getType()
            {
                return type;
            }
            public int getHealth()
            {
                return healthPoints;
            }
            public int getAge()
            {
                return age;
            }
            public string getGender()
            {
                return gender;
            }
        }
    }
}