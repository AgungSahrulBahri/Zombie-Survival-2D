using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Sprite spriteLeft;
    public Sprite spriteRight;
    public Sprite spriteUp;
    public Sprite spriteDown;
    
    public Transform bullet;

    public float timeBetweenAttacks;
    private ulong timer;

    private Player player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {

        timer++;
        timeBetweenAttacks /= 1.0000001f;

        InputHandler();    
	}

    //keyboard input
    public void InputHandler()
    {    
        if (Input.GetKeyDown("right") && timer > timeBetweenAttacks * 60)
        {
            player.lookingAt = "right";
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteRight;
            Instantiate(bullet, new Vector3(0, 0.6f, 0), new Quaternion(0, 0, 0, 0));

            timer = 0;
        }
        else if (Input.GetKeyDown("left") && timer > timeBetweenAttacks*60)
        {
            player.lookingAt = "left";
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteLeft;
            Instantiate(bullet, new Vector3(0, 0.74f, 0), new Quaternion());

            timer = 0;
        }
        else if (Input.GetKeyDown("up") && timer > timeBetweenAttacks * 60)
        {
            player.lookingAt = "up";
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteUp;
            Instantiate(bullet, new Vector3(0.3f, 0.75f, 0), new Quaternion());

            timer = 0;

        }
        else if (Input.GetKeyDown("down") && timer > timeBetweenAttacks * 60)
        {
            player.lookingAt = "down";
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteDown;
            Instantiate(bullet, new Vector3(-0.2f, 0.5f, 0), new Quaternion());
            timer = 0;

        }      
    }
}


