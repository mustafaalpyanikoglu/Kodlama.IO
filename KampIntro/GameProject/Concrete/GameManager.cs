﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi.");
        }

        public Game Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi.");
            return game;
        }
    }
}
