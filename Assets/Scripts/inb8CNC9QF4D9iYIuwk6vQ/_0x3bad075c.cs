using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The three objectives on the lobby, and the pool they are drawn from.
///
/// The draw is part of what makes two sessions differ (C.11): three of nine entries, picked
/// with the session's own <c>System.Random</c>, so the board of objectives is not a constant.
/// Progress is counted in the GAME scene and read back here, so it travels through
/// <see cref = "ParlourProfile"/> rather than through a field - the two scenes never share an
/// object.
///
/// Layout follows C.25: the gem chip owns the gutter band and the text column starts clear of
/// it, so a long objective can never run under the chip.
/// </summary>
public sealed class _0x3bad075c : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    /// <summary>The objective text of a pool entry, in this game's words.</summary>
    public static string Title(int _0x9e782d5b)
    {
        switch (_0x9e782d5b)
        {
            case 0:
                return _0xf145e4d5._0x0187a25f(new byte[13] { 7, 18, 24, 22, 115, 98, 97, 115, 0, 3, 26, 29, 0 }, 83);
            case 1:
                return _0xf145e4d5._0x0187a25f(new byte[19] { 79, 66, 77, 71, 35, 54, 35, 83, 66, 90, 74, 77, 68, 35, 79, 74, 77, 70, 80 }, 3);
            case 2:
                return _0xf145e4d5._0x0187a25f(new byte[20] { 6, 10, 9, 9, 0, 6, 17, 101, 113, 101, 2, 0, 8, 101, 22, 13, 4, 23, 1, 22 }, 69);
            case 3:
                return _0xf145e4d5._0x0187a25f(new byte[19] { 187, 185, 172, 187, 176, 216, 202, 216, 178, 183, 179, 189, 170, 216, 180, 177, 182, 189, 171 }, 248);
            case 4:
                return _0xf145e4d5._0x0187a25f(new byte[26] { 172, 178, 181, 219, 205, 203, 203, 219, 184, 180, 178, 181, 168, 219, 178, 181, 219, 186, 219, 168, 190, 168, 168, 178, 180, 181 }, 251);
            case 5:
                return _0xf145e4d5._0x0187a25f(new byte[17] { 11, 6, 9, 3, 103, 6, 103, 118, 117, 63, 103, 23, 6, 30, 8, 18, 19 }, 71);
            case 6:
                return _0xf145e4d5._0x0187a25f(new byte[26] { 252, 233, 227, 237, 136, 158, 136, 251, 248, 225, 230, 251, 136, 233, 252, 136, 154, 152, 136, 231, 250, 136, 229, 231, 250, 237 }, 168);
            case 7:
                return _0xf145e4d5._0x0187a25f(new byte[17] { 229, 232, 231, 237, 137, 154, 137, 251, 252, 235, 240, 137, 229, 224, 231, 236, 250 }, 169);
            default:
                return _0xf145e4d5._0x0187a25f(new byte[20] { 58, 54, 52, 41, 53, 60, 45, 60, 89, 54, 55, 60, 89, 62, 60, 52, 89, 42, 60, 45 }, 121);
        }
    }

    /// <summary>Entries in the objective pool.</summary>
    public const int PoolSize = 9;
    /// <summary>
    /// Fills the three slots from the pool if they are empty or all claimed. Drawn with the
    /// session's own generator, so a new set of objectives is a real difference between runs
    /// rather than the same three every time.
    /// </summary>
    public static void EnsureDrawn(System.Random _0x4875caaf)
    {
        bool _0xf9d66426 = false;
        for (int _0x93a8c7be = 0; _0x93a8c7be < _0xaa0251af.MissionSlots; _0x93a8c7be++)
        {
            int _0x258ed625 = _0xaa0251af.MissionId(_0x93a8c7be);
            if (_0x258ed625 < 0 || _0x258ed625 >= PoolSize)
                _0xf9d66426 = true;
        }

        bool _0xe805e380 = true;
        for (int _0x3f0e18df = 0; _0x3f0e18df < _0xaa0251af.MissionSlots; _0x3f0e18df++)
        {
            if (!_0xaa0251af.MissionClaimed(_0x3f0e18df))
                _0xe805e380 = false;
        }

        if (!_0xf9d66426 && !_0xe805e380)
            return;
        int[] _0x6ea9d297 = new int[PoolSize];
        for (int _0x73c0b7a3 = 0; _0x73c0b7a3 < PoolSize; _0x73c0b7a3++)
            _0x6ea9d297[_0x73c0b7a3] = _0x73c0b7a3;
        for (int _0x1338d620 = PoolSize - 1; _0x1338d620 > 0; _0x1338d620--)
        {
            int _0x43d70863 = _0x4875caaf.Next(_0x1338d620 + 1);
            int _0x021b6314 = _0x6ea9d297[_0x1338d620];
            _0x6ea9d297[_0x1338d620] = _0x6ea9d297[_0x43d70863];
            _0x6ea9d297[_0x43d70863] = _0x021b6314;
        }

        for (int _0x928302f6 = 0; _0x928302f6 < _0xaa0251af.MissionSlots; _0x928302f6++)
            _0xaa0251af.SetMission(_0x928302f6, _0x6ea9d297[_0x928302f6]);
        _0xaa0251af._0x082baaeb = _0x4875caaf.Next(int.MaxValue);
        _0xaa0251af.Save();
    }

    private _0x30d693a6 _0x3a0ebc09;
    /// <summary>Width of the text column. 174 + 760 = 934, inside the 1036 row body.</summary>
    private const float TextWidth = 760f;
    private const float RowPitch = 140f;
    private void _0x1f2e6fda(int _0x5e9c8b39, int _0x89e16076, Vector2 _0x9b21427d)
    {
        bool _0xd9d35ace = Claimable(_0x5e9c8b39);
        Color _0x100c0848 = _0xd9d35ace ? _0xe058d175.Gold : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.95f);
        RectTransform _0x4ef6530a = _0xcecf7be6.Frame(this._0x5129fd6b, _0xf145e4d5._0x0187a25f(new byte[7] { 219, 255, 229, 229, 255, 249, 248 }, 150), _0x9b21427d, new Vector2(RowWidth, RowHeight), this._0x3a0ebc09 != null ? this._0x3a0ebc09._0xfae782aa : null, _0x100c0848, _0xe058d175.Alpha(_0xe058d175.Surface, 0.96f), 26f, _0xd9d35ace ? 5f : 3f);
        // The gutter: the chip lives alone in it and the text column never enters it (C.25).
        _0xcecf7be6.Picture(_0x4ef6530a, _0xf145e4d5._0x0187a25f(new byte[4] { 147, 184, 185, 160 }, 208), new Vector2(GutterCentre, RowHeight * 0.5f), new Vector2(GutterWidth, GutterWidth), this._0x3a0ebc09 != null ? this._0x3a0ebc09._0xe39fd6d8 : null, _0xd9d35ace ? _0xe058d175.Gold : _0xe058d175.VioletSoft);
        // A finished row hands its right-hand band to the CLAIM button, so the text column is
        // narrowed to match: two elements must never share an x-band (C.25).
        float _0x16e477fc = _0xd9d35ace ? 620f : TextWidth;
        float _0x047879e8 = TextLeft + (_0x16e477fc * 0.5f);
        _0xcecf7be6.Label(_0x4ef6530a, _0xf145e4d5._0x0187a25f(new byte[5] { 143, 178, 175, 183, 190 }, 219), new Vector2(_0x047879e8, RowHeight * 0.66f), new Vector2(_0x16e477fc, 44f), Title(_0x89e16076), 36f, 28f, _0xe058d175.TextPrimary, this._0x5d4e51d6, TextAlignmentOptions.Left);
        int _0x69afa5fb = Mathf.Min(Target(_0x89e16076), _0xaa0251af.MissionDone(_0x5e9c8b39));
        float _0x1361eb35 = Target(_0x89e16076) <= 0 ? 0f : _0x69afa5fb / (float)Target(_0x89e16076);
        if (_0xd9d35ace)
        {
            _0xcecf7be6.Label(_0x4ef6530a, _0xf145e4d5._0x0187a25f(new byte[5] { 64, 119, 115, 118, 107 }, 18), new Vector2(_0x047879e8, RowHeight * 0.30f), new Vector2(_0x16e477fc, 40f), _0xf145e4d5._0x0187a25f(new byte[7] { 66, 85, 71, 81, 66, 84, 48 }, 16) + Reward(_0x89e16076).ToString() + _0xf145e4d5._0x0187a25f(new byte[6] { 56, 91, 87, 81, 86, 75 }, 24), 30f, 28f, _0xe058d175.Gold, this._0x5d4e51d6, TextAlignmentOptions.Left);
            Button _0x2eb96104 = _0xcecf7be6.Cta(_0x4ef6530a, _0xf145e4d5._0x0187a25f(new byte[5] { 72, 103, 106, 98, 102 }, 11), new Vector2(950f, RowHeight * 0.5f), new Vector2(180f, 92f), this._0x3a0ebc09 != null ? this._0x3a0ebc09._0xfae782aa : null, _0xe058d175.Ruby, _0xf145e4d5._0x0187a25f(new byte[5] { 249, 246, 251, 243, 247 }, 186), 34f, 28f, _0xe058d175.TextPrimary, this._0x5d4e51d6, 22f);
            int _0xae56a5b5 = _0x5e9c8b39;
            _0x2eb96104.onClick.AddListener(() => this._0x91953ba6(_0xae56a5b5));
            return;
        }

        _0xcecf7be6.Meter(_0x4ef6530a, _0xf145e4d5._0x0187a25f(new byte[8] { 187, 153, 132, 140, 153, 142, 152, 152 }, 235), new Vector2(TextLeft + 270f, RowHeight * 0.30f), new Vector2(540f, 16f), this._0x3a0ebc09 != null ? this._0x3a0ebc09._0xfae782aa : null, _0xe058d175.Alpha(_0xe058d175.Ground, 1f), _0xe058d175.Gold, _0x1361eb35);
        _0xcecf7be6.Label(_0x4ef6530a, _0xf145e4d5._0x0187a25f(new byte[5] { 51, 31, 5, 30, 4 }, 112), new Vector2(TextLeft + 650f, RowHeight * 0.30f), new Vector2(180f, 40f), _0x69afa5fb.ToString() + _0xf145e4d5._0x0187a25f(new byte[3] { 14, 1, 14 }, 46) + Target(_0x89e16076).ToString(), 30f, 28f, _0xe058d175.Gold, this._0x5d4e51d6, TextAlignmentOptions.Right);
    }

    /// <summary>Free coins the objective pays when claimed.</summary>
    public static int Reward(int _0x1446c55b)
    {
        switch (_0x1446c55b)
        {
            case 0:
                return 300;
            case 1:
                return 350;
            case 2:
                return 400;
            case 3:
                return 500;
            case 4:
                return 450;
            case 5:
                return 600;
            case 6:
                return 400;
            case 7:
                return 550;
            default:
                return 700;
        }
    }

    /// <summary>Width of the chip gutter.</summary>
    private const float GutterWidth = 72f;
    /// <summary>Progress kinds the game scene reports.</summary>
    public enum _0x7e41363e
    {
        Spin = 0,
        PayingLine = 1,
        Shard = 2,
        JokerLine = 3,
        CoinsWon = 4,
        BigWin = 5,
        HighStakeSpin = 6,
        RubyLine = 7,
        SetCompleted = 8
    }

    /// <summary>Draws the strip into a host the lobby already placed.</summary>
    public void _0x3c59bc32(RectTransform _0xac2ee92c, _0x30d693a6 _0xf61c02dc, TMP_FontAsset _0xc8334290, _0x999838f3 _0xf06f4c32)
    {
        this._0x5129fd6b = _0xac2ee92c;
        this._0x3a0ebc09 = _0xf61c02dc;
        this._0x5d4e51d6 = _0xc8334290;
        this._0x02a39b1d = _0xf06f4c32;
        this._0x2860035d();
    }

    /// <summary>Centre of the chip gutter inside a row, in row-local units.</summary>
    private const float GutterCentre = 92f;
    /// <summary>Counts progress of one kind against every slot that wants it.</summary>
    public static void Report(_0x7e41363e _0xd767d0b9, int _0x44d4db18)
    {
        if (_0x44d4db18 <= 0)
            return;
        for (int _0x72930867 = 0; _0x72930867 < _0xaa0251af.MissionSlots; _0x72930867++)
        {
            int _0xb996889c = _0xaa0251af.MissionId(_0x72930867);
            if (_0xb996889c < 0 || _0xb996889c >= PoolSize)
                continue;
            if (KindOf(_0xb996889c) != _0xd767d0b9)
                continue;
            if (_0xaa0251af.MissionClaimed(_0x72930867))
                continue;
            int _0xd123b8fa = Mathf.Min(Target(_0xb996889c), _0xaa0251af.MissionDone(_0x72930867) + _0x44d4db18);
            _0xaa0251af.SetMissionDone(_0x72930867, _0xd123b8fa);
        }
    }

    private _0x999838f3 _0x02a39b1d;
    /// <summary>How much of the kind the objective wants.</summary>
    public static int Target(int _0xa4ab3bdb)
    {
        switch (_0xa4ab3bdb)
        {
            case 0:
                return 12;
            case 1:
                return 5;
            case 2:
                return 4;
            case 3:
                return 2;
            case 4:
                return 600;
            case 5:
                return 1;
            case 6:
                return 6;
            case 7:
                return 3;
            default:
                return 1;
        }
    }

    /// <summary>The kind of progress an objective counts.</summary>
    public static _0x7e41363e KindOf(int _0xaf992d0c)
    {
        switch (_0xaf992d0c)
        {
            case 0:
                return _0x7e41363e.Spin;
            case 1:
                return _0x7e41363e.PayingLine;
            case 2:
                return _0x7e41363e.Shard;
            case 3:
                return _0x7e41363e.JokerLine;
            case 4:
                return _0x7e41363e.CoinsWon;
            case 5:
                return _0x7e41363e.BigWin;
            case 6:
                return _0x7e41363e.HighStakeSpin;
            case 7:
                return _0x7e41363e.RubyLine;
            default:
                return _0x7e41363e.SetCompleted;
        }
    }

    /// <summary>Pays a finished objective and returns the coins granted.</summary>
    public static int Claim(int _0xa85f1fb5)
    {
        if (!Claimable(_0xa85f1fb5))
            return 0;
        int _0x4c073878 = _0xaa0251af.MissionId(_0xa85f1fb5);
        _0xaa0251af.SetMissionClaimed(_0xa85f1fb5, true);
        int _0xe9b8143d = Reward(_0x4c073878);
        _0xaa0251af._0xa151f4ff = _0xaa0251af._0xa151f4ff + _0xe9b8143d;
        _0xaa0251af.Save();
        return _0xe9b8143d;
    }

    /// <summary>Left edge of the text column: gutter right edge plus a real gap.</summary>
    private const float TextLeft = 174f;
    /// <summary>True when a slot is finished and still owed its reward.</summary>
    public static bool Claimable(int _0x111cd6f7)
    {
        int _0xb9672600 = _0xaa0251af.MissionId(_0x111cd6f7);
        if (_0xb9672600 < 0 || _0xb9672600 >= PoolSize || _0xaa0251af.MissionClaimed(_0x111cd6f7))
            return false;
        return _0xaa0251af.MissionDone(_0x111cd6f7) >= Target(_0xb9672600);
    }

    /// <summary>Redraws from the stored state. Cheap enough to do on every lobby entry.</summary>
    public void _0x2860035d()
    {
        if (this._0x5129fd6b == null)
            return;
        _0xcecf7be6.Clear(this._0x5129fd6b);
        int _0x0925c08a = 0;
        for (int _0x826e2a72 = 0; _0x826e2a72 < _0xaa0251af.MissionSlots; _0x826e2a72++)
        {
            int _0xec86ee2e = _0xaa0251af.MissionId(_0x826e2a72);
            if (_0xec86ee2e >= 0 && _0xec86ee2e < PoolSize && !_0xaa0251af.MissionClaimed(_0x826e2a72))
                _0x0925c08a++;
        }

        if (_0x0925c08a == 0)
        {
            // Never a blank area: an exhausted board says so in the game's own words.
            _0xcecf7be6.Label(this._0x5129fd6b, _0xf145e4d5._0x0187a25f(new byte[12] { 136, 172, 182, 182, 172, 170, 171, 182, 129, 170, 171, 160 }, 197), new Vector2(RowWidth * 0.5f, 210f), new Vector2(RowWidth - 40f, 160f), _0xf145e4d5._0x0187a25f(new byte[41] { 90, 87, 87, 59, 86, 82, 72, 72, 82, 84, 85, 72, 59, 88, 87, 94, 90, 73, 94, 95, 17, 85, 94, 76, 59, 72, 94, 79, 59, 85, 94, 67, 79, 59, 72, 94, 72, 72, 82, 84, 85 }, 27), 40f, 30f, _0xe058d175.TextSecondary, this._0x5d4e51d6, TextAlignmentOptions.Center);
            return;
        }

        float _0xc9325762 = 420f - (RowHeight * 0.5f);
        int _0xefc59de8 = 0;
        for (int _0x251bf0a2 = 0; _0x251bf0a2 < _0xaa0251af.MissionSlots; _0x251bf0a2++)
        {
            int _0xadce58ae = _0xaa0251af.MissionId(_0x251bf0a2);
            if (_0xadce58ae < 0 || _0xadce58ae >= PoolSize || _0xaa0251af.MissionClaimed(_0x251bf0a2))
                continue;
            this._0x1f2e6fda(_0x251bf0a2, _0xadce58ae, new Vector2(RowWidth * 0.5f, _0xc9325762 - (_0xefc59de8 * RowPitch)));
            _0xefc59de8++;
        }
    }

    private const float RowHeight = 128f;
    private const float RowWidth = 1060f;
    private void _0x91953ba6(int _0x0ceea89d)
    {
        int _0xbc037dbd = Claim(_0x0ceea89d);
        if (_0xbc037dbd <= 0)
            return;
        if (this._0x02a39b1d != null)
            this._0x02a39b1d._0x850577a0(_0xbc037dbd);
        this._0x2860035d();
    }

    private RectTransform _0x5129fd6b;
    private TMP_FontAsset _0x5d4e51d6;
}

internal static class _0xf145e4d5
{
    internal static string _0x0187a25f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}