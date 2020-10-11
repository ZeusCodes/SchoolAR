using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mgstrip : MonoBehaviour
{
    void Start()
    {
        SetComponent();

    }

    void SetComponent()
    {
        float y  = (3000f-3296.09f);
        transform.position = new Vector3(0f, y, 0f);
        transform.localScale = new Vector3(4.204922f, 4.204922f, 4.204922f);
        transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
