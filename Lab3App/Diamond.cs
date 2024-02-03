using System;
namespace Lab3App
{
    internal class Diamond : Treasure
    {
        private string name;
        private int Score;

        public Diaomond(string name, int score)
        {
            this.name = name;
            this.Score = score;
        }
        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine(name + " Collected, Congrats!!!!");
            UpdateTotalScore();
            list.Add(this);
        }
        public override void Display()
        {
            Console.WriteLine("Diamond" + name + " is displayed");
        }
        public override void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += Score;
            Console.WriteLine("Total Score is uodated to: " + CollectionBoard.TotalScore);
        }
        }
    }
