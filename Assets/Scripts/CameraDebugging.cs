using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraDebugging : MonoBehaviour
{

    public TMP_Text cameraPositionText;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPositionText.text = camera.transform.localPosition.y.ToString();
    }
}
