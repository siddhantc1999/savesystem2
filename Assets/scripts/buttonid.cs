using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonid : MonoBehaviour
{
    public scenemanager.nextscreen mynextcanvas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextcanvas()
    {

        foreach (var name in scenemanager.nextscreen.GetNames(mynextcanvas.GetType()))
        {
            if (name == mynextcanvas.ToString())
            {

                scenemanager.instance.changescreen(name);
            }
        }
    }
}
