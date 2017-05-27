using System;
using System.ComponentModel;

[Serializable]
[Description("login")]
public class LoginUser
{
    public int userId;
    public string name;

    public static LoginUser actualUser;

    public LoginUser(int userId, string name)
    {
        this.userId = userId;
        this.name = name;
    }

    public string Print()
    {
        return string.Format("{0}, {1}", userId, name);
    }
}
