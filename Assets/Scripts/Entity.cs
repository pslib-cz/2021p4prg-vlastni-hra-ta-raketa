using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public int startHp;
    int hp;
    public float bulletCooldown;
    float bulletTimer;
    void Start()
    {
        hp = startHp;
    }
    void Update()
    {
        bulletTimer -= Time.deltaTime;
        if (hp == 0)
        {
            //SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet" && bulletTimer <= 0)
        {
            hp -= 1;
            //print(hp);
            bulletTimer = bulletCooldown;
        }
    }
}
