using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCars : MonoBehaviour
{
    private float speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
