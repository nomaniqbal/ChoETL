﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ChoKVPRecordObjectAttribute : ChoFileRecordObjectAttribute
    {
        public string Delimiter
        {
            get;
            private set;
        }

        public ChoKVPRecordObjectAttribute(string delimiter = null)
        {
            Delimiter = delimiter;
        }
    }
}