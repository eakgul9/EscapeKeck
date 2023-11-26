using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    private List<string> playerInventory;
    private int puzzlesSolved;
    private int tasksCompleted;

    private bool screwdriverObtained;

    private void awake() {
        // Singleton pattern
        if (_instance == null) {
            _instance = this;
            DontDestroyOnLoad(gameObject); // Keep the game manager alive between scenes
            InitializeGameManager(); // Set up initial values
        } else {
            Destroy(gameObject);
        }
    }

    private void InitializeGameManager() {
        playerInventory = new List<string>();
        puzzlesSolved = 0;
        tasksCompleted = 0;
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
