using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    public float obsticalSpeed = 10.0f;
    public float xRange = -3.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * obsticalSpeed * Time.deltaTime);

        if (transform.position.x < startPos.x - repeatWidth) { transform.position = startPos; } 
    }
}
