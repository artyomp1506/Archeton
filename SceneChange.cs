﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneChange : MonoBehaviour
{
    
    public void ChangeScene(int number)
    {
        SceneManager.LoadScene(number);
    }
}
