using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public decimal timer;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += (decimal)Time.deltaTime;
	}
}
