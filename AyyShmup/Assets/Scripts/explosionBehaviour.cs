using UnityEngine;
using System.Collections;

public class explosionBehaviour : MonoBehaviour {
	void Start() {
		Animator a = gameObject.GetComponent<Animator>();
		AnimatorClipInfo[] aci = a.GetCurrentAnimatorClipInfo (0);
		Destroy (gameObject, aci[0].clip.length);
	}
}
