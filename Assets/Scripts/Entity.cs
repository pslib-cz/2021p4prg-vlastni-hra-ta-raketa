using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public float HP = 5;
    public bool IsDead = false;


    public void Damage(float Damage)
    {
        HP -= Damage;
        if (HP <= 0)
        {
            if (!IsDead)
            {
                IsDead = true;
                Die();
            }
        }
    }
    public virtual void Die()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
