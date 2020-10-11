using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class bunsenburner : MonoBehaviour
{
    public SphereCollider potionball;
    public CapsuleCollider potionneck;
    public BoxCollider potionbase;

    // Start is called before the first frame update
    void Start()
    {
        //AddComponent();
        //FindComponent();
        SetComponent();

    }

    void SetComponent()
    {
        float y = (3000f - 3299.8f);
        transform.position = new Vector3(0f, y, 0f);
        transform.localScale = new Vector3(0.0455f, 0.0455f, 0.0455f);

    }

    void FindComponent()
    {
        potionneck = gameObject.GetComponent<CapsuleCollider>();
        potionball = gameObject.GetComponent<SphereCollider>();
        potionbase = gameObject.GetComponent<BoxCollider>();

    }

    void AddComponent()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<CapsuleCollider>();
        gameObject.AddComponent<SphereCollider>();
        gameObject.AddComponent<BoxCollider>();

    }


    // Update is called once per frame
    void Update()
    {

    }
}
