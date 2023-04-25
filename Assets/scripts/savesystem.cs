using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class savesystem
{
    public static List<userdata> userlist=new List<userdata>();
    public static void saveplayer(getinfo usergetinfo)
    {
      
        string path = Application.persistentDataPath + "/phonerecords5.fun";
        if (File.Exists(path))
        {
            userlist = fileopen(path);
            /*if (userlist == null)
            {
                userlist = new List<userdata>();
            }*/

            //userlist.Add(userlist);
            Debug.Log("in file append");
            path = fileappend(path, usergetinfo);

        }
        else
        {
            Debug.Log("in file create");
            path = filecreate(path, usergetinfo);
        }
    }



    public static List<userdata> loadplayer()
    {
        string path = Application.persistentDataPath + "/phonerecords5.fun";
        if (File.Exists(path))
        {
            return fileopen(path);
        }
        else
        {
            Debug.LogError("save file not found in " + path);
            return null;
        }
    }

    private static List<userdata> fileopen(string path)
    {
        BinaryFormatter formatter = new BinaryFormatter();
     
        FileStream stream = new FileStream(path, FileMode.Open);
        /*Debug.Log("stream length "+stream.Length);*/
        /*stream.Position = 0;*/
        if (stream.Length > 0)
        {
           
            List<userdata> data1 = formatter.Deserialize(stream) as List<userdata>;

           
            stream.Close();
            if (data1 == null)
            {
                return null;
            }
            else
            {
               
                return data1;
            }
        }
        else
        {
           
            stream.Close();
        }
        return null;
    }

    private static string filecreate(string path, getinfo usergetinfo)
    {
       

        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream(path, FileMode.Create);
        userdata newuserdata = new userdata(usergetinfo);

        userlist.Add(newuserdata);

        formatter.Serialize(stream, userlist);
        stream.Close();
        ///no need for below
        return path;
    }

    private static string fileappend(string path, getinfo usergetinfo)
    {

      /*  Debug.Log("here in file creatae "+usergetinfo.name);*/
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream(path, FileMode.Create);
       
        userdata newuserdata = new userdata(usergetinfo);
        
        userlist.Add(newuserdata);
    
        formatter.Serialize(stream, userlist);
        stream.Close();
        /*Debug.Log(userlist[0].name);*/
        ///no need for below
        return path;
    }


}

//public class Playerdata
//{

//    public userdata myuserdata;
//}