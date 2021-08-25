using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float enemySpeed;
    NavMeshAgent nav;
    Animator anim;
    [SerializeField] bool isChasing;
    [SerializeField] float chasingPoint;
    Vector3 startingPosition;
    [SerializeField] float chaseCount;
    [SerializeField] GameObject player;
    [SerializeField] float fireCount;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firePoint;
    [SerializeField] float BtwShots;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim=GetComponent<Animator>();
        startingPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = player.transform.position;
        if (Vector3.Distance(transform.position, target) <= chasingPoint)
        {
            isChasing = true;
        }
        else
        {
            isChasing = false;
        }
        if (isChasing)
        {
            nav.SetDestination(target);
            Fire();
            anim.SetBool("Walk", true);

        }
        else
        {
            nav.SetDestination(startingPosition);
            anim.SetBool("Walk", false);
        }
        
        
    }
    public void Fire()
    {
        float count = fireCount;
        fireCount -= Time.deltaTime;
        if (fireCount <= 0)
        {
            firePoint.LookAt(player.transform.position+new Vector3(0,1.5f,0));
            if (Time.time > BtwShots)
            {
                GameObject prefab = Instantiate(bullet, firePoint.transform.position, firePoint.rotation);
                BtwShots = BtwShots + Time.time;
            }
            fireCount = count ;
        }
    }
    
}
