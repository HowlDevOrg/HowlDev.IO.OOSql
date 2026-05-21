using HowlDev.IO.OOSql.Tests.baseReturns;

namespace HowlDev.IO.OOSql.Tests.baseTables;

public class SingleIntTable : ISqlTable {
    public static IntermediateQuery<SingleIntTable, SingleIntDTO> From() => new();

    public IEnumerable<(Type type, string parameter)> Properties => [
        (typeof(int), "Id") 
    ];

    public string TableName => "singleint";
}
