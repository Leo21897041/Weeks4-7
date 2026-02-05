using UnityEngine;

public class CodingGymSpawnedMovement : MonoBehaviour
{
    public float speed = 1f;
    public float direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * speed * direction * transform.right;
    }
}
