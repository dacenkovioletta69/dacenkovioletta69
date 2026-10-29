using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x13a45d40 : MonoBehaviour
{
    private static _0x13a45d40 _0x04ef72c7;
    private const float TargetRatio = 7f;
    private void OnDisable()
    {
        if (this._0xbb78f5c1 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xbb78f5c1);
    }

    private const float MinOutlineWidth = 0.01f;
    private static float Linear(float _0x3a69ca6c)
    {
        _0x3a69ca6c = Mathf.Clamp01(_0x3a69ca6c);
        return _0x3a69ca6c <= 0.03928f ? _0x3a69ca6c / 12.92f : Mathf.Pow((_0x3a69ca6c + 0.055f) / 1.055f, 2.4f);
    }

    private void LateUpdate()
    {
        if (this._0xb624b547.Count == 0)
            return;
        this._0xded437fa.Clear();
        this._0xded437fa.AddRange(this._0xb624b547);
        this._0xb624b547.Clear();
        for (int _0xd5cdfc40 = 0; _0xd5cdfc40 < this._0xded437fa.Count; _0xd5cdfc40++)
            Fix(this._0xded437fa[_0xd5cdfc40]);
    }

    private static void Fix(TMP_Text _0x6dd5cef3)
    {
        if (_0x6dd5cef3 == null || !_0x6dd5cef3.isActiveAndEnabled)
            return;
        Material _0xf590ffaf = _0x6dd5cef3.fontSharedMaterial;
        if (_0xf590ffaf == null || !_0xf590ffaf.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xf590ffaf.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xf590ffaf.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x49d3a16c = _0x6dd5cef3.color;
        if (_0x49d3a16c.a <= 0f)
            return;
        Color _0x5acf2cd7 = _0xf590ffaf.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x49d3a16c, _0x5acf2cd7) >= MinRatio)
            return;
        Color _0xbaffccc7 = Luminance(_0x5acf2cd7) < 0.5f ? Color.white : Color.black;
        Color _0xc19ec868;
        if (Ratio(_0xbaffccc7, _0x5acf2cd7) < TargetRatio)
        {
            _0xc19ec868 = _0xbaffccc7;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x56307a0f = 0f;
            float _0x2caca9ae = 1f;
            for (int _0x0cff94e2 = 0; _0x0cff94e2 < 20; _0x0cff94e2++)
            {
                float _0x61121297 = (_0x56307a0f + _0x2caca9ae) * 0.5f;
                if (Ratio(Color.Lerp(_0x49d3a16c, _0xbaffccc7, _0x61121297), _0x5acf2cd7) >= TargetRatio)
                    _0x2caca9ae = _0x61121297;
                else
                    _0x56307a0f = _0x61121297;
            }

            _0xc19ec868 = Color.Lerp(_0x49d3a16c, _0xbaffccc7, _0x2caca9ae);
        }

        _0xc19ec868.a = _0x49d3a16c.a;
        _0x6dd5cef3.color = _0xc19ec868;
    }

    private const float MinRatio = 4.5f;
    private readonly List<TMP_Text> _0xded437fa = new List<TMP_Text>();
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xdd4628aa)
    {
        return 0.2126f * Linear(_0xdd4628aa.r) + 0.7152f * Linear(_0xdd4628aa.g) + 0.0722f * Linear(_0xdd4628aa.b);
    }

    private static float Ratio(Color _0x067a318a, Color _0x2b30278a)
    {
        float _0xcc86fd51 = Luminance(_0x067a318a);
        float _0xbd597ef6 = Luminance(_0x2b30278a);
        return (Mathf.Max(_0xcc86fd51, _0xbd597ef6) + 0.05f) / (Mathf.Min(_0xcc86fd51, _0xbd597ef6) + 0.05f);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xf9b1b404(Object _0xa51c408f)
    {
        TMP_Text _0xb1af9cdb = _0xa51c408f as TMP_Text;
        if (_0xb1af9cdb != null)
            this._0xb624b547.Add(_0xb1af9cdb);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x04ef72c7 != null)
            return;
        GameObject _0xd6fac614 = new GameObject(_0x853c7d8b._0xe3ea3cac(new byte[16] { 94, 103, 122, 73, 101, 100, 126, 120, 107, 121, 126, 77, 127, 107, 120, 110 }, 10));
        _0xd6fac614.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xd6fac614);
        _0x04ef72c7 = _0xd6fac614.AddComponent<_0x13a45d40>();
    }

    private readonly HashSet<TMP_Text> _0xb624b547 = new HashSet<TMP_Text>();
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xbb78f5c1;
    private void OnEnable()
    {
        if (this._0xbb78f5c1 == null)
            this._0xbb78f5c1 = _0x62ffba65 => this._0xf9b1b404(_0x62ffba65);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xbb78f5c1);
    }
}

internal static class _0x853c7d8b
{
    internal static string _0xe3ea3cac(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}