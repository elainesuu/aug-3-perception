using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelPositions : MonoBehaviour
{

    public Transform point_wheel_left_front;
    public Transform point_wheel_right_front;
    public Transform point_wheel_left_back;
    public Transform point_wheel_right_back;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 screenPos_wlf = cam.WorldToScreenPoint(point_wheel_left_front.position);
        Vector3 screenPos_wrf = cam.WorldToScreenPoint(point_wheel_right_front.position);
        Vector3 screenPos_wlb = cam.WorldToScreenPoint(point_wheel_left_back.position);
        Vector3 screenPos_wrb = cam.WorldToScreenPoint(point_wheel_right_back.position);

        Debug.Log("screenPos_lfw is " + screenPos_wlf.x + " pixels from the left");
        Debug.Log("screenPos_rfw is " + screenPos_wrf.x + " pixels from the left");
        Debug.Log("screenPos_lbw is " + screenPos_wlb.x + " pixels from the left");
        Debug.Log("screenPos_rbw is " + screenPos_wrb.x + " pixels from the left");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
