using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private LevelManager levelManager;
    private AudioManager audioManager;

    public GameObject fadeToBlackIcon;
    public bool timerOn = false;

    float timer = 2f;

    

    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("T_AudioManager").GetComponent<AudioManager>();

        if (fadeToBlackIcon == true)
        {
            timerOn = true;
            audioManager.TemporaryPause();
        }
    }

    void Update()
    {
        if (timerOn == true)
        {
            timer -= Time.deltaTime;
            print(timer);
            if (timer < 0)
            {
                fadeToBlackIcon.SetActive(false);
                timerOn = false;
                audioManager.TemporaryPause();
            }
        }
    }
    
    public void LoadNextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (currentScene == nextScene)
        {
            Debug.Log("No next Scene!");
            return;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            if (currentScene == 3) // If the scene is "1.2 Room", then load the first scene ("_1Room")

                SceneManager.LoadScene(0);
            }
        }
}
//private UIManager UIManager;

//UIManager = GameObject.FindGameObjectWithTag("T_UIManager").GetComponent<UIManager>();

/*
public void LoadLevel(string levelID)
{
    SceneManager.LoadScene(levelID); //Loads scene according to name (Can be int ID if needed)
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        UIManager.UnhideUI();
        print("Menu Activated");
    }
}
*/
