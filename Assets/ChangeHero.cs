using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeHero : MonoBehaviour
{
    private  Image Image;
    // Start is called before the first frame update
    void Start()
    {
        Image = GameObject.Find("Hero-01").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //替换英雄图片
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Image.sprite = Resources.Load("HeroPic/aaa", typeof(Sprite)) as Sprite;
        }

    }
}
