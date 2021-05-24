using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;

    private float x = 12;
    private float y;
    private float z = 0;
    private GameObject pipeClone;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipe()
    {
        y = Random.Range(-3, 3);
        pipeClone = Instantiate(pipe, new Vector3(x, y, z), transform.rotation);
        Destroy(pipeClone, 10);
    }
}
