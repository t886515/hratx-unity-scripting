using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject gameOverText;
	public bool gameOver;
	public Text scoreText;
	public static GameController instance;
    public float scrollSpeed = -1.5f;
	private int score = 0;

    // Use this for initialization
    void Awake ()
	{
		if (instance == null)
		{
			instance = this;
		} else if (instance != null)
		{
			Destroy (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameOver == true && Input.GetMouseButtonDown (0))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void BirdScored ()
	{
		if (gameOver)
		{
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString ();
	}
	public void BirdDied ()
	{
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
