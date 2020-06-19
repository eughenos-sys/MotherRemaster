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
    public string className {get{
        if(this.rank<100){
            return "Fool Lamer";
        }
        if(this.rank<200){
            return "Lamer";
        }
        if(this.rank<500){
            return "Scripter";
        }
        if(this.rank<1000){
            return "Coder";
        }
        if(this.rank<1500){
            return "Code Hacker";
        }
        if(this.rank<2000){
            return "Cracker";
        }
        if(this.rank<2500){
            return "Master Cracker";
        }
        if(this.rank<3000){
            return "Hacker";
        }
        if(this.rank<3500){
            return "Master Hacker";
        }
        return string.Empty;
    }}
    public string mail {get{return user + "@mother";}}
}