using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement; 

public class Balls : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject ProjectilPrefab;
    [SerializeField] private GameObject Flashlight;
    [SerializeField] private Camera Camera;
    private float projectileCooldown;
    
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Painting")) 
        {
            Destroy(other.gameObject);
            
            int sceneNumber = SceneManager.GetActiveScene().buildIndex;
            
            SceneManager.LoadScene(sceneNumber + 1);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(this.gameObject.transform.position,Vector3.down,out RaycastHit hit, transform.localScale.z + 0.04f))
            {
                if (hit.collider != null)
                {
                    rb.AddForce(Vector3.up * 8f, ForceMode.Impulse);
                }
            }
        }
        
        
        
        if (projectileCooldown <= 0)
        {
            
            if (!Flashlight.activeSelf)
            {
                Flashlight.SetActive(true);
            }
            
            if (Input.GetKeyDown(KeyCode.F))
            {
                Instantiate(ProjectilPrefab, transform.position, transform.rotation); projectileCooldown = 2;
                
            }
        }
        else
        {
            if (Flashlight.activeSelf)
            {
                Flashlight.SetActive(false);
            }
        }
        

        projectileCooldown -= Time.deltaTime;
    }

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 camForward = Camera.transform.forward;
            camForward.y = 0;
            camForward.Normalize();
            rb.AddForce(camForward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 camLeft = -Camera.transform.right;
            camLeft.y = 0;
            camLeft.Normalize();
            rb.AddForce(camLeft * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 camBack = -Camera.transform.forward;
            camBack.y = 0;
            camBack.Normalize();
            rb.AddForce(camBack * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 camRight = Camera.transform.right;
            camRight.y = 0;
            camRight.Normalize();
            rb.AddForce(camRight * speed);
        }
        
    }
}

//make a layer called "interactable" and add it to the door
//make a 3d platform and attach the "Platform" Script to it
//make a 3d cylinder, make its mass infinite, activate interpolation, collision detection continuous, and attach "push cylinder" to it
//window, package manager, unity registry, probuilder, install

