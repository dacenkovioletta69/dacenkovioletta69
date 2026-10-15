using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The UGUI factory every screen is drawn with. This game is 100% UGUI - not one
/// SpriteRenderer and not one world-space TMP - so draw order is purely sibling order and the
/// camera's orthographic size never enters a layout calculation.
///
/// Coordinates: callers work in PANEL units of the 1242 x 2688 reference canvas, measured from
/// the panel's bottom-left corner. Every node is anchored to that corner with a centred pivot,
/// so an anchoredPosition IS the element's centre and the numbers in the design document, in
/// the screenshot scenario and in this code all mean the same thing.
/// </summary>
public static class _0xcecf7be6
{
    /// <summary>
    /// A framed plate: accent ring behind, dark body in front. Two draws instead of a sprite
    /// with a baked frame, so the ring thickness is a number the layout controls and no
    /// generated PNG can arrive with an opaque middle over its own content (C.13).
    /// </summary>
    public static RectTransform Frame(Transform _0x4b1949b9, string _0xe9da8df3, Vector2 _0xf0682794, Vector2 _0x3558c2b7, Sprite _0x2a95f730, Color _0x98e6fbb1, Color _0x41a637b7, float _0xc7f8ee74, float _0x7017d4d2)
    {
        RectTransform _0x6f844ed2 = Node(_0x4b1949b9, _0xe9da8df3, _0xf0682794, _0x3558c2b7);
        Plate(_0x6f844ed2, _0x5a8224f7._0xee7ae724(new byte[4] { 252, 199, 192, 201 }, 174), new Vector2(_0x3558c2b7.x * 0.5f, _0x3558c2b7.y * 0.5f), _0x3558c2b7, _0x2a95f730, _0x98e6fbb1, _0xc7f8ee74);
        Plate(_0x6f844ed2, _0x5a8224f7._0xee7ae724(new byte[4] { 227, 206, 197, 216 }, 161), new Vector2(_0x3558c2b7.x * 0.5f, _0x3558c2b7.y * 0.5f), new Vector2(_0x3558c2b7.x - (_0x7017d4d2 * 2f), _0x3558c2b7.y - (_0x7017d4d2 * 2f)), _0x2a95f730, _0x41a637b7, Mathf.Max(2f, _0xc7f8ee74 - _0x7017d4d2));
        return _0x6f844ed2;
    }

    /// <summary>
    /// A label. Wrapping is OFF and auto-size is ON for every caption without exception,
    /// counters and timers included: the engine must never choose where a line ends, and a line
    /// that does not fit shrinks to fontSizeMin rather than being clipped. Line breaks come
    /// from explicit \n in the string. fontSizeMin is what really ships, so it never drops
    /// below the project floor (C.10, C.12).
    /// </summary>
    public static TextMeshProUGUI Label(Transform _0x2d653a5c, string _0x4b9b5517, Vector2 _0xd0091b86, Vector2 _0xae049c74, string _0x9914fb12, float _0x6c32ba52, float _0xf727f370, Color _0xfa5f3ae1, TMP_FontAsset _0xddc6d71c, TextAlignmentOptions _0x98ed104a)
    {
        GameObject _0x28fb39d0 = new GameObject(_0x4b9b5517, typeof(RectTransform), typeof(CanvasRenderer), typeof(TextMeshProUGUI));
        RectTransform _0xbaff0b85 = _0x28fb39d0.GetComponent<RectTransform>();
        _0xbaff0b85.SetParent(_0x2d653a5c, false);
        Anchor(_0xbaff0b85, _0xd0091b86, _0xae049c74);
        TextMeshProUGUI _0x8cd689d2 = _0x28fb39d0.GetComponent<TextMeshProUGUI>();
        if (_0xddc6d71c != null)
            _0x8cd689d2.font = _0xddc6d71c;
        _0x8cd689d2.text = _0x9914fb12;
        _0x8cd689d2.color = _0xfa5f3ae1;
        _0x8cd689d2.alignment = _0x98ed104a;
        _0x8cd689d2.textWrappingMode = TextWrappingModes.NoWrap;
        _0x8cd689d2.overflowMode = TextOverflowModes.Overflow;
        _0x8cd689d2.enableAutoSizing = true;
        _0x8cd689d2.fontSizeMin = Mathf.Max(MinFont, _0xf727f370);
        _0x8cd689d2.fontSizeMax = _0x6c32ba52;
        _0x8cd689d2.fontSize = _0x6c32ba52;
        _0x8cd689d2.raycastTarget = false;
        _0x77b5335c.ApplyOutline(_0x8cd689d2, _0xfa5f3ae1);
        return _0x8cd689d2;
    }

    /// <summary>Reference canvas height, from the template's CanvasScaler.</summary>
    public const float PanelHeight = 2688f;
    /// <summary>
    /// A transparent, raycastable plate. Unity drops the mesh of an alpha-0 graphic and a
    /// dropped mesh is never raycast against, so the alpha sits a hair above zero AND
    /// cullTransparentMesh is switched off - a hit layer that looks perfect and never fires is
    /// otherwise impossible to see.
    /// </summary>
    public static Image HitLayer(Transform _0xf071f288, string _0xf5755b7f)
    {
        GameObject _0xa64e1b58 = new GameObject(_0xf5755b7f, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        RectTransform _0xa2ffc7b3 = _0xa64e1b58.GetComponent<RectTransform>();
        _0xa2ffc7b3.SetParent(_0xf071f288, false);
        _0xa2ffc7b3.anchorMin = Vector2.zero;
        _0xa2ffc7b3.anchorMax = Vector2.one;
        _0xa2ffc7b3.offsetMin = Vector2.zero;
        _0xa2ffc7b3.offsetMax = Vector2.zero;
        _0xa2ffc7b3.localScale = Vector3.one;
        Image _0x376eb7a2 = _0xa64e1b58.GetComponent<Image>();
        _0x376eb7a2.color = new Color(1f, 1f, 1f, HitAlpha);
        _0x376eb7a2.raycastTarget = true;
        _0xa64e1b58.GetComponent<CanvasRenderer>().cullTransparentMesh = false;
        return _0x376eb7a2;
    }

    /// <summary>Resizes a meter fill built by <see cref = "Meter"/>; the track never moves.</summary>
    public static void SetMeter(Image _0x87774ccc, float _0xb0e16f69, float _0xf4672ebc)
    {
        if (_0x87774ccc == null)
            return;
        float width = Mathf.Clamp01(_0xf4672ebc) * _0xb0e16f69;
        RectTransform _0x866209de = _0x87774ccc.rectTransform;
        _0x866209de.sizeDelta = new Vector2(width, _0x866209de.sizeDelta.y);
        _0x866209de.anchoredPosition = new Vector2(width * 0.5f, _0x866209de.anchoredPosition.y);
    }

    /// <summary>Low enough to be invisible, high enough that UGUI still raycasts it.</summary>
    private const float HitAlpha = 0.004f;
    /// <summary>Horizontal centre of the panel, used by nearly every layout line.</summary>
    public const float MidX = 621f;
    /// <summary>The readability floor for this 1242-wide canvas: 24 * 1242 / 1080 = 27.6.</summary>
    public const float MinFont = 28f;
    /// <summary>An empty node of a fixed size, centred at <paramref name = "centre"/>.</summary>
    public static RectTransform Node(Transform _0x065221e3, string _0xfe54bb8f, Vector2 _0x9e96a452, Vector2 _0x0a0d4eac)
    {
        GameObject _0x580da508 = new GameObject(_0xfe54bb8f, typeof(RectTransform));
        RectTransform _0x71e7abcb = _0x580da508.GetComponent<RectTransform>();
        _0x71e7abcb.SetParent(_0x065221e3, false);
        Anchor(_0x71e7abcb, _0x9e96a452, _0x0a0d4eac);
        return _0x71e7abcb;
    }

    /// <summary>Anchors a rect to its parent's bottom-left and centres it at a panel coordinate.</summary>
    public static void Anchor(RectTransform _0xfd3c3785, Vector2 _0xbec1a88c, Vector2 _0xe39e44fe)
    {
        _0xfd3c3785.anchorMin = Vector2.zero;
        _0xfd3c3785.anchorMax = Vector2.zero;
        _0xfd3c3785.pivot = new Vector2(0.5f, 0.5f);
        _0xfd3c3785.sizeDelta = _0xe39e44fe;
        _0xfd3c3785.anchoredPosition = _0xbec1a88c;
        _0xfd3c3785.localScale = Vector3.one;
        _0xfd3c3785.localRotation = Quaternion.identity;
    }

    /// <summary>
    /// A rounded plate. The corner radius is a real request in panel units and is clamped to
    /// half the shorter side: a 9-slice border wider than the rect it is drawn into collapses
    /// the sprite into a sliver.
    /// </summary>
    public static Image Plate(Transform _0x7b93182d, string _0x8d903727, Vector2 _0x94e73878, Vector2 _0x2a30c804, Sprite _0x9ff27fdc, Color _0x48359220, float _0xbbea1138)
    {
        GameObject _0xeba1dcb9 = new GameObject(_0x8d903727, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        RectTransform _0x8d1e29a3 = _0xeba1dcb9.GetComponent<RectTransform>();
        _0x8d1e29a3.SetParent(_0x7b93182d, false);
        Anchor(_0x8d1e29a3, _0x94e73878, _0x2a30c804);
        Image _0x0ae5fb8a = _0xeba1dcb9.GetComponent<Image>();
        _0x0ae5fb8a.color = _0x48359220;
        _0x0ae5fb8a.raycastTarget = false;
        if (_0x9ff27fdc != null)
        {
            _0x0ae5fb8a.sprite = _0x9ff27fdc;
            _0x0ae5fb8a.type = Image.Type.Sliced;
            float _0x1efb40e1 = Mathf.Min(_0x2a30c804.x, _0x2a30c804.y) * 0.5f;
            _0x0ae5fb8a.pixelsPerUnitMultiplier = PlateBorder / Mathf.Max(1f, Mathf.Min(_0xbbea1138, _0x1efb40e1));
        }

        return _0x0ae5fb8a;
    }

    /// <summary>The label a <see cref = "Cta"/> drew, so a caller can recaption it later.</summary>
    public static TextMeshProUGUI CaptionOf(Button _0x5aa0c064)
    {
        if (_0x5aa0c064 == null)
            return null;
        return _0x5aa0c064.GetComponentInChildren<TextMeshProUGUI>(true);
    }

    /// <summary>A 9-slice bar that is MEANT to stretch on one axis, so preserveAspect stays off.</summary>
    public static Image Bar(Transform _0xfad3866a, string _0xb7639d6e, Vector2 _0x63e04950, Vector2 _0x9b1916f2, Sprite _0x6e45239b, Color _0x12ea8c7a, float _0x21fe3ac0)
    {
        Image _0xd746d63d = Plate(_0xfad3866a, _0xb7639d6e, _0x63e04950, _0x9b1916f2, _0x6e45239b, _0x12ea8c7a, _0x21fe3ac0);
        _0xd746d63d.preserveAspect = false;
        return _0xd746d63d;
    }

    /// <summary>Removes every child of a host, so a view can be rebuilt from scratch.</summary>
    public static void Clear(Transform _0xd448503c)
    {
        if (_0xd448503c == null)
            return;
        for (int _0xab2cf745 = _0xd448503c.childCount - 1; _0xab2cf745 >= 0; _0xab2cf745--)
        {
            Transform _0x653243ee = _0xd448503c.GetChild(_0xab2cf745);
            _0x653243ee.SetParent(null, false);
            Object.Destroy(_0x653243ee.gameObject);
        }
    }

    /// <summary>A full-stretch, transparent child: the host a screen is built inside.</summary>
    public static RectTransform Branch(Transform _0xdcd21f60, string _0x5f86a6d8)
    {
        GameObject _0xfab2b56e = new GameObject(_0x5f86a6d8, typeof(RectTransform));
        RectTransform _0xce420349 = _0xfab2b56e.GetComponent<RectTransform>();
        _0xce420349.SetParent(_0xdcd21f60, false);
        _0xce420349.anchorMin = Vector2.zero;
        _0xce420349.anchorMax = Vector2.one;
        _0xce420349.offsetMin = Vector2.zero;
        _0xce420349.offsetMax = Vector2.zero;
        _0xce420349.localScale = Vector3.one;
        return _0xce420349;
    }

    /// <summary>
    /// A content sprite: Simple draw mode plus preserveAspect, so a 512 square PNG is never
    /// stretched into an egg whatever rect it is given (F.2a).
    /// </summary>
    public static Image Picture(Transform _0x60f6f772, string _0x6375bd8b, Vector2 _0xb430d72b, Vector2 _0xea9b69d2, Sprite _0xa91b4ed3, Color _0xc496dc8c)
    {
        GameObject _0xfeaa66e8 = new GameObject(_0x6375bd8b, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        RectTransform _0x8d3f7557 = _0xfeaa66e8.GetComponent<RectTransform>();
        _0x8d3f7557.SetParent(_0x60f6f772, false);
        Anchor(_0x8d3f7557, _0xb430d72b, _0xea9b69d2);
        Image _0xdd5b7617 = _0xfeaa66e8.GetComponent<Image>();
        _0xdd5b7617.sprite = _0xa91b4ed3;
        _0xdd5b7617.preserveAspect = true;
        _0xdd5b7617.type = Image.Type.Simple;
        _0xdd5b7617.color = _0xc496dc8c;
        _0xdd5b7617.raycastTarget = false;
        return _0xdd5b7617;
    }

    /// <summary>
    /// A square icon button: plate, then the glyph on top. No caption - an icon button that
    /// also carries text ends up with one of the two cropped (C.17).
    /// </summary>
    public static Button IconCta(Transform _0x69bafccf, string _0x7071c65f, Vector2 _0xc55ddff1, Vector2 _0x783f7bf8, Sprite _0x40bfab32, Color _0xb6a63421, Sprite _0x45b949c0, Color _0x33e02625, float _0xa97640fa)
    {
        RectTransform _0xbee2f38c = Node(_0x69bafccf, _0x7071c65f, _0xc55ddff1, _0x783f7bf8);
        GameObject _0x0c4b90d5 = _0xbee2f38c.gameObject;
        Image _0xd5508c9d = _0x0c4b90d5.AddComponent<Image>();
        _0xd5508c9d.raycastTarget = true;
        _0xd5508c9d.color = _0xb6a63421;
        if (_0x40bfab32 != null)
        {
            _0xd5508c9d.sprite = _0x40bfab32;
            _0xd5508c9d.type = Image.Type.Sliced;
            float _0xdd54766d = Mathf.Min(_0x783f7bf8.x, _0x783f7bf8.y) * 0.5f;
            _0xd5508c9d.pixelsPerUnitMultiplier = PlateBorder / Mathf.Max(1f, Mathf.Min(_0xa97640fa, _0xdd54766d));
        }

        Button _0xfb7054b9 = _0x0c4b90d5.AddComponent<Button>();
        _0xfb7054b9.targetGraphic = _0xd5508c9d;
        Picture(_0xbee2f38c, _0x5a8224f7._0xee7ae724(new byte[5] { 58, 17, 4, 13, 21 }, 125), new Vector2(_0x783f7bf8.x * 0.5f, _0x783f7bf8.y * 0.5f), new Vector2(_0x783f7bf8.x * 0.52f, _0x783f7bf8.y * 0.52f), _0x45b949c0, _0x33e02625);
        return _0xfb7054b9;
    }

    /// <summary>Reference canvas width, from the template's CanvasScaler.</summary>
    public const float PanelWidth = 1242f;
    /// <summary>
    /// A full-stretch invisible button, used as the shade behind a modal sheet. A scenario tap
    /// that misses a 110-unit close glyph by twenty units would otherwise leave the sheet
    /// covering the screen and every later frame identical.
    /// </summary>
    public static Button Shade(Transform _0xb095dea6, string _0xd96bdbae, Color _0x4917c352)
    {
        Image _0x3dc7f4ee = HitLayer(_0xb095dea6, _0xd96bdbae);
        _0x3dc7f4ee.color = _0x4917c352;
        Button _0x5bbbca37 = _0x3dc7f4ee.gameObject.AddComponent<Button>();
        _0x5bbbca37.transition = Selectable.Transition.None;
        _0x5bbbca37.targetGraphic = _0x3dc7f4ee;
        return _0x5bbbca37;
    }

    /// <summary>A horizontal progress bar: track, then a fill whose width is the fraction.</summary>
    public static Image Meter(Transform _0x4de42fd4, string _0x8b2214c6, Vector2 _0xb2893eca, Vector2 _0xc29e91e9, Sprite _0x27d9acc2, Color _0xc78cb6ac, Color _0xeb3bdf90, float _0xbc29fa51)
    {
        RectTransform _0x83940e68 = Node(_0x4de42fd4, _0x8b2214c6, _0xb2893eca, _0xc29e91e9);
        Bar(_0x83940e68, _0x5a8224f7._0xee7ae724(new byte[5] { 234, 204, 223, 221, 213 }, 190), new Vector2(_0xc29e91e9.x * 0.5f, _0xc29e91e9.y * 0.5f), _0xc29e91e9, _0x27d9acc2, _0xc78cb6ac, _0xc29e91e9.y * 0.5f);
        float width = Mathf.Clamp01(_0xbc29fa51) * _0xc29e91e9.x;
        Image _0x17a77b5c = Bar(_0x83940e68, _0x5a8224f7._0xee7ae724(new byte[4] { 119, 88, 93, 93 }, 49), new Vector2(width * 0.5f, _0xc29e91e9.y * 0.5f), new Vector2(width, _0xc29e91e9.y), _0x27d9acc2, _0xeb3bdf90, _0xc29e91e9.y * 0.5f);
        return _0x17a77b5c;
    }

    /// <summary>The 9-slice border of the template's rounded plate sprite, in source pixels.</summary>
    private const float PlateBorder = 127f;
    /// <summary>
    /// A button: face plate, then the caption LAST so the backing can never cover its own label
    /// (sibling order is draw order in UGUI). The caller wires it with a lambda; a method group
    /// would survive the compiler and die in the obfuscated build (C.1).
    /// </summary>
    public static Button Cta(Transform _0x13beaad1, string _0x623b0ef2, Vector2 _0x41caac13, Vector2 _0x53fca8b3, Sprite _0xf4f31213, Color _0x94b7bc72, string _0x6205836f, float _0xc1214b07, float _0x095586bc, Color _0x92afb322, TMP_FontAsset _0x67022056, float _0x7a199a87)
    {
        RectTransform _0xde0b0b4a = Node(_0x13beaad1, _0x623b0ef2, _0x41caac13, _0x53fca8b3);
        GameObject _0x1d5f20e2 = _0xde0b0b4a.gameObject;
        Image _0x894658fa = _0x1d5f20e2.AddComponent<Image>();
        _0x894658fa.raycastTarget = true;
        _0x894658fa.color = _0x94b7bc72;
        if (_0xf4f31213 != null)
        {
            _0x894658fa.sprite = _0xf4f31213;
            _0x894658fa.type = Image.Type.Sliced;
            float _0xd888dbc9 = Mathf.Min(_0x53fca8b3.x, _0x53fca8b3.y) * 0.5f;
            _0x894658fa.pixelsPerUnitMultiplier = PlateBorder / Mathf.Max(1f, Mathf.Min(_0x7a199a87, _0xd888dbc9));
        }

        Button _0x4eb8c1c5 = _0x1d5f20e2.AddComponent<Button>();
        _0x4eb8c1c5.targetGraphic = _0x894658fa;
        _0x4eb8c1c5.transition = Selectable.Transition.ColorTint;
        ColorBlock _0xe0be4fd1 = _0x4eb8c1c5.colors;
        _0xe0be4fd1.normalColor = _0xe058d175.White;
        _0xe0be4fd1.highlightedColor = new Color(1f, 0.96f, 0.88f, 1f);
        _0xe0be4fd1.pressedColor = new Color(0.78f, 0.66f, 0.42f, 1f);
        _0xe0be4fd1.selectedColor = _0xe058d175.White;
        _0xe0be4fd1.disabledColor = new Color(0.55f, 0.46f, 0.42f, 0.8f);
        _0x4eb8c1c5.colors = _0xe0be4fd1;
        if (!string.IsNullOrEmpty(_0x6205836f))
        {
            Label(_0xde0b0b4a, _0x5a8224f7._0xee7ae724(new byte[7] { 128, 162, 179, 183, 170, 172, 173 }, 195), new Vector2(_0x53fca8b3.x * 0.5f, _0x53fca8b3.y * 0.5f), new Vector2(_0x53fca8b3.x - 44f, _0x53fca8b3.y - 26f), _0x6205836f, _0xc1214b07, _0x095586bc, _0x92afb322, _0x67022056, TextAlignmentOptions.Center);
        }

        return _0x4eb8c1c5;
    }
}

internal static class _0x5a8224f7
{
    internal static string _0xee7ae724(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}