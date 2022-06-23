using System;
using UnityEngine;

namespace Andi_Scripts.SplashScreen
{
    public class Rotation : MonoBehaviour
    {
        [SerializeField] private float rotationSpeed;
        [SerializeField] private GameObject pivot;

        private void Update()
        {
            transform.RotateAround(pivot.transform.position, new Vector3(0,0,1), rotationSpeed * Time.deltaTime);
        }
    }
}