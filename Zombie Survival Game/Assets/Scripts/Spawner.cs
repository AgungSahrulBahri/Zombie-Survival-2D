using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    
    public Transform zombie;

    public float enemyMovementSpeed = 0.2f;
    public ulong spawnTime = 1;
    ulong time = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        time++;

        if (time % (spawnTime * 35) == 0)
        {
            ZombieSpawner();
        }
	}

    void ZombieSpawner()
    {
        int direction = Random.Range(1, 5);

        switch (direction)
        {

            case 1:
                Instantiate(zombie, new Vector3(13, 0, 7), new Quaternion());
                break;

            case 2:
                Instantiate(zombie, new Vector3(-13, 0, 7), new Quaternion());

                break;

            case 3:
                Instantiate(zombie, new Vector3(0, -8, 7), new Quaternion());

                break;

            case 4:
                Instantiate(zombie, new Vector3(0, 9, 7), new Quaternion());

                break;

        }
    }
}
