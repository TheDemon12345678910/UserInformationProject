using consoleUserInfo;

namespace testingProject;

public class Tests
{
    //Setting up the class I want to test methods from
    private MoreThanFive _moreThanFive;
    
    [SetUp]
    public void Setup()
    {
        _moreThanFive = new MoreThanFive();
    }

    [Test]
    public void Test1()
    {
        //Arrange
        var name = "Julianna";
        var expected = true;
        
        //Act
        var result = _moreThanFive.moreThanFive(name);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    //Multiple test-cases
    [TestCase("Charlie", true)]
    [TestCase("Lotte", false)]
    [TestCase("Ida", false)]
    [TestCase("Rafael", true)]
    public void Test2(string name, bool expected)
    {
        //Arrange
        
        //Act
        var result = _moreThanFive.moreThanFive(name);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    
}