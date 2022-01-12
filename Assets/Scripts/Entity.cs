using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Entity : MonoBehaviour
{
    public int startHp;
    int hp;
    public float bulletCooldown;
    float bulletTimer;
    public Text MyHP;
    void Start()
    {
        hp = startHp;
        MyHP.text = "HP: " + hp;
    }
    void Update()
    {
        MyHP.text = "HP: " + hp;
        bulletTimer -= Time.deltaTime;
        if (hp == 0)
        {
            SceneManager.LoadScene(0);
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
