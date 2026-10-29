using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Everything around the reels: the top bar with the balance, the mission ticker, the control
/// hint, the last-win readout, the bet row and SPIN.
///
/// All of it is OUR OWN objects. The template ships a HUD drawn for a different game
/// (LEFT_BUTTON, RIGHT_BUTTON, a 00:00 timer, ScoreText, MoneyContainer) and stage 5da
/// switches those off; hanging our content on them would ship it invisible (C.2). Nothing here
/// references a template placeholder and nothing here is addressed by name.
///
/// Every band below occupies its own horizontal strip, and inside the top bar and the ticker
/// the icon gutter and the text column never share an x-range (C.25).
/// </summary>
public sealed class _0x49e7e897 : MonoBehaviour
{
    /// <summary>Reads a grouped integer back, so a counter can animate from what it shows.</summary>
    private static int ReadNumber(string _0x5866f30f)
    {
        if (string.IsNullOrEmpty(_0x5866f30f))
            return 0;
        int _0xf3a406eb = 0;
        for (int _0x5021160d = 0; _0x5021160d < _0x5866f30f.Length; _0x5021160d++)
        {
            char _0xc6c7cdba = _0x5866f30f[_0x5021160d];
            if (_0xc6c7cdba >= '0' && _0xc6c7cdba <= '9')
                _0xf3a406eb = (_0xf3a406eb * 10) + (_0xc6c7cdba - '0');
        }

        return _0xf3a406eb;
    }

    private void _0xfda1f327(RectTransform _0xb7a8bfbe, Sprite _0x83887485)
    {
        this._0xd0c3bb04 = _0xcecf7be6.Cta(_0xb7a8bfbe, _0x3c832e27._0x1a7508bc(new byte[10] { 138, 169, 176, 183, 155, 172, 173, 173, 182, 183 }, 217), new Vector2(_0xcecf7be6.MidX, SpinPanelY), new Vector2(SpinW, SpinH), _0x83887485, _0xe058d175.Ruby, _0x3c832e27._0x1a7508bc(new byte[4] { 184, 187, 162, 165 }, 235), 68f, 36f, _0xe058d175.TextPrimary, this._0x3417f0e5, 34f);
        this._0xd0c3bb04.onClick.AddListener(() => this._0xf271a539());
        this._0x51375671 = _0xcecf7be6.CaptionOf(this._0xd0c3bb04);
    }

    private const float SpinH = 180f;
    private const float TickerY = 2350f;
    /// <summary>Panel centre of SPIN. The screenshot scenario taps exactly here.</summary>
    public const float SpinPanelY = 530f;
    /// <summary>Centre of the ticker's chip gutter, in ticker-local units.</summary>
    private const float GutterCentre = 70f;
    private void _0x370eab24()
    {
        if (this._0xbd619eea != null)
            this._0xbd619eea._0xa7cdec5e(1);
    }

    private void _0x9b240e86(RectTransform _0x38075b73, Sprite _0x89a73d68)
    {
        this._0xf4bf2648 = _0xcecf7be6.Node(_0x38075b73, _0x3c832e27._0x1a7508bc(new byte[10] { 62, 19, 1, 6, 37, 27, 28, 32, 29, 5 }, 114), new Vector2(_0xcecf7be6.MidX, LastWinY), new Vector2(1060f, 110f));
        this._0xddb7a49c = _0xcecf7be6.Label(this._0xf4bf2648, _0x3c832e27._0x1a7508bc(new byte[12] { 136, 165, 183, 176, 147, 173, 170, 146, 165, 168, 177, 161 }, 196), new Vector2(530f, 55f), new Vector2(1040f, 86f), _0x3c832e27._0x1a7508bc(new byte[21] { 111, 115, 126, 124, 122, 31, 126, 31, 108, 111, 118, 113, 31, 107, 112, 31, 125, 122, 120, 118, 113 }, 63), 44f, 28f, _0xe058d175.Gold, this._0x3417f0e5, TextAlignmentOptions.Center);
        // The gesture and its result, in the game scene and visible in the review frame (C.6).
        _0xcecf7be6.Label(_0x38075b73, _0x3c832e27._0x1a7508bc(new byte[11] { 196, 232, 233, 243, 245, 232, 235, 207, 238, 233, 243 }, 135), new Vector2(_0xcecf7be6.MidX, HintY), new Vector2(1060f, 96f), _0x3c832e27._0x1a7508bc(new byte[58] { 10, 31, 14, 126, 13, 14, 23, 16, 126, 10, 17, 126, 14, 18, 31, 7, 126, 31, 126, 12, 17, 11, 16, 26, 84, 10, 31, 14, 126, 10, 22, 27, 126, 12, 27, 27, 18, 13, 126, 10, 17, 126, 13, 10, 17, 14, 126, 10, 22, 27, 19, 126, 13, 17, 17, 16, 27, 12 }, 94), 32f, 28f, _0xe058d175.TextSecondary, this._0x3417f0e5, TextAlignmentOptions.Center);
    }

    private const float BarY = 2540f;
    private const float BarW = 1140f;
    private const float LastWinY = 1120f;
    private const float SpinW = 620f;
    /// <summary>The result line under the board. Gold on a win, muted when nothing paid.</summary>
    public void _0x3ef9f96c(string _0x9428cb4e, bool _0xa87b5018)
    {
        if (this._0xddb7a49c == null)
            return;
        this._0xddb7a49c.text = _0x9428cb4e;
        this._0xddb7a49c.color = _0xa87b5018 ? _0xe058d175.Gold : _0xe058d175.TextSecondary;
        _0x77b5335c.ApplyOutline(this._0xddb7a49c, this._0xddb7a49c.color);
        if (!_0xa87b5018 || _0xaa0251af._0x70f7e906 || this._0xf4bf2648 == null)
            return;
        this._0xf4bf2648.DOPunchScale(Vector3.one * 0.1f, 0.4f, 7, 0.6f).SetLink(this._0xf4bf2648.gameObject);
    }

    private void _0x4b80a2f8(RectTransform _0x56c2f501)
    {
        _0xcecf7be6.Label(_0x56c2f501, _0x3c832e27._0x1a7508bc(new byte[9] { 101, 66, 91, 82, 68, 121, 88, 67, 82 }, 55), new Vector2(_0xcecf7be6.MidX, 340f), new Vector2(1120f, 56f), _0x3c832e27._0x1a7508bc(new byte[41] { 28, 5, 105, 108, 107, 96, 118, 5, 8, 5, 113, 109, 96, 5, 111, 106, 110, 96, 119, 5, 118, 113, 100, 107, 97, 118, 5, 108, 107, 5, 99, 106, 119, 5, 100, 107, 124, 5, 98, 96, 104 }, 37), 30f, 28f, _0xe058d175.TextSecondary, this._0x3417f0e5, TextAlignmentOptions.Center);
        _0xcecf7be6.Label(_0x56c2f501, _0x3c832e27._0x1a7508bc(new byte[8] { 180, 146, 158, 150, 189, 156, 135, 150 }, 243), new Vector2(_0xcecf7be6.MidX, 250f), new Vector2(1120f, 56f), _0x3c832e27._0x1a7508bc(new byte[49] { 252, 245, 232, 154, 255, 244, 238, 255, 232, 238, 251, 243, 244, 247, 255, 244, 238, 154, 245, 244, 246, 227, 154, 151, 154, 244, 245, 154, 232, 255, 251, 246, 154, 247, 245, 244, 255, 227, 150, 154, 244, 245, 154, 234, 232, 243, 224, 255, 233 }, 186), 30f, 28f, _0xe058d175.TextMuted, this._0x3417f0e5, TextAlignmentOptions.Center);
    }

    /// <summary>Builds the whole HUD into the panel body.</summary>
    public void _0x399e9c1d(RectTransform _0x49399783, _0x30d693a6 _0x7297ea48, TMP_FontAsset _0x9d4a7891, _0x097d9957 _0x3bd654dd)
    {
        if (_0x49399783 == null)
            return;
        this._0x88141842 = _0x7297ea48;
        this._0x3417f0e5 = _0x9d4a7891;
        this._0xbd619eea = _0x3bd654dd;
        Sprite _0x461276c6 = _0x7297ea48 != null ? _0x7297ea48._0xfae782aa : null;
        this._0xa4a59b42(_0x49399783, _0x461276c6);
        this._0xc79e7d21(_0x49399783, _0x461276c6);
        this._0x9b240e86(_0x49399783, _0x461276c6);
        this._0x3bf96e3c(_0x49399783, _0x461276c6);
        this._0xfda1f327(_0x49399783, _0x461276c6);
        this._0x4b80a2f8(_0x49399783);
    }

    private TextMeshProUGUI _0x15cbcc94;
    /// <summary>
    /// SPIN reads SPINNING and stops taking taps while the reels move, so the player can see
    /// that the machine is busy rather than that the button is broken.
    /// </summary>
    public void _0x11fca156(bool _0xcc1f854a)
    {
        if (this._0xd0c3bb04 != null)
            this._0xd0c3bb04.interactable = !_0xcc1f854a;
        if (this._0x51375671 != null)
            this._0x51375671.text = _0xcc1f854a ? _0x3c832e27._0x1a7508bc(new byte[8] { 238, 237, 244, 243, 243, 244, 243, 250 }, 189) : _0x3c832e27._0x1a7508bc(new byte[4] { 226, 225, 248, 255 }, 177);
    }

    private void _0xc79e7d21(RectTransform _0x1515f36d, Sprite _0x05160de8)
    {
        RectTransform _0x781d8d9e = _0xcecf7be6.Frame(_0x1515f36d, _0x3c832e27._0x1a7508bc(new byte[13] { 172, 136, 146, 146, 136, 142, 143, 181, 136, 130, 138, 132, 147 }, 225), new Vector2(_0xcecf7be6.MidX, TickerY), new Vector2(TickerW, TickerH), _0x05160de8, _0xe058d175.Alpha(_0xe058d175.Violet, 0.6f), _0xe058d175.Alpha(_0xe058d175.Surface, 0.94f), 24f, 4f);
        _0xcecf7be6.Picture(_0x781d8d9e, _0x3c832e27._0x1a7508bc(new byte[10] { 214, 235, 225, 233, 231, 240, 193, 234, 235, 242 }, 130), new Vector2(GutterCentre, TickerH * 0.5f), new Vector2(GutterWidth, GutterWidth), this._0x88141842 != null ? this._0x88141842._0xe39fd6d8 : null, _0xe058d175.White);
        // 152 .. 672: starts 46 right of the gutter's edge, ends 58 left of the meter.
        this._0x15cbcc94 = _0xcecf7be6.Label(_0x781d8d9e, _0x3c832e27._0x1a7508bc(new byte[11] { 86, 107, 97, 105, 103, 112, 86, 107, 118, 110, 103 }, 2), new Vector2(TextLeft + 260f, TickerH * 0.5f), new Vector2(520f, 64f), _0x3c832e27._0x1a7508bc(new byte[19] { 186, 187, 212, 181, 183, 160, 189, 162, 177, 212, 187, 182, 190, 177, 183, 160, 189, 162, 177 }, 244), 32f, 28f, _0xe058d175.TextPrimary, this._0x3417f0e5, TextAlignmentOptions.Left);
        this._0x7e09931b = _0xcecf7be6.Meter(_0x781d8d9e, _0x3c832e27._0x1a7508bc(new byte[11] { 40, 21, 31, 23, 25, 14, 49, 25, 8, 25, 14 }, 124), new Vector2(880f, TickerH * 0.5f), new Vector2(MeterW, 18f), _0x05160de8, _0xe058d175.Alpha(_0xe058d175.Abyss, 0.9f), _0xe058d175.Gold, 0f);
    }

    private void _0xf271a539()
    {
        if (this._0xbd619eea != null)
            this._0xbd619eea._0x2a6a7868();
    }

    private const float HintY = 980f;
    private void _0x0f7d5c62()
    {
        if (this._0xbd619eea != null)
            this._0xbd619eea._0xa7cdec5e(-1);
    }

    /// <summary>The top bar, handed to <see cref = "GameNavButtons"/> for Back and Pause.</summary>
    public RectTransform _0x42e3e159 { get; private set; }

    private Button _0xd0c3bb04;
    private Button _0xa562b4c8;
    private void _0xa4a59b42(RectTransform _0xdad52005, Sprite _0xabf83c7c)
    {
        RectTransform _0xe4e03bac = _0xcecf7be6.Frame(_0xdad52005, _0x3c832e27._0x1a7508bc(new byte[6] { 148, 175, 176, 130, 161, 178 }, 192), new Vector2(_0xcecf7be6.MidX, BarY), new Vector2(BarW, BarH), _0xabf83c7c, _0xe058d175.Alpha(_0xe058d175.Gold, 0.85f), _0xe058d175.Alpha(_0xe058d175.Surface, 0.97f), 30f, 5f);
        this._0x42e3e159 = _0xe4e03bac;
        // Back occupies 20..152 and Pause 988..1120, so the balance band is 368..810 and the
        // two never touch (C.25).
        this._0x973bd040 = _0xcecf7be6.Node(_0xe4e03bac, _0x3c832e27._0x1a7508bc(new byte[12] { 243, 208, 221, 208, 223, 210, 212, 246, 195, 222, 196, 193 }, 177), new Vector2(590f, BarH * 0.5f), new Vector2(460f, 96f));
        _0xcecf7be6.Picture(this._0x973bd040, _0x3c832e27._0x1a7508bc(new byte[11] { 175, 140, 129, 140, 131, 142, 136, 174, 130, 132, 131 }, 237), new Vector2(42f, 48f), new Vector2(64f, 64f), this._0x88141842 != null ? this._0x88141842._0x6cba7c24 : null, _0xe058d175.White);
        this._0xa3e84b44 = _0xcecf7be6.Label(this._0x973bd040, _0x3c832e27._0x1a7508bc(new byte[12] { 157, 190, 179, 190, 177, 188, 186, 137, 190, 179, 170, 186 }, 223), new Vector2(270f, 48f), new Vector2(340f, 72f), _0x3c832e27._0x1a7508bc(new byte[1] { 34 }, 18), 46f, 28f, _0xe058d175.Gold, this._0x3417f0e5, TextAlignmentOptions.Left);
    }

    private RectTransform _0x973bd040;
    private TextMeshProUGUI _0x0440fc6a;
    private void _0x3bf96e3c(RectTransform _0x6e6eab7e, Sprite _0x75c170e5)
    {
        RectTransform _0xa708db34 = _0xcecf7be6.Node(_0x6e6eab7e, _0x3c832e27._0x1a7508bc(new byte[6] { 128, 167, 182, 144, 173, 181 }, 194), new Vector2(_0xcecf7be6.MidX, BetRowY), new Vector2(BetRowW, BetRowH));
        this._0xa562b4c8 = _0xcecf7be6.Cta(_0xa708db34, _0x3c832e27._0x1a7508bc(new byte[7] { 179, 148, 133, 181, 158, 134, 159 }, 241), new Vector2(90f, BetRowH * 0.5f), new Vector2(140f, 120f), this._0x88141842 != null ? this._0x88141842._0xfae782aa : null, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.96f), _0x3c832e27._0x1a7508bc(new byte[1] { 132 }, 169), 56f, 32f, _0xe058d175.TextPrimary, this._0x3417f0e5, 24f);
        this._0xa562b4c8.onClick.AddListener(() => this._0x0f7d5c62());
        RectTransform _0xd4ad78af = _0xcecf7be6.Frame(_0xa708db34, _0x3c832e27._0x1a7508bc(new byte[7] { 158, 185, 168, 159, 180, 181, 172 }, 220), new Vector2(540f, BetRowH * 0.5f), new Vector2(420f, 120f), this._0x88141842 != null ? this._0x88141842._0xfae782aa : null, _0xe058d175.Alpha(_0xe058d175.Gold, 0.8f), _0xe058d175.Alpha(_0xe058d175.Ground, 0.96f), 26f, 4f);
        _0xcecf7be6.Label(_0xd4ad78af, _0x3c832e27._0x1a7508bc(new byte[10] { 168, 143, 158, 169, 139, 154, 158, 131, 133, 132 }, 234), new Vector2(210f, 86f), new Vector2(380f, 40f), _0x3c832e27._0x1a7508bc(new byte[3] { 59, 60, 45 }, 121), 28f, 28f, _0xe058d175.TextMuted, this._0x3417f0e5, TextAlignmentOptions.Center);
        this._0x0440fc6a = _0xcecf7be6.Label(_0xd4ad78af, _0x3c832e27._0x1a7508bc(new byte[8] { 68, 99, 114, 80, 103, 106, 115, 99 }, 6), new Vector2(210f, 44f), new Vector2(380f, 56f), _0x3c832e27._0x1a7508bc(new byte[2] { 81, 80 }, 96), 44f, 28f, _0xe058d175.Gold, this._0x3417f0e5, TextAlignmentOptions.Center);
        this._0x6c12255b = _0xcecf7be6.Cta(_0xa708db34, _0x3c832e27._0x1a7508bc(new byte[5] { 162, 133, 148, 181, 144 }, 224), new Vector2(990f, BetRowH * 0.5f), new Vector2(140f, 120f), this._0x88141842 != null ? this._0x88141842._0xfae782aa : null, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.96f), _0x3c832e27._0x1a7508bc(new byte[1] { 8 }, 35), 56f, 32f, _0xe058d175.TextPrimary, this._0x3417f0e5, 24f);
        this._0x6c12255b.onClick.AddListener(() => this._0x370eab24());
    }

    private Image _0x7e09931b;
    private const float TickerH = 104f;
    private const float TickerW = 1060f;
    private const float GutterWidth = 72f;
    private const float BetRowY = 790f;
    /// <summary>Counts the balance up to its new value and punches the pill.</summary>
    public void _0x1cefc27c(int _0xe13d6148, bool _0x286ccc73)
    {
        if (this._0xa3e84b44 == null)
            return;
        if (!_0x286ccc73 || _0xaa0251af._0x70f7e906)
        {
            this._0xa3e84b44.text = _0x999838f3.Money(_0xe13d6148);
            return;
        }

        TextMeshProUGUI _0xd1ca8c5c = this._0xa3e84b44;
        int _0x6f972e6a = ReadNumber(_0xd1ca8c5c.text);
        DOVirtual.Float(_0x6f972e6a, _0xe13d6148, 0.6f, _0xada32e78 => _0xd1ca8c5c.text = _0x999838f3.Money(Mathf.RoundToInt(_0xada32e78))).SetEase(Ease.OutCubic).SetLink(_0xd1ca8c5c.gameObject);
        if (this._0x973bd040 != null)
            this._0x973bd040.DOPunchScale(Vector3.one * 0.08f, 0.3f, 6, 0.6f).SetLink(this._0x973bd040.gameObject);
    }

    private const float BarH = 140f;
    private _0x30d693a6 _0x88141842;
    private const float BetRowH = 140f;
    /// <summary>The active objective and how far along it is.</summary>
    public void _0x3f26d1ba(string _0xb96e09de, float _0x5017fe50)
    {
        if (this._0x15cbcc94 != null)
            this._0x15cbcc94.text = _0xb96e09de;
        _0xcecf7be6.SetMeter(this._0x7e09931b, MeterW, _0x5017fe50);
    }

    private TextMeshProUGUI _0x51375671;
    private TextMeshProUGUI _0xa3e84b44;
    private Button _0x6c12255b;
    private TMP_FontAsset _0x3417f0e5;
    private _0x097d9957 _0xbd619eea;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private const float BetRowW = 1080f;
    /// <summary>Width of the ticker's progress meter, needed to resize its fill.</summary>
    private const float MeterW = 300f;
    /// <summary>Writes the staked amount and greys the arrows at the ends of the ladder.</summary>
    public void _0x224302ca(int _0x2abc1d55)
    {
        if (this._0x0440fc6a != null)
            this._0x0440fc6a.text = _0xaa0251af.BetAt(_0x2abc1d55).ToString();
        if (this._0xa562b4c8 != null)
            this._0xa562b4c8.interactable = _0x2abc1d55 > 0;
        if (this._0x6c12255b != null)
            this._0x6c12255b.interactable = _0x2abc1d55 < _0xaa0251af._0xcb593797 - 1;
    }

    /// <summary>Right edge of the gutter plus a 46-unit gap: where text may begin.</summary>
    private const float TextLeft = 152f;
    private TextMeshProUGUI _0xddb7a49c;
    private RectTransform _0xf4bf2648;
}

internal static class _0x3c832e27
{
    internal static string _0x1a7508bc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}