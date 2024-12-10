using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    //public GameObject[] obstaclePrefabs;
    //public Vector3 spawnPos = new Vector3(25,0,0);

    //public float startDelay = 2;
    //public float repeatRate = 2;

    public GameObject[] obstaclePrefabs;
    public Vector3 spawnPosition;
    private PlayerController playerControllerScript;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Instantiate(obstaclePrefab, spawnPos,obstaclePrefab.transform.rotation);
        //InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

        InvokeRepeating("SpawnObstacle", 2, 3);

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    void SpawnObstacle()
    {

        //Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPosition, Quaternion.identity);

        if (playerControllerScript.gameOver == false)
        {
            //Instantiate(obstaclePrefabs, spawnPosition, obstaclePrefabs.transform.rotation);
            Instantiate(obstaclePrefabs[obstacleIndex], spawnPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
