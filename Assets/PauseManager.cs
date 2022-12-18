using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public bool togglePause = false;
    public bool isPauseScript = true;

    public GameObject panel, anet;

    public string menu;
    //public Animator
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPauseScript == true)
        {
            togl();
        }

        if (isPauseScript == true)
        {
            if (togglePause == true)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                panel.SetActive(false);
                Time.timeScale = 1;
            }
        } else
        {
            panel.SetActive(true);
            Time.timeScale = 1;
        }
        
    }
    public void togl()
    {
        togglePause = !togglePause;
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void toMenu()
    {
        SceneManager.LoadScene(menu);
    }

    public void Quitt()
    {
        Application.Quit();
    }

    public void TriggerAnim()
    {
        anet.SetActive(true);
        //panel.SetActive(false);
        Destroy(panel.gameObject);
    }
}
