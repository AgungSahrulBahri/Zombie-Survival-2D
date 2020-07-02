using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;

    public string lookingAt;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zombie")
        {
            if (PlayerPrefs.GetInt("High Score") < (int)scoreKeeper.score)
            {
                PlayerPrefs.SetInt("High Score", (int)scoreKeeper.score);
            }
          
            SceneManager.LoadScene("GameOver");   
        }
    }
}
