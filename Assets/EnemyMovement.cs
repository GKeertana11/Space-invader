using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    bool flag = false;
    float bulletTime;
   // EnemySpawnAndMovement enemySpawner;
    public GameObject enemybulletPrefab;
    GameObject bullet;
    public Vector3 offset;

    void Start()
    {
       // enemySpawner = GameObject.Find("SpawnManager").GetComponent<EnemySpawnAndMovement>();
    }

    // Update is called once per frame
    void Update()
    {

        if (flag == false)
        {
            time = time + Time.deltaTime;
            transform.Translate(Vector2.right * 2f * Time.deltaTime);
            bulletTime = bulletTime + Time.deltaTime;
            if (bulletTime > 2f)
            {
                //int k = Random.Range(0, enemySpawner.enemyPrefab.Length);
                bullet = Instantiate(enemybulletPrefab, transform.position + offset, Quaternion.identity);
                bulletTime = 0;
            }
            if (time > 4f)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);

                time = 0;
                flag = true;
            }
        }
        else if (flag == true)
        {
            transform.Translate(Vector2.left * 2f * Time.deltaTime);
            bulletTime = bulletTime + Time.deltaTime;
            bulletTime = bulletTime + Time.deltaTime;
            if (bulletTime > 2f)
            {
                //int k = Random.Range(0, enemySpawner.enemyPrefab.Length);
                bullet = Instantiate(enemybulletPrefab, transform.position + offset, Quaternion.identity);
                bulletTime = 0;
            }

            time = time + Time.deltaTime;
            if (time > 4f)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
                time = 0;
                flag = false;
            }
        }
        //if(enemySpawner==null)



    }
}