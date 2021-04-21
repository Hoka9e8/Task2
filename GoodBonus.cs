using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Ball
{
    public class GoodBonus : InteractiveObject, IFlicker, IFly
    {
        private float _lengthFly;
        private Material _material;

        private void Start()
        {
            _lengthFly = Random.Range(1.0f, 3.0f);
            _material = GetComponent<Renderer>().material;
        }

        protected override void Interaction()
        {
            
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthFly),
                transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }
    }
}