using UnityEngine;

public class SpawnerCannonball : MonoBehaviour
{
    public GameObject cannonballPrefab;
    public Transform crosshairLocation;
    public Transform smallShip;

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

        newCannonball.GetComponent<MovementCannonball>().smallShip = smallShip;

        Debug.Log("FIRE!!");
    }
}
