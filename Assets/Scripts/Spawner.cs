using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawningPrefab;

    public float waitDuration;
    public float destroyDuration;

    public Color pacerColor;
    public float pacerSpeed;

    public float progress;
    public float destroyProgress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Rotates spawner, but keeps the rotation and direction of the object to zero <<<<
        //Empty Vector
        //Vector3 originPosition = Vector3.zero;
        //Empty Rotation
        //Quaternion originRotation = Quaternion.identity;
        //Instantiate(spawningPrefab, transform.position, Quaternion.identity);

        //Spawns at position and rotation of spawner <<<<
        //Instantiate(spawningPrefab, transform.position, transform.rotation);

        //Spawns at origin <<<<
        //Instantiate(spawningPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        if (progress > waitDuration)
        {
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            //TypeOfComponent variableName = variableOfObject.GetComponent<TypeOfComponent>();

            Pacer spawnPacer = spawnedObject.GetComponent<Pacer>();
            spawnPacer.speed = pacerSpeed;

            //Set color of pacer spawner to be pacerColor
            //SpriteRenderer of pacer
            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = pacerColor;

            //Destroy(spawnedObject, destroyDuration);
            
            progress = 0f;
        }

        //destroyProgress += Time.deltaTime;

        //if (destroyProgress > destroyDuration)
        //{
        //    Destroy(gameObject);
        //}
    }

    public void IncreasePacerSpeed()
    {
        pacerSpeed++;
    }
}
