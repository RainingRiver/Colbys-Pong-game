using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    private GameManager gameManager;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// this calls the count down to start
    /// </summary>
    public void StartCountdown()
    {
        animator.SetTrigger("StartCountdown");
    }

    public void StartGame()
    {
        gameManager.StartGame();
    }
}
