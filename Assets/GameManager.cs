using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public int lives = 3;
    public GameObject loseText;
    public List<Kostka> bricks = new List<Kostka>();
    public int maxLevel = 3;
    public int currentLevel = 1;

    private void Start()
    {
        loseText.SetActive(false);
    }

    bool gameEnded;
    private void Update()
    {
        if ((gameEnded))
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                //Restart
            }
        }
        if (bricks.Count == 0)
        {
            currentLevel++;
            if(currentLevel > maxLevel)
            {
                //Game Win
            }
            else
            {
                GetComponent<BricksGenerator>().StartLevel(currentLevel);
            }
        }
    }

    public void GameOver()
    {
        loseText.SetActive(true);
    }
}
