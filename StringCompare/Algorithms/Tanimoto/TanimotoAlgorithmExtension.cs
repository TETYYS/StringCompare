﻿// Library for compare strings
// Copyright (C) 2015 Nick Rimmer. Contacts: <xan@dipteam.com>
// 
// This file is part of StringCompare library.
// Licensed under the MIT License (MIT)

namespace StringCompare.Algorithms.Tanimoto
{
    public static class TanimotoAlgorithmExtension
    {
        /// <summary>
        /// Measure the difference
        /// </summary>
        /// <param name="source">source string</param>
        /// <param name="target">target string</param>
        /// <returns>0 is different, 1 is equals, >1 if target string has more matches</returns>
        public static double CompareTanimoto(this string source, string target)
        {
            return new TanimotoAlgorithm().GetCompareResult(source, target);
        }
    }
}