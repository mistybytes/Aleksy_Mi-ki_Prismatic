using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    
    void OnApplicationQuit()
    {
        Debug.Log("GAME SAVED");
        GameManager.instance.Save();
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            Debug.Log("GAME SAVED");
            GameManager.instance.Save();
        }
    }
    // Update is called once per frame
}
