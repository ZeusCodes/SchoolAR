using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class cubeblock : MonoBehaviour
{
    public BoxCollider tableboxcollider;
    public PhysicMaterial physicMaterial;

    // Start is called before the first frame update
    void Start()
    {
        AddComponent();
        FindComponent();
        SetComponent();

    }

    void SetComponent()
    {
        transform.position = new Vector3(4.4899f, -3300.770f, -3.2899f);
        transform.localScale = new Vector3(0.002949f, 0.00254f, 0.00526f);

        //main table
        tableboxcollider.center = new Vector3(-7.2767f, 1.334f, -7.537f);
        tableboxcollider.size = new Vector3(208.156f, 148.863f, 169.289f);



    }

    void FindComponent()
    {
        tableboxcollider = gameObject.GetComponent<BoxCollider>();
        
    }

    void AddComponent()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<BoxCollider>();
        
    }


    // Update is called once per frame
    void Update()
    {

    }
}

