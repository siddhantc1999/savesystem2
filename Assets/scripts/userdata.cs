using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class userdata
{
    public string userid;
    public string password;
    public string name;
    public string mobilenumber;
    public userdata(getinfo usergetinfo)
    {
        userid = usergetinfo.userid;
        password = usergetinfo.password;
        name = usergetinfo.name;
        mobilenumber = usergetinfo.mobilenumber;

    }
   

}
