using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	    GameObject.Find("HighScore").GetComponent<Text>().text = "High Score: " + PlayerPrefs.GetInt("High Score");
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
