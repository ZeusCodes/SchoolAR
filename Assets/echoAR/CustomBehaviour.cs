/**************************************************************************
* Copyright (C) echoAR, Inc. 2018-2020.                                   *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echoar.xyz/terms, or another agreement                      *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {
               
        // Add RemoteTransformations script to object and set its entry
        //this.gameObject.AddComponent<RemoteTransformations>().entry = entry;

        // Qurey additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {   
            // Set name
            this.gameObject.name = value;
            if (value == "table")
            {
                gameObject.AddComponent<table>();
            }
            if (value == "ptable")
            {
                gameObject.AddComponent<ptable>();
            }
            if (value == "Flask")
            {
                gameObject.AddComponent<Flask>();
            }
            if (value == "burner")
            {
                gameObject.AddComponent<bunsenburner>();
            }
            if (value == "burningbunsen")
            {
                gameObject.AddComponent<bunsenburner>();
            }
            if (value == "ifinal")
            {
                gameObject.AddComponent<testtube>();
            }
            if (value == "ffinal")
            {
                gameObject.AddComponent<testtubefinal>();
            }
            if (value == "vtube")
            {
                gameObject.AddComponent<vtube>();
            }
            if (value == "initial")
            {
                gameObject.AddComponent<testtubeinitial>();
            }
            if (value == "tongs")
            {
                gameObject.AddComponent<tongs>();
            }
            if (value == "base")
            {
                gameObject.AddComponent<woodenbase>();
            }
            if (value == "changer")
            {
                gameObject.AddComponent<woodenchanger>();
            }
            if (value == "cubeblock")
            {
                gameObject.AddComponent<cubeblock>();
            }
            if (value == "mgstrip")
            {
                gameObject.AddComponent<mgstrip>();
            }
            if (value == "i")
            {
                gameObject.AddComponent<i>();
            }
            if (value == "t")
            {
                gameObject.AddComponent<t>();
            }
            if (value == "final")
            {
                gameObject.AddComponent<t>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}