using TMPro;
using UnityEngine;

/// <summary>
/// Outline for text created in C#. Stage 5c3 reads scenes and prefabs only, so a label built at
/// runtime is invisible to it and would ship with whatever the shared font material happens to
/// carry (CLAUDE-unity.md C.10). Reading <c>fontMaterial</c> hands the label its OWN material
/// instance; the shared asset the pipeline themes is never modified.
/// </summary>
public static class _0x77b5335c
{
    /// <summary>
    /// Gives <paramref name = "label"/> an outline that contrasts with its own face: dark ink
    /// under a light face, cream under a dark one. A face that matches its outline merges into
    /// a blot no background can rescue.
    /// </summary>
    public static void ApplyOutline(TMP_Text _0xf7c9b908, Color _0xb209c03d)
    {
        if (_0xf7c9b908 == null)
            return;
        float _0xf21855b3 = (0.299f * _0xb209c03d.r) + (0.587f * _0xb209c03d.g) + (0.114f * _0xb209c03d.b);
        Color _0x358fbfe0 = _0xf21855b3 < 0.5f ? _0xe058d175.TextPrimary : _0xe058d175.Ink;
        Material _0x75f87525 = _0xf7c9b908.fontMaterial;
        if (_0x75f87525 == null)
            return;
        _0x75f87525.SetColor(ShaderUtilities.ID_OutlineColor, _0x358fbfe0);
        _0x75f87525.SetFloat(ShaderUtilities.ID_OutlineWidth, OutlineWidth);
    }

    private const float OutlineWidth = 0.2f;
}