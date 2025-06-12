using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CircleWipeDown : SceneTransition
{
    public Image circleDown;

    public override IEnumerator AnimateTransitionIn()
    {
        circleDown.rectTransform.anchoredPosition = new Vector2(0f, 1000f);
        var tweener = circleDown.rectTransform.DOAnchorPosY(-390f, 1f);
        yield return tweener.WaitForCompletion();

    }

    public override IEnumerator AnimateTransitionOut()
    {
        var tweener = circleDown.rectTransform.DOAnchorPosY(-1000f, 1f);
        yield return tweener.WaitForCompletion();
    }
}
