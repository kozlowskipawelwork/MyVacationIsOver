using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorClosed, doorOpened, intIcon, lockedtext;
    public bool opened, locked;
    public static bool keyfound;
    public float openTime;

    void Start(){
        keyfound = false;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intIcon.SetActive(true);
            if (locked == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    intIcon.SetActive(false);
                    doorClosed.SetActive(false);
                    doorOpened.SetActive(true);
                    StartCoroutine(closeDoor());
                }
            }
            if (locked == true)
            {
                lockedtext.SetActive(true);
            }
        }
    }
    IEnumerator closeDoor()
    {
        yield return new WaitForSeconds(openTime);
        doorOpened.SetActive(false);
        doorClosed.SetActive(true);
    }

    void Update(){
        if(keyfound == true){
            locked = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intIcon.SetActive(false);
            lockedtext.SetActive(false);
        }
    }
}