﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreGCBench.Analysis
{
    public static class Extensions
    {
        /// <summary>
        /// Calculates the standard deviation of a given sample.
        /// </summary>
        /// <param name="values">The collection of values.</param>
        /// <returns>The sample standard deviation of the given values.</returns>
        public static double StandardDeviation(this IEnumerable<double> values)
        {
            double aggregate = 0;
            int count = values.Count();

            // standard deviation doesn't make sense with only one sample.
            if (count <= 1)
            {
                return aggregate;
            }

            double mean = values.Average();
            double meanSquaredDiff = values.Sum(v => (v - mean) * (v - mean));
            return Math.Sqrt(meanSquaredDiff / (count - 1));
        }
    }
}
