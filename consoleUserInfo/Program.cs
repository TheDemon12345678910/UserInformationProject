//Now we create another class that contains this method

using consoleUserInfo;

MoreThanFive moreThanFiveClass = new MoreThanFive();
//Now we can use the method
string name = "Cristoff";
bool moreThenFiveBool = moreThanFiveClass.moreThanFive(name);
Console.WriteLine("The name: " + name + " has more than 5 characters: " + moreThenFiveBool);
Console.WriteLine("The name: " + name + " is an awesome name");
Console.WriteLine("A little change in the program");

