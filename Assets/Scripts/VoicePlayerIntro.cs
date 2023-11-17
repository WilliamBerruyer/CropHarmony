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
        
        //audiosource.Play();
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
                tree.transform.position = new Vector3(130.1517f, 9.1f, 120.2001f);
                Debug.Log("Tree height set to 9.1");
            } else if (eyes.gameObject.transform.localPosition.y < 1.75f && eyes.gameObject.transform.localPosition.y > 1.65f)
            {
                tree.transform.position = new Vector3(130.1517f, 9f, 120.2001f);
                Debug.Log("Tree height set to 9");
            }
            else if (eyes.gameObject.transform.localPosition.y < 1.65f && eyes.gameObject.transform.localPosition.y > 1.55f)
            {
                tree.transform.position = new Vector3(130.1517f, 8.9f, 120.2001f);
                Debug.Log("Tree height set to 8.9");
            }
            else if (eyes.gameObject.transform.localPosition.y < 1.55f && eyes.gameObject.transform.localPosition.y > 1.45f)
            {
                tree.transform.position = new Vector3(130.1517f, 8.8f, 120.2001f);
                Debug.Log("Tree height set to 8.8");
            }
            else if (eyes.gameObject.transform.localPosition.y < 1.55f)
            {
                tree.transform.position = new Vector3(130.1517f, 8.7f, 120.2001f);
                Debug.Log("Tree height set to 8.7");
            }
        }
            

    }
}
