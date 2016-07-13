using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{
    private int pitchVal = 1;

    public bool AudioBegin = false;
    public AudioSource bgm;
    public int counter = 0;

    LevelManager levelManger;


    void Awake()
    {
        levelManger = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();
        StartLoop();
    }
    public void StartLoop()
    {
        bgm.clip = Instantiate(Resources.Load ("275673__foolboymedia__c64-melody")) as AudioClip;
        bgm.loop = true;
        bgm.Play();
        DontDestroyOnLoad(gameObject);
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
        bgm.pitch = --pitchVal;
    }
}