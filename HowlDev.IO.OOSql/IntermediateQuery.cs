namespace HowlDev.IO.OOSql;

/// <summary>
/// Intermediate query to build full SQL queries off of. 
/// </summary>
public class IntermediateQuery<T, D> where T : ISqlTable where D : IBaseDTO {
    /// <summary>
    /// Select all columns in the given table. 
    /// </summary>
    /// <returns></returns>
    public CompleteQuery<T, D> SelectAll() {
        return new();
    }
}
