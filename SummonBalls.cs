using UnityEngine;

namespace TutorialInfo
{
    public class SummonBalls : MonoBehaviour
    {
        [SerializeField] float timer;
        [SerializeField] private GameObject bolitaPrefab;
        void Start()
        {
            GameObject copy = Instantiate(bolitaPrefab, transform.position, Quaternion.identity);
            Destroy (copy, 3f);
        }
        
        void Update()
        {
            timer += Time.deltaTime;
            if (timer > 1f)
            {
                timer = 0f;
            }
        }
    }
}