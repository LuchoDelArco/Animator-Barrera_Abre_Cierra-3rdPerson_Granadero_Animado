using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreraABEScript : MonoBehaviour
{
	[SerializeField] Animator Anim;

	void OnTriggerEnter()
	{
		Anim.SetBool("ObjetoEnRango", true);
	}
	
	void OnTriggerExit()
	{
		Anim.SetBool("ObjetoEnRango", false);
	}
}
