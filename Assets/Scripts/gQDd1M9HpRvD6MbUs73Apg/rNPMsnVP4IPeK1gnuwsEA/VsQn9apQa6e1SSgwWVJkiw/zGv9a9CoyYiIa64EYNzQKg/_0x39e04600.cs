using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x39e04600 : MonoBehaviour
{
    public Ease Ease = Ease.OutSine;
    private void _0x5f5aee1d()
    {
        if (this.OuterBackground != null)
        {
            Image _0x385881b8 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x385881b8, true);
            _0x385881b8.DOFade(1f, 0f);
        }
    }

    public void Show()
    {
        this._0xbb2c3241();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x868e2cfd.Instance._0xac0772e3(_0x868e2cfd.Instance.CurrentPanelIndex);
            });
        }
    }

    public TMP_Text HeaderText;
    public void _0x48b9c562()
    {
        this._0x18f184ba();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private bool _0x823b9801 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public GameObject Content;
    public GameObject OuterBackground;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x3d34762c();
    }

    public float ScaleDuration = 0.4f;
    public void _0x31e7a6f7()
    {
        this._0x5f5aee1d();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x868e2cfd.Instance._0xac0772e3(_0x868e2cfd.Instance.CurrentPanelIndex);
    }

    private void _0xbb2c3241()
    {
        if (this.OuterBackground != null)
        {
            Image _0x38ebf7f3 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x38ebf7f3, true);
            _0x38ebf7f3.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0x18f184ba()
    {
        if (this.OuterBackground != null)
        {
            Image _0xd6663fa7 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xd6663fa7, true);
            _0xd6663fa7.DOFade(0f, this.ScaleDuration);
        }
    }

    public TMP_Text MainText;
    public bool IsScaledDownOnAwake = true;
    private void _0x3d34762c()
    {
        if (this.OuterBackground != null)
        {
            Image _0x6d41274a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x6d41274a, true);
            _0x6d41274a.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }
}