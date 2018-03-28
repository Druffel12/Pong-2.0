using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public GameObject loadingImage;


    public void LoadLevel(string Game)
    {
        SceneManager.LoadScene(Game);
    }
}