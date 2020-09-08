using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject spawne;
    public float spawnTime = 5.0f;
    public float spawnDelay = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    public void SpawnObject()
    {
        Color color = new Color(r: Random.Range(0F, 1F), g: Random.Range(0F, 1F), b: Random.Range(0F, 1F));
        Vector3 spawnPosition = new Vector3(Random.Range(-5, 5), 2.57f,0);
        GameObject ballInit = Instantiate(spawne, spawnPosition, transform.rotation);
        ballInit.GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Main Camera").GetComponent<ScoreHeal>().Heals() == 0)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
