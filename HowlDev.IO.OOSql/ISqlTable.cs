namespace HowlDev.IO.OOSql;

/// <summary>
/// Base interface/object for building queries. 
/// </summary>
public interface ISqlTable {
    /// <summary>
    /// Returns an <c>IIntermediateQuery</c> to build off of. 
    /// </summary>
    public static IntermediateQuery<ISqlTable, object> From() { return new(); }

    /// <summary>
    /// Retrieve the base DTO type for reflection.
    /// </summary>
    public IEnumerable<(Type type, string parameter)> Properties { get; }

    /// <summary>
    /// Retrieve the table name to use in the query. 
    /// </summary>
    public string TableName { get; }
}
