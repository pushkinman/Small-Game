using UnityEngine;

namespace SmallGame.Enemies
{
    public class Enemy : MonoBehaviour
    {
        public void TakeDamage(int damage)
        {
            Debug.Log($"Enemy shoot with {damage} damage");
        }
    }
}
