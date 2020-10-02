using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 8;
    float x, y;
    private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

    }


    void Update()
    {
        transform.Translate(new Vector3(x * speed * Time.deltaTime, y * speed * Time.deltaTime, 0));
    }
}
