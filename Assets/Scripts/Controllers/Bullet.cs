using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Vector3 velocity;
    public float acceleration;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity += acceleration * speed * Vector3.up * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }
}