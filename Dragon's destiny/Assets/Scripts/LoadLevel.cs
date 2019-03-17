using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public void Play()
    {
        Application.LoadLevel(2);
    }

    public void SkipIntro()
    {
        Application.LoadLevel(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
