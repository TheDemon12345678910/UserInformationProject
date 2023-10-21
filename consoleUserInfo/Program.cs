//Now we create another class that contains this method

using consoleUserInfo;

//using the classes we build the methods inside
MoreThanFive moreThanFiveClass = new MoreThanFive();
Agevalidation agevalidation = new Agevalidation();

//Now we can use the method
string name = "Cristoff";
int age = 27;
bool moreThenFiveBool = moreThanFiveClass.moreThanFive(name);
bool olderThanTwenty = agevalidation.aboveTwenty(age);
Console.WriteLine("The name: " + name + " has more than 5 characters: " + moreThenFiveBool);
Console.WriteLine("The name: " + name + " is an awesome name");
Console.WriteLine(name + " is above the age of 20: " + olderThanTwenty);