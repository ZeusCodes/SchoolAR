using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class table : MonoBehaviour
{
    public BoxCollider tableboxcollider;
    //public BoxCollider leg1;
    //public BoxCollider leg2;
    //public BoxCollider leg3;
    //public BoxCollider leg4;

    // Start is called before the first frame update
    void Start()
    {
        AddComponent();
        FindComponent();
        SetComponent();

    }

    void SetComponent()
    {
        float y = (3000f - 3325.1f);
        transform.position = new Vector3(-4.683f, y, 3.685f);
        transform.localScale = new Vector3(1.290f, 1.1095f, 2.30f);

        //main table
        tableboxcollider.center = new Vector3(0f, 17f, 0f);
        tableboxcollider.size = new Vector3(13f, 7.5f, 16f);

        /*
        //leg1
        leg1.center = new Vector3(4.5f, 16.5f, -6.1449f);
        leg1.size = new Vector3(1f, 7.199f, 0.699f);

        //leg2
        leg2.center = new Vector3(-4.5f, 16.5f, -6.149f);
        leg2.size = new Vector3(1f, 7.199f, 0.699f);

        //leg3
        leg3.center = new Vector3(-4.5f, 16.5f, 6.145f); ;
        leg3.size = new Vector3(1f, 7.1991f, 0.699f);

        //leg4
        leg4.center = new Vector3(4.5f, 16.5f, 6.144f);
        leg4.size = new Vector3(1f, 7.199f, 0.699f);
        */
    }

    void FindComponent()
    {
        tableboxcollider = gameObject.GetComponent<BoxCollider>();
        /*
         * leg1 = gameObject.GetComponent<BoxCollider>();
        leg2 = gameObject.GetComponent<BoxCollider>();
        leg3 = gameObject.GetComponent<BoxCollider>();
        leg4 = gameObject.GetComponent<BoxCollider>();
        */
    }

    void AddComponent()
    {
        //gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<BoxCollider>();
        /*
        gameObject.AddComponent<BoxCollider>();
        gameObject.AddComponent<BoxCollider>();
        gameObject.AddComponent<BoxCollider>();
        gameObject.AddComponent<BoxCollider>();
        */
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
