using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ptable : MonoBehaviour
{
    public BoxCollider tableboxcollider;

    // Start is called before the first frame update
    void Start()
    {
        AddComponent();
        FindComponent();
        SetComponent();

    }

    void SetComponent()
    {
        transform.position = new Vector3(3.4105f, -3306f, 3.6076f);
        transform.localScale = new Vector3(9.0977f, 7.8247f, 16.2207f);

        //main table
        tableboxcollider.center = new Vector3(-0.0279f, -0.0208f, -0.0065f);
        tableboxcollider.size = new Vector3(0.7179f, 0.7856f, 1.8144f);

        
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
