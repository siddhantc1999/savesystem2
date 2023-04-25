using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenemanager : MonoBehaviour
{
    Canvas[] allcanvases;
    public static scenemanager instance
    {
        get;
        private set;
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
            Destroy(gameObject);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        allcanvases = FindObjectsOfType<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public enum nextscreen
    {
        contactbook,
        register,
        username,
        createnewcontact,
        viewdetail
    }
    public void changescreen(string name)
    {
        
        foreach(Canvas mycanvas in allcanvases)
        {
            if(mycanvas.gameObject.name==name)
            {
                mycanvas.GetComponent<Canvas>().enabled=true;
            }
            else
            {
                mycanvas.GetComponent<Canvas>().enabled =false;
            }
        }
        
    }

    
}
