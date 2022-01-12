using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 velocity;
    public float speed;
    public float rotation;
    private float countDiff = 5;
    private float currentTime;
    void Start()
    {
        currentTime = Time.time;
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
    void Update()
    {
        transform.Translate(velocity * speed * Time.deltaTime);

        if (currentTime + countDiff < Time.time)
        {
            Destroy(gameObject);
            currentTime = Time.time;
        }
    }
}
