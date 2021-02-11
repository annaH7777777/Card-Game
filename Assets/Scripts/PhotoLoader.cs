using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class PhotoLoader : MonoBehaviour
{
    public string url = "https://picsum.photos/200/300?random=1";
    public Renderer thisRenderer;

    IEnumerator Start()
    {
        Debug.Log("Loading");
        WWW www = new WWW(url);
        yield return www;
        Debug.Log("Loaded");
        thisRenderer.material.mainTexture = www.texture;
    }
}
