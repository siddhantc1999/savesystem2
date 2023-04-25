using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class getcontact : MonoBehaviour
{
    [SerializeField] GameObject nameinputfield;
    string name;
    [SerializeField] GameObject mobileinputfield;
    string mobilenum;
    [SerializeField] GameObject addressinputfield;
    string address;
    [SerializeField] GameObject mailinputfield;
    string mail;
    public void assignname()
    {

        name = nameinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void assignmobilenum()
    {
        mobilenum = mobileinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void assignaddress()
    {
        address = addressinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void assignmail()
    {
        mail = mailinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void contactdetailssave()
    {
        assignname();
        assignmobilenum();
        assignaddress();
        assignmail();
   /*     savesystem.saveplayer(this);*/


    }
}
