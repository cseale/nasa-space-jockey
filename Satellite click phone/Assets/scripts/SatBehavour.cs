using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SatBehavour : MonoBehaviour {
    float rotationSpeed = 5.0f; //degrees per second
    string loc = "?=0,0";

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
        transform.Rotate(new Vector3(
           0 * rotationSpeed * Time.deltaTime,
               1f * rotationSpeed * Time.deltaTime,
               1f * rotationSpeed * Time.deltaTime));
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

    IEnumerator CheckLoc()
    {
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield break;

        // Start service before querying location
        Input.location.Start();

        // Wait until service initializes
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            yield break;
        }
        else
        {
            // Access granted and location value could be retrieved
            Debug.Log("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
        }

        // Stop service if there is no need to query location updates continuously
        Input.location.Stop();
    }

}
