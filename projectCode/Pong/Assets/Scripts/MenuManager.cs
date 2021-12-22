using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OnePlayer()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void TwoPlayer()
    {
        SceneManager.LoadScene("TwoPlayer");
    }
}
