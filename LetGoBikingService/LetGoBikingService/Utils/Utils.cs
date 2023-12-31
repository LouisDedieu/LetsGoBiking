﻿using LetGoBikingService.Models;
using LetGoBikingService.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LetGoBikingService.Utils
{
    public class Utils
    {
        public static void PopulateStepCoordinates(Itinary itinary)
        {
            List<List<double>> coordinates = itinary.Features.First().geometry.coordinates;
            foreach (var feature in itinary.Features)
            {
                foreach (var segment in feature.Properties.Segments)
                {
                    foreach (var step in segment.Steps)
                    {
                        if (step.way_points != null && step.way_points.Count == 2)
                        {
                            int startIndex = step.way_points[0];
                            int endIndex = step.way_points[1];

                            if (startIndex >= 0 && startIndex < coordinates.Count)
                            {
                                step.StartLongitude = coordinates[startIndex][0];
                                step.StartLatitude = coordinates[startIndex][1];
                            }
                            else
                            {
                                Console.WriteLine($"Index de waypoint de début {startIndex} est hors limites.");
                            }

                            if (endIndex >= 0 && endIndex < coordinates.Count)
                            {
                                step.EndLongitude = coordinates[endIndex][0];
                                step.EndLatitude = coordinates[endIndex][1];
                            }
                            else
                            {
                                Console.WriteLine($"Index de waypoint de fin {endIndex} est hors limites.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Step sans deux waypoints valides.");
                        }
                    }
                }
            }
        }
        public static CoordinateNominatim ConvertPositionToCoordinateNominatim(Position position)
        {
            return new CoordinateNominatim(Convert.ToString(position.longitude).Replace(',', '.'), 
                                            Convert.ToString(position.latitude).Replace(',', '.'));
        }
    }
}
