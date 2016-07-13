using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    static bool AudioBegin = false;
    public AudioSource bgm;
    LevelManager levelManger;

    void Awake()
    {
        levelManger = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();

        if (!AudioBegin)
        {
            bgm.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    public void TemporaryPause()
    {
        bgm.Pause();
        if (levelManger.timerOn == false)
        {
            bgm.UnPause();
        }
    }
    public void CripplingDepression()
    {
        bgm.pitch -= 1;
    }
}