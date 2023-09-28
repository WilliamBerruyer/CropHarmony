using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePlayerIntro : MonoBehaviour
{

    public GameObject obj;
    public AudioSource audiosource;
    public GameObject camera;
    public GameObject tree;
    public GameObject eyes;

    // Start is called before the first frame update
    void Start()
    {
        
        audiosource.Play();
        StartCoroutine(WaitForSound());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator WaitForSound()
    {
        yield return new WaitUntil(() => audiosource.isPlaying == false);
        // or yield return new WaitWhile(() => audiosource.isPlaying == true);
        if (obj != null)
        {
            obj.SetActive(true);
            if(eyes.gameObject.transform.localPosition.y > 1.75f)
            {
                tree.transform.position = new Vector3(-112.614f, 2.40f, -14.835f);
                Debug.Log("Tree height set to 2.50");
            } else if (eyes.gameObject.transform.localPosition.y < 1.75f && eyes.gameObject.transform.localPosition.y > 1.65f)
            {
                tree.transform.position = new Vector3(-112.614f, 2.30f, -14.835f);
                Debug.Log("Tree height set to 2.40");
            }
            else if (eyes.gameObject.transform.localPosition.y < 1.65f && eyes.gameObject.transform.localPosition.y > 1.55f)
            {
                tree.transform.position = new Vector3(-112.614f, 2.20f, -14.835f);
                Debug.Log("Tree height set to 2.30");
            }
            else if (eyes.gameObject.transform.localPosition.y < 1.55f && eyes.gameObject.transform.localPosition.y > 1.45f)
            {
                tree.transform.position = new Vector3(-112.614f, 2.10f, -14.835f);
                Debug.Log("Tree height set to 2.20");
            }
            else if (eyes.gameObject.transform.localPosition.y < 1.55f)
            {
                tree.transform.position = new Vector3(-112.614f, 2f, -14.835f);
                Debug.Log("Tree height set to 2");
            }
        }
            

    }
}
