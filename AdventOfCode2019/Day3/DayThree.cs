using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AdventOfCode2019.Day3
{
    public class DayThree
    {
        public int PartOne(string[] inputs)
        {
            var intersections = new HashSet<Point>();

            var firstWire = new HashSet<Point>();

            var secondWire = new HashSet<Point>();

            for (int i = 0; i < inputs.Length; i++)
            {
                var coordinates = inputs[i].Split(',');

                var centralPoint = new Point
                {
                    X = 2,
                    Y = 2,
                };

                var currentPoint = centralPoint;

                foreach (var coordinate in coordinates)
                {
                    var direction = coordinate.ElementAt(0);
                    var travelDistance = int.Parse(coordinate.Remove(0, 1));
                    if (i == 0)
                    {
                        currentPoint = MarkWay(direction, travelDistance, firstWire, currentPoint);
                    }
                    else
                    {
                        currentPoint = MarkWay(direction, travelDistance, secondWire, currentPoint);
                    }
                }
            }

            intersections = firstWire.Intersect(secondWire).ToHashSet();

            return CalculateManhattanDitance(intersections);
        }

        private Point MarkWay(char direction,
            int travelDistance,
            HashSet<Point> coordinatesUsed,
            Point previousPoint)
        {
            var nextPoint = new Point();
            switch (direction)
            {
                case 'U':
                    for (int i = 0; i < travelDistance; i++)
                    {
                        nextPoint = new Point(previousPoint.X, previousPoint.Y + 1);
                        coordinatesUsed.Add(nextPoint);
                        previousPoint = nextPoint;
                    }
                    return coordinatesUsed.Last();
                case 'R':
                    for (int i = 0; i < travelDistance; i++)
                    {
                        nextPoint = new Point(previousPoint.X + 1, previousPoint.Y);
                        coordinatesUsed.Add(nextPoint);
                        previousPoint = nextPoint;
                    }
                    return coordinatesUsed.Last();
                case 'D':
                    for (int i = 0; i < travelDistance; i++)
                    {
                        nextPoint = new Point(previousPoint.X, previousPoint.Y - 1);
                        coordinatesUsed.Add(nextPoint);
                        previousPoint = nextPoint;
                    }
                    return coordinatesUsed.Last();
                case 'L':
                    for (int i = 0; i < travelDistance; i++)
                    {
                        nextPoint = new Point(previousPoint.X - 1, previousPoint.Y);
                        coordinatesUsed.Add(nextPoint);
                        previousPoint = nextPoint;
                    }
                    return coordinatesUsed.Last();
                default:
                    throw new ArgumentException("Invalid direciton");
            }
        }

        private int CalculateManhattanDitance(HashSet<Point> intersections)
        {
            var distances = new List<int>();

            foreach (var intersection in intersections)
            {
                var distance = Math.Abs(2 - intersection.X) + Math.Abs(2 - intersection.Y);
                distances.Add(distance);
            }

            return distances.OrderBy(d => d).First();
        }
    }
}
