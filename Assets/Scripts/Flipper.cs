using UnityEngine;

public class Flipper : MonoBehaviour
{
    public bool isMovingRight = false;

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
        if (isMovingRight == true)
        { 
            position += direction * Time.deltaTime * speed * transform.right;
            transform.position = position;
        }
    }

    public void OnClickMove()
    {
        isMovingRight = true;
    }
    public void OnClickStop()
    {
        isMovingRight = false;
    }
    public void OnClickFlip()
    {
        direction *= -1f;
    }
}
