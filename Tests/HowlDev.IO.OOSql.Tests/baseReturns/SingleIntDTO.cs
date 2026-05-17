namespace HowlDev.IO.OOSql.Tests.baseReturns; 

public class SingleIntDTO : IBaseDTO {
    public int Id { get; set; }

    public IEnumerable<(Type type, string name)> Properties => [
        (typeof(int), "Id")
    ];
}
