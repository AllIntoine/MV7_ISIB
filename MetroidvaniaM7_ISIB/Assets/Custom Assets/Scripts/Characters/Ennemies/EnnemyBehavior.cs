using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBehavior : CharacterBehavior
{
    public Transform player;//PlayerBehavior player;
    public float Range;
    public int dommage;
    public float intervalAttacks;

    void Start()
    {
        //player =  null;//FindGameObjectWithTag("Player")
        MaxHp = 5;
        Hp = MaxHp;
        MoveSpeed = 10.0f;
        JumpPower = 0.0f;
        Range = 0f;
        dommage = 1;
        intervalAttacks = 5f;
    }

    void Update()
    {
        /*
        if (Vector3.Distance(transform.position, player.transform.position) < Range)
        {
            //attack
            player.Hp = player.Hp - dommage;  // il faut appler une méthode prendre dégat dans player
        }*/
    }

    public void MoveToPlayer()
    {
        
        transform.LookAt(player.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        if (Vector3.Distance(transform.position, player.transform.position) > Range)
        {
            if (player.position.x > transform.position.x)
                transform.Translate(new Vector3(MoveSpeed * Time.deltaTime, 0, 0));
            else {
                transform.Translate(new Vector3( - MoveSpeed * Time.deltaTime, 0, 0));
            }
        }
    }

    public void TakeAHit()
    {
        Hp = Hp - 1;
        if (Hp == 0)
        {
            // annimation mort 
            Destroy(gameObject);
        }
    }
}