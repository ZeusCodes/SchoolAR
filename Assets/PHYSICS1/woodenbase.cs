using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class woodenbase : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SetComponent();

    }

    void SetComponent()
    {
        transform.position = new Vector3(-4.599f, -3320.53f, -0.14839f);
        transform.localScale = new Vector3(13.58228f, 13.58228f, 13.58228f);

    }  

    // Update is called once per frame
    void Update()
    {

    }
}

