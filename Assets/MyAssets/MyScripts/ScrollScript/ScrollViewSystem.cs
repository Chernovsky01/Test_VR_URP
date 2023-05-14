using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewSystem : MonoBehaviour
{
    private ScrollRect scrollRect;

    [SerializeField] private ScrollArrow bottomArrow;

    [SerializeField] public float scrollSpeed = 0.01f;

    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    void Update()
    {
        if (bottomArrow != null)
        {
            if (bottomArrow.isDown)
            {
                ScrollDown();
            }
        }
    }

    private void ScrollDown()
    {
        if (scrollRect != null)
        {
            if (scrollRect.verticalNormalizedPosition >= 0)
            {
                scrollRect.verticalNormalizedPosition -= scrollSpeed;
            }
        }
    }
}
