using UnityEngine;
public class Knife : MonoBehaviour
{
    public GameObject knifeSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        knifeSprite = GetComponent<GameObject>();
        knifeSprite.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
