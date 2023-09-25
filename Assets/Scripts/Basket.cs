using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private int appleCounter = 0;
    public TMP_Text counterNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Apple"))
        {
            Debug.Log("Entered");
            appleCounter++;
            counterNumber.text = appleCounter.ToString();
        }
        
    }
}
