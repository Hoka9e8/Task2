using UnityEngine;

namespace Ball
{
    public class BadBonus : InteractiveObject, IRotation, IFly
    {
        private float _lengthFly;
        private  float _speedRotation;

        private void Start()
        {
            _lengthFly = Random.Range(1.0f, 3.0f);
            _speedRotation =  Random.Range(10.0f, 20.0f);
        }

        protected override void Interaction()
        {
            
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthFly),
                transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * _speedRotation * Time.deltaTime, Space.World);
        }
    }
}