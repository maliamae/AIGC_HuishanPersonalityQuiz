using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SlideButton : MonoBehaviour
{
    public Image buttonBorder;
    public float distanceActive = 100;
    public float distanceInactive = -100;
    public float duration = .5f;

    public float scaleIncrease = 1.05f;
    public float originalScale = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SlideActive()
    {
        //Debug.Log("sliiiiiiiiiiide to the left");
        buttonBorder.transform.DOMoveX(distanceActive, duration, true);

        //this.transform.position = new Vector2(500f, 0f);
        //var tweener = this.transform.DOAnchorPosX(-500f, 1f);

    }

    public void SlideInactive()
    {
        buttonBorder.transform.DOMoveX(distanceInactive, duration, true);
    }

    public void SlideYActive()
    {
        //Debug.Log("sliiiiiiiiiiide to the left");
        buttonBorder.transform.DOMoveY(distanceActive, duration, true);

        //this.transform.position = new Vector2(500f, 0f);
        //var tweener = this.transform.DOAnchorPosX(-500f, 1f);

    }

    public void SlideYInactive()
    {
        buttonBorder.transform.DOMoveY(distanceInactive, duration, true);
    }

    public void ImageEnlarge()
    {
        buttonBorder.transform.DOScale(scaleIncrease, duration);
    }

    public void ImageSizeReset()
    {
        buttonBorder.transform.DOScale(originalScale, duration);
    }
}
