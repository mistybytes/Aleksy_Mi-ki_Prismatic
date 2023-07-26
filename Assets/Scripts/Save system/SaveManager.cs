using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    void OnApplicationQuit()
    {
        GameManager.instance.Save();
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            GameManager.instance.Save();
        }
    }
    // Update is called once per frame
}
