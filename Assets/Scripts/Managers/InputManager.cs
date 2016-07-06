using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    PlayerController playerController;
    LevelManager levelManager;
    float xAxis = 0; // 1 = right, -1 = left

    void Awake ()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        levelManager = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();
    }

    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        if (xAxis != 0)
        {
            playerController.PlayerMove(xAxis);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            print("Restart");
            levelManager.ReloadLevel();
        }
    }
}
