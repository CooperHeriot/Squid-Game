using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public bool togglePause = false;

    public GameObject panel;

    public string menu;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            togl();
        }

        if (togglePause == true)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        } else
        {
            panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void togl()
    {
        togglePause = !togglePause;
    }

    public void toMenu()
    {
        SceneManager.LoadScene(menu);
    }

    public void Quitt()
    {
        Application.Quit();
    }
}
