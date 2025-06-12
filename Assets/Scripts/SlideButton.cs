using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SlideButton : MonoBehaviour
{
    public Image buttonBorder;
    public float xDistanceActive = 100;
    public float xDistanceInactive = -100;
    public float duration = .5f;

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
        Debug.Log("sliiiiiiiiiiide to the left");
        buttonBorder.transform.DOMoveX(xDistanceActive, duration, true);

        //this.transform.position = new Vector2(500f, 0f);
        //var tweener = this.transform.DOAnchorPosX(-500f, 1f);

    }

    public void SlideInactive()
    {
        buttonBorder.transform.DOMoveX(xDistanceInactive, duration, true);
    }
}
