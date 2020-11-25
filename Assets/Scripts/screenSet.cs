using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_STANDALONE
        Screen.SetResolution(1080, 1920,false);

#endif
        //transform.GetChild(0).GetComponent<Image>().
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
