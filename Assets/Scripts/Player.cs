using UnityEngine;

namespace FlappyBird
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float gravity;
        [SerializeField] private float jump;

        private float velocity = 0f;

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                velocity = jump;
            }

            transform.position += Vector3.up * velocity * Time.deltaTime;
            velocity += gravity * Time.deltaTime;

            if (transform.position.y < 0f)
            {
                transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
            }
        }
    }
}