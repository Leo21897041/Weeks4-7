using UnityEngine;

public class SpawnerCannonball : MonoBehaviour
{
    public GameObject cannonballPrefab;
    public Transform crosshairLocation;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClickFiringCannonballs()
    {
        GameObject newCannonball = Instantiate(cannonballPrefab, transform.position, transform.rotation);

        newCannonball.GetComponent<MovementCannonball>().crosshairLocation = crosshairLocation;
        newCannonball.GetComponent<MovementCannonball>().ShootCannonball();

        Debug.Log("FIRE!!");
    }
}
