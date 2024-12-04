using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManagerX;
    public int difficulty; // Value representing difficulty (e.g., 1 for Easy, 2 for Medium, 3 for Hard)

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    // Sets the difficulty and starts the game
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameManagerX.StartGame(difficulty); // Pass the difficulty value to StartGame
    }
}
