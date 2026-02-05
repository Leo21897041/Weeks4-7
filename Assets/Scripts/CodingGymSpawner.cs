using UnityEngine;

public class CodingGymSpawner : MonoBehaviour
{
    public GameObject prefabSpawner;

    public float duration;
    public float destroyDuration;

    public float progress;
    public float destroyProgress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        if (progress > duration)
        {
            GameObject prefabSpawned = Instantiate(prefabSpawner, transform.position, Quaternion.identity);

            progress = 0f;
        }

        destroyProgress += Time.deltaTime;

        if (destroyProgress > destroyDuration)
        {
            Destroy(prefabSpawner);
        }
    }
}