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
    }
}
