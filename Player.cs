using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ball
{
    public class Player : MonoBehaviour
    {
        private float Speed = 3.0f;
        private Rigidbody _rigidbody;

        public void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            _rigidbody.AddForce(movement * Speed);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("GoodBonus"))
            {
                StartCoroutine(SpeedTimer());
            }
        }

        private IEnumerator SpeedTimer()
        {
            Speed = 10f;
            yield return new WaitForSecondsRealtime(2f);
            Speed = 3f;
        }
    }
 
}
