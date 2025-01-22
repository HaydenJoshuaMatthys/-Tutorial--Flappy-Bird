using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public  float SpawnRate = 2;
    public float Timer = 0;
    public float HeightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < SpawnRate)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            Timer = 0;
        }
    }

    void SpawnPipe()
    {
        Debug.Log("Pipe Spawned");
        float LowestPoint = transform.position.y - HeightOffset;
        float HighestPoint = transform.position.y + HeightOffset;

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), transform.position.z), transform.rotation);
    }
}
