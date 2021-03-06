﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DeepAnalysis.Core
{
    [Serializable]
    public class Edition
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string SourceUrl { get; set; }

        public Edition()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name).Append("(").Append(Abbreviation).Append(")");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            // If parameter is null return false
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Card return false
            Edition e = obj as Edition;
            if ((object)e == null)
            {
                return false;
            }

            // Return true if the fields match
            return Equals(e);
        }

        public bool Equals(Edition e)
        {
            // If parameter is null return false
            if ((object)e == null)
            {
                return false;
            }

            // Return true if the fields match
            // This doesn't include url's because currently those are based on the parsed source
            return Name == e.Name &&
                Abbreviation == e.Abbreviation;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
