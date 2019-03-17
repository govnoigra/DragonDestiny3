using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class AutoLoadMenu : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public void AutoLoadOurMenu()
    {
        
        ulong numberFramesInVideo;
        numberFramesInVideo = videoPlayer.frameCount;
        ulong numberOfCurrentFrame;
        numberOfCurrentFrame = (ulong) videoPlayer.frame;
        if (numberOfCurrentFrame== numberFramesInVideo)
        {
            Application.LoadLevel(1);
        }


    }
}


