﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MigrationEngine.Mappers
{
    /// <summary>
    /// Base class for mapping Xml elements to business objects.
    /// </summary>
    /// <typeparam name="ReturnType">The type of the returned business object.</typeparam>
    /// <remarks>This class provides common functionality and constants.
    /// User objects should not be referenced as type XmlDataMapper.</remarks>
    public abstract class XmlDataMapper<ReturnType>
        : DataMapper<ReturnType>
    {
        // List of fields which shouldn't be copied into a descriptor's field set.
        private string[] ommittedFields = { ContentTypeField, CommunityNameField, PathNameField };

        protected void CopyFields(XmlNode dataNode, Dictionary<String, String> fieldset)
        {

            foreach (XmlNode field in dataNode.ChildNodes)
            {
                // It is assumed that fields in Percussion will always be
                // lowercase, otherwise it becomes more difficult to map
                // them from database column names.
                string name = field.Name.ToLower();

                // Skip copying certain fields.
                if (Array.Exists(ommittedFields, fieldName => fieldName == name))
                    continue;

                string value = field.InnerText;
                fieldset.Add(name, value);
            }

        }


        protected string GetNamedFieldValue(XmlNode dataNode, string fieldName, Action<string,string> errorRecorder)
        {
            string fieldValue = string.Empty;

            try
            {
                fieldValue = GetNamedFieldValue(dataNode, fieldName);
            }
            catch (MigrationException ex)
            {
                errorRecorder(fieldName, ex.Message);
            }

            return fieldValue;
        }

        protected string GetNamedFieldValue(XmlNode dataNode, string fieldName)
        {
            string fieldValue = string.Empty;

            XmlNode namedNode = dataNode.SelectSingleNode(fieldName);
            if (namedNode==null)
            {
                throw new DataFieldException(string.Format("No value found for field {0}.", fieldName));
            }

            fieldValue = namedNode.InnerText;

            return fieldValue;
        }
    }
}
