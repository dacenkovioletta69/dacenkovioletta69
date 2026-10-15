using UnityEngine;
using UnityEngine.UI;

public class _0x95e3c891 : MonoBehaviour
{
    private void Awake()
    {
        if (this._0xfed54e1f == null)
            if (!this.TryGetComponent(out this._0xfed54e1f))
                this._0xfed54e1f = this.GetComponentInChildren<Button>();
    }

    private int _0x3b00d677;
    private void Start()
    {
        if (this._0x6274a438)
            this._0xfed54e1f.onClick.AddListener(() => _0x868e2cfd.Instance._0x166a3fb7());
        else
            this._0xfed54e1f.onClick.AddListener(() => _0x868e2cfd.Instance._0x168cb9c2(this._0x3b00d677));
    }

    private Button _0xfed54e1f;
    private bool _0x6274a438;
}