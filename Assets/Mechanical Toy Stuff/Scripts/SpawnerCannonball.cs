using UnityEngine;

public class SpawnerCannonball : MonoBehaviour
{
    //The cannonball prefab
    public GameObject cannonballPrefab;

    //A reference to the crosshair object so the cannonball knows where it is
    public Transform crosshairLocation;

    //A reference to the small ships so the cannonball knows where it is
    public Transform smallShip;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //A new method to put on the button
    //Runs this method when the button is pressed
    public void OnClickFiringCannonballs()
    {
        //Spawns a new cannonball prefab at the position and rotation of the spawner
        GameObject newCannonball = Instantiate(cannonballPrefab, transform.position, transform.rotation);

        //Gets the crosshairLocation reference from the MovementCannonball script and make it equal to the crosshairLocation reference from this script
        newCannonball.GetComponent<MovementCannonball>().crosshairLocation = crosshairLocation;
        
        //Gets the ShootCannonball() method from the MovementCannonball script and run it
        newCannonball.GetComponent<MovementCannonball>().ShootCannonball();

        //Gets the smallShip reference from the MovementCannonball script and puts it into the smallShip reference from this script
        newCannonball.GetComponent<MovementCannonball>().smallShip = smallShip;

        //Writes this in the console
        Debug.Log("FIRE!!");
    }
}
