using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4
{
    class Superhero
    {
        //fields
        private int strengthLevel;
        private bool canTeleport;
        private string invulnerability;
        private int intelligence;

        //properties
        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public bool CanTeleport
        {
            get { return this.canTeleport; }
            set { this.canTeleport = value; }
        }

        public string Invulnarability
        {
            get { return this.invulnerability; }
            set { this.invulnerability = value; }
        }

        public int Intelligence
        {
            get { return this.intelligence; }
            set { this.intelligence = value; }
        }

        //constructors
        public Superhero()
        {

        }

        public Superhero(int strengthLevel, bool canTeleport)
        {
            this.strengthLevel = strengthLevel;
            this.canTeleport = canTeleport;
        }

        public Superhero(string invulnerability, int intelligence)
        {
            this.invulnerability = invulnerability;
            this.intelligence = intelligence;
        }

        //methods
        public void Regenerate()
        {
            invulnerability = "laughs and walks it off";
        }

        public void HasPower()
        {
            strengthLevel++;
        }
    }

}
