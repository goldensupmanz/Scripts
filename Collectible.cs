using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (speed * Time.deltaTime));
    }
}
