using UnityEngine;


public class Zombie : MonoBehaviour
{

    public string direction;
    public float movementSpeed = 5;
    private Vector2 directionV2;
    GameObject Player;
        
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
         
        switch (transform.localPosition.ToString())
        {
            case "(0.0, 9.0, 7.0)":
                direction = "down";
                directionV2 = Vector2.down; 
                break;

            case "(13.0, 0.0, 7.0)":
                direction = "left";
                directionV2 = Vector2.left; 
                break;

            case "(-13.0, 0.0, 7.0)":
                direction = "right";
                directionV2 = Vector2.right; 
                break;

            case "(0.0, -8.0, 7.0)":
                direction = "up";
                directionV2 = Vector2.up; 
                break;
        }

        anim.SetTrigger(direction);

        decimal timePassed = GameObject.Find("TimeKeeper").GetComponent<Timer>().timer;
        movementSpeed += (float)timePassed / 7;
    }

    void Update()
    {
        movementSpeed += 0.01f;
        //transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, transform.position.z), movementSpeed);
        transform.Translate(directionV2 * Time.deltaTime * movementSpeed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Projectile")
        {
            Destroy(gameObject);
            
            if (col.gameObject.tag == "Projectile")
            {
                GameObject.Find("ScoreKeeper").GetComponent<ScoreKeeper>().score += 100;
            }
        }
    }
}

