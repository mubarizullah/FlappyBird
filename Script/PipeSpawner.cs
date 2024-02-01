using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    private float TimeBtwSpawn;
    public float StartTimeBtwSpawn;
    private Vector3 SpawnPos;
    float yPos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        yPos = Random.Range(-1.13f,4.17f);
        SpawnPos = new Vector3(transform.position.x,yPos,transform.position.z);
        if (TimeBtwSpawn <=0)
        {
                    Instantiate(pipe ,SpawnPos , transform.rotation);
                    TimeBtwSpawn = StartTimeBtwSpawn;
        }
        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }
    }
}
