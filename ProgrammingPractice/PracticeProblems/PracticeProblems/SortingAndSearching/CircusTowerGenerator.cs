﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeProblems.SortingAndSearching
{
    public class CircusTowerGenerator
    {
        public Tuple<int,int>[] Generate(Tuple<int,int>[] people)
        {
            if (people == null)
            {
                return null;
            }

            if (people.Length == 0)
            {
                return people;
            }

            var peopleOrderedByHeight = people.OrderBy(x => x.Item1).ToArray();
            var peopleOrderedByWeight = people.OrderBy(x => x.Item2).ToArray();

            var bestHeightSequence = new List<Tuple<int, int>> { peopleOrderedByHeight[0] };
            var currHeightSequence = new List<Tuple<int, int>> { peopleOrderedByHeight[0] };
            for (int i = 1; i < peopleOrderedByHeight.Length; i++)
            {
                if (peopleOrderedByHeight[i].Item2 > peopleOrderedByHeight[i-1].Item2)
                {
                    currHeightSequence.Add(peopleOrderedByHeight[i]);
                }
                else
                {
                    if (currHeightSequence.Count > bestHeightSequence.Count)
                    {
                        bestHeightSequence = currHeightSequence;
                    }

                    currHeightSequence = new List<Tuple<int, int>> { peopleOrderedByHeight[i] };
                }
            }

			var bestWeightSequence = new List<Tuple<int, int>> { peopleOrderedByWeight[0] };
			var currWeightSequence = new List<Tuple<int, int>> { peopleOrderedByWeight[0] };
            for (int i = 1; i < peopleOrderedByWeight.Length; i++)
			{
                if (peopleOrderedByWeight[i].Item1 > peopleOrderedByWeight[i - 1].Item1)
				{
                    currWeightSequence.Add(peopleOrderedByWeight[i]);
				}
				else
				{
                    if (currWeightSequence.Count > bestWeightSequence.Count)
                    {
                        bestWeightSequence = currWeightSequence;
                    }

                    currWeightSequence = new List<Tuple<int, int>> { peopleOrderedByWeight[i] };
				}
			}

            return bestHeightSequence.Count > bestWeightSequence.Count 
                 ? bestHeightSequence.ToArray() : bestWeightSequence.ToArray();
        }
    }
}
