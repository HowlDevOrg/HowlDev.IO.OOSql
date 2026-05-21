using BenchmarkDotNet.Attributes;

namespace HowlDev.IO.OOSql.Benchmarks;
[MemoryDiagnoser]
[ShortRunJob]
public class FullQueryTest {
    [Benchmark]
    public CompleteQuery<SingleIntTable, SingleIntDTO> FullQuery() => SingleIntTable.From().Select();

    [Benchmark]
    public CompleteQuery<SingleIntTable, SingleIntDTO> FullQueryDirectApplication() => SingleIntTable.From().Select<SingleIntDTO>();
}

public class SingleIntTable : ISqlTable {
    public static IntermediateQuery<SingleIntTable, SingleIntDTO> From() => new();

    public IEnumerable<(Type type, string parameter)> Properties => [
        (typeof(int), "Id") 
    ];

    public string TableName => "singleint";
}

public class SingleIntDTO {
    public int Id { get; set; }
}
