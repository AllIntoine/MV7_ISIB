using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTerritory : MonoBehaviour
{
    public BoxCollider territory;
    GameObject player;
    bool playerInTerritory;

    public GameObject enemyx;
    EnnemyBehavior enemy;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = enemyx.GetComponent<EnnemyBehavior>();
        playerInTerritory = false;
    }

    void Update()
    {
        if (playerInTerritory == true)
        {
            enemy.MoveToPlayer();
        }

        if (playerInTerritory == false)
        {
            //rien faire
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInTerritory = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInTerritory = false;
        }
    }
}
