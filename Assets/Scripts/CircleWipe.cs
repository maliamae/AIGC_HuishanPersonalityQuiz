using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CircleWipe : SceneTransition 
{
    public Image circle;

    public override IEnumerator AnimateTransitionIn()
    {
        circle.rectTransform.anchoredPosition = new Vector2(-1000f, 0f);
        var tweener = circle.rectTransform.DOAnchorPosX(250f, 1f);
        yield return tweener.WaitForCompletion();

    }

    public override IEnumerator AnimateTransitionOut()
    {
        var tweener = circle.rectTransform.DOAnchorPosX(1000f, 1f);
        yield return tweener.WaitForCompletion();
    }
}
