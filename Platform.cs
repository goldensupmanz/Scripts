using Unity.VisualScripting;
using UnityEngine;

namespace TutorialInfo
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] float timer = 5f;
        [SerializeField] float speed = 5f;
        private Rigidbody rb;
        private float time;
    
        void Start()
        {
            rb = this.gameObject.GetComponent<Rigidbody>();
            rb.linearVelocity = Vector3.forward * speed; //5 meters per sec
        }

        void Update()
        {
            time += Time.deltaTime;
            if (time >= timer)
            {
                time = 0f;
                speed *= -1;
                rb.linearVelocity = Vector3.forward * speed;
            }
        }
    }
}