using UnityEngine;

namespace SmallGame.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 1;

        public void Move(Vector3 direction)
        {
            transform.Translate(direction * speed);
        }
    }
}
