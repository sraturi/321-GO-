using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
   [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
		
		private CarController m_Car; // the car controller we want to use

		//public virtual 
        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

		private float time = 0;
        private void FixedUpdate ()
		{
			time += Time.deltaTime;
			if (time > 3) {
				// pass the input to the car!
				float h = CrossPlatformInputManager.GetAxis ("Horizontal");
				float v = CrossPlatformInputManager.GetAxis ("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
				m_Car.Move (h, v, v, 0f);
#endif
			}

		}

	}
}
