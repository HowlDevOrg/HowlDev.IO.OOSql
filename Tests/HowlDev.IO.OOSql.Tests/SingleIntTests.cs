using HowlDev.IO.OOSql.Tests.baseTables;

namespace HowlDev.IO.OOSql.Tests;

public class SingleIntTests {
    [Test]
    public async Task SingleIntTest() {
        await Assert.That(SingleIntTable.From().Select().Sql).IsEqualTo("select id from \"singleint\"");
    }
    
    [Test]
    public async Task SingleIntTestWithCustomDTO() {
        await Assert.That(SingleIntTable.From().Select<CustomDTO>().Sql).IsEqualTo("select id from \"singleint\"");
    }

    [Test]
    public async Task SingleIntTestFailsWithCustomDTO() {
        await Assert.That(() => SingleIntTable.From().Select<CustomFailingDTO>())
            .Throws<InvalidCastException>()
            .WithMessage("Not all properties on the provided class have an equivalent.");
    }

    public class CustomDTO {
        public int id { get; set; }
    }

    public class CustomFailingDTO {
        public int NotId { get; set; }
    }
}

