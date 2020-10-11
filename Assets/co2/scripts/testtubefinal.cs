using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class testtubefinal : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SetComponent();

    }

    void SetComponent()
    {
        transform.position = new Vector3(-9.85f, -3301.09f, -6f);
        transform.localScale = new Vector3(0.07421f, 0.04373f, 0.0742f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

