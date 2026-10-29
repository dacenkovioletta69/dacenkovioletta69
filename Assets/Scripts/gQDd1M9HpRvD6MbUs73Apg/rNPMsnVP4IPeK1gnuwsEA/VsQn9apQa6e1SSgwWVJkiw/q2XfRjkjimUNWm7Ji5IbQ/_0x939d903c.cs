using TMPro;
using UnityEngine;
using static _0x4fc558d7;

public class _0x939d903c : MonoBehaviour
{
    public void _0x4e103074()
    {
        this.MoneyCountText.text = _0x566e4cde._0xd0203e80.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xaaf0690d;
            if (this.gameObject.TryGetComponent(out _0xaaf0690d))
                this.MoneyCountText = _0xaaf0690d;
        }

        this._0x4e103074();
    }
}