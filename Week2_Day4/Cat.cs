using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4
{
    class Cat
    {
        //STATES
        //Fields - almost always private
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Properties - almost always public
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
            //get allows us to access the information in the field
            //set assigns the value to the class

        }

        //BEHAVIORS


        //Constructors - instantiate, allow us to create a new instance
        public Cat()
        {
            //default constructor - because it takes no parameters in the parenthesis
        }

        public Cat( string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        //Methods

        public void Eat()
        {
            if(isHungry == true)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void WorkOut()
        {
            if (isHungry == false)
            {
                isHungry = true;
            }
            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);
        }
    }
}
