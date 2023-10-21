namespace consoleUserInfo;

public class MoreThanFive
{

    
//Now we create a method for checking is a name has more than 5 characters
//this method will return true if the name has more than 5 characters, and false, if it does not have

    public bool moreThanFive(string name)
    {
        if (name.Length > 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}