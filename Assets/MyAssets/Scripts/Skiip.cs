using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skiip : MonoBehaviour
{
    public void back2Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

