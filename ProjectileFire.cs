using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float shrinkSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * (speed * Time.deltaTime));
        transform.localScale -= new Vector3(0, 1, 1) * (shrinkSpeed * Time.deltaTime);
        
        if (gameObject.transform.localScale.y <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destructible"))
        {
            Destroy(collision.gameObject); 
        }
    }

    
}
