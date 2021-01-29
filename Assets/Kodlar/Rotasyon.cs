using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotasyon : MonoBehaviour
{
    Rigidbody fizik;
    public float hiz;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere * hiz;     /// angularVeloctiy açısal hızdır. Yani cismin rotationunda değişiklik yapar. Random fonk. kullanararak random bir değer de
        ///dönmesini sağladık. 
        
    }

    

    void Update()
    {
        
    }
}
