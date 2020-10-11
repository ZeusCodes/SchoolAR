using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class testtubeinitial : MonoBehaviour
{
    public Animator colour;

    // Start is called before the first frame update
    void Start()
    {
        AddComponent();
        FindComponent();
        SetComponent();

    }

    void SetComponent()
    {
        transform.position = new Vector3(-13.9499f, -3308.8799f, 0.1500f);
        transform.localScale = new Vector3(6.748f, 6.6647f, 6.7479f);

        //scolour.Controller = UnityEditor.ObjectWrapperJSON:{ "guid":"d74d3f3bf73f9e24a8efc6bd200e98d2","localId":9100000,"type":2,"instanceID":-41508};
        /*
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
        */
    }

    void FindComponent()
    {
        colour = gameObject.GetComponent<Animator>();
        /*
        potionball = gameObject.GetComponent<SphereCollider>();
        potionbase = gameObject.GetComponent<BoxCollider>();
        */
    }

    void AddComponent()
    {
        gameObject.AddComponent<Animator>();
        /*
        gameObject.AddComponent<CapsuleCollider>();
        gameObject.AddComponent<SphereCollider>();
        gameObject.AddComponent<BoxCollider>();
        */
    }

    // Update is called once per frame
    void Update()
    {
        SetComponent();
    }
}
