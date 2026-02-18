using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnerSmallShip : MonoBehaviour
{
    public float duration;
    public float timer;

    public GameObject smallShipPrefab;
    public Transform mainShip;

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

            smallShipSpawned.GetComponent<MovementSmallShip>().mainShip = mainShip;

            timer = 0f;
        }
    }
}