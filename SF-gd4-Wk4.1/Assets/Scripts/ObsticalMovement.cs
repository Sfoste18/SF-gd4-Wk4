using UnityEngine;

public class ObsticalMovement : MonoBehaviour
{
    public float obstacleSpeed = 10.0f;
    public float xRange = -1.5f;
    private PlayerController playerControllerScript;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * obstacleSpeed * Time.deltaTime);
        
        if (transform.position.x < xRange)
        {
            Destroy(gameObject);
        }

        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * obstacleSpeed);
        }



    }
}
