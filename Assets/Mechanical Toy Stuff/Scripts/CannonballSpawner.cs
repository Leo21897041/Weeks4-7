using UnityEngine;

public class CannonballSpawner : MonoBehaviour
{
    public GameObject cannonball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickFiringCannonballs()
    {
        Instantiate(cannonball, transform.position, transform.rotation);
        
        Debug.Log("FIRE!!");
    }
}
