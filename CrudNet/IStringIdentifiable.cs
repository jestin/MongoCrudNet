﻿namespace CrudNet
{
    /// <summary>
    /// This is an interface to be implemented by domain objects or database objects (depending on
    /// your case, you may not want domain objects to implement interfaces).  It ensures that a
    /// class has a string Id field on it.  This interface allows a base implementation of
    /// StringIdentifiableMongoRepository to be provided.
    /// </summary>
    public interface IStringIdentifiable
    {
        string Id { get; set; }
    }
}