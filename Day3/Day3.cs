﻿using System;
using System.Buffers;
using System.IO;
using System.Linq;

namespace AdventCalendar.Day3
{
    public class Day3
    {
        private readonly char[,] _field;
        private readonly int _fieldMultiplier = 100;

        public Day3(string[] input)
        {
            _field = new char[input.Length, input[0].Length* _fieldMultiplier];
            for (int a = 0; a < _fieldMultiplier; a++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input[i].Length; j++)
                    {
                        _field[i, j + (a * input[i].Length)] = input[i][j];
                    }
                }
            }
        }

        public int Puzzle1()
        {
            return SearchTrees(1, 3);
        }

        private int SearchTrees(int down, int right)
        {
            int foundTrees = 0;
            int j = 0;
            for (int i = down; i < _field.GetLength(0); i += down)
            {
                j += right;
                if (_field[i, j] == '#')
                {
                    foundTrees++;
                }
            }

            return foundTrees;
        }

        public int Puzzle2()
        {
            return SearchTrees(1, 1) 
                   * SearchTrees(1, 3) 
                   * SearchTrees(1, 5) 
                   * SearchTrees(1, 7) 
                   * SearchTrees(2, 1);
        }
    }
}