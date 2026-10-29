using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x6447bdac : MonoBehaviour
{
    private void Update()
    {
        this._0x617306d6();
    }

    private Image _0x95d086cb;
    private void _0x617306d6()
    {
        if (this._0x95d086cb.canvasRenderer.GetColor() != this._0xc1206e2c.canvasRenderer.GetColor())
            this._0xc1206e2c.canvasRenderer.SetColor(this._0x95d086cb.canvasRenderer.GetColor());
    }

    private TMP_Text _0xc1206e2c;
}