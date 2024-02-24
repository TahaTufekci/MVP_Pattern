using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private float _horizontalSpeed = 3f;
        private float _forwardSpeed = 5f;
        private Vector3 _movementVector;
    
        private void Awake()
        {
            _movementVector = new Vector3();
        }

        void Update()
        {
            MovementInput();
            CalculateMovement();
            if (transform.position.y < -3f) SceneManager.LoadScene(0);
        }

        private void CalculateMovement()
        {
            Vector3 newPosition = new Vector3();
            newPosition.z += Time.deltaTime * _forwardSpeed;
            newPosition.x += Time.deltaTime * _horizontalSpeed * _movementVector.x;
            transform.position += newPosition;
        }

        private void MovementInput()
        {
            if (!Input.anyKey)
            {
                _movementVector = Vector3.zero;
                return;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                _movementVector = Vector3.left;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                _movementVector = Vector3.right;
            }

            _movementVector.Normalize();
        }
    }
}
