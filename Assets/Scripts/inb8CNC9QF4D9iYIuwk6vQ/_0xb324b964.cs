using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Four controls that each change something a player can see. There is no sound row: this
/// pipeline ships no audio at all, so a speaker toggle would mute silence and a button that
/// confirms nothing is a dead button (C.20, C.7).
///
/// HAPTICS fires one pulse the moment it is switched on. QUICK SPIN shortens the next spin and
/// shows a filled speed meter. REDUCE EFFECTS drops the idle loops and the swatch loses its
/// sparkle on the spot. RESET PROGRESS arms first and clears on the second tap inside four
/// seconds.
/// </summary>
public sealed class _0xb324b964 : MonoBehaviour
{
    /// <summary>Opens the sheet, disarming any half-finished reset.</summary>
    public void _0x9833c894()
    {
        if (this._0x7f5a6696 == null)
            return;
        this._0xfd500681 = -100f;
        this._0x24a12a9a();
        this._0x7f5a6696.gameObject.SetActive(true);
        this._0x7bab0b2a.localScale = new Vector3(0.9f, 0.9f, 1f);
        this._0x7bab0b2a.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(this._0x7bab0b2a.gameObject);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private TMP_FontAsset _0x2275efd6;
    private const float CardH = 1240f;
    private static Vector2 Card(float _0x8dd8c03e, float _0xdbab2673)
    {
        return new Vector2(_0x8dd8c03e - CardLeft, _0xdbab2673 - CardBottom);
    }

    private void _0xa187e652()
    {
        if (Time.unscaledTime - this._0xfd500681 >= ArmWindow)
        {
            this._0xfd500681 = Time.unscaledTime;
            this._0x24a12a9a();
            return;
        }

        this._0xfd500681 = -100f;
        _0xaa0251af.ResetAll();
        this._0x24a12a9a();
        if (this._0xe4b0154c != null)
            this._0xe4b0154c._0x8617ee6a();
    }

    /// <summary>Closes the sheet.</summary>
    public void _0xf71bfa76()
    {
        if (this._0x7f5a6696 == null)
            return;
        this._0xfd500681 = -100f;
        this._0x7f5a6696.gameObject.SetActive(false);
        if (this._0xe4b0154c != null)
            this._0xe4b0154c._0x8dc68993();
    }

    private _0x30d693a6 _0x30307812;
    private const float CardW = 1060f;
    /// <summary>Panel centre of the close glyph.</summary>
    public const float ClosePanelX = 1061f;
    private void _0x75811299(float _0x7fa225db, bool _0x2f315815, Sprite _0xd5c911d3)
    {
        RectTransform _0x351109e1 = _0xcecf7be6.Frame(this._0x7bab0b2a, _0x0e27adc8._0xb180c7d4(new byte[8] { 250, 205, 219, 205, 220, 250, 199, 223 }, 168), Card(_0xcecf7be6.MidX, _0x7fa225db), new Vector2(RowW, RowH), _0xd5c911d3, _0x2f315815 ? _0xe058d175.Alarm : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.92f), _0xe058d175.Alpha(_0xe058d175.Ground, 0.97f), 26f, _0x2f315815 ? 6f : 3f);
        _0xcecf7be6.Picture(_0x351109e1, _0x0e27adc8._0xb180c7d4(new byte[9] { 98, 85, 67, 85, 68, 115, 88, 89, 64 }, 48), new Vector2(GutterCentre, RowH * 0.5f), new Vector2(GutterWidth, GutterWidth), this._0x30307812 != null ? this._0x30307812._0xe39fd6d8 : null, _0x2f315815 ? _0xe058d175.Alarm : _0xe058d175.VioletSoft);
        _0xcecf7be6.Label(_0x351109e1, _0x0e27adc8._0xb180c7d4(new byte[10] { 90, 109, 123, 109, 124, 92, 97, 124, 100, 109 }, 8), new Vector2(TextLeft + 380f, RowH * 0.64f), new Vector2(760f, 46f), _0x0e27adc8._0xb180c7d4(new byte[14] { 107, 124, 106, 124, 109, 25, 105, 107, 118, 126, 107, 124, 106, 106 }, 57), 36f, 28f, _0x2f315815 ? _0xe058d175.Alarm : _0xe058d175.TextPrimary, this._0x2275efd6, TextAlignmentOptions.Left);
        _0xcecf7be6.Label(_0x351109e1, _0x0e27adc8._0xb180c7d4(new byte[10] { 59, 12, 26, 12, 29, 58, 29, 8, 29, 12 }, 105), new Vector2(TextLeft + 380f, RowH * 0.30f), new Vector2(760f, 40f), _0x2f315815 ? _0x0e27adc8._0xb180c7d4(new byte[20] { 20, 1, 16, 96, 1, 7, 1, 9, 14, 96, 20, 15, 96, 3, 15, 14, 6, 9, 18, 13 }, 64) : _0x0e27adc8._0xb180c7d4(new byte[32] { 254, 242, 244, 243, 238, 145, 157, 240, 244, 238, 238, 244, 242, 243, 238, 145, 157, 252, 241, 255, 232, 240, 157, 252, 243, 249, 157, 239, 242, 242, 240, 238 }, 189), 30f, 28f, _0x2f315815 ? _0xe058d175.Alarm : _0xe058d175.TextMuted, this._0x2275efd6, TextAlignmentOptions.Left);
        Button _0x645ecb34 = _0xcecf7be6.Shade(_0x351109e1, _0x0e27adc8._0xb180c7d4(new byte[8] { 200, 255, 233, 255, 238, 210, 243, 238 }, 154), new Color(1f, 1f, 1f, 0.004f));
        _0x645ecb34.onClick.AddListener(() => this._0xa187e652());
    }

    private const float CardLeft = 91f;
    /// <summary>One switch row. Gutter chip, label column, then the knob at the right end.</summary>
    private void _0x1e22d493(int _0xe36a23ae, float _0xa3e167cd, string _0xa69137c7, string _0x99046a4d, bool _0x3fba7806, Sprite _0x3d570da4)
    {
        RectTransform _0xbe114190 = _0xcecf7be6.Frame(this._0x7bab0b2a, _0x0e27adc8._0xb180c7d4(new byte[6] { 200, 254, 239, 201, 244, 236 }, 155), Card(_0xcecf7be6.MidX, _0xa3e167cd), new Vector2(RowW, RowH), _0x3d570da4, _0x3fba7806 ? _0xe058d175.Gold : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.92f), _0xe058d175.Alpha(_0xe058d175.Ground, 0.97f), 26f, _0x3fba7806 ? 5f : 3f);
        _0xcecf7be6.Picture(_0xbe114190, _0x0e27adc8._0xb180c7d4(new byte[7] { 100, 89, 65, 117, 94, 95, 70 }, 54), new Vector2(GutterCentre, RowH * 0.5f), new Vector2(GutterWidth, GutterWidth), this._0x30307812 != null ? this._0x30307812._0xe39fd6d8 : null, _0x3fba7806 ? _0xe058d175.Gold : _0xe058d175.VioletSoft);
        _0xcecf7be6.Label(_0xbe114190, _0x0e27adc8._0xb180c7d4(new byte[8] { 13, 48, 40, 11, 54, 43, 51, 58 }, 95), new Vector2(TextLeft + 220f, RowH * 0.64f), new Vector2(440f, 46f), _0xa69137c7, 36f, 28f, _0xe058d175.TextPrimary, this._0x2275efd6, TextAlignmentOptions.Left);
        _0xcecf7be6.Label(_0xbe114190, _0x0e27adc8._0xb180c7d4(new byte[8] { 245, 200, 208, 244, 211, 198, 211, 194 }, 167), new Vector2(TextLeft + 220f, RowH * 0.30f), new Vector2(440f, 40f), _0x99046a4d, 30f, 28f, _0x3fba7806 ? _0xe058d175.Gold : _0xe058d175.TextMuted, this._0x2275efd6, TextAlignmentOptions.Left);
        // Speed meter for the spin row, sparkle swatch for the effects row: each control shows
        // its own result, not just a changed word.
        if (_0xe36a23ae == 1)
        {
            for (int _0x09a2ef1a = 0; _0x09a2ef1a < 3; _0x09a2ef1a++)
            {
                bool _0x98715b0c = _0x3fba7806 || _0x09a2ef1a == 0;
                _0xcecf7be6.Plate(_0xbe114190, _0x0e27adc8._0xb180c7d4(new byte[8] { 249, 218, 207, 207, 206, 232, 203, 216 }, 170), new Vector2(670f + (_0x09a2ef1a * 34f), RowH * 0.42f), new Vector2(22f, 26f + (_0x09a2ef1a * 16f)), _0x3d570da4, _0x98715b0c ? _0xe058d175.Gold : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 1f), 8f);
            }
        }
        else if (_0xe36a23ae == 2)
        {
            _0xcecf7be6.Picture(_0xbe114190, _0x0e27adc8._0xb180c7d4(new byte[6] { 199, 227, 245, 224, 247, 252 }, 148), new Vector2(700f, RowH * 0.5f), new Vector2(92f, 92f), this._0x30307812 != null ? this._0x30307812._0x38f9d754 : null, _0x3fba7806 ? _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.8f) : _0xe058d175.Alpha(_0xe058d175.GoldSoft, 0.85f));
        }
        else
        {
            _0xcecf7be6.Picture(_0xbe114190, _0x0e27adc8._0xb180c7d4(new byte[5] { 235, 206, 215, 200, 222 }, 187), new Vector2(700f, RowH * 0.5f), new Vector2(76f, 76f), this._0x30307812 != null ? this._0x30307812._0x1b3bad39 : null, _0x3fba7806 ? _0xe058d175.VioletSoft : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 1f));
        }

        RectTransform _0x0c8dcd14 = _0xcecf7be6.Node(_0xbe114190, _0x0e27adc8._0xb180c7d4(new byte[5] { 157, 187, 168, 170, 162 }, 201), new Vector2(880f, RowH * 0.5f), new Vector2(160f, 72f));
        _0xcecf7be6.Bar(_0x0c8dcd14, _0x0e27adc8._0xb180c7d4(new byte[9] { 227, 197, 214, 212, 220, 245, 216, 211, 206 }, 183), new Vector2(80f, 36f), new Vector2(160f, 72f), _0x3d570da4, _0x3fba7806 ? _0xe058d175.Alpha(_0xe058d175.RubyDeep, 1f) : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 1f), 36f);
        _0xcecf7be6.Plate(_0x0c8dcd14, _0x0e27adc8._0xb180c7d4(new byte[4] { 4, 33, 32, 45 }, 79), new Vector2(_0x3fba7806 ? 118f : 42f, 36f), new Vector2(60f, 60f), _0x3d570da4, _0x3fba7806 ? _0xe058d175.Gold : _0xe058d175.TextMuted, 30f);
        Button _0x95322e4c = _0xcecf7be6.Shade(_0xbe114190, _0x0e27adc8._0xb180c7d4(new byte[6] { 17, 44, 52, 11, 42, 55 }, 67), new Color(1f, 1f, 1f, 0.004f));
        int _0xf548773e = _0xe36a23ae;
        _0x95322e4c.onClick.AddListener(() => this._0x1202db28(_0xf548773e));
    }

    private _0x999838f3 _0xe4b0154c;
    private float _0xfd500681 = -100f;
    private void _0x1202db28(int _0xeec5092f)
    {
        if (_0xeec5092f == 0)
        {
            _0xaa0251af._0x82fe9f6a = !_0xaa0251af._0x82fe9f6a;
            if (_0xaa0251af._0x82fe9f6a)
                Handheld.Vibrate();
        }
        else if (_0xeec5092f == 1)
        {
            _0xaa0251af._0xa4fcbfc3 = !_0xaa0251af._0xa4fcbfc3;
        }
        else
        {
            _0xaa0251af._0x70f7e906 = !_0xaa0251af._0x70f7e906;
        }

        _0xaa0251af.Save();
        this._0x24a12a9a();
        if (this._0xe4b0154c != null)
            this._0xe4b0154c._0xd649f68e();
    }

    private const float GutterWidth = 72f;
    private const float RowW = 1000f;
    private RectTransform _0x7f5a6696;
    private void _0x24a12a9a()
    {
        if (this._0x7bab0b2a == null)
            return;
        for (int _0x56dd6f18 = this._0x7bab0b2a.childCount - 1; _0x56dd6f18 >= 2; _0x56dd6f18--)
        {
            Transform _0x233ca5c6 = this._0x7bab0b2a.GetChild(_0x56dd6f18);
            _0x233ca5c6.SetParent(null, false);
            Object.Destroy(_0x233ca5c6.gameObject);
        }

        Sprite _0x996fac24 = this._0x30307812 != null ? this._0x30307812._0xfae782aa : null;
        _0xcecf7be6.Label(this._0x7bab0b2a, _0x0e27adc8._0xb180c7d4(new byte[7] { 186, 140, 157, 161, 140, 136, 141 }, 233), Card(_0xcecf7be6.MidX, 2030f), new Vector2(680f, 90f), _0x0e27adc8._0xb180c7d4(new byte[8] { 66, 84, 69, 69, 88, 95, 86, 66 }, 17), 64f, 40f, _0xe058d175.Gold, this._0x2275efd6, TextAlignmentOptions.Center);
        this._0x1e22d493(0, 1870f, _0x0e27adc8._0xb180c7d4(new byte[7] { 131, 138, 155, 159, 130, 136, 152 }, 203), _0xaa0251af._0x82fe9f6a ? _0x0e27adc8._0xb180c7d4(new byte[2] { 162, 163 }, 237) : _0x0e27adc8._0xb180c7d4(new byte[3] { 181, 188, 188 }, 250), _0xaa0251af._0x82fe9f6a, _0x996fac24);
        this._0x1e22d493(1, 1870f - RowPitch, _0x0e27adc8._0xb180c7d4(new byte[10] { 237, 238, 247, 240, 158, 237, 238, 251, 251, 250 }, 190), _0xaa0251af._0xa4fcbfc3 ? _0x0e27adc8._0xb180c7d4(new byte[4] { 249, 254, 236, 235 }, 191) : _0x0e27adc8._0xb180c7d4(new byte[6] { 146, 147, 142, 145, 157, 144 }, 220), _0xaa0251af._0xa4fcbfc3, _0x996fac24);
        this._0x1e22d493(2, 1870f - (RowPitch * 2f), _0x0e27adc8._0xb180c7d4(new byte[14] { 155, 140, 141, 156, 138, 140, 233, 140, 143, 143, 140, 138, 157, 154 }, 201), _0xaa0251af._0x70f7e906 ? _0x0e27adc8._0xb180c7d4(new byte[2] { 72, 73 }, 7) : _0x0e27adc8._0xb180c7d4(new byte[3] { 98, 107, 107 }, 45), _0xaa0251af._0x70f7e906, _0x996fac24);
        bool _0x25678d29 = Time.unscaledTime - this._0xfd500681 < ArmWindow;
        this._0x75811299(1870f - (RowPitch * 3f), _0x25678d29, _0x996fac24);
        _0xcecf7be6.Label(this._0x7bab0b2a, _0x0e27adc8._0xb180c7d4(new byte[9] { 219, 237, 252, 206, 231, 231, 252, 237, 250 }, 136), Card(_0xcecf7be6.MidX, 1130f), new Vector2(960f, 120f), _0x0e27adc8._0xb180c7d4(new byte[63] { 198, 207, 210, 160, 197, 206, 212, 197, 210, 212, 193, 201, 206, 205, 197, 206, 212, 160, 207, 206, 204, 217, 138, 198, 201, 195, 212, 201, 207, 206, 193, 204, 160, 195, 207, 201, 206, 211, 172, 160, 206, 207, 160, 208, 213, 210, 195, 200, 193, 211, 197, 211, 172, 160, 206, 207, 160, 208, 210, 201, 218, 197, 211 }, 128), 30f, 28f, _0xe058d175.TextMuted, this._0x2275efd6, TextAlignmentOptions.Center);
        Button _0x938f4489 = _0xcecf7be6.Cta(this._0x7bab0b2a, _0x0e27adc8._0xb180c7d4(new byte[7] { 13, 59, 42, 26, 49, 48, 59 }, 94), Card(_0xcecf7be6.MidX, 970f), new Vector2(420f, 140f), _0x996fac24, _0xe058d175.Ruby, _0x0e27adc8._0xb180c7d4(new byte[4] { 132, 143, 142, 133 }, 192), 44f, 30f, _0xe058d175.TextPrimary, this._0x2275efd6, 30f);
        _0x938f4489.onClick.AddListener(() => this._0xf71bfa76());
        Button _0x03251466 = _0xcecf7be6.IconCta(this._0x7bab0b2a, _0x0e27adc8._0xb180c7d4(new byte[8] { 44, 26, 11, 60, 19, 16, 12, 26 }, 127), Card(ClosePanelX, ClosePanelY), new Vector2(132f, 132f), _0x996fac24, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.95f), this._0x30307812 != null ? this._0x30307812._0x028932ee : null, _0xe058d175.Gold, 30f);
        _0x03251466.onClick.AddListener(() => this._0xf71bfa76());
    }

    /// <summary>Panel y of the close glyph.</summary>
    public const float ClosePanelY = 2040f;
    private const float CardY = 1500f;
    private const float GutterCentre = 92f;
    private RectTransform _0x7bab0b2a;
    /// <summary>Seconds the destructive row stays armed.</summary>
    private const float ArmWindow = 4f;
    /// <summary>Builds the sheet once, switched off.</summary>
    public void _0x9a6e1938(RectTransform _0x07950ebc, _0x30d693a6 _0x28494d59, TMP_FontAsset _0x6f42b3fd, _0x999838f3 _0x584bc2e8)
    {
        this._0x7f5a6696 = _0x07950ebc;
        this._0x30307812 = _0x28494d59;
        this._0x2275efd6 = _0x6f42b3fd;
        this._0xe4b0154c = _0x584bc2e8;
        Button _0x5f2f186b = _0xcecf7be6.Shade(_0x07950ebc, _0x0e27adc8._0xb180c7d4(new byte[13] { 33, 23, 6, 6, 27, 28, 21, 1, 33, 26, 19, 22, 23 }, 114), _0xe058d175.Alpha(_0xe058d175.Abyss, 0.82f));
        _0x5f2f186b.onClick.AddListener(() => this._0xf71bfa76());
        this._0x7bab0b2a = _0xcecf7be6.Frame(_0x07950ebc, _0x0e27adc8._0xb180c7d4(new byte[12] { 52, 2, 19, 19, 14, 9, 0, 20, 36, 6, 21, 3 }, 103), new Vector2(_0xcecf7be6.MidX, CardY), new Vector2(CardW, CardH), _0x28494d59 != null ? _0x28494d59._0xfae782aa : null, _0xe058d175.Gold, _0xe058d175.Alpha(_0xe058d175.Surface, 0.99f), 34f, 7f);
        this._0x24a12a9a();
        _0x07950ebc.gameObject.SetActive(false);
    }

    private const float RowH = 150f;
    private const float TextLeft = 174f;
    private const float CardBottom = 880f;
    private const float RowPitch = 170f;
}

internal static class _0x0e27adc8
{
    internal static string _0xb180c7d4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}