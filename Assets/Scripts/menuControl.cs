using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{
    public string scenename;
    void Update()
    {
        if(Input.GetKey(KeyCode.E)){
            SceneManager.LoadScene(scenename);
        }
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
