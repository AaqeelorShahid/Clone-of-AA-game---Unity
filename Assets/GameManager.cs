using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator Rotator;
    public Spawner Spawner;
    public Animator Animator;
    public void EngGame()
    {
        if (gameHasEnded)
            return;

        Rotator.enabled = false;
        Spawner.enabled = false;
        gameHasEnded = true;
        
        Animator.SetTrigger("EndGame");
        
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
