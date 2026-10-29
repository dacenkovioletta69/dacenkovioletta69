using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the template's splash panel, in both scenes.
///
/// Two constraints shape everything here. First, the splash must not read as the lobby: the
/// loader/menu comparison that gates the review album measures one against the other, and a
/// splash that looks like the menu fails it. So this is a near-black wash with one abstract
/// mark and two lines, while the lobby is a lit parlour with a gold call to action, a room
/// stage and a mission strip.
///
/// Second, nothing loops here. The capture job's wait for the loading bar only ends after a
/// stretch with no change on screen, so a perpetual animation on the splash can burn its whole
/// ceiling; the mark settles once and stops.
///
/// The mark is abstract - a faceted gem in a jester collar. No letters, no name, no logo type
/// (hard rule 1).
/// </summary>
public sealed class _0x98683103 : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    /// <summary>Draws the splash contents into a host the director already parented.</summary>
    public void _0xfcc86443(RectTransform _0xbcd12bc0, _0x30d693a6 _0xdacc6c6d, TMP_FontAsset _0x5735ceb6)
    {
        if (_0xbcd12bc0 == null)
            return;
        Image _0xa3856a44 = _0xcecf7be6.Plate(_0xbcd12bc0, _0x1ba31f95._0x59b9e84b(new byte[10] { 234, 201, 213, 216, 202, 209, 239, 220, 208, 213 }, 185), new Vector2(_0xcecf7be6.MidX, _0xcecf7be6.PanelHeight * 0.5f), new Vector2(_0xcecf7be6.PanelWidth, _0xcecf7be6.PanelHeight), null, _0xe058d175.Alpha(_0xe058d175.Abyss, 0.88f), 1f);
        _0xa3856a44.raycastTarget = false;
        // Aura first, mark second: a glow created after the thing it sits behind would cover
        // it, and sibling order is the only draw order UGUI has (C.13).
        _0xcecf7be6.Picture(_0xbcd12bc0, _0x1ba31f95._0x59b9e84b(new byte[10] { 160, 131, 159, 146, 128, 155, 178, 134, 129, 146 }, 243), new Vector2(_0xcecf7be6.MidX, 1680f), new Vector2(760f, 760f), _0xdacc6c6d != null ? _0xdacc6c6d._0x38f9d754 : null, _0xe058d175.Alpha(_0xe058d175.Violet, 0.22f));
        Image _0x571bcce7 = _0xcecf7be6.Picture(_0xbcd12bc0, _0x1ba31f95._0x59b9e84b(new byte[10] { 59, 24, 4, 9, 27, 0, 37, 9, 26, 3 }, 104), new Vector2(_0xcecf7be6.MidX, 1680f), new Vector2(520f, 520f), _0xdacc6c6d != null ? _0xdacc6c6d._0xfb27b785 : null, _0xe058d175.White);
        _0xcecf7be6.Label(_0xbcd12bc0, _0x1ba31f95._0x59b9e84b(new byte[13] { 76, 111, 115, 126, 108, 119, 92, 126, 111, 107, 118, 112, 113 }, 31), new Vector2(_0xcecf7be6.MidX, 1300f), new Vector2(1040f, 80f), _0x1ba31f95._0x59b9e84b(new byte[18] { 233, 246, 245, 240, 234, 241, 240, 247, 254, 153, 237, 241, 252, 153, 254, 252, 244, 234 }, 185), 44f, 32f, _0xe058d175.TextSecondary, _0x5735ceb6, TextAlignmentOptions.Center);
        _0xcecf7be6.Label(_0xbcd12bc0, _0x1ba31f95._0x59b9e84b(new byte[12] { 2, 33, 61, 48, 34, 57, 23, 62, 62, 37, 52, 35 }, 81), new Vector2(_0xcecf7be6.MidX, 150f), new Vector2(1080f, 64f), _0x1ba31f95._0x59b9e84b(new byte[22] { 73, 64, 93, 47, 74, 65, 91, 74, 93, 91, 78, 70, 65, 66, 74, 65, 91, 47, 64, 65, 67, 86 }, 15), 30f, 28f, _0xe058d175.TextMuted, _0x5735ceb6, TextAlignmentOptions.Center);
        if (_0xaa0251af._0x70f7e906)
            return;
        _0x571bcce7.rectTransform.localScale = new Vector3(0.86f, 0.86f, 1f);
        _0x571bcce7.rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutBack).SetLink(_0x571bcce7.gameObject);
        _0x571bcce7.color = _0xe058d175.Alpha(_0xe058d175.White, 0f);
        _0x571bcce7.DOFade(1f, 0.35f).SetLink(_0x571bcce7.gameObject);
    }

    /// <summary>
    /// Finds the splash panel by its SETTINGS index, hangs our mark UNDER everything the
    /// template already put there, and retints the loading bar. Both scenes call this: each
    /// one shows its own splash, so each one has to dress its own.
    /// </summary>
    public void _0x9bfd8d48(_0x30d693a6 _0xdaf9539c, TMP_FontAsset _0x95c6da6c)
    {
        if (_0x868e2cfd.Instance == null || _0x868e2cfd.Instance.Panels == null)
            return;
        int _0x7150eed9 = _0x4fc558d7._0xb679ca6b.SPLASH;
        if (_0x7150eed9 < 0 || _0x7150eed9 >= _0x868e2cfd.Instance.Panels.Count)
            return;
        _0x39e04600 _0x0e823cef = _0x868e2cfd.Instance.Panels[_0x7150eed9];
        if (_0x0e823cef == null || _0x0e823cef.Content == null)
            return;
        RectTransform _0x5ae8d0cf = _0xcecf7be6.Branch(_0x0e823cef.Content.transform, _0x1ba31f95._0x59b9e84b(new byte[13] { 58, 11, 24, 6, 5, 31, 24, 57, 26, 6, 11, 25, 2 }, 106));
        // First sibling: the loading bar and everything else the template placed in this
        // body keeps drawing OVER the mark. Sibling order is the only draw order UGUI has.
        _0x5ae8d0cf.SetAsFirstSibling();
        this._0xfcc86443(_0x5ae8d0cf, _0xdaf9539c, _0x95c6da6c);
        this._0x9497f3f9(_0x0e823cef);
    }

    /// <summary>
    /// The template ships the bar as a white fill on a track at alpha 0.004 - one step above
    /// invisible - so progress cannot be read at all. Both layers are reached through the
    /// Slider's own fillRect, so no part of the chain is addressed by name or by path, and
    /// the Slider itself is found BY COMPONENT TYPE.
    /// </summary>
    private void _0x9497f3f9(_0x39e04600 _0xde112e5a)
    {
        Slider _0x50314036 = _0xde112e5a.GetComponentInChildren<Slider>(true);
        if (_0x50314036 == null || _0x50314036.fillRect == null)
            return;
        Image _0x27be7880 = _0x50314036.fillRect.GetComponent<Image>();
        if (_0x27be7880 != null)
            _0x27be7880.color = _0xe058d175.Gold;
        Transform _0xdf02d146 = _0x50314036.fillRect.parent;
        Image _0x89ef5561 = _0xdf02d146 != null ? _0xdf02d146.GetComponent<Image>() : null;
        if (_0x89ef5561 != null)
            _0x89ef5561.color = _0xe058d175.SurfaceRaise;
    }
}

internal static class _0x1ba31f95
{
    internal static string _0x59b9e84b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}