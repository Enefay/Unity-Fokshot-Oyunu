using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public GameObject takipObjesi;
    public Vector3 cameraOffset;
    // Update is called once per frame
    void LateUpdate()
    {
        if(takipObjesi)
        {
            transform.position = takipObjesi.transform.position + cameraOffset;
        }
        
    }
}
