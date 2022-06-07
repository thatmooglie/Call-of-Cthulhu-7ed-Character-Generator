using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace Engine.Character
{
    public class Characteristics
    {
        public int Str { get; set; }
        public int Con { get; set; }
        public int Siz { get; set; }
        public int Dex { get; set; }
        public int App { get; set; }
        public int Int { get; set; }
        public int Pow { get; set; }
        public int Edu { get; set; }
        public int Luck { get; set; }

        private readonly DiceMachine DiceMachine = new DiceMachine();

        public Characteristics()
        {
            Str = DiceMachine.rollDice(3, 6) * 5;
            Con = DiceMachine.rollDice(3, 6) * 5;
            Siz = (DiceMachine.rollDice(2, 6) + 6) * 5;
            Dex = DiceMachine.rollDice(3, 6) * 5;
            App = DiceMachine.rollDice(3, 6) * 5;
            Int = (DiceMachine.rollDice(2, 6) + 6) * 5;
            Pow = DiceMachine.rollDice(3, 6) * 5;
            Edu = (DiceMachine.rollDice(2, 6) + 6) * 5;

            Luck = DiceMachine.rollDice(3, 6) * 5;
        }

        public void AgeModification(int age)
        {
            if (15 <= age  && age <= 19)
            {
                this.Str -= 3;
                this.Siz -= 2;
                var tempLuck = DiceMachine.rollDice(3, 6) * 5;
                this.Luck = this.Luck > tempLuck ? this.Luck : tempLuck;
            }

            else if (20 <= age && age <= 39)
            {
                var roll = DiceMachine.rollDice();
                if (roll > this.Edu)
                    this.Edu += DiceMachine.rollDice(1, 10);
            }

            else if (40 <= age && age <= 49)
            {
                for (int i = 0; i < 2; i++)
                {
                    var roll = DiceMachine.rollDice();
                    if (roll > this.Edu)
                        this.Edu += DiceMachine.rollDice(1, 10);
                }
                this.Str -= 2;
                this.Con -= 2;
                this.Dex -= 1;
                this.App -= 5;
            }

            else if (50 <= age && age <= 59)
            {
                this.Str -= 4;
                this.Con -= 3;
                this.Dex -= 3;
                this.App -= 10;

                for (int i = 0; i < 3; i++)
                {
                    var roll = DiceMachine.rollDice();
                    if (roll > this.Edu)
                        this.Edu += DiceMachine.rollDice(1, 10);
                }
            }

            else if (60 <= age && age <= 69)
            {
                this.Str -= 6;
                this.Con -= 7;
                this.Dex -= 7;
                this.App -= 15;

                for (int i = 0; i < 4; i++)
                {
                    var roll = DiceMachine.rollDice();
                    if (roll > this.Edu)
                        this.Edu += DiceMachine.rollDice(1, 10);
                }
            }

            else if (70 <= age && age <= 79)
            {
                this.Str -= 14;
                this.Con -= 12;
                this.Dex -= 14;
                this.App -= 20;

                for (int i = 0; i < 4; i++)
                {
                    var roll = DiceMachine.rollDice();
                    if (roll > this.Edu)
                        this.Edu += DiceMachine.rollDice(1, 10);
                }
            }

            else if (80 <= age && age <= 89)
            {
                this.Str -= 28;
                this.Con -= 24;
                this.Dex -= 28;
                this.App -= 25;

                for (int i = 0; i < 4; i++)
                {
                    var roll = DiceMachine.rollDice();
                    if (roll > this.Edu)
                        this.Edu += DiceMachine.rollDice(1, 10);
                }
            }

            // Ensure non negative values
            this.Str = this.Str < 0 ? 0 : this.Str;
            this.Con = this.Con < 0 ? 1 : this.Con;
            this.Dex = this.Dex < 0 ? 0 : this.Dex;
            this.App = this.App < 0 ? 0 : this.App;

            this.Edu = this.Edu > 100 ? 100 : this.Edu;
        }
          
    }
}
