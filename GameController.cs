using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ball
{
    public class GameController : MonoBehaviour
    {
        private List<InteractiveObject> _interactiveObjects;

        private void Awake()
        {
            _interactiveObjects = new List<InteractiveObject>(FindObjectsOfType<InteractiveObject>());
        }

        private void Update()
        {
            foreach (var interactiveObject in _interactiveObjects)
            {
                if (interactiveObject == null)
                    continue;
                if (interactiveObject is IFly fly)
                    fly.Fly();
                if (interactiveObject is IFlicker flicker)
                    flicker.Flicker();
                if (interactiveObject is IRotation rotation)
                    rotation.Rotation();
            }
        }
    }
}