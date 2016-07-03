using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    PlayerController playerController;
    float xAxis = 0; // 1 = right, -1 = left

    void Awake ()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        if (xAxis != 0)
        {
            playerController.PlayerMove(xAxis);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadLevel();
        }
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Loads the current scene again
    }

}
