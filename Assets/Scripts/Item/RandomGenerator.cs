using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public List<GameObject> obj;
    public List<Transform> position;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            //random
            int spawnPoint = Random.Range(0, position.Count);
            int objSpawn = Random.Range(0, obj.Count);

            //spawn object
            Instantiate(obj[objSpawn], position[spawnPoint].position, position[spawnPoint].rotation);

            obj.Remove(obj[objSpawn]);
            position.Remove(position[spawnPoint]);
        }
    }
}
