using System.Collections;
using UnityEngine;

public class FadeManager : MonoBehaviour
{
    public Animator animator;

    public void Fade()
    {
        StartCoroutine(FadeCoroutine());
    }

    private IEnumerator FadeCoroutine()
    {
        FadeOut();
        yield return new WaitForSeconds(3);
        FadeIn();
    }

    private void FadeOut()
    {
        animator.SetTrigger("FadeOut");
    }

    private void FadeIn()
    {
        animator.SetTrigger("FadeIn");
    }
}
