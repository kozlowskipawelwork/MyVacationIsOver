using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterChase : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody monsterRigid;
    public Transform monsterTransform, playerTransform;
    public int monsterSpeed;

    void FixedUpdate(){
        monsterRigid.velocity = playerTransform.forward * monsterSpeed * Time.deltaTime;
    }
    void Update(){
        monsterTransform.LookAt(playerTransform);
    }
}   
