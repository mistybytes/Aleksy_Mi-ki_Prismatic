using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameOverCon : MonoBehaviour
{
    public void PlayGame()
    {
        GameManager.instance.levelEnded();
        SceneManager.LoadScene("MainMenu");
    }
}
