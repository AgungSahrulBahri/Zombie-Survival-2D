using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Bullet_Scripts
{
    public class Bullet : MonoBehaviour
    {
        private Vector2 directionV2;
        
        void Start()
        {
            var player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            var child = gameObject.transform.GetChild(0).transform;
            switch (player.lookingAt)
            {
                case "down":
                    directionV2 = Vector2.down;
                    break;

                case "left":
                    directionV2 = Vector2.left;
                    child.eulerAngles = new Vector3(0, 0, -90);
                    break;

                case "right":
                    directionV2 = Vector2.right;
                    child.eulerAngles = new Vector3(0, 0, 90);
                    break;

                case "up":
                    directionV2 = Vector2.up;
                    child.eulerAngles = new Vector3(0, 0, 180);
                    break;
            }
        }

        void Update()
        {
            int shootingSpeed = 35;
            transform.Translate(directionV2 * Time.deltaTime * shootingSpeed);
        }

        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "Zombie")
            {
                Destroy(gameObject);
            }
        }
    }
}
