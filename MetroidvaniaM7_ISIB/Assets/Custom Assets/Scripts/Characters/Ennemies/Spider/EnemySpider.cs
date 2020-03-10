﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpider : CharacterBehavior
{
    public PlayerBehavior player;//
    public float Range;
    public int dommage;
    public float intervalAttacks;

    void Start()
    {

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
        
    }
    
    public void MoveToPlayer()
    {
        
        this.transform.LookAt(player.transform.position);
        this.transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        
        if (Vector3.Distance(this.transform.position, player.transform.position) > Range)
        {
            //if (player.transform.position.x > this.transform.position.x)
                this.transform.Translate(new Vector3(MoveSpeed * Time.deltaTime, 0, 0)); 
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

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Toucher");
        if (collider.tag == "Player")
        {
            Debug.Log("player doit prendre dégat");
        }      
}}