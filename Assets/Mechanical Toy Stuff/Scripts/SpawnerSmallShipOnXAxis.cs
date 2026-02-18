using UnityEngine;

public class SpawnerSmallShipOnXAxis : MonoBehaviour
{
    public float duration;
    public float timer;

    public float spawnerWidth;
    public float spawnerTop;
    public float spawnerBottom;

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
            float randomSpotToSpawnShip = Random.Range(spawnerTop, spawnerBottom);

            Vector2 spawnPosition = new Vector2(spawnerWidth, randomSpotToSpawnShip);

            GameObject smallShipSpawned = Instantiate(smallShipPrefab, spawnPosition, transform.rotation);

            smallShipSpawned.GetComponent<MovementSmallShip>().mainShip = mainShip;

            timer = 0f;
        }
    }
}
