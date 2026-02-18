using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnerSmallShip : MonoBehaviour
{
    public float duration;
    public float timer;

    public GameObject smallShipPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > duration)
        {
            GameObject smallShipSpawned = Instantiate(smallShipPrefab, transform.position, Quaternion.identity);

            timer = 0f;
        }

    }
}