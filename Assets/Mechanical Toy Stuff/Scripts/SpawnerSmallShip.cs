using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnerSmallShip : MonoBehaviour
{
    //Variables to create a timer
    //One for how long the timer will go for -> duration
    //one to see how long the timer has been going for -> timer
    public float duration;
    public float timer;

    //Variables to check the left and right side of the screen
    //spawnerHeight is to set the position of the spawner on the y-axis
    public float spawnerHeight;
    public float spawnerLeft;
    public float spawnerRight;

    //The spawning prefab
    public GameObject smallShipPrefab;
    //Spawned ships detecting collisions with the main ship
    public Transform mainShip;

    void Start()
    {
        
    }

    void Update()
    {
        //Adds the time passed to the timer
        timer += Time.deltaTime;

        //Once the value of the timer is greater than the duration value, run this block of code
        if (timer > duration)
        {
            //Create a variable with the value being a random range between spawnerLeft and spawnerRight
            float randomSpotToSpawnShip = Random.Range(spawnerLeft, spawnerRight);

            //Create a Vector2 variable with the x position being set to the random value variable
            Vector2 spawnPosition = new Vector2(randomSpotToSpawnShip, spawnerHeight);

            //Create a variable that is set to spawn the prefab at the Vector2 position and rotated the same way as the spawner
            GameObject smallShipSpawned = Instantiate(smallShipPrefab, spawnPosition, transform.rotation);

            //A reference to the players ship to know where the player is
            smallShipSpawned.GetComponent<MovementSmallShip>().mainShip = mainShip;

            //Change the duration value to a random number between 5 - 10
            duration = Random.Range(5f, 10f);

            //Reset the timer back to zero
            timer = 0f;
        }
    }
}