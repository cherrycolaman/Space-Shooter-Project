using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public GameObject missilePrefab;
    public float speed = 2;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x > 14 || transform.position.x < -14)
        {
            speed = speed * -1;
        }
        if (timer > 1.5)
        {
            Instantiate(missilePrefab, transform.position, Quaternion.identity);
            timer = 0;
        }
    }

}
