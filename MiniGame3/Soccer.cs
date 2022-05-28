using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame3
{
    class Soccer
    {
        public Random randomNumber = new Random();

        protected string FullName;
        protected int SoccerShirtNumber;
        protected int Speed;
        protected int Stamina;
        protected int Pass;
        protected int Shoot;
        protected int Ability;
        protected int Stability;
        protected int Form;
        protected int Chance;

        public Soccer(string FullName, int SoccerShirtNumber)
        {

            SoccerShirtNumber = randomNumber.Next(50, 100);
            Speed= randomNumber.Next(50, 100);
            Stamina = randomNumber.Next(50, 100);
            Pass = randomNumber.Next(50, 100);
            Shoot = randomNumber.Next(50, 100);
            Ability = randomNumber.Next(50, 100);
            Stability = randomNumber.Next(50, 100);
            Form = randomNumber.Next(50, 100);
            Chance = randomNumber.Next(50, 100);
        }
        
        public Soccer()
        {

        }
        public virtual Boolean GivePass()
        {
            int PassScore = Convert.ToInt32(Pass * 0.3 + Ability * 0.3 + Stamina * 0.1 + Stability * 0.1 + Chance * 0.2);
            if (PassScore > 60)
                return true;
            else
                return false;
        }
        public virtual Boolean GoalShoot()
        {
            int GoalScore = Convert.ToInt32(Ability * 0.3 + Shoot*0.2 + Stability *0.1+ Form * 0.1 + Speed * 0.1+ Chance * 0.2);
            if (GoalScore > 70)           
                return true;
            
            else
                return false;
        }
    }
    class Defence : Soccer
    {
        private int Positioning;
        private int Head;
        private int Jump;
        public Defence(string FullName, int SoccerShirtNumber)
        {
            this.FullName = FullName;
            this.SoccerShirtNumber = SoccerShirtNumber;
            SoccerShirtNumber = randomNumber.Next(50, 90);
            Speed = randomNumber.Next(50, 90);
            Stamina = randomNumber.Next(50, 90);
            Pass = randomNumber.Next(50, 90);
            Shoot = randomNumber.Next(50, 90);
            Ability = randomNumber.Next(50, 90);
            Stability = randomNumber.Next(50, 90);
            Form = randomNumber.Next(50, 90);
            Chance = randomNumber.Next(50, 90);
            Positioning = randomNumber.Next(50, 90);
            Head = randomNumber.Next(50, 90);
            Jump = randomNumber.Next(50, 90);
        }


        public override bool GivePass()
        {
            int PassScore = Convert.ToInt32(Pass * 0.3 + Ability * 0.3 + Stamina * 0.1 + Stability * 0.1 + Chance * 0.2);
            if (PassScore > 60)
                return true;
            else
                return false;
        }
        public override bool GoalShoot()
        {
            int GoalScore = Convert.ToInt32(Ability * 0.3 + Shoot * 0.2 + Stability * 0.1 + Form * 0.1 + Head * 0.1 +Jump*0.1+ Chance * 0.2);
            if (GoalScore > 70)
                return true;

            else
                return false;
        }

    }


    class Midfield : Soccer
    {
        private int LongBall;
        private int FirstTouch;
        private int Performance;
        private int Dribbling;
        private int SpecialAbility;
        public Midfield(string FullName, int SoccerShirtNumber)
        {
            this.FullName = FullName;
            this.SoccerShirtNumber = SoccerShirtNumber;
            SoccerShirtNumber = randomNumber.Next(60, 100);
            Speed = randomNumber.Next(60, 90);
            Stamina = randomNumber.Next(60, 90);
            Pass = randomNumber.Next(60, 90);
            Shoot = randomNumber.Next(60, 90);
            Ability = randomNumber.Next(60, 90);
            Stability = randomNumber.Next(60, 90);
            Form = randomNumber.Next(60, 90);
            Chance = randomNumber.Next(60, 90);
            LongBall = randomNumber.Next(60, 90);
            FirstTouch = randomNumber.Next(60, 90);
            Performance = randomNumber.Next(60, 90);
            Dribbling = randomNumber.Next(60, 90);
            SpecialAbility  = randomNumber.Next(60, 90);
        }
        public override bool GivePass()
        {
            int PassScore = Convert.ToInt32(Pass * 0.3 + Ability * 0.2+ SpecialAbility * 0.2 + Stamina * 0.1 + Stability  * 0.1 +LongBall * 0.1+Dribbling*0.1+ Chance * 0.1);
            if (PassScore > 60)
                return true;
            else
                return false;
        }
        public override bool GoalShoot()
        {
            int GoalScore = Convert.ToInt32(Ability * 0.3 + Shoot * 0.2+ SpecialAbility * 0.2+FirstTouch*0.1 + Stability * 0.1  + Chance * 0.1);
            if (GoalScore > 70)
                return true;

            else
                return false;
        }


    }
    class Forward : Soccer
    {
        private int Finishing;
        private int FirstTouch;
        private int Head;
        private int SpecialAbility;
        private int Calmness;
        public Forward(string FullName, int SoccerShirtNumber)
        {
            this.FullName = FullName;
            this.SoccerShirtNumber = SoccerShirtNumber;
            SoccerShirtNumber = randomNumber.Next(70, 100);
            Speed = randomNumber.Next(70, 90);
            Stamina = randomNumber.Next(70, 90);
            Pass = randomNumber.Next(70, 90);
            Shoot = randomNumber.Next(70, 90);
            Ability = randomNumber.Next(70, 90);
            Stability = randomNumber.Next(70, 90);
            Form = randomNumber.Next(70, 90);
            Chance = randomNumber.Next(70, 90);
            Finishing = randomNumber.Next(70, 90);
            FirstTouch = randomNumber.Next(70, 90);
            Head = randomNumber.Next(70, 90);
            SpecialAbility = randomNumber.Next(70, 90);
            Calmness = randomNumber.Next(70, 90);
        }
        public override bool GivePass()
        {
            int PassScore = Convert.ToInt32(Pass * 0.3 + Ability * 0.2 +SpecialAbility *0.2+ Stamina * 0.1 + Stability * 0.1 +Chance * 0.1);
            if (PassScore > 60)
                return true;
            else
                return false;
        }
        public override bool GoalShoot()
        {
            int GoalScore = Convert.ToInt32(Ability * 0.2 + Shoot * 0.1 + SpecialAbility * 0.2+Head * 0.1+Finishing*0.1+Calmness*0.1 + FirstTouch * 0.1 + Stability * 0.1 + Form * 0.1 + Chance * 0.1);
            if (GoalScore > 70)
                return true;

            else
                return false;
        }

    }
}
