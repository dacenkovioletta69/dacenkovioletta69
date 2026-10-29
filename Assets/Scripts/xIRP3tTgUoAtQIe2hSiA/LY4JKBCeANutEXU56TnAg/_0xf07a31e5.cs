using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xf07a31e5 : MonoBehaviour
{
    private static void SafeAreaChanged()
    {
        _0xd4de082f = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static void ResolutionChanged()
    {
        _0x633beef1.x = Screen.width;
        _0x633beef1.y = Screen.height;
        _0xd4de082f = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x9f2be407.Invoke();
    }

    private Vector2 _0xc6d2d959;
    private static UnityEvent _0x9f2be407 = new();
    private Canvas _0x648f5e97;
    private RectTransform _0xcfb2f159;
    private void Awake()
    {
        if (!_0xc122dfb0.Contains(this))
            _0xc122dfb0.Add(this);
        this._0x648f5e97 = this.GetComponent<Canvas>();
        this._0xd1a517f9 = this.GetComponent<CanvasScaler>();
        if (this._0xd1a517f9 != null)
            this._0xc6d2d959 = this._0xd1a517f9.referenceResolution;
        this._0xcfb2f159 = this.GetComponent<RectTransform>();
        this._0x28ebf1cc = this.transform.Find(_0x8f538677._0x5b91bb6e(new byte[8] { 250, 200, 207, 204, 232, 219, 204, 200 }, 169)) as RectTransform;
        if (!_0xc16da8aa)
        {
            _0x5666fb93 = Screen.orientation;
            _0x633beef1.x = Screen.width;
            _0x633beef1.y = Screen.height;
            _0xd4de082f = Screen.safeArea;
            _0xc16da8aa = true;
        }

        this._0xd9298333();
    }

    private static Rect _0xd4de082f = Rect.zero;
    private RectTransform _0x28ebf1cc;
    private static bool _0xc16da8aa;
    private static void OrientationChanged()
    {
        _0x5666fb93 = Screen.orientation;
        _0x633beef1.x = Screen.width;
        _0x633beef1.y = Screen.height;
        _0xd4de082f = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x9f2be407.Invoke();
    }

    private static readonly List<_0xf07a31e5> _0xc122dfb0 = new();
    private static Vector2 _0x633beef1 = Vector2.zero;
    private void Start()
    {
    }

    private void Update()
    {
        if (_0xc122dfb0.Count == 0 || _0xc122dfb0[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x5666fb93)
            OrientationChanged();
        if (Screen.safeArea != _0xd4de082f)
            SafeAreaChanged();
        if (Screen.width != _0x633beef1.x || Screen.height != _0x633beef1.y)
            ResolutionChanged();
    }

    private void _0xd9298333()
    {
        if (this._0x28ebf1cc == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xe795e72a = Screen.safeArea;
        Vector2 _0xf355e2ea = _0xe795e72a.position;
        Vector2 _0xb659cd65 = _0xe795e72a.position + _0xe795e72a.size;
        _0xf355e2ea.x /= screenWidth;
        _0xf355e2ea.y /= screenHeight;
        _0xb659cd65.x /= screenWidth;
        _0xb659cd65.y /= screenHeight;
        this._0x28ebf1cc.anchorMin = _0xf355e2ea;
        this._0x28ebf1cc.anchorMax = _0xb659cd65;
        this._0x28ebf1cc.offsetMin = Vector2.zero;
        this._0x28ebf1cc.offsetMax = Vector2.zero;
        if (this._0xd1a517f9 == null)
            return;
        Vector2 _0xdb3bdf54 = _0xb659cd65 - _0xf355e2ea;
        float _0x195b48f1 = 2f - _0xdb3bdf54.x;
        float _0x72428f28 = 2f - _0xdb3bdf54.y;
        this._0xd1a517f9.referenceResolution = this._0xc6d2d959 * new Vector2(_0x195b48f1, _0x72428f28);
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0xdc5e82f8 = 0; _0xdc5e82f8 < _0xc122dfb0.Count; _0xdc5e82f8++)
            _0xc122dfb0[_0xdc5e82f8]._0xd9298333();
    }

    private static ScreenOrientation _0x5666fb93 = ScreenOrientation.LandscapeLeft;
    private CanvasScaler _0xd1a517f9;
    private void OnDestroy()
    {
        if (_0xc122dfb0 != null && _0xc122dfb0.Contains(this))
            _0xc122dfb0.Remove(this);
    }
}

internal static class _0x8f538677
{
    internal static string _0x5b91bb6e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}