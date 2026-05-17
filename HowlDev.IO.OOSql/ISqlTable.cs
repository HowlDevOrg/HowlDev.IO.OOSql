namespace HowlDev.IO.OOSql;

/// <summary>
/// Base interface/object for building queries. 
/// </summary>
public interface ISqlTable {
    /// <summary>
    /// Returns an <c>IIntermediateQuery</c> to build off of. 
    /// </summary>
    public IntermediateQuery<ISqlTable, IBaseDTO> From() { return new(); }
}
