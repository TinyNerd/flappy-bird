using UnityEngine;

namespace FlappyBird
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float gravity;
        [SerializeField] private float jump;

        private float velocity = 0f;

        private void FixedUpdate()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                velocity = jump;
            }

            transform.position += Vector3.up * velocity;
            velocity += gravity;

            if (transform.position.y < 0f)
            {
                transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
                velocity = 0f;
            }
        }
    }
}