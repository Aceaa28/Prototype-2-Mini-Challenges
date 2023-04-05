using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score += 1;
        Debug.Log("Score: " + score);
    }

    public void UpdateLives()
    {
        lives -= 1;
        Debug.Log("lives: " + lives);

        if(lives == 0)
        {
            Debug.Log("Game Over!");
            lives = 0;
        }
    }
}
