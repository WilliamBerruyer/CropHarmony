using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePlayerIntro : MonoBehaviour
{

    public GameObject obj;
    public AudioSource audiosource;

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
            obj.SetActive(true);
    }
}
