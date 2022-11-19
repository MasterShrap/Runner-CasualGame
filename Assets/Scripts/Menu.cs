using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void StopGame()
    {
        Time.timeScale = 0;
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void SoundOffOn()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
