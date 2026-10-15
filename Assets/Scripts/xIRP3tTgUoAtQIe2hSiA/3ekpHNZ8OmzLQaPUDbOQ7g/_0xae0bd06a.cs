using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xae0bd06a : MonoBehaviour
{
    private float _0x98779727 = 1.5f;
    private List<string> _0x3c95c74c = new();
    private float _0x24d7df8b = 0.6f;
    private AspectRatioFitter _0xf930b894;
    private float _0xd735364e = 4;
    private TMP_Text _0xacb62d3d;
    private float _0x9387281f;
    private void Update()
    {
        int _0x8ade7b0e = 1;
        if (this._0x3c95c74c.Count > 0)
        {
            string _0x0dc33e79 = this._0xacb62d3d.text;
            foreach (string _0x346b3168 in this._0x3c95c74c)
                while (_0x0dc33e79.Contains(_0x346b3168))
                    _0x0dc33e79 = _0x0dc33e79.Replace(_0x346b3168, "");
            _0x8ade7b0e = _0x0dc33e79.Length;
        }
        else
        {
            _0x8ade7b0e = this._0xacb62d3d.text.Length;
        }

        float _0x46a01dc0 = Mathf.Clamp(this._0x9387281f + this._0x24d7df8b * _0x8ade7b0e, this._0x98779727, this._0xd735364e);
        if (!Mathf.Approximately(this._0xf930b894.aspectRatio, _0x46a01dc0))
            this._0xf930b894.aspectRatio = _0x46a01dc0;
    }
}