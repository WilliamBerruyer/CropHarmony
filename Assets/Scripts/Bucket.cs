using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GridBrushBase;

public class Bucket : MonoBehaviour
{
    public GameObject bucket;
    public GameObject rope;

    private float oldAngle = 0;

    void Start()
    {
       
    }

    void Update()
    {

        float newAngle = GetObjectRotation();
        Debug.Log(newAngle);
        if (newAngle != oldAngle && bucket.transform.position.y < 8.246f && rope.transform.localScale.y > 0.04f)
        {
            
            bucket.transform.Translate(0, 0.01f, 0);
            float sc = rope.transform.localScale.y;
            float newValue = sc - 0.001f;
            rope.gameObject.transform.localScale -= new Vector3(0, 0.0028f, 0);
            oldAngle = newAngle;
        }
      

    }

    float GetObjectRotation()
    {
        if (transform.eulerAngles.x > 180)
        {
            return transform.eulerAngles.x - 360;
        }
        else
        {
            return transform.eulerAngles.x;
        }
    }
}
