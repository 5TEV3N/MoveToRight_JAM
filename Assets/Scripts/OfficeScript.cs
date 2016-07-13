using UnityEngine;
using System.Collections;

public class OfficeScript : MonoBehaviour
{
    private LevelManager levelManager;
    float timer = 10f;
    void Awake()
    {
        levelManager = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();
    }
    void Update()
    {
        print(timer);
        timer -= Time.deltaTime; // -1 on time between each frame
        if (timer < 0)
        {
            levelManager.LoadNextLevel();
        }
    }
}
