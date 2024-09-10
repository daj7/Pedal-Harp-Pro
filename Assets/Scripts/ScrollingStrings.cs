using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingStrings : MonoBehaviour
{
    private RectTransform rt;
    public float scrollSpeed = 800f;
    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Scroll (float scrollPos)
    {
        rt.anchoredPosition = new Vector2((scrollPos - 0.5f) * -1f * scrollSpeed, rt.anchoredPosition.y);
    }
}
