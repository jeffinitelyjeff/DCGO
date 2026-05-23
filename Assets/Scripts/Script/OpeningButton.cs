using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningButton : MonoBehaviour
{
    [Header("Button Animator")]
    public Animator ButtonAnimator;

    [Header("選択表示オブジェクト")]
    public GameObject selectedObject;
    public void OnSelect()
    {
        if (selectedObject != null)
        {
            selectedObject.SetActive(true);

            ContinuousController.instance.PlaySE(Opening.instance.TitleButtonSE);
        }
    }

    public void OnExit()
    {
        if (selectedObject != null)
        {
            selectedObject.SetActive(false);
        }
    }

    public void OnClick()
    {
        if (ButtonAnimator != null)
        {
            ButtonAnimator.SetTrigger("Click");
        }

        Opening.instance.CreateOnClickEffect();
        ContinuousController.instance.PlaySE(Opening.instance.DecisionSE);
    }
}
