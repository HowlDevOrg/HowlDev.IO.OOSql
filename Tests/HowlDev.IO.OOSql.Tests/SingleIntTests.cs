using HowlDev.IO.OOSql.Tests.baseTables;

namespace HowlDev.IO.OOSql.Tests;

public class SingleIntTests {
    [Test]
    public async Task SingleIntTest() {
        await Assert.That(SingleIntTable.From().Select().Sql).IsEqualTo("select Id from SingleInt");
    }
    [Test]
    public async Task SingleIntTestWithCustomDTO() {
        await Assert.That(SingleIntTable.From().Select<CustomDTO>().Sql).IsEqualTo("select Id from SingleInt");
    }

    public class CustomDTO {
        
    }
}

