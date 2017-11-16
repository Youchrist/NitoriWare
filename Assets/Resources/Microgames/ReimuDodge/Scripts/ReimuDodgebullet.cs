using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReimuDodgebullet : MonoBehaviour
{ void Start()
    {
        Invoke("SetTrajectory", delay);
        GameObject player = GameObject.Find("Player");
        trajectory = (player.transform.position - transform.position).normalized;
    }
    void SetTrajectory()
    {
        GameObject player = GameObject.Find("Player");
        trajectory = (player.transform.position - transform.position).normalized;
    }
    [Header("How fast the bullet goes")]
    [SerializeField]
    private float speed = 1f;

    [Header("Firing delay in seconds")]
    [SerializeField]
   
    private float delay = 1f;
    private Vector2 trajectory;
   
    void Update()
    {
        if (trajectory != null)
        {
            Vector2 newPosition = (Vector2)transform.position + (trajectory * speed * Time.deltaTime);
            transform.position = newPosition;
        }
    }
}
