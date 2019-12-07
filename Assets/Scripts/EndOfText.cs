using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfText : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        SceneManager.LoadScene("Natasha");
    }
<<<<<<< HEAD

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(Collider collider) 	{				   
	SceneManager.LoadScene(1);
	}
=======
>>>>>>> 8b2f7be3c4fb3e8a0b21f378217842e921a7f4da
}
