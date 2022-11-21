using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingCar : MonoBehaviour
{
    float speed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the oncoming vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
