using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetComponent();

    }

    void SetComponent()
    {
        float y = (-3295.93f + 3000f);
        transform.position = new Vector3(0.0294f, y, 1.49f);
        //transform.localScale = new Vector3(9.25125f, 9.25125f, 9.25125f);
        //transform.eulerAngles = new Vector3(-101.433f, -2.1659f, -10.80798f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
