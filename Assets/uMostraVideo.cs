using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.EventSystems;
using System.Windows;
using UnityEngine.UI;


public class uMostraVideo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public VideoPlayer wVid;
    public GameObject wRaw;
    public VideoClip wVideo;
    // Start is called before the first frame update
    void Start()
    {
        wRaw.SetActive(false);

    }
    private void pSetVideo()
    {
        wVid.Prepare();
        wVid.clip = wVideo;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            pSetVideo();
            wRaw.SetActive(true);
            wVid.Play();
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        wVid.Stop();
        wRaw.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
