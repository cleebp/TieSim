//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssemblyCSharp
{
	public class monitor : MonoBehaviour
	{
		GameObject welcome;
		GameObject step1;
		GameObject step2;
		GameObject step3;
		GameObject step4;
		GameObject step5;
		GameObject step6;
		GameObject step7;
		GameObject step8;
		GameObject step9;

		void Start()
		{
			welcome = GameObject.Find ("welcome");
			step1 = GameObject.Find ("step1");
			step2 = GameObject.Find ("step2");
			step3 = GameObject.Find ("step3");
			step4 = GameObject.Find ("step4");
			step5 = GameObject.Find ("step5");
			step6 = GameObject.Find ("step6");
			step7 = GameObject.Find ("step7");
			step8 = GameObject.Find ("step8");
			step9 = GameObject.Find ("step9");
		
			disableAll();
			welcome.renderer.enabled = true;
		}

		void Update()
		{
			if (Input.GetKeyDown (KeyCode.F1)) {
				disableAll();
				step1.renderer.enabled = true;
			}
			if (Input.GetKeyDown (KeyCode.F2)) {
				disableAll();
				step2.renderer.enabled = true;
			}
			if (Input.GetKeyDown (KeyCode.F3)) {
				disableAll();
				step3.renderer.enabled = true;
			}
			if (Input.GetKeyDown (KeyCode.F4)) {
				disableAll();
				step4.renderer.enabled = true;
			}
			if (Input.GetKeyDown (KeyCode.F5)) {
				disableAll();
				step5.renderer.enabled = true;
			}
			if (Input.GetKeyDown (KeyCode.F6)) {
				disableAll();
				step6.renderer.enabled = true;
			}
			if (Input.GetKeyDown (KeyCode.F7)) {
				disableAll();
				step7.renderer.enabled = true;
			}
			if (Input.GetKeyDown (KeyCode.F8)) {
				disableAll();
				step8.renderer.enabled = true;
			}
			if (Input.GetKeyDown (KeyCode.F9)) {
				disableAll();
				step9.renderer.enabled = true;
			}
		}

		/// STUFF FOR WALLS
		private void disableAll()
		{
			welcome.renderer.enabled = false;
			step1.renderer.enabled = false;
			step2.renderer.enabled = false;
			step3.renderer.enabled = false;
			step4.renderer.enabled = false;
			step5.renderer.enabled = false;
			step6.renderer.enabled = false;
			step7.renderer.enabled = false;
			step8.renderer.enabled = false;
			step9.renderer.enabled = false;
		}
	}

}

