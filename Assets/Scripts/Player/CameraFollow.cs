using UnityEngine;

namespace SmallGame.Player
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform objectToFollow { private get; set; }
        
        private Vector3 offSet;
    
        void Start()
        {
            offSet = transform.position - objectToFollow.position;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = objectToFollow.position + offSet;
        }
    }
}
