using UnityEngine;

namespace Ass19
{
    public class KinataicBall : MonoBehaviour
    {
        public float amplitude = 2f;
        public float delaySpeed = 1f;
        public float speed = 2f;
        private Vector3 waveDirection = Vector3.up;
        private Vector3 initialPosition;
        
        void Start()
        {
            initialPosition = transform.position;
        }

        void Update()
        {
            float waveOffset = Mathf.Sin(delaySpeed * Time.time) * amplitude;
            Vector3 waveMotion = waveDirection * waveOffset * speed;
            transform.position = initialPosition + waveMotion;
        }
    }
}
