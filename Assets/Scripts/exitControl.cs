using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitControl : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
