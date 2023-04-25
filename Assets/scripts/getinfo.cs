using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class getinfo : MonoBehaviour
{
    [SerializeField] GameObject useridinputfield;
    public string userid;
    [SerializeField] GameObject passwordinputfield;
    public string password;
    [SerializeField] GameObject nameinputfield;
    public string name;
    [SerializeField] GameObject mobileinputfield;
    public string mobilenumber;
    public List<userdata> myuserdata;
    public void assignuserid()
    {
       
        userid = useridinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void assignpassword()
    {
        password = passwordinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void assignname()
    {
        name = nameinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void assignmobilenum()
    {
        mobilenumber = mobileinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void registerplayer()
    {
        assignuserid();
        assignpassword();
        assignname();
        assignmobilenum();
        savesystem.saveplayer(this);


    }
    public void loadplayer()
    {
        myuserdata=savesystem.loadplayer();
        if(myuserdata == null)
        {
            Debug.Log("in null");
        }
        Debug.Log("the userdata count "+myuserdata[myuserdata.Count- 1].name);
      /*  Debug.Log("the userdata length "+myuserdata[0].name);
        Debug.Log("the userdata length " + myuserdata[0].mobilenumber);
        Debug.Log("the userdata length " + myuserdata[0].password);
        Debug.Log("the userdata length " + myuserdata[0].userid);*/

    }



}
