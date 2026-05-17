namespace HowlDev.IO.OOSql;

/// <summary>
/// Holds the data information for an <c>ISqlTable</c>.
/// </summary>
public interface IBaseDTO {
    /// <summary>
    /// Gets all the properties for a given table.
    /// </summary>
    public IEnumerable<(Type type, string name)> Properties { get; } 
}
