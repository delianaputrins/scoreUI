using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOutController : MonoBehaviour
{
        public Collider bola;
        public kameraController kameraController;

        private void OnTriggerEnter(Collider other)
        {
            if (other == bola)
            {
                kameraController.GoBackToDefault();
            }
        }
}
