using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravellingSalesLibrary
{
    public class TravellingSalesMan
    {
        public delegate void EventDelegate();
        public event EventDelegate ReportProgress;

        public int TotalCities { private get; set; } = 10;
        public int EllipseSize { get; set; } = 10;

        public int Width { private get; set; }
        public int Height { private get; set; }

        public List<Node> Cities { get; private set; } = new List<Node>();
        public List<Node> BestRoute { get; private set; } = new List<Node>();

        public int Iterations { get; private set; }

        private const int Offset = 30;
        private int _vertex;

        public TravellingSalesMan()
        {

        }

        public void InitCity()
        {
            Cities = new List<Node>();
            BestRoute = new List<Node>();
            _vertex = 0;
            Iterations = 0;

            Random random = new Random();
            for (int i = 0; i < TotalCities; i++)
            {
                Cities.Add(new Node()
                {
                    XLocation = random.Next(Offset, Width - (Offset * 2)),
                    YLocation = random.Next(Offset, Height - (Offset * 2))
                });
            }
        }

        public void CalculateNearestNeighbour()
        {
            while (BestRoute.Count != Cities.Count)
            {
                double bestDistance = int.MaxValue;
                int closestCityIndex = 0;

                for (int i = 0; i < Cities.Count; i++)
                {
                    double distance = CalculateDistance(Cities[_vertex], Cities[i]);
                    if (bestDistance > distance && !Cities[i].Visited)
                    {
                        bestDistance = distance;
                        closestCityIndex = i;
                    }
                    ReportProgress();
                }

                //Thread.Sleep(10);

                if (BestRoute.Count < Cities.Count)
                {
                    Cities[closestCityIndex].Visited = true;
                    _vertex = closestCityIndex;
                    BestRoute.Add(Cities[_vertex]);
                }

                //TwoOptSwap();

                Iterations++;
            }
        }

        private void TwoOptSwap()
        {
            List<Node> temp = Copy(BestRoute);
            double beforeDistance = CalculateTotalDistance(BestRoute);

            for (int i = 0; i < BestRoute.Count - 1; i++)
            {
                for (int k = i + 1; k < BestRoute.Count; k++)
                {
                    temp = Swap(temp, BestRoute, i, k);

                    double afterDistance = CalculateTotalDistance(temp);
                    if (afterDistance < beforeDistance)
                    {
                        BestRoute = Copy(temp);
                        beforeDistance = afterDistance;
                    }
                    ReportProgress();
                }
            }
        }

        /// <summary>
        /// Calculates the distance between two x,y points
        /// </summary>
        private static double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        /// <summary>
        /// Calculates the distance between two nodes
        /// </summary>
        private static double CalculateDistance(Node node1, Node node2)
        {
            return Math.Sqrt(Math.Pow(node2.XLocation - node1.XLocation, 2) + Math.Pow(node2.YLocation - node1.YLocation, 2));
        }

        /// <summary>
        /// Calculates the total distance from nodes[0] to nodes[nodes.count]
        /// </summary>
        private static double CalculateTotalDistance(IReadOnlyList<Node> nodes)
        {
            double total = 0;
            for (int i = 0; i < nodes.Count - 1; i++)
            {
                total += CalculateDistance(nodes[i].XLocation, nodes[i].YLocation, nodes[i + 1].XLocation, nodes[i + 1].YLocation);
            }

            return total;
        }

        /// <summary>
        /// Makes a hard copy of the array
        /// </summary>
        private static List<Node> Copy(IReadOnlyList<Node> nodes)
        {
            var temp = new List<Node>();
            for (int i = 0; i < nodes.Count(); i++)
            {
                temp.Add(nodes[i]);
            }
            return temp;
        }

        private static List<Node> Swap(List<Node> newCity, IReadOnlyList<Node> currentCity, int i, int k)
        {
            int size = newCity.Count();

            // Step 1 - Take route[0] to route[i-1] and add them in order to new_route
            for (int c = 0; c <= i - 1; ++c)
            {
                newCity[c] = currentCity[c];
            }

            // Step 2 - Take route[i] to route[k] and add them in reverse order to new_route
            int dec = 0;
            for (int c = i; c <= k; ++c)
            {
                newCity[c] = currentCity[k - dec];
                dec++;
            }

            // Step 3 - Take route[k+1] to end and add them in order to new_route
            for (int c = k + 1; c < size; ++c)
            {
                newCity[c] = currentCity[c];
            }
            return newCity;
        }

    }
}
