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
        monsterRigid.velocity = monsterTransform.forward * monsterSpeed * Time.deltaTime;
    }
    void Update(){
    Quaternion forwardLean = Quaternion.Euler(30, 0, 0);
    Quaternion targetRotation = Quaternion.LookRotation(playerTransform.position - monsterTransform.position) * forwardLean;
    monsterTransform.rotation = Quaternion.Slerp(monsterTransform.rotation, targetRotation, Time.deltaTime);
}


}   
