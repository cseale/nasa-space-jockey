using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createSat : MonoBehaviour {

	public Transform prefab;

	/*private float nextActionTime = 0.0f;
	public float period = 100000f;*/

	void Start () {

        //GameObject foo = GameObject.Instantiate((GameObject)Resources.Load("prefabName"));

        //Transform t = Resources.Load("SeaStarComposite.3ds") as Transform;
        var az = Random.Range(-20f, 30.0f);
        var loc = Random.Range(-20f, 0.0f);

        var sat = createNewSat(az, loc, prefab);

		//createNewSat (Random.Range (-20f, 30.0f), Random.Range (-20f, 0.0f), prefab);
		//createNewSat (Random.Range (-20f, 30.0f), Random.Range (-20f, 0.0f), prefab);
		//createNewSat (Random.Range (-20f, 30.0f), Random.Range (-20f, 0.0f), prefab);

	}
	// Update is called once per frame
	void Update () {

		/*if (Time.time > nextActionTime ) {
			nextActionTime += period;
			createNewSat (Random.Range (-20f, 30.0f), Random.Range (-20f, 0.0f), prefab);
		}*/

	}

	public GameObject createNewSat(float azimuth, float elevation, Transform t){

		Vector3 vec = new Vector3 (azimuth, elevation, 15);//Fixed Z
		GameObject satellite = Instantiate (t, vec, Quaternion.identity).gameObject;
		satellite.SetActive (true);
        return satellite;
	}

}
