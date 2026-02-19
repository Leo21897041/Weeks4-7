using UnityEngine;

public class SpawnerSmallShipOnXAxis : MonoBehaviour
{
    //THIS SCRIPT IS THE SAME AS THE SpawnerSmallShip SCRIPT. THIS SCRIPT ONLY HAS A FEW VARIABLE CHANGED

    public float duration;
    public float timer;

    public float spawnerWidth;
    public float spawnerTop;
    public float spawnerBottom;

    public GameObject smallShipPrefab;
    public Transform mainShip;

    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > duration)
        {
            float randomSpotToSpawnShip = Random.Range(spawnerTop, spawnerBottom);

            //Put the random value variable in the y position of the Vector2
            Vector2 spawnPosition = new Vector2(spawnerWidth, randomSpotToSpawnShip);

            //The prefab will spawn on a random spot on the y axis
            GameObject smallShipSpawned = Instantiate(smallShipPrefab, spawnPosition, transform.rotation);

            smallShipSpawned.GetComponent<MovementSmallShip>().mainShip = mainShip;

            timer = 0f;

            duration = Random.Range(2f, 7f);
        }
    }
}
