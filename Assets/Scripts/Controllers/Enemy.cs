using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject missilePrefab;
    public float speed;
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x > 14 || transform.position.x < -14)
        {
            speed = speed * -1;
        }
    }

}
