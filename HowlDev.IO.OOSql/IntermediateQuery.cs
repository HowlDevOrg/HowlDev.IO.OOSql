namespace HowlDev.IO.OOSql;

/// <summary>
/// Intermediate query to build full SQL queries off of. 
/// </summary>
public class IntermediateQuery<T, D> where T : ISqlTable {
    /// <summary>
    /// DO NOT USE. This is for internal use of generated classes. 
    /// </summary>
    public IntermediateQuery() { }

    /// <summary>
    /// Pass in a custom DTO to 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <returns></returns>
    public CompleteQuery<T, T1> Select<T1>() {
        return new();
    }

    /// <summary>
    /// Select all columns in the given table. Uses the default 
    /// DTO provided with the table. 
    /// </summary>
    /// <returns></returns>
    public CompleteQuery<T, D> Select() {
        return new();
    }
}
