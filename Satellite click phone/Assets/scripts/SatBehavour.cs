using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SatBehavour : MonoBehaviour {
    float rotationSpeed = 5.0f; //degrees per second
    string loc = "?=0,0";
    public GameObject satellite;

	// Use this for initialization
	void Start () {
        Input.location.Start();
        //   GameObject sat = 
        //Some stuff here that is not important for this......

        //   Button myButton = sat.GetComponentInChildren<Button>();
        //    Button myButton;
        //  myButton = this.GetComponentInChildren<Button>(); // <-- you get access to the button component here
        //myButton.onClick.AddListener(myFunctionForOnClickEvent);
        //() => { myFunctionForOnClickEvent(); });

    }
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(Vector3.zero);

        satellite.transform.Rotate(new Vector3(
           1f * rotationSpeed * Time.deltaTime,
               1f * rotationSpeed * Time.deltaTime,
               0 * rotationSpeed * Time.deltaTime));

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            
            if (hit)
            {
                Debug.Log(hitInfo.transform.gameObject.tag + " clicked");
                if (hitInfo.transform.gameObject.tag == "SeaStar")
                {
                    Debug.Log("It's working!");
                    loc = "?=" + Input.location.lastData.latitude + "," + Input.location.lastData.longitude;
                    Debug.Log(loc);

                    Application.OpenURL("https://space-cowboys-sat-view.glitch.me/" + loc);
                }
                else
                {
                    Debug.Log("nopz");
                }
            }
            else
            {
                Debug.Log("No hit");
            }
            Debug.Log("Mouse is down");
        }
    }

}
