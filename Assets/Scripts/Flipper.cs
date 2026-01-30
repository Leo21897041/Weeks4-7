using UnityEngine;

public class Flipper : MonoBehaviour
{
    public bool isMovingRight = false;
    public bool isStopped = false;
    public bool isFlipped = false;

    public Vector3 position;
    public float speed;
    public float direction = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        position = direction * Time.deltaTime * speed * transform.right;
        transform.position = position;

        if (isFlipped == true)
        {
            direction *= -1f;
        }
    }

    public void OnClickMove()
    {
        isMovingRight = true;
        isFlipped = false;
        isStopped = false;
    }
    public void OnClickStop()
    {
        isMovingRight = false;
        isStopped = true;
        isFlipped = false;
    }
    public void OnClickFlip()
    {
        isMovingRight = false;
        isStopped = false;
        isFlipped = true;
    }
}
