﻿using System;

namespace MigrationEngine
{
    /// <summary>
    /// Base class for exceptions in the MigrationEngine.
    /// </summary>
    [global::System.Serializable]
    public abstract class MigrationException : Exception
    {
        public MigrationException() { }
        public MigrationException(string message) : base(message) { }
        public MigrationException(string message, Exception inner) : base(message, inner) { }
        protected MigrationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    /// <summary>
    /// Exception thrown when errors are encountered in migration script.
    /// (e.g. Required attribute not being set.)
    /// </summary>
    [global::System.Serializable]
    public class MigrationScriptException : MigrationException
    {
        public MigrationScriptException() { }
        public MigrationScriptException(string message) : base(message) { }
        public MigrationScriptException(string message, Exception inner) : base(message, inner) { }
        protected MigrationScriptException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    /// <summary>
    /// Exception thrown when unable to create a relationship between content items.
    /// </summary>
    [global::System.Serializable]
    public class RelationshipException : MigrationException
    {
        public RelationshipException() { }
        public RelationshipException(string message) : base(message) { }
        public RelationshipException(string message, Exception inner) : base(message, inner) { }
        protected RelationshipException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    /// <summary>
    /// Exception thrown when an invalid community name is specified.
    /// </summary>
    [global::System.Serializable]
    public class InvalidCommunityNameException : MigrationException
    {
        public InvalidCommunityNameException() { }
        public InvalidCommunityNameException(string message) : base(message) { }
        public InvalidCommunityNameException(string message, Exception inner) : base(message, inner) { }
        protected InvalidCommunityNameException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    /// <summary>
    /// Exception thrown when a configuration error is encountered.
    /// </summary>
    [global::System.Serializable]
    public class ConfigurationException : MigrationException
    {
        public ConfigurationException() { }
        public ConfigurationException(string message) : base(message) { }
        public ConfigurationException(string message, Exception inner) : base(message, inner) { }
        protected ConfigurationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    /// <summary>
    /// Exception thrown by Datamapper classes when errors occur in a data field.
    /// </summary>
    [global::System.Serializable]
    public class DataFieldException : MigrationException
    {
        public DataFieldException() { }
        public DataFieldException(string message) : base(message) { }
        public DataFieldException(string message, Exception inner) : base(message, inner) { }
        protected DataFieldException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
