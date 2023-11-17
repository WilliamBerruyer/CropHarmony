using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private int appleCounter = 0;
    private int boxCounter = 0;
    public TMP_Text counterNumber;

    public GameObject[] apples;
    public GameObject box1;
    public GameObject endDialog;
    public AudioSource audiosource;

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
            if(appleCounter == 17)
            {
                end();
            }

            Debug.Log("Entered");
            audiosource.Play();
            appleCounter++;
            boxCounter++;
            counterNumber.text = appleCounter.ToString();
            Destroy(collision.gameObject);
            if(boxCounter <= 9 && boxCounter > 0)
            {
                apples[boxCounter - 1].SetActive(true);

            }
            else if(boxCounter > 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    apples[i].SetActive(false);
                }
                box1.SetActive(true);
                boxCounter = 0;
            }
        }
    }

    private void end()
    {
        endDialog.SetActive(true);
        //play a sound
    }
}
