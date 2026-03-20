using System;
using UnityEngine;

namespace TutorialInfo
{
    public class Push_Cylinder : MonoBehaviour
    {
        private Rigidbody rb;
        [SerializeField] float speed;

        void Start()
        {
            rb = this.gameObject.GetComponent<Rigidbody>();
        }

        void Update()
        {
            if (rb.angularVelocity.magnitude < 300)
            {
                rb.AddTorque(Vector3.up * (speed * Time.deltaTime * 50));
            }
            
        }
    }
}