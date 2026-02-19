using UnityEngine;

public class MovementSmallShip : MonoBehaviour
{
    //Variable to control the speed of the small ship
    public float smallShipMoveSpeed;

    //Variable that changes the despawn distance
    public float offScreen = 30f;

    //Variable to check for collisions
    public float collisionDetectionDistance = 1f;

    //Variable to store the position of the small ship
    private Vector3 smallShipPosition;

    //A reference to the player sh[
    public Transform mainShip;

    void Start()
    {
        
    }

    void Update()
    {
        //Sets the position variable to the current position of the small ship
        smallShipPosition = transform.position;

        //Moves the small ship in the direction its pointing
        smallShipPosition += Time.deltaTime * smallShipMoveSpeed * transform.up;

        //Sets the new position to thechanging variable -- smallShipPosition
        transform.position = smallShipPosition;

        //Finds the position the small ship is in the world space and converts it's position to the screen space
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

        //Checks if the small ship goes off either side of the screen
        if (screenPosition.x > Screen.width + offScreen || screenPosition.x < 0 - offScreen ||
            screenPosition.y > Screen.height + offScreen || screenPosition.y < 0 - offScreen )
        {
            //Destroys the small ship clone
            Destroy(gameObject);
        }

        //Finds the distance between the small ship and the players ship
        float distanceToMainShip = Vector2.Distance(transform.position, mainShip.position);

        //Checks if the distance between the small ship and the players ship is smaller than the detection distance
        if (distanceToMainShip < collisionDetectionDistance)
        {
            //Destroys the players main ship -- GAME OVER
            Destroy(mainShip.gameObject);
        }
    }
}
