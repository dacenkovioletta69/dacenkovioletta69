using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The daily ladder, as a modal sheet over the lobby.
///
/// It is not a template panel index: only SPLASH, DEFAULT and TUTORIAL0..6 are documented, and
/// an invented index silently shows the wrong panel. It is an overlay group the lobby owns and
/// toggles through a serialized reference.
///
/// The shade behind the card is itself a close control. A scenario tap that misses the 132-unit
/// close glyph by twenty units would otherwise leave the sheet covering the screen and every
/// later review frame would be the same sheet.
/// </summary>
public sealed class _0x73518b7d : MonoBehaviour
{
    private RectTransform _0xbfce5e3d;
    private void _0xb5bd8f01()
    {
        int _0xf0c81963 = _0xaa0251af.ClaimVault();
        if (_0xf0c81963 <= 0)
            return;
        if (_0xaa0251af._0x82fe9f6a)
            Handheld.Vibrate();
        // The chest opening, six coins flying to the purse and the card flipping to CLAIMED are
        // all one visible answer to the tap (C.7).
        this._0xd56f9ecc();
        this._0x363f8bd9();
        if (this._0x6b543afa != null)
            this._0x6b543afa._0x850577a0(_0xf0c81963);
    }

    /// <summary>Panel y of the close glyph.</summary>
    public const float ClosePanelY = 2055f;
    /// <summary>Opens the sheet and redraws it against today's state.</summary>
    public void _0xb025f3b5()
    {
        if (this._0x46534a6c == null)
            return;
        this._0x363f8bd9();
        this._0x46534a6c.gameObject.SetActive(true);
        this._0xbfce5e3d.localScale = new Vector3(0.9f, 0.9f, 1f);
        this._0xbfce5e3d.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(this._0xbfce5e3d.gameObject);
    }

    /// <summary>Closes the sheet. Also the shade's handler.</summary>
    public void _0x7b3ef945()
    {
        if (this._0x46534a6c == null)
            return;
        this._0x46534a6c.gameObject.SetActive(false);
        if (this._0x6b543afa != null)
            this._0x6b543afa._0x8dc68993();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private void _0x363f8bd9()
    {
        if (this._0xbfce5e3d == null)
            return;
        // Everything except the ring and the body is rebuilt, so a claim made a second ago is
        // reflected without a cached card offering a reward that is already paid.
        for (int _0xa20678c4 = this._0xbfce5e3d.childCount - 1; _0xa20678c4 >= 2; _0xa20678c4--)
        {
            Transform _0x5d76443b = this._0xbfce5e3d.GetChild(_0xa20678c4);
            _0x5d76443b.SetParent(null, false);
            Object.Destroy(_0x5d76443b.gameObject);
        }

        Sprite _0x3bf5b138 = this._0x394962f9 != null ? this._0x394962f9._0xfae782aa : null;
        bool _0x20fcdfca = _0xaa0251af.VaultReady();
        int _0xb346ef79 = _0xaa0251af.PendingStep();
        // Header sits clear of the close glyph's x band: 281..961 against 995..1127 (C.25).
        _0xcecf7be6.Label(this._0xbfce5e3d, _0xfd89f20e._0x57f28629(new byte[9] { 49, 6, 18, 11, 19, 47, 2, 6, 3 }, 103), Card(_0xcecf7be6.MidX, 2040f), new Vector2(680f, 90f), _0xfd89f20e._0x57f28629(new byte[11] { 71, 66, 74, 79, 90, 35, 85, 66, 86, 79, 87 }, 3), 64f, 40f, _0xe058d175.Gold, this._0xe0472b1d, TextAlignmentOptions.Center);
        _0xcecf7be6.Label(this._0xbfce5e3d, _0xfd89f20e._0x57f28629(new byte[8] { 149, 162, 182, 175, 183, 144, 182, 161 }, 195), Card(_0xcecf7be6.MidX, 1945f), new Vector2(900f, 56f), _0xfd89f20e._0x57f28629(new byte[24] { 104, 126, 109, 126, 117, 27, 127, 122, 98, 104, 27, 116, 125, 27, 125, 105, 126, 126, 27, 120, 116, 114, 117, 104 }, 59), 32f, 28f, _0xe058d175.TextSecondary, this._0xe0472b1d, TextAlignmentOptions.Center);
        this._0x2a8dca9f(4, 0, 1780f, _0xb346ef79, _0x20fcdfca);
        this._0x2a8dca9f(3, 4, 1534f, _0xb346ef79, _0x20fcdfca);
        this._0xbacea6ac = _0xcecf7be6.Label(this._0xbfce5e3d, _0xfd89f20e._0x57f28629(new byte[11] { 77, 122, 110, 119, 111, 72, 111, 122, 111, 110, 104 }, 27), Card(_0xcecf7be6.MidX, 1300f), new Vector2(960f, 120f), this._0xc2665373(_0x20fcdfca, _0xb346ef79), 38f, 28f, _0xe058d175.TextSecondary, this._0xe0472b1d, TextAlignmentOptions.Center);
        this._0x050df849 = _0xcecf7be6.Cta(this._0xbfce5e3d, _0xfd89f20e._0x57f28629(new byte[10] { 176, 135, 147, 138, 146, 165, 138, 135, 143, 139 }, 230), Card(_0xcecf7be6.MidX, ClaimPanelY), new Vector2(620f, 160f), _0x3bf5b138, _0x20fcdfca ? _0xe058d175.Ruby : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.9f), _0x20fcdfca ? _0xfd89f20e._0x57f28629(new byte[5] { 25, 22, 27, 19, 23 }, 90) : _0xfd89f20e._0x57f28629(new byte[7] { 145, 158, 147, 155, 159, 151, 150 }, 210), 52f, 34f, _0x20fcdfca ? _0xe058d175.TextPrimary : _0xe058d175.TextMuted, this._0xe0472b1d, 34f);
        this._0x050df849.interactable = _0x20fcdfca;
        this._0x050df849.onClick.AddListener(() => this._0xb5bd8f01());
        _0xcecf7be6.Label(this._0xbfce5e3d, _0xfd89f20e._0x57f28629(new byte[9] { 130, 181, 161, 184, 160, 154, 187, 160, 177 }, 212), Card(_0xcecf7be6.MidX, 930f), new Vector2(960f, 56f), _0xfd89f20e._0x57f28629(new byte[41] { 48, 63, 53, 34, 63, 57, 56, 55, 58, 86, 53, 57, 63, 56, 37, 86, 91, 86, 56, 57, 86, 38, 35, 36, 53, 62, 55, 37, 51, 37, 90, 86, 56, 57, 86, 38, 36, 63, 44, 51, 37 }, 118), 30f, 28f, _0xe058d175.TextMuted, this._0xe0472b1d, TextAlignmentOptions.Center);
        Button _0x981bb7b9 = _0xcecf7be6.IconCta(this._0xbfce5e3d, _0xfd89f20e._0x57f28629(new byte[10] { 194, 245, 225, 248, 224, 215, 248, 251, 231, 241 }, 148), Card(ClosePanelX, ClosePanelY), new Vector2(132f, 132f), _0x3bf5b138, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.95f), this._0x394962f9 != null ? this._0x394962f9._0x028932ee : null, _0xe058d175.Gold, 30f);
        _0x981bb7b9.onClick.AddListener(() => this._0x7b3ef945());
        this._0x28e951f0 = Time.unscaledTime;
    }

    /// <summary>A panel coordinate expressed in the card's own space.</summary>
    private static Vector2 Card(float _0x46a984e5, float _0x603cf88a)
    {
        return new Vector2(_0x46a984e5 - CardLeft, _0x603cf88a - CardBottom);
    }

    private const float CardW = 1060f;
    /// <summary>One ladder row: four tiles, then three, centred on the card.</summary>
    private void _0x2a8dca9f(int _0x432f6430, int _0x42cc9387, float _0x1cd88eb7, int _0x8748322d, bool _0x04b96a6a)
    {
        float width = (_0x432f6430 * TileSize) + ((_0x432f6430 - 1) * TileGap);
        float _0xcb795a11 = _0xcecf7be6.MidX - (width * 0.5f) + (TileSize * 0.5f);
        for (int _0x1509a47c = 0; _0x1509a47c < _0x432f6430; _0x1509a47c++)
        {
            int _0xa76f29a0 = _0x42cc9387 + _0x1509a47c + 1;
            float _0x0d11e234 = _0xcb795a11 + (_0x1509a47c * (TileSize + TileGap));
            bool _0x7561522f = _0xa76f29a0 < _0x8748322d || (!_0x04b96a6a && _0xa76f29a0 <= _0x8748322d);
            bool _0xc31b47a6 = _0x04b96a6a && _0xa76f29a0 == _0x8748322d;
            Color _0x472f24fc = _0xc31b47a6 ? _0xe058d175.Gold : _0x7561522f ? _0xe058d175.Alpha(_0xe058d175.Violet, 0.9f) : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.9f);
            RectTransform _0xb0213ad9 = _0xcecf7be6.Frame(this._0xbfce5e3d, _0xfd89f20e._0x57f28629(new byte[3] { 183, 146, 138 }, 243), Card(_0x0d11e234, _0x1cd88eb7), new Vector2(TileSize, TileSize), this._0x394962f9 != null ? this._0x394962f9._0xfae782aa : null, _0x472f24fc, _0xe058d175.Alpha(_0xe058d175.Ground, 0.96f), 26f, _0xc31b47a6 ? 6f : 4f);
            _0xcecf7be6.Label(_0xb0213ad9, _0xfd89f20e._0x57f28629(new byte[5] { 49, 20, 12, 59, 26 }, 117), new Vector2(TileSize * 0.5f, TileSize * 0.74f), new Vector2(TileSize - 24f, 44f), _0xfd89f20e._0x57f28629(new byte[4] { 196, 193, 217, 160 }, 128) + _0xa76f29a0.ToString(), 30f, 28f, _0xe058d175.TextMuted, this._0xe0472b1d, TextAlignmentOptions.Center);
            if (_0x7561522f)
            {
                _0xcecf7be6.Picture(_0xb0213ad9, _0xfd89f20e._0x57f28629(new byte[7] { 21, 48, 40, 28, 48, 35, 58 }, 81), new Vector2(TileSize * 0.5f, TileSize * 0.36f), new Vector2(96f, 96f), this._0x394962f9 != null ? this._0x394962f9._0x6cba7c24 : null, _0xe058d175.Alpha(_0xe058d175.Gold, 0.55f));
            }
            else
            {
                _0xcecf7be6.Label(_0xb0213ad9, _0xfd89f20e._0x57f28629(new byte[6] { 182, 147, 139, 162, 147, 139 }, 242), new Vector2(TileSize * 0.5f, TileSize * 0.34f), new Vector2(TileSize - 24f, 56f), _0xaa0251af.LadderReward(_0xa76f29a0).ToString(), 42f, 28f, _0xc31b47a6 ? _0xe058d175.Gold : _0xe058d175.TextSecondary, this._0xe0472b1d, TextAlignmentOptions.Center);
            }

            if (!_0xc31b47a6 || _0xaa0251af._0x70f7e906)
                continue;
            _0xb0213ad9.DOScale(1.06f, 1.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0xb0213ad9.gameObject);
        }
    }

    private const float TileSize = 220f;
    private void _0xd56f9ecc()
    {
        if (this._0xbfce5e3d == null)
            return;
        _0xcecf7be6.Picture(this._0xbfce5e3d, _0xfd89f20e._0x57f28629(new byte[10] { 14, 57, 45, 52, 44, 27, 48, 61, 43, 44 }, 88), Card(_0xcecf7be6.MidX, 1620f), new Vector2(240f, 240f), this._0x394962f9 != null ? this._0x394962f9._0x2c273d07 : null, _0xe058d175.White);
        if (_0xaa0251af._0x70f7e906)
            return;
        for (int _0xf40dab6c = 0; _0xf40dab6c < 6; _0xf40dab6c++)
        {
            Image _0xf298558d = _0xcecf7be6.Picture(this._0xbfce5e3d, _0xfd89f20e._0x57f28629(new byte[9] { 235, 220, 200, 209, 201, 254, 210, 212, 211 }, 189), Card(_0xcecf7be6.MidX, 1620f), new Vector2(80f, 80f), this._0x394962f9 != null ? this._0x394962f9._0x6cba7c24 : null, _0xe058d175.White);
            Vector2 _0x0bab215b = Card(_0xcecf7be6.MidX - 240f + (_0xf40dab6c * 96f), 2420f);
            _0xf298558d.rectTransform.DOAnchorPos(_0x0bab215b, 0.5f).SetDelay(0.06f * _0xf40dab6c).SetEase(Ease.InCubic).SetLink(_0xf298558d.gameObject);
            _0xf298558d.DOFade(0f, 0.5f).SetDelay(0.06f * _0xf40dab6c).SetLink(_0xf298558d.gameObject);
        }
    }

    private Button _0x050df849;
    /// <summary>Builds the sheet once, switched off, into a host the lobby placed.</summary>
    public void _0x44ec4587(RectTransform _0x895da5dc, _0x30d693a6 _0x342d997b, TMP_FontAsset _0x30f9ecf9, _0x999838f3 _0x447e7449)
    {
        this._0x46534a6c = _0x895da5dc;
        this._0x394962f9 = _0x342d997b;
        this._0xe0472b1d = _0x30f9ecf9;
        this._0x6b543afa = _0x447e7449;
        Button _0x7eb9984a = _0xcecf7be6.Shade(_0x895da5dc, _0xfd89f20e._0x57f28629(new byte[10] { 152, 175, 187, 162, 186, 157, 166, 175, 170, 171 }, 206), _0xe058d175.Alpha(_0xe058d175.Abyss, 0.82f));
        _0x7eb9984a.onClick.AddListener(() => this._0x7b3ef945());
        this._0xbfce5e3d = _0xcecf7be6.Frame(_0x895da5dc, _0xfd89f20e._0x57f28629(new byte[9] { 157, 170, 190, 167, 191, 136, 170, 185, 175 }, 203), new Vector2(_0xcecf7be6.MidX, CardY), new Vector2(CardW, CardH), _0x342d997b != null ? _0x342d997b._0xfae782aa : null, _0xe058d175.Gold, _0xe058d175.Alpha(_0xe058d175.Surface, 0.99f), 34f, 7f);
        this._0x363f8bd9();
        _0x895da5dc.gameObject.SetActive(false);
    }

    private float _0x28e951f0;
    private _0x999838f3 _0x6b543afa;
    private string _0xc2665373(bool _0x82e129f0, int _0xc65a968e)
    {
        if (_0x82e129f0)
            return _0xfd89f20e._0x57f28629(new byte[4] { 112, 117, 109, 20 }, 52) + _0xc65a968e.ToString() + _0xfd89f20e._0x57f28629(new byte[12] { 149, 252, 230, 149, 226, 244, 252, 225, 252, 251, 242, 191 }, 181) + _0xaa0251af.LadderReward(_0xc65a968e).ToString() + _0xfd89f20e._0x57f28629(new byte[11] { 1, 103, 115, 100, 100, 1, 98, 110, 104, 111, 114 }, 33);
        return _0xfd89f20e._0x57f28629(new byte[33] { 2, 14, 12, 4, 97, 3, 0, 2, 10, 97, 21, 14, 12, 14, 19, 19, 14, 22, 75, 15, 4, 25, 21, 97, 23, 0, 20, 13, 21, 97, 8, 15, 97 }, 65) + Clock(_0xaa0251af.SecondsToMidnight());
    }

    private void Update()
    {
        // The countdown is the only live number on the sheet; one refresh a minute is enough
        // and keeps the capture job's quiet-frame counter from being reset.
        if (this._0x46534a6c == null || !this._0x46534a6c.gameObject.activeSelf || this._0xbacea6ac == null)
            return;
        if (_0xaa0251af.VaultReady())
            return;
        if (Time.unscaledTime - this._0x28e951f0 < 30f)
            return;
        this._0x28e951f0 = Time.unscaledTime;
        this._0xbacea6ac.text = this._0xc2665373(false, _0xaa0251af.PendingStep());
    }

    private _0x30d693a6 _0x394962f9;
    private const float CardLeft = 91f;
    private const float CardBottom = 800f;
    private TextMeshProUGUI _0xbacea6ac;
    private const float CardY = 1470f;
    /// <summary>Panel y of the CLAIM button, the coordinate the screenshot scenario taps.</summary>
    public const float ClaimPanelY = 1110f;
    private const float CardH = 1340f;
    private const float TileGap = 26f;
    private TMP_FontAsset _0xe0472b1d;
    /// <summary>Panel centre of the close glyph, the coordinate the scenario taps to leave.</summary>
    public const float ClosePanelX = 1061f;
    private RectTransform _0x46534a6c;
    private static string Clock(int _0xe06c9274)
    {
        int _0xffa62ff2 = _0xe06c9274 / 3600;
        int _0x5b84b019 = (_0xe06c9274 % 3600) / 60;
        return (_0xffa62ff2 < 10 ? _0xfd89f20e._0x57f28629(new byte[1] { 10 }, 58) : "") + _0xffa62ff2.ToString() + _0xfd89f20e._0x57f28629(new byte[1] { 28 }, 38) + (_0x5b84b019 < 10 ? _0xfd89f20e._0x57f28629(new byte[1] { 91 }, 107) : "") + _0x5b84b019.ToString();
    }
}

internal static class _0xfd89f20e
{
    internal static string _0x57f28629(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}