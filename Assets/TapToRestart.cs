﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int num = Input.touchCount;

        if(num > 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}
