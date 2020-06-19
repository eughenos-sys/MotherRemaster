using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class UserBehaviour
{
    public string user;
    public string password;
    public int rank=100;
    public int credit=100;
    public string mail {get{return user + "@mother";}}
}