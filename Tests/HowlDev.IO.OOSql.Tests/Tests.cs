namespace HowlDev.IO.OOSql.Tests; 
public class LibraryTests {
    [Test]
    public async Task Test() {
        int item = 1 + 2;
        await Assert.That(item).IsEqualTo(3);
    }
}
