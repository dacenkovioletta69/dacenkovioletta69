using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xe551054e : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe551054e>();
    }

    private static bool _0x45234747 = false;
    public GameObject Error;
    public void _0xf98b8b96()
    {
        this._0x8736c5b2?.Play();
    }

    public void _0x40691c81()
    {
        this._0x8736c5b2?.Pause();
    }

    public GameObject Background;
    public float DefaultAnimationTime = 0.4f;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x4fc558d7._0xf3e0f416.SCENE_0 && !_0x45234747)
        {
            this._0x333a5444();
        }
        else
        {
            this._0x2183b1c2();
        }
    }

    public void _0x2ce55f1d()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x8736c5b2?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x45234747 = false;
    }

    public void _0x88f0ed84()
    {
        this._0x8736c5b2?.Kill();
        this.AnimationSlider.value = _0x45234747 ? this.SecondPassSliderValue : 0.05f;
    }

    public Slider AnimationSlider;
    private void _0x333a5444()
    {
        this.AnimationSlider.value = 0.05f;
        _0x45234747 = !_0x45234747;
        this._0x8736c5b2 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x7e3da817 => this.AnimationSlider.value = _0x7e3da817, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x81086c60._0xe57755da?._0x151f6d80();
        });
    }

    public static _0xe551054e Instance;
    private Sequence _0x8736c5b2;
    public float SecondPassSliderValue = 0.5f;
    public void _0x2183b1c2()
    {
        this._0x88f0ed84();
        bool _0xe4ad53d5 = _0x45234747;
        this._0x8736c5b2 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x7e3da817 => this.AnimationSlider.value = _0x7e3da817, _0xe4ad53d5 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x45234747 = !_0x45234747;
    }

    public float FirstAnimationTime = 10.0f;
    public GameObject Content;
}