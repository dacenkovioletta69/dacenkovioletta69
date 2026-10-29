using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The collection album: eight symbol cards, five shards each, and the rooms the completed
/// sets open. A modal sheet over the lobby, built and toggled by
/// <see cref = "LobbyStageDirector"/>.
///
/// C.25 applies inside a card as well as across a row: the gem portrait owns a gutter band and
/// the card's text starts clear of it, so a long symbol name can never run under the art.
/// </summary>
public sealed class _0x952fe249 : MonoBehaviour
{
    private _0x30d693a6 _0x1f8e69a4;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    /// <summary>Builds the sheet once, switched off.</summary>
    public void _0x1ff48388(RectTransform _0xd46e763a, _0x30d693a6 _0x5d6145f2, TMP_FontAsset _0xc24ab7bd, _0x999838f3 _0x7277c9a9)
    {
        this._0xf267dbfd = _0xd46e763a;
        this._0x1f8e69a4 = _0x5d6145f2;
        this._0xde6fa8d8 = _0xc24ab7bd;
        this._0x4bca8768 = _0x7277c9a9;
        Button _0xac40b048 = _0xcecf7be6.Shade(_0xd46e763a, _0x9cfe9747._0x3415b373(new byte[10] { 96, 77, 67, 84, 76, 114, 73, 64, 69, 68 }, 33), _0xe058d175.Alpha(_0xe058d175.Abyss, 0.82f));
        _0xac40b048.onClick.AddListener(() => this._0xa6108861());
        this._0xe12ffcfb = _0xcecf7be6.Frame(_0xd46e763a, _0x9cfe9747._0x3415b373(new byte[9] { 221, 240, 254, 233, 241, 223, 253, 238, 248 }, 156), new Vector2(_0xcecf7be6.MidX, CardY), new Vector2(CardW, CardH), _0x5d6145f2 != null ? _0x5d6145f2._0xfae782aa : null, _0xe058d175.Gold, _0xe058d175.Alpha(_0xe058d175.Surface, 0.99f), 34f, 7f);
        this._0x22fd8676();
        _0xd46e763a.gameObject.SetActive(false);
    }

    private const float TileGapX = 20f;
    private void _0xafda7c3e(string _0x321d6f2b)
    {
        if (this._0xe12ffcfb == null)
            return;
        RectTransform _0xc87991dc = _0xcecf7be6.Frame(this._0xe12ffcfb, _0x9cfe9747._0x3415b373(new byte[11] { 111, 66, 76, 91, 67, 124, 71, 76, 76, 65, 64 }, 46), Card(_0xcecf7be6.MidX, 1430f), new Vector2(940f, 130f), this._0x1f8e69a4 != null ? this._0x1f8e69a4._0xfae782aa : null, _0xe058d175.Gold, _0xe058d175.Alpha(_0xe058d175.RubyDeep, 0.97f), 28f, 6f);
        _0xcecf7be6.Label(_0xc87991dc, _0x9cfe9747._0x3415b373(new byte[10] { 104, 83, 88, 88, 85, 84, 110, 95, 66, 78 }, 58), new Vector2(470f, 65f), new Vector2(880f, 80f), _0x321d6f2b, 40f, 28f, _0xe058d175.TextPrimary, this._0xde6fa8d8, TextAlignmentOptions.Center);
        _0xc87991dc.localScale = new Vector3(0.8f, 0.8f, 1f);
        _0xc87991dc.DOScale(1f, 0.24f).SetEase(Ease.OutBack).SetLink(_0xc87991dc.gameObject);
    }

    private RectTransform _0xe12ffcfb;
    /// <summary>Panel y of the close glyph.</summary>
    public const float ClosePanelY = 2130f;
    private const float CardLeft = 91f;
    private const float CardW = 1060f;
    /// <summary>
    /// One album card. The gem sits alone in a 200-unit gutter and the text column starts at
    /// 240, so the two never share an x band whatever the symbol is called.
    /// </summary>
    private void _0xf93c0214(_0x65cc6a73 _0x8ed62106, float _0x4d653721, float _0x524c61d5, Sprite _0x5d8c1b90)
    {
        int _0x77613e94 = _0xaa0251af.Shards(_0x8ed62106);
        bool _0x31e0b612 = _0x77613e94 >= _0xaa0251af.ShardsPerSet;
        RectTransform _0x0c088f80 = _0xcecf7be6.Frame(this._0xe12ffcfb, _0x9cfe9747._0x3415b373(new byte[9] { 213, 248, 246, 225, 249, 192, 253, 248, 241 }, 148), Card(_0x4d653721, _0x524c61d5), new Vector2(TileW, TileH), _0x5d8c1b90, _0x31e0b612 ? _0xe058d175.Gold : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.92f), _0xe058d175.Alpha(_0xe058d175.Ground, 0.97f), 28f, _0x31e0b612 ? 6f : 4f);
        const float _0x93be3ed2 = 110f;
        const float _0xf086ab72 = 200f;
        const float _0x2a2dd739 = 240f;
        float _0x605f4a22 = TileW - _0x2a2dd739 - 24f;
        float _0x8f1ac5b0 = _0x2a2dd739 + (_0x605f4a22 * 0.5f);
        _0xcecf7be6.Picture(_0x0c088f80, _0x9cfe9747._0x3415b373(new byte[3] { 23, 53, 61 }, 80), new Vector2(_0x93be3ed2, TileH * 0.5f), new Vector2(_0xf086ab72 * 0.9f, _0xf086ab72 * 0.9f), this._0x1f8e69a4 != null ? this._0x1f8e69a4._0x2b16b7b0(_0x8ed62106) : null, _0x31e0b612 ? _0xe058d175.White : _0xe058d175.Alpha(_0xe058d175.White, 0.45f));
        _0xcecf7be6.Label(_0x0c088f80, _0x9cfe9747._0x3415b373(new byte[7] { 232, 202, 194, 225, 206, 194, 202 }, 175), new Vector2(_0x8f1ac5b0, TileH * 0.70f), new Vector2(_0x605f4a22, 48f), _0xbb4bed3e.NameOf(_0x8ed62106), 38f, 28f, _0x31e0b612 ? _0xe058d175.Gold : _0xe058d175.TextSecondary, this._0xde6fa8d8, TextAlignmentOptions.Left);
        for (int _0xc4b5851f = 0; _0xc4b5851f < _0xaa0251af.ShardsPerSet; _0xc4b5851f++)
        {
            bool _0xd8f763cc = _0xc4b5851f < _0x77613e94;
            _0xcecf7be6.Plate(_0x0c088f80, _0x9cfe9747._0x3415b373(new byte[3] { 191, 134, 159 }, 239), new Vector2(_0x2a2dd739 + 16f + (_0xc4b5851f * 42f), TileH * 0.40f), new Vector2(28f, 28f), _0x5d8c1b90, _0xd8f763cc ? _0xe058d175.Gold : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 1f), 14f);
        }

        _0xcecf7be6.Label(_0x0c088f80, _0x9cfe9747._0x3415b373(new byte[6] { 120, 90, 82, 111, 94, 70 }, 63), new Vector2(_0x8f1ac5b0, TileH * 0.18f), new Vector2(_0x605f4a22, 40f), _0xbb4bed3e.Row(_0x8ed62106), 28f, 28f, _0xe058d175.TextMuted, this._0xde6fa8d8, TextAlignmentOptions.Left);
        if (!_0x31e0b612)
            return;
        // Tapping a finished set re-dresses the lobby room behind the shade and floats a
        // ribbon, so the tap has an answer that shows up in one frame (C.7).
        Button _0x9b1e198d = _0x0c088f80.gameObject.AddComponent<Button>();
        Image _0x7f7447f6 = _0x0c088f80.GetComponentInChildren<Image>(true);
        _0x9b1e198d.targetGraphic = _0x7f7447f6;
        _0x9b1e198d.transition = Selectable.Transition.None;
        if (_0x7f7447f6 != null)
            _0x7f7447f6.raycastTarget = true;
        _0x65cc6a73 _0x9bc367bb = _0x8ed62106;
        _0x9b1e198d.onClick.AddListener(() => this._0x80b5545f(_0x9bc367bb));
    }

    private void _0x22fd8676()
    {
        if (this._0xe12ffcfb == null)
            return;
        for (int _0xe602a805 = this._0xe12ffcfb.childCount - 1; _0xe602a805 >= 2; _0xe602a805--)
        {
            Transform _0x76b189d1 = this._0xe12ffcfb.GetChild(_0xe602a805);
            _0x76b189d1.SetParent(null, false);
            Object.Destroy(_0x76b189d1.gameObject);
        }

        Sprite _0xba7014bc = this._0x1f8e69a4 != null ? this._0x1f8e69a4._0xfae782aa : null;
        _0xcecf7be6.Label(this._0xe12ffcfb, _0x9cfe9747._0x3415b373(new byte[9] { 47, 2, 12, 27, 3, 38, 11, 15, 10 }, 110), Card(_0xcecf7be6.MidX, 2110f), new Vector2(680f, 90f), _0x9cfe9747._0x3415b373(new byte[9] { 196, 198, 206, 163, 194, 207, 193, 214, 206 }, 131), 64f, 40f, _0xe058d175.Gold, this._0xde6fa8d8, TextAlignmentOptions.Center);
        int _0xfc73bf9c = 0;
        for (int _0x6e8c985b = 0; _0x6e8c985b < _0xaa0251af.AlbumSize; _0x6e8c985b++)
            _0xfc73bf9c += _0xaa0251af.Shards((_0x65cc6a73)_0x6e8c985b);
        if (_0xfc73bf9c == 0)
        {
            // Never a blank grid: an empty album says what fills it (G, empty states).
            _0xcecf7be6.Picture(this._0xe12ffcfb, _0x9cfe9747._0x3415b373(new byte[13] { 13, 32, 46, 57, 33, 9, 33, 60, 56, 53, 13, 62, 56 }, 76), Card(_0xcecf7be6.MidX, 1620f), new Vector2(280f, 280f), this._0x1f8e69a4 != null ? this._0x1f8e69a4._0x1b3bad39 : null, _0xe058d175.Alpha(_0xe058d175.VioletSoft, 0.9f));
            _0xcecf7be6.Label(this._0xe12ffcfb, _0x9cfe9747._0x3415b373(new byte[10] { 108, 65, 79, 88, 64, 104, 64, 93, 89, 84 }, 45), Card(_0xcecf7be6.MidX, 1330f), new Vector2(960f, 160f), _0x9cfe9747._0x3415b373(new byte[42] { 203, 202, 165, 194, 192, 200, 214, 165, 198, 196, 209, 196, 201, 202, 194, 208, 192, 193, 165, 220, 192, 209, 143, 214, 213, 204, 203, 165, 209, 202, 165, 195, 204, 203, 193, 165, 214, 205, 196, 215, 193, 214 }, 133), 44f, 30f, _0xe058d175.TextSecondary, this._0xde6fa8d8, TextAlignmentOptions.Center);
        }
        else
        {
            for (int _0xf52b6f33 = 0; _0xf52b6f33 < _0xaa0251af.AlbumSize; _0xf52b6f33++)
            {
                int _0xe7e881d3 = _0xf52b6f33 % 2;
                int _0x4de8b742 = _0xf52b6f33 / 2;
                float _0x7845ac2e = _0xcecf7be6.MidX + ((_0xe7e881d3 == 0 ? -1f : 1f) * ((TileW + TileGapX) * 0.5f));
                float _0xd5a5caf9 = 1900f - (_0x4de8b742 * TilePitchY);
                this._0xf93c0214((_0x65cc6a73)_0xf52b6f33, _0x7845ac2e, _0xd5a5caf9, _0xba7014bc);
            }
        }

        int _0x3dfecbdf = _0xaa0251af.CompletedSets();
        int _0x8f2547a1 = _0xaa0251af.RefreshRooms();
        _0xcecf7be6.Label(this._0xe12ffcfb, _0x9cfe9747._0x3415b373(new byte[11] { 10, 39, 41, 62, 38, 13, 36, 36, 63, 46, 57 }, 75), Card(_0xcecf7be6.MidX, 850f), new Vector2(960f, 60f), _0x9cfe9747._0x3415b373(new byte[5] { 53, 35, 50, 53, 70 }, 102) + _0x3dfecbdf.ToString() + _0x9cfe9747._0x3415b373(new byte[3] { 188, 179, 188 }, 156) + _0xaa0251af.AlbumSize.ToString() + _0x9cfe9747._0x3415b373(new byte[9] { 98, 98, 98, 16, 13, 13, 15, 17, 98 }, 66) + _0x8f2547a1.ToString() + _0x9cfe9747._0x3415b373(new byte[3] { 77, 66, 77 }, 109) + _0xaa0251af.RoomCount.ToString(), 38f, 28f, _0xe058d175.Gold, this._0xde6fa8d8, TextAlignmentOptions.Center);
        _0xcecf7be6.Label(this._0xe12ffcfb, _0x9cfe9747._0x3415b373(new byte[9] { 247, 218, 212, 195, 219, 254, 223, 216, 194 }, 182), Card(_0xcecf7be6.MidX, 770f), new Vector2(960f, 56f), _0x9cfe9747._0x3415b373(new byte[31] { 128, 140, 142, 147, 143, 134, 151, 134, 227, 144, 134, 151, 144, 227, 151, 140, 227, 140, 147, 134, 141, 227, 141, 134, 148, 227, 145, 140, 140, 142, 144 }, 195), 30f, 28f, _0xe058d175.TextMuted, this._0xde6fa8d8, TextAlignmentOptions.Center);
        Button _0xbae8582b = _0xcecf7be6.IconCta(this._0xe12ffcfb, _0x9cfe9747._0x3415b373(new byte[10] { 26, 55, 57, 46, 54, 24, 55, 52, 40, 62 }, 91), Card(ClosePanelX, ClosePanelY), new Vector2(132f, 132f), _0xba7014bc, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.95f), this._0x1f8e69a4 != null ? this._0x1f8e69a4._0x028932ee : null, _0xe058d175.Gold, 30f);
        _0xbae8582b.onClick.AddListener(() => this._0xa6108861());
    }

    private TMP_FontAsset _0xde6fa8d8;
    private const float CardY = 1430f;
    /// <summary>Closes the sheet.</summary>
    public void _0xa6108861()
    {
        if (this._0xf267dbfd == null)
            return;
        this._0xf267dbfd.gameObject.SetActive(false);
        if (this._0x4bca8768 != null)
            this._0x4bca8768._0x8dc68993();
    }

    private const float TileH = 260f;
    private static Vector2 Card(float _0x29a8a831, float _0x4245157a)
    {
        return new Vector2(_0x29a8a831 - CardLeft, _0x4245157a - CardBottom);
    }

    private RectTransform _0xf267dbfd;
    private const float TilePitchY = 280f;
    /// <summary>Panel centre of the close glyph.</summary>
    public const float ClosePanelX = 1061f;
    /// <summary>Opens the sheet and redraws it.</summary>
    public void _0x849c9006()
    {
        if (this._0xf267dbfd == null)
            return;
        this._0x22fd8676();
        this._0xf267dbfd.gameObject.SetActive(true);
        this._0xe12ffcfb.localScale = new Vector3(0.9f, 0.9f, 1f);
        this._0xe12ffcfb.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(this._0xe12ffcfb.gameObject);
    }

    private _0x999838f3 _0x4bca8768;
    private const float TileW = 500f;
    private const float CardBottom = 650f;
    private void _0x80b5545f(_0x65cc6a73 _0xefaad79e)
    {
        int _0x66737640 = _0xaa0251af.RefreshRooms();
        int _0x328513fb = (_0xaa0251af._0x1a827b81 + 1) % _0x66737640;
        _0xaa0251af._0x1a827b81 = _0x328513fb;
        _0xaa0251af.Save();
        if (this._0x4bca8768 != null)
            this._0x4bca8768._0x35adba6b();
        this._0xafda7c3e(_0x999838f3.RoomName(_0x328513fb) + _0x9cfe9747._0x3415b373(new byte[8] { 107, 24, 14, 31, 107, 9, 18, 107 }, 75) + _0xbb4bed3e.NameOf(_0xefaad79e));
    }

    private const float CardH = 1560f;
}

internal static class _0x9cfe9747
{
    internal static string _0x3415b373(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}