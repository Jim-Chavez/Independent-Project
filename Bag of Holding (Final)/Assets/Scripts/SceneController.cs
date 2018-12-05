using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

public void StartScreen()
    {
        SceneManager.LoadScene(0);
    }

public void MainApplication()
    {
        SceneManager.LoadScene(1);
    }
}
