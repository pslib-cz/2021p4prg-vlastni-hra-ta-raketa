using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Bullet Bullet;
    public Entity Parent;
    public float FireRate;
    public float Cooldown;

    public virtual void Fire()
    {
        Vector3 pos = new Vector3(0, 1, 0);
        if (Cooldown > 0) return;
        Bullet newBullet = Instantiate(Bullet, transform.position + pos, Parent.transform.rotation);
        newBullet.OwnedBy = Parent;
        Cooldown = FireRate;
        StartCoroutine(DestroyOverSeconds(5, newBullet.gameObject));
    }

    public IEnumerator DestroyOverSeconds(float time, GameObject go)
    {
        yield return new WaitForSeconds(time);
        Destroy(go);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Cooldown -= Time.deltaTime;
    }
}
