using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public List<GameObject> Walls = new List<GameObject>();
    private float TimeCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeCounter += Time.deltaTime;

        if(TimeCounter % 5 == 0)
        {
            Instantiate(Walls[Random.Range(0, Walls.Count)], transform.position, transform.rotation);
        }
    }
}
