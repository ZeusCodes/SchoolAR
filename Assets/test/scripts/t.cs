using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetComponent();

    }

    void SetComponent()
    {
        float y = (3000f - 3308.63f);
        transform.position = new Vector3(0.54f, y, 8.73f);
        transform.localScale = new Vector3(5.5f, 5.5f, 5.5f);
        //transform.eulerAngles = new Vector3(-101.433f, -2.1659f, -10.80798f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
