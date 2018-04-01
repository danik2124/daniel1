using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Networking;

public class PlayerSetup : NetworkBehaviour {

	[SerializeField]
	Behaviour[] c;
    [SerializeField]
    GameObject Camera1;

    void Start()
    {



        if (!isLocalPlayer)
        {
            foreach (Behaviour b in c)
            {
                b.enabled = false;
            }
            Camera1.GetComponent<Camera>().enabled = false;
        }
	}

	// When we are destroyed
	void Update ()
	{
 
	}

}
