using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Flask : MonoBehaviour
{
    public SphereCollider potionball;
    public CapsuleCollider potionneck;
    public BoxCollider potionbase;

    // Start is called before the first frame update
    void Start()
    {
        AddComponent();
        FindComponent();
        SetComponent();

    }

    void SetComponent()
    {
        transform.position = new Vector3(-11f, -3331f, 3f);
        transform.localScale = new Vector3(25f, 25f, 25f);

        //ball
        potionball.center = new Vector3(0.196f, 1.220f, 0.270f);
        potionball.radius = 0.07f;

        //neck
        potionneck.center = new Vector3(0.199f, 1.279f, 0.259f);
        potionneck.radius = 0.029f;
        potionneck.height = 0.223f;

        //base
        potionbase.center = new Vector3(0.199f, 1.2017f, 0.2659f);
        potionbase.size = new Vector3(0.0799f, 0.0965f, 0.0981f);
    }

    void FindComponent()
    {
        potionneck = gameObject.GetComponent<CapsuleCollider>();
        potionball = gameObject.GetComponent<SphereCollider>();
        potionbase = gameObject.GetComponent<BoxCollider>();
        
    }

    void AddComponent()
    {
        //gameObject.AddComponent<Rigidbody>();    
        gameObject.AddComponent<CapsuleCollider>();
        gameObject.AddComponent<SphereCollider>();
        gameObject.AddComponent<BoxCollider>();
        
    }


    // Update is called once per frame
    void Update()
    {

    }
}
