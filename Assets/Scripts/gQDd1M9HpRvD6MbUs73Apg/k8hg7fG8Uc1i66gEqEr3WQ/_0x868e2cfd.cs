using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x4fc558d7;

public class _0x868e2cfd : MonoBehaviour
{
    private void _0x90dd622e(int _0x7333acc0)
    {
        this.LastPanelIndexes.Add(_0x7333acc0);
        this.CurrentPanelIndex = _0x7333acc0;
        for (int _0x27037a82 = 0; _0x27037a82 < this.Panels.Count; _0x27037a82++)
            if (_0x27037a82 != _0x7333acc0 && this.Panels[_0x27037a82] != null)
                this.Panels[_0x27037a82]._0x48b9c562();
    }

    private void SwitchSplash()
    {
        if (_0x5a326faa.Instance.IsTutorialEnabled && !_0x697b0043._0x11c5e97a._0xf2fbedf8)
            this._0x168cb9c2(_0xb679ca6b.TUTORIAL0);
        else
            this._0x168cb9c2(_0xb679ca6b.DEFAULT);
    }

    public float StaticBlurMaterialInitialValue;
    private void _0x0b1667bc(int _0x42f06cd8)
    {
        this._0x90dd622e(_0x42f06cd8);
        this._0xa4f5517e(_0x42f06cd8);
        this.CurrentPanelIndex = _0x42f06cd8;
        this.Panels[_0x42f06cd8]._0x31e7a6f7();
    }

    public static _0x868e2cfd Instance;
    public List<_0x39e04600> Panels;
    public void _0xac0772e3(int _0xd621c7df)
    {
        if (_0xd621c7df == _0xb679ca6b.SPLASH && _0x697b0043.Instance._0x72fb3c34 != _0xf3e0f416.SCENE_0)
            _0xe551054e.Instance._0x2183b1c2();
        if (_0x697b0043.Instance._0x72fb3c34 != _0xf3e0f416.SCENE_0)
        {
            if (_0xd621c7df == _0xb679ca6b.SPLASH || _0xd621c7df == _0xb679ca6b.TUTORIAL0)
                _0x697b0043.Instance._0x08427db9(false);
            else if (_0xd621c7df == _0xb679ca6b.DEFAULT)
                _0x697b0043.Instance._0x08427db9(true);
        }
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0xa4f5517e(int _0xf775820d)
    {
        if (_0xf775820d == _0xb679ca6b.SPLASH)
            _0xe551054e.Instance._0x88f0ed84();
        if (_0x697b0043.Instance._0x72fb3c34 == _0xf3e0f416.SCENE_0)
        {
        }
    }

    public float ScaleDuration = 0.4f;
    public void _0x166a3fb7()
    {
        this.LastPanelIndexes.RemoveAll(_0x0bb4f0e2 => _0x0bb4f0e2 == this.CurrentPanelIndex);
        int _0x3ae62c54 = this.LastPanelIndexes.Last();
        this._0xa4f5517e(_0x3ae62c54);
        this._0x5e36c2da(_0x3ae62c54);
        this.CurrentPanelIndex = _0x3ae62c54;
        this.Panels[_0x3ae62c54].Show();
    }

    private void _0x5e36c2da(int _0x78dfff0c)
    {
        this.LastPanelIndexes.Add(_0x78dfff0c);
        this.CurrentPanelIndex = _0x78dfff0c;
        for (int _0xf798ec6c = 0; _0xf798ec6c < this.Panels.Count; _0xf798ec6c++)
            if (_0xf798ec6c != _0x78dfff0c && this.Panels[_0xf798ec6c] != null)
                this.Panels[_0xf798ec6c]._0x48b9c562();
    }

    public bool IsShowSplashOnStart = true;
    public int CurrentPanelIndex;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x868e2cfd>();
    }

    private void Start()
    {
        this._0x888e9b80();
    }

    private void _0x888e9b80()
    {
        this._0x0b1667bc(_0xb679ca6b.SPLASH);
        if (_0x697b0043.Instance._0x72fb3c34 == _0xf3e0f416.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xe551054e.Instance.DefaultAnimationTime);
        }
    }

    private _0x39e04600 _0x4522466d(int _0xb8d0ee5a)
    {
        return this.Panels[_0xb8d0ee5a];
    }

    public void _0x168cb9c2(int _0x1066eadf)
    {
        this._0x90dd622e(_0x1066eadf);
        this._0xa4f5517e(_0x1066eadf);
        this.CurrentPanelIndex = _0x1066eadf;
        this.Panels[_0x1066eadf].Show();
    }
}