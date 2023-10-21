using consoleUserInfo;

namespace testingProject;

public class Tests
{
    //Setting up the class I want to test methods from
    private MoreThanFive _moreThanFive;
    private Agevalidation _agevalidation;
    
    [SetUp]
    public void Setup()
    {
        _moreThanFive = new MoreThanFive();
        _agevalidation = new Agevalidation();
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

    [TestCase(29,true)]
    [TestCase(30,true)]
    [TestCase(19,false)]
    [TestCase(3,false)]
    public void TestIfAboveTwenty(int age, bool expected)
    {
        //Arrange
        
        //Act
        var result = _agevalidation.aboveTwenty(age);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
}