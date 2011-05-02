﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace MigrationEngine.Descriptors
{
    /// <summary>
    /// Business object representing a Percusison folder and its Navon.
    /// </summary>
    public class FolderDescription : MigrationData
    {
        [XmlIgnore()]
        public String Path { get; set; }
        public Guid MigrationID { get; set; }

        public override string ToString()
        {
            string fmt = @"MigrationID: {{{0}}}; Path: {{{1}}};";

            return string.Format(fmt, MigrationID, Path);
        }
    }
}