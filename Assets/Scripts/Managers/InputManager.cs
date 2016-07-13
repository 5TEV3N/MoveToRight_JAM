using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    PlayerController playerController;
    float xAxis = 0; // 1 = right, -1 = left
    public Animator anim;

    void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        if (xAxis != 0)
        {
            anim.SetBool("isWalking", true);
            playerController.PlayerMove(xAxis);
        }
        if (xAxis == 0)
        {
            anim.SetBool("isWalking", false);
        }
    }
}
