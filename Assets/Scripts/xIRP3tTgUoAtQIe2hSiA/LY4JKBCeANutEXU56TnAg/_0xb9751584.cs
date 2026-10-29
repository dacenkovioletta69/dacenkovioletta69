using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xb9751584 : MonoBehaviour
{
    private static void SafeAreaChanged()
    {
        _0xf5af880f = Screen.safeArea;
        for (int _0x45faf5f8 = 0; _0x45faf5f8 < _0x7850e0d6.Count; _0x45faf5f8++)
            _0x7850e0d6[_0x45faf5f8]._0x4c1b3136();
    }

    private static readonly List<_0xb9751584> _0x7850e0d6 = new();
    private RectTransform _0x18842981;
    private void Awake()
    {
        if (!_0x7850e0d6.Contains(this))
            _0x7850e0d6.Add(this);
        this._0x148dfbc1 = this.GetComponent<Canvas>();
        this._0x18842981 = this.GetComponent<RectTransform>();
        this._0x565eaa10 = this.transform.Find(_0xdd2f535c._0x2430c8d6(new byte[8] { 217, 235, 236, 239, 203, 248, 239, 235 }, 138)) as RectTransform;
        if (!_0x5d8c2007)
        {
            _0x127d88cf = Screen.orientation;
            _0xb0b6cf2b.x = Screen.width;
            _0xb0b6cf2b.y = Screen.height;
            _0xf5af880f = Screen.safeArea;
            _0x5d8c2007 = true;
        }

        this._0x4c1b3136();
    }

    private void OnDestroy()
    {
        if (_0x7850e0d6 != null && _0x7850e0d6.Contains(this))
            _0x7850e0d6.Remove(this);
    }

    private RectTransform _0x565eaa10;
    private Canvas _0x148dfbc1;
    private static UnityEvent _0xf7c64b73 = new();
    private void _0x4c1b3136()
    {
        if (this._0x565eaa10 == null)
            return;
        Rect _0x09382047 = Screen.safeArea;
        Vector2 _0xe26fba8b = _0x09382047.position;
        Vector2 _0x22da451b = _0x09382047.position + _0x09382047.size;
        _0xe26fba8b.x /= this._0x148dfbc1.pixelRect.width;
        _0xe26fba8b.y /= this._0x148dfbc1.pixelRect.height;
        _0x22da451b.x /= this._0x148dfbc1.pixelRect.width;
        _0x22da451b.y /= this._0x148dfbc1.pixelRect.height;
        this._0x565eaa10.anchorMin = _0xe26fba8b;
        this._0x565eaa10.anchorMax = _0x22da451b;
    }

    private static void OrientationChanged()
    {
        _0x127d88cf = Screen.orientation;
        _0xb0b6cf2b.x = Screen.width;
        _0xb0b6cf2b.y = Screen.height;
        _0xf7c64b73.Invoke();
    }

    private static Rect _0xf5af880f = Rect.zero;
    private static ScreenOrientation _0x127d88cf = ScreenOrientation.LandscapeLeft;
    private static Vector2 _0xb0b6cf2b = Vector2.zero;
    private static void ResolutionChanged()
    {
        _0xb0b6cf2b.x = Screen.width;
        _0xb0b6cf2b.y = Screen.height;
        _0xf7c64b73.Invoke();
    }

    private void Update()
    {
        if (_0x7850e0d6[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x127d88cf)
            OrientationChanged();
        if (Screen.safeArea != _0xf5af880f)
            SafeAreaChanged();
        if (Screen.width != _0xb0b6cf2b.x || Screen.height != _0xb0b6cf2b.y)
            ResolutionChanged();
    }

    private static bool _0x5d8c2007;
}

internal static class _0xdd2f535c
{
    internal static string _0x2430c8d6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}