using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;		

public class CollisionBehavior : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

}


