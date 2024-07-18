using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class GameManager
    {
        private static GameManager instance = null;
        private static readonly object padlock = new object();
        public int Score { get; private set; }

        private GameManager()
        {
            Score = 0;
        }

        public static GameManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new GameManager();
                    }
                    return instance;
                }
            }
        }

        public void AddScore(int points)
        {
            Score += points;
        }
    }

}
