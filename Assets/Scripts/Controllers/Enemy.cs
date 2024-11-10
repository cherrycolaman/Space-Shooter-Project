using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject missilePrefab;
    public float speed;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x > 14 || transform.position.x < -14)
        {
            speed = speed * -1;
        }
        if (timer > 3)
        {
            Instantiate(missilePrefab, transform.position, Quaternion.identity);
            timer = 0;
        }
    }

}
