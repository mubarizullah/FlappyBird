using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TreeSpawner : MonoBehaviour
{
    public GameObject tree;
    private float TimeBtwSpawn;
    public float StartTimeBtwSpawn;
    public float yPos;
    private Vector3 treePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        treePos = new Vector3(transform.position.x,yPos , transform.position.z);
        if (TimeBtwSpawn<= 0 )
        {
            Instantiate(tree ,treePos, transform.rotation );
            TimeBtwSpawn = StartTimeBtwSpawn;
        }
    else
    {
        TimeBtwSpawn -= Time.deltaTime;
    }
    }
}
