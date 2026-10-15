using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x62964e65 : MonoBehaviour
{
    public TMP_Text ContentHeaderText;
    public bool IsScaledDownOnAwake = true;
    public GameObject Content;
    public Ease ease = Ease.OutSine;
    private void Start()
    {
    // Content.SetActive(false);
    }

    private bool _0x61da0cc7 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public float scaleDuration = 0.4f;
    public static void HideAllPops()
    {
        _0xdc687a8e.Instance._0x19fb78e1();
    }

    private void _0x81f73865()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public void _0xe66846cd()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public TMP_Text ContentAdditionalText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x81f73865();
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public Image ContentImage;
    public TMP_Text ContentMainText;
    public bool IsOnlyYScale;
}