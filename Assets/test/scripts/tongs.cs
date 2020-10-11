using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class tongs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetComponent();

    }

    void SetComponent()
    {
        float y = (-3294.81f+3000.0f) ;
        transform.position = new Vector3(0.54f, y, -2.35f);
        transform.localScale = new Vector3(9.25125f, 9.25125f, 9.25125f);
        transform.eulerAngles = new Vector3(-101.433f, -2.1659f, -10.80798f);
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
