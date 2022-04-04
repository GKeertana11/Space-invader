using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemeyPrefab;
    public Vector3 offset;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
       // time = time + Time.deltaTime;
        float x = Random.Range(-8.0f, 8.0f);
        int i = 0;
        
            while (i < 5)
            {
                Instantiate(enemeyPrefab[i], transform.position+new Vector3(-5 + i, 4f, 0f), Quaternion.identity);
                time = 0f;
                i++;
            }
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
