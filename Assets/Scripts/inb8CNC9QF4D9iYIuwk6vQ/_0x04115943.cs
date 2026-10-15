using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Back and Pause for the game scene, as OUR OWN pair inside our own top bar.
///
/// Rule H prefers restyling the template's RIGHT_BUTTON / LEFT_BUTTON in place. That option
/// does not exist on this template family: stage 5da (<c>disable-template-leftovers.sh</c>)
/// runs before every verifier and switches both of them off, so anything wired onto them would
/// ship invisible and the game would have no way back to the lobby and no pause at all. H's
/// second option is therefore the one taken here - author our own pair and leave the template
/// buttons completely alone, so 5da can switch them off without breaking anything.
///
/// Both are wired with lambdas. A method group in any argument survives the compiler and dies
/// in the obfuscated cloud build, because Plana renames the declaration and leaves the bare
/// reference behind (C.1).
/// </summary>
public sealed class _0x04115943 : MonoBehaviour
{
    private _0x097d9957 _0x65a2f82f;
    private const float IconSize = 132f;
    /// <summary>
    /// Places both buttons inside the bar the HUD built. <paramref name = "bar"/> is 1140 x 140,
    /// so Back sits at 20..152 and Pause at 988..1120 - clear of the balance band at 368..810.
    /// </summary>
    public void _0x670a6800(RectTransform _0x4bd6b993, _0x30d693a6 _0xe9ad18fa, _0x097d9957 _0x61056d42)
    {
        if (_0x4bd6b993 == null)
            return;
        this._0x65a2f82f = _0x61056d42;
        Sprite _0x760eb5ad = _0xe9ad18fa != null ? _0xe9ad18fa._0xfae782aa : null;
        Button _0x5b560781 = _0xcecf7be6.IconCta(_0x4bd6b993, _0x3df60cb6._0x41216c32(new byte[10] { 158, 189, 191, 183, 158, 169, 168, 168, 179, 178 }, 220), new Vector2(86f, 70f), new Vector2(IconSize, IconSize), _0x760eb5ad, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.96f), _0xe9ad18fa != null ? _0xe9ad18fa._0x8ceb8881 : null, _0xe058d175.Gold, 26f);
        _0x5b560781.onClick.AddListener(() => this._0x20ef1430());
        Button _0x47e68fc7 = _0xcecf7be6.IconCta(_0x4bd6b993, _0x3df60cb6._0x41216c32(new byte[11] { 146, 163, 183, 177, 167, 128, 183, 182, 182, 173, 172 }, 194), new Vector2(1054f, 70f), new Vector2(IconSize, IconSize), _0x760eb5ad, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.96f), _0xe9ad18fa != null ? _0xe9ad18fa._0xb27602ab : null, _0xe058d175.Gold, 26f);
        _0x47e68fc7.onClick.AddListener(() => this._0x169f3622());
    }

    /// <summary>Panel y of both, matching the top bar.</summary>
    public const float NavPanelY = 2540f;
    /// <summary>Panel x of the Pause button's centre.</summary>
    public const float PausePanelX = 1105f;
    /// <summary>Panel x of the Back button's centre, for the screenshot scenario.</summary>
    public const float BackPanelX = 137f;
    /// <summary>
    /// Raises the pause card. The director is told first so it stops the idle backstop before
    /// the card is up, rather than spinning behind it.
    /// </summary>
    private void _0x169f3622()
    {
        if (this._0x65a2f82f != null)
            this._0x65a2f82f._0x9af127eb();
    }

    /// <summary>
    /// Back to the lobby. The scene is addressed by its SETTINGS index, never by name: the
    /// obfuscator renames scene files and a string would point at nothing (C.1).
    /// </summary>
    private void _0x20ef1430()
    {
        if (this._0x65a2f82f != null)
            this._0x65a2f82f._0xcc1a1a2e();
        if (_0x697b0043.Instance != null)
            _0x697b0043.Instance._0x3abfd880(_0x4fc558d7._0xf3e0f416.SCENE_0);
    }
}

internal static class _0x3df60cb6
{
    internal static string _0x41216c32(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}