using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public List<GameObject> Walls = new List<GameObject>();
    private float SpawnerTime = 1.5f;
    private float TimeCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeCounter += Time.deltaTime;

        if(TimeCounter >= SpawnerTime)
        {
            Instantiate(Walls[Random.Range(0, Walls.Count)], transform.position, transform.rotation);
            // Ou: GameObject spawner;
            // GameObject muro = Instantiate(Walls[Random.Range(0, Walls.Count)];
            // muro.transform.position = spawner.transform.position;
            TimeCounter = 0;
        }
    }
}
