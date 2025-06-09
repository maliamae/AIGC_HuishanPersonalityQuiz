using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CircleWipeLeft : SceneTransition
{
    public Image circleLeft;

    public override IEnumerator AnimateTransitionIn()
    {
        circleLeft.rectTransform.anchoredPosition = new Vector2(500f, 0f);
        var tweener = circleLeft.rectTransform.DOAnchorPosX(-500f, 1f);
        yield return tweener.WaitForCompletion();

    }

    public override IEnumerator AnimateTransitionOut()
    {
        var tweener = circleLeft.rectTransform.DOAnchorPosX(-1000f, 1f);
        yield return tweener.WaitForCompletion();
    }
}