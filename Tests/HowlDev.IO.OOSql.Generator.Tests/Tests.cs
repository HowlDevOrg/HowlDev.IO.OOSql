namespace HowlDev.IO.OOSql.Generator.Tests;

public class GeneratorTests {
    [Test]
    public async Task Test() {
        int item = 1 + 2;
        await Assert.That(item).IsEqualTo(3);
    }
}
