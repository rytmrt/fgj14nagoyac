using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public GUIText scoreGUIText;

   
    private int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        scoreGUIText.text = score.ToString();
	}

    public void SetScore(int setP)
    {
        score = setP;
    }

    public int GetScore() 
    {
        return score;
    }

    public void InitScore()
    {
        score = 0;
    }

    public void AddScore(int addP)
    {
        score += addP;
    }


}
