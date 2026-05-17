using HowlDev.IO.OOSql.Tests.baseReturns;

namespace HowlDev.IO.OOSql.Tests.baseTables;

public class SingleIntTable : ISqlTable {
    public static IntermediateQuery<SingleIntTable, SingleIntDTO> From() => new();

    public Type BaseDTO => typeof(SingleIntDTO);
}
