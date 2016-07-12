using UnityEngine;
using System.Collections;

public class OfficeScript : MonoBehaviour
{
    private LevelManager levelManager;
    void Awake()
    {
        levelManager = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();
    }
    void Start()
    {
        StartCoroutine(Example());
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(10);
        levelManager.LoadNextLevel();

    }
}
