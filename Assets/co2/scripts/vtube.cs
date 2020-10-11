using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class vtube : MonoBehaviour
{
    public Animator colour;

    // Start is called before the first frame update
    void Start()
    {
        SetComponent();
    }

    void SetComponent()
    {
        transform.position = new Vector3(-9.7399f, -3290.8999f, -3.119f);
        transform.localScale = new Vector3(2.9732f, 2.973f, 2.9732f);
        transform.eulerAngles = new Vector3(0f, 0f, 165.4207f);

    }

}

