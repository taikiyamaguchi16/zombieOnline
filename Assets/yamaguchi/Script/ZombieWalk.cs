using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieWalk : MonoBehaviour
{
    public Transform player;
    UnityEngine.AI.NavMeshAgent nav;
    Animator anim;

    void Awake()
    {
       // player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        nav.SetDestination(player.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            Debug.Log("hit");
            anim.SetBool("isAttack", true);
        }
    }
}