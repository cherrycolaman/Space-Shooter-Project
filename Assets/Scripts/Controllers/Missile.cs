using Codice.Client.BaseCommands.CheckIn.Progress;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 moveDirection;
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
        moveDirection = Vector3.Normalize(playerTransform.position - transform.position);
        transform.Rotate(0, 0, (Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg) + 90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}
