using UnityEngine;
using UnityEngine.UI;

public class _0x0ac7d6d8 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    public bool IsShowLastPop;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xdc687a8e.Instance._0xbb1af79f();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xdc687a8e.Instance._0x19fb78e1());
        else
            this.Button.onClick.AddListener(() => _0xdc687a8e.Instance._0x9d1b4ae2(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    public bool IsHideAllPops;
}