using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float bulletSpeed;
    public Rigidbody bulletrb;
    public float lifeTime;
    //public GameObject effects;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bulletrb.velocity = transform.forward * bulletSpeed;
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 2f);
        if (other.gameObject.tag == "Player")
        {
            var playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.PlayerDie(1);
            }
        }
        //Instantiate(effects, transform.position, transform.rotation);
    }

}
