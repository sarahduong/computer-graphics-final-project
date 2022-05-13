using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // index to gameplay scene (scene 1)
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
