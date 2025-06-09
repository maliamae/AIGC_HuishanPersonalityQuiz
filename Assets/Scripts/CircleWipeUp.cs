using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CircleWipeUp : SceneTransition
{
    public Image circleUp;

    public override IEnumerator AnimateTransitionIn()
    {
        circleUp.rectTransform.anchoredPosition = new Vector2(0f, -1000f);
        var tweener = circleUp.rectTransform.DOAnchorPosY(250f, 1f);
        yield return tweener.WaitForCompletion();

    }

    public override IEnumerator AnimateTransitionOut()
    {
        var tweener = circleUp.rectTransform.DOAnchorPosY(1000f, 1f);
        yield return tweener.WaitForCompletion();
    }
}