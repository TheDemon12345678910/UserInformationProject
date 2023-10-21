namespace consoleUserInfo;

public class Agevalidation
{
    //Method that returns a boolean, if you really are above the age of 20, and false if not
    public bool aboveTwenty(int age)
    {
        if (age > 20)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}