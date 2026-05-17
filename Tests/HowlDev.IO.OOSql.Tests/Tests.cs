using HowlDev.IO.OOSql.Tests.baseTables;

namespace HowlDev.IO.OOSql.Tests;

public class LibraryTests {
    [Test]
    public async Task SingleIntTest() {
        await Assert.That(SingleIntTable.From().SelectAll().Sql).IsEqualTo("select Id from SingleInt");
    }
}
