using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class woodenchanger : MonoBehaviour
{
    public BoxCollider tableboxcollider;
    // Start is called before the first frame update
    void Start()
    {
        AddComponent();
        FindComponent();
        SetComponent(true);

    }

    public void SetComponent(bool c)
    {
        transform.position = new Vector3(-4.599f, -3318.84f, -8.0866f);
        transform.localScale = new Vector3(13.58228f, 13.58228f, 13.58228f);
        transform.eulerAngles = new Vector3(27.673f, 0f, 0f);
        /*
        tableboxcollider.center = new Vector3(0.6392f, 1.2951f, -0.1641f);
        tableboxcollider.size = new Vector3(0.1260f, 0.01895f, 0.3427f);
        tableboxcollider.enabled = c;
        */
    }

    void FindComponent()
    {
        //tableboxcollider = gameObject.GetComponent<BoxCollider>();
        
    }

    void AddComponent()
    {
       //gameObject.AddComponent<BoxCollider>();
     }

    // Update is called once per frame
    void Update()
    {

    }
}

