﻿// Copyright (C) Microsoft. All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Microsoft.ApplicationInspector.RulesEngine
{

    /// <summary>
    /// Analysis Issue
    /// </summary>
    public class Issue
    {
        Confidence _confidence;
        /// <summary>
        /// Creates new instance of Issue
        /// </summary>
        public Issue()
        {
            Rule = null;
            Boundary = new Boundary();
            StartLocation = new Location();
            IsSuppressionInfo = false;
            Confidence = Confidence.Medium;
        }

        public Confidence Confidence
        {
            get
            {
                if (_confidence == null)//possible from serialiation
                    _confidence = Confidence.Medium;

                return _confidence;
            }
            set
            {
                _confidence = value;
            }
        }

        /// <summary>
        /// Boundary of issue (index, length)
        /// </summary>
        public Boundary Boundary { get; set; }

        /// <summary>
        /// Location (line, column) where issue starts
        /// </summary>
        public Location StartLocation { get; set; }

        /// <summary>
        /// Location (line, column) where issue ends
        /// </summary>
        public Location EndLocation { get; set; }

        /// <summary>
        /// Matching rule
        /// </summary>
        public Rule Rule { get; set; }

        /// <summary>
        /// True if Issue refers to suppression information 
        /// </summary>
        public bool IsSuppressionInfo { get; set; }

        public SearchPattern PatternMatch { get; set; }
    }
}
