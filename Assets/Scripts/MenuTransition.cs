using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTransition : MonoBehaviour
{
    public int sceneNumber;
    public void LoadGame()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
