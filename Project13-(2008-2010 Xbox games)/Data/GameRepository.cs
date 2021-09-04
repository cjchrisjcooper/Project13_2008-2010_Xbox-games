﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project13__2008_2010_Xbox_games_.Models;
namespace Project13__2008_2010_Xbox_games_.Data
{
    public class GameRepository
    {
        private static Game[] _gamesRepository = new Game[]
        {
            new Game()
            {
                Id = 1,
                Title = "",
                DateOfRelease = new DateTime(),
                Description = "",
                Developer = "",
                Series = "",
                Genre = ""
            },
            new Game()
            {
                Id = 2,
                Title = "",
                DateOfRelease = new DateTime(),
                Description = "",
                Developer = "",
                Series = "",
                Genre = ""
            },
            new Game()
            {
                Id = 3,
                Title = "",
                DateOfRelease = new DateTime(),
                Description = "",
                Developer = "",
                Series = "",
                Genre = ""
            },
            new Game()
            {
                Id = 4,
                Title = "",
                DateOfRelease = new DateTime(),
                Description = "",
                Developer = "",
                Series = "",
                Genre = ""
            },
            new Game()
            {
                Id = 5,
                Title = "",
                DateOfRelease = new DateTime(),
                Description = "",
                Developer = "",
                Series = "",
                Genre = ""
            },

        };


        public Game[] GetAllGames()
        {
            return _gamesRepository;
        }

        public Game GetGame(int id)
        {
            Game gameInRepository = null;
            
            foreach(var game in _gamesRepository)
            {
                if(gameInRepository.Id == id)
                {
                    gameInRepository = game;
                }
            }

            return gameInRepository;
        }



    }
}