using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    private List<string> playerInventory;
    private int puzzlesSolved;
    private int tasksCompleted;

    public bool screwdriverObtained;
    public bool taskComplete;

    private void Awake() {
        // Singleton pattern
        if (_instance == null) {
            DontDestroyOnLoad(gameObject); // Keep the game manager alive between scenes
            InitializeGameManager(); // Set up initial values
            _instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    private void InitializeGameManager() {
        this.playerInventory = new List<string>();
        this.puzzlesSolved = 0;
        this.tasksCompleted = 0;
        screwdriverObtained = false;
        taskComplete = false;
    }

    public void AddToInventory(string itemName) {
        playerInventory.Add(itemName);
    }

    public void IncreasePuzzles(int points) {
        puzzlesSolved += points;
    }

    public void IncreaseTasks(int points) {
        tasksCompleted += points;
    }
}
