using Bank;
namespace KontoTest;

[TestClass]
public class KontoTests
{
    [TestMethod]
    public void Konto_GuthabenEinzahlen()
    {
        //Arrange
        int startGuthaben = 100;
        Konto testKonto = new Konto(startGuthaben);

        int eingezahlterBetrag = 50;
        //Act
        testKonto.Einzahlen(eingezahlterBetrag);

        //Assert
        Assert.AreEqual(150,testKonto.Guthaben);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Konto_GuthabenAuszahlen()
    {
        //Arrange
        Konto testKonto = new Konto(150);

        //Act
        testKonto.Auszahlen(1000);

        //Assert
    }
}
