﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Pyramidic
{
    public class Pyramidic
    {
        public static void Main()
        {
            List<string> pyramids = new List<string>();

            int n = int.Parse(Console.ReadLine());

            string[] lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentChar = currentLine[j];

                    int layer = 1;
                    string currPyramid = string.Empty;

                    for (int k = i; k < lines.Length; k++)
                    {
                        string currentLayer = new string(currentChar, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currPyramid += currentLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }
                        
                        layer += 2;
                    }

                    pyramids.Add(currPyramid.Trim());
                }
            }

            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());

        }
    }
}
