using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The GAME RULES sheet in the lobby: how a round is played, and what each gem pays.
///
/// It carries the three onboarding lines rather than a first-run overlay. A card thrown over
/// the lobby on first launch would cover the very first review frame, so the album would open
/// on a modal instead of on the game; behind a button the same three lines are one tap away
/// and never in the way.
///
/// Inside every paytable row the gem sits in its own gutter and the text column starts 46
/// units clear of it, so a glyph can never be drawn over a letter - an overlap that no
/// validator sees, because left alignment is honoured inside a rect that is itself in the
/// wrong place (C.25).
/// </summary>
public sealed class _0x1ea45921 : MonoBehaviour
{
    private const float RowH = 110f;
    /// <summary>One paytable line: the gem in its gutter, then name and payouts beside it.</summary>
    private void _0x472fa718(int _0xccdc0cfb, Sprite _0x2c7c499e)
    {
        _0x65cc6a73 _0xab5ad97e = (_0x65cc6a73)_0xccdc0cfb;
        float _0xbd32d8e7 = FirstRowY - (_0xccdc0cfb * RowPitch);
        RectTransform _0xf0294c57 = _0xcecf7be6.Node(this._0x80704879, _0x75da5fe6._0x94b349e8(new byte[6] { 242, 195, 219, 240, 205, 213 }, 162), Card(_0xcecf7be6.MidX, _0xbd32d8e7), new Vector2(RowW, RowH));
        _0xcecf7be6.Plate(_0xf0294c57, _0x75da5fe6._0x94b349e8(new byte[8] { 164, 153, 129, 166, 154, 151, 130, 147 }, 246), new Vector2(RowW * 0.5f, RowH * 0.5f), new Vector2(RowW, RowH), _0x2c7c499e, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, _0xccdc0cfb % 2 == 0 ? 0.55f : 0.3f), 20f);
        _0xcecf7be6.Picture(_0xf0294c57, _0x75da5fe6._0x94b349e8(new byte[6] { 109, 80, 72, 120, 90, 82 }, 63), new Vector2(GutterCentre, RowH * 0.5f), new Vector2(GutterWidth - 18f, GutterWidth - 18f), this._0x0ef86e51 != null ? this._0x0ef86e51._0x2b16b7b0(_0xab5ad97e) : null, _0xe058d175.White);
        // 155 .. 455, then 475 .. 935: the two text bands and the gutter never overlap.
        _0xcecf7be6.Label(_0xf0294c57, _0x75da5fe6._0x94b349e8(new byte[7] { 166, 155, 131, 186, 149, 153, 145 }, 244), new Vector2(TextLeft + 150f, RowH * 0.5f), new Vector2(300f, 60f), _0xbb4bed3e.NameOf(_0xab5ad97e), 32f, 28f, _0xab5ad97e == _0x65cc6a73.Joker ? _0xe058d175.Gold : _0xe058d175.TextPrimary, this._0x9fb3108d, TextAlignmentOptions.Left);
        _0xcecf7be6.Label(_0xf0294c57, _0x75da5fe6._0x94b349e8(new byte[7] { 195, 254, 230, 193, 240, 232, 226 }, 145), new Vector2(705f, RowH * 0.5f), new Vector2(460f, 60f), _0xbb4bed3e.Row(_0xab5ad97e), 30f, 28f, _0xe058d175.TextSecondary, this._0x9fb3108d, TextAlignmentOptions.Right);
    }

    /// <summary>Panel centre of the close glyph, used by the screenshot scenario.</summary>
    public const float ClosePanelX = 1061f;
    private const float CardBottom = 700f;
    private const float CardH = 1500f;
    private const float CardLeft = 91f;
    private const float CardW = 1060f;
    private TMP_FontAsset _0x9fb3108d;
    private _0x999838f3 _0x38424495;
    /// <summary>Gutter's right edge plus a 30-unit gap: 70 + 55 + 30.</summary>
    private const float TextLeft = 155f;
    /// <summary>Closes the sheet and hands the lobby back.</summary>
    public void _0x86f2994b()
    {
        if (this._0xef725819 == null)
            return;
        this._0xef725819.gameObject.SetActive(false);
        if (this._0x38424495 != null)
            this._0x38424495._0x8dc68993();
    }

    private const float RowPitch = 125f;
    private RectTransform _0x80704879;
    private const float RowW = 960f;
    private void _0xcfe529a4()
    {
        if (this._0x80704879 == null)
            return;
        Sprite _0xcc5d06ee = this._0x0ef86e51 != null ? this._0x0ef86e51._0xfae782aa : null;
        _0xcecf7be6.Label(this._0x80704879, _0x75da5fe6._0x94b349e8(new byte[9] { 251, 220, 197, 204, 218, 225, 204, 200, 205 }, 169), Card(_0xcecf7be6.MidX, 2120f), new Vector2(760f, 90f), _0x75da5fe6._0x94b349e8(new byte[10] { 24, 30, 18, 26, 127, 13, 10, 19, 26, 12 }, 95), 64f, 40f, _0xe058d175.Gold, this._0x9fb3108d, TextAlignmentOptions.Center);
        // Three lines, broken by hand. The engine never decides where a line ends (C.10).
        _0xcecf7be6.Label(this._0x80704879, _0x75da5fe6._0x94b349e8(new byte[8] { 241, 214, 207, 198, 208, 235, 204, 212 }, 163), Card(_0xcecf7be6.MidX, 1955f), new Vector2(940f, 190f), _0x75da5fe6._0x94b349e8(new byte[117] { 48, 37, 52, 68, 55, 52, 45, 42, 68, 48, 43, 68, 52, 40, 37, 61, 68, 37, 68, 54, 43, 49, 42, 32, 110, 41, 37, 48, 39, 44, 68, 87, 68, 43, 54, 68, 41, 43, 54, 33, 68, 34, 54, 43, 41, 68, 48, 44, 33, 68, 40, 33, 34, 48, 68, 43, 42, 68, 37, 68, 40, 45, 42, 33, 110, 48, 44, 33, 68, 46, 43, 47, 33, 54, 68, 55, 48, 37, 42, 32, 55, 68, 45, 42, 68, 34, 43, 54, 68, 37, 42, 61, 68, 35, 33, 41, 68, 37, 42, 32, 68, 32, 43, 49, 38, 40, 33, 55, 68, 48, 44, 33, 68, 40, 45, 42, 33 }, 100), 34f, 28f, _0xe058d175.TextSecondary, this._0x9fb3108d, TextAlignmentOptions.Center);
        for (int _0x57f4b9dc = 0; _0x57f4b9dc < _0xaa0251af.AlbumSize; _0x57f4b9dc++)
            this._0x472fa718(_0x57f4b9dc, _0xcc5d06ee);
        _0xcecf7be6.Label(this._0x80704879, _0x75da5fe6._0x94b349e8(new byte[9] { 122, 93, 68, 77, 91, 110, 71, 71, 92 }, 40), Card(_0xcecf7be6.MidX, 790f), new Vector2(940f, 100f), _0x75da5fe6._0x94b349e8(new byte[77] { 152, 129, 231, 232, 249, 228, 229, 129, 237, 232, 239, 228, 242, 129, 140, 129, 233, 232, 230, 233, 228, 242, 245, 129, 246, 232, 239, 129, 241, 228, 243, 129, 237, 232, 239, 228, 171, 231, 232, 226, 245, 232, 238, 239, 224, 237, 129, 226, 238, 232, 239, 242, 141, 129, 239, 238, 129, 241, 244, 243, 226, 233, 224, 242, 228, 242, 141, 129, 239, 238, 129, 241, 243, 232, 251, 228, 242 }, 161), 30f, 28f, _0xe058d175.TextMuted, this._0x9fb3108d, TextAlignmentOptions.Center);
        Button _0xa15b69b0 = _0xcecf7be6.IconCta(this._0x80704879, _0x75da5fe6._0x94b349e8(new byte[10] { 61, 26, 3, 10, 28, 44, 3, 0, 28, 10 }, 111), Card(ClosePanelX, ClosePanelY), new Vector2(132f, 132f), _0xcc5d06ee, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.96f), this._0x0ef86e51 != null ? this._0x0ef86e51._0x028932ee : null, _0xe058d175.Gold, 26f);
        _0xa15b69b0.onClick.AddListener(() => this._0x86f2994b());
    }

    private const float GutterWidth = 110f;
    /// <summary>Builds the sheet once, switched off.</summary>
    public void _0x62b3b3eb(RectTransform _0xb04767e2, _0x30d693a6 _0xa381e638, TMP_FontAsset _0x74db4f28, _0x999838f3 _0x1d7e7803)
    {
        if (_0xb04767e2 == null)
            return;
        this._0xef725819 = _0xb04767e2;
        this._0x0ef86e51 = _0xa381e638;
        this._0x9fb3108d = _0x74db4f28;
        this._0x38424495 = _0x1d7e7803;
        Button _0xd1e38c1b = _0xcecf7be6.Shade(_0xb04767e2, _0x75da5fe6._0x94b349e8(new byte[10] { 88, 127, 102, 111, 121, 89, 98, 107, 110, 111 }, 10), _0xe058d175.Alpha(_0xe058d175.Abyss, 0.82f));
        _0xd1e38c1b.onClick.AddListener(() => this._0x86f2994b());
        Sprite _0x0f954d2a = _0xa381e638 != null ? _0xa381e638._0xfae782aa : null;
        this._0x80704879 = _0xcecf7be6.Frame(_0xb04767e2, _0x75da5fe6._0x94b349e8(new byte[9] { 251, 220, 197, 204, 218, 234, 200, 219, 205 }, 169), new Vector2(_0xcecf7be6.MidX, CardY), new Vector2(CardW, CardH), _0x0f954d2a, _0xe058d175.Gold, _0xe058d175.Alpha(_0xe058d175.Surface, 0.99f), 34f, 7f);
        this._0xcfe529a4();
        _0xb04767e2.gameObject.SetActive(false);
    }

    /// <summary>Centre of the gem gutter inside a paytable row.</summary>
    private const float GutterCentre = 70f;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private const float CardY = 1450f;
    private RectTransform _0xef725819;
    /// <summary>Opens the sheet.</summary>
    public void _0x8c61fc16()
    {
        if (this._0xef725819 == null)
            return;
        this._0xef725819.gameObject.SetActive(true);
        this._0x80704879.localScale = new Vector3(0.9f, 0.9f, 1f);
        this._0x80704879.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(this._0x80704879.gameObject);
    }

    private _0x30d693a6 _0x0ef86e51;
    /// <summary>Panel coordinates to card-local ones, so the layout table reads in one system.</summary>
    private static Vector2 Card(float _0xe23fa2ad, float _0x9379d366)
    {
        return new Vector2(_0xe23fa2ad - CardLeft, _0x9379d366 - CardBottom);
    }

    private const float FirstRowY = 1790f;
    /// <summary>Panel y of the close glyph.</summary>
    public const float ClosePanelY = 2130f;
}

internal static class _0x75da5fe6
{
    internal static string _0x94b349e8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}