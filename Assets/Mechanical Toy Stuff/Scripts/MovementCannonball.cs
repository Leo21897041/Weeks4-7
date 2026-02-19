using UnityEngine;

public class MovementCannonball : MonoBehaviour
{
    //Controls the speed the cannonball moves at
    public float cannonballSpeed;

    //Checks if the cannonball hits the small ship
    public float hitbox = 1f;

    //Checks if the button/method is pressed
    public bool isShot;

    //A reference to the crosshair's position
    public Transform crosshairLocation;

    //A reference to the small ships 
    public Transform smallShip;

    void Start()
    {

    }

    void Update()
    {
        //Check of the button is pressed
        if (isShot == true)
        { 
            //Moves the cannonball forward
            transform.position += cannonballSpeed * Time.deltaTime * transform.right;

            //Stores the distance between the cannonball and the crosshair's position
            float distance = Vector2.Distance(transform.position, crosshairLocation.position);

            //Stores the distance between the cannonball and the position of the small ship
            float distanceToSmallShip = Vector2.Distance(transform.position, smallShip.position);

            //Check if the distance between the cannonball and crosshair is less than a certain value
            if (distance < 0.1)
            {
                //Check if the distance between the cannonball and small ship is less than the hitbox variable
                if (distanceToSmallShip < hitbox)
                { 
                    //Destroy the small ship
                    Destroy(smallShip.gameObject);
                    Debug.Log("Hit the small ship");
                }

                //Destroy the cannonball when it reaches the crosshair
                Debug.Log("Hit the crosshair");
                Destroy(gameObject);
            }
        }
    }

    //Method that gets called when the button is pressed
    public void ShootCannonball()
    {
        isShot = true;
    }
}
