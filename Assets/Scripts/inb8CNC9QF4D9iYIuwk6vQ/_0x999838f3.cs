using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The parlour lobby: everything the player sees in <c>1_MenuScene</c> once the splash hands
/// over. It owns the coin pill, the room stage, the room selector, the mission strip, the
/// four secondary sheets and the disclaimer, and it dresses the template's own
/// scene-loading button into this game's PLAY.
///
/// The panel body is reached through <c>PanelController.Instance.Panels[PANELS.DEFAULT]</c> -
/// an INDEX, never a name - and the PLAY button is found by COMPONENT TYPE inside it. Both
/// survive obfuscation, which renames every object, asset and class in the project.
///
/// Nothing is shown over the lobby on a first run. An onboarding card would cover the very
/// first review frame and make the album open on a modal instead of on the game; the same
/// three lines live in the rules sheet behind GAME RULES, one tap away.
/// </summary>
public sealed class _0x999838f3 : MonoBehaviour
{
    private void _0xe31ff72a()
    {
        if (this._settings != null)
            this._settings._0x9833c894();
    }

    /// <summary>The four parlour rooms, in unlock order. Index 0 is open from the start.</summary>
    public static string RoomName(int _0xe49ddf3e)
    {
        switch (_0xe49ddf3e)
        {
            case 0:
                return _0x41092f04._0xafac7cc7(new byte[12] { 151, 144, 135, 156, 229, 149, 132, 151, 137, 138, 144, 151 }, 197);
            case 1:
                return _0x41092f04._0xafac7cc7(new byte[11] { 7, 20, 29, 7, 20, 5, 113, 25, 16, 29, 29 }, 81);
            case 2:
                return _0x41092f04._0xafac7cc7(new byte[12] { 243, 253, 248, 240, 241, 240, 148, 226, 245, 225, 248, 224 }, 180);
            default:
                return _0x41092f04._0xafac7cc7(new byte[13] { 107, 100, 114, 117, 100, 115, 114, 1, 114, 117, 96, 102, 100 }, 33);
        }
    }

    private Transform _0x9dd40d12()
    {
        if (_0x868e2cfd.Instance == null || _0x868e2cfd.Instance.Panels == null)
            return null;
        int _0x82e1189e = _0x4fc558d7._0xb679ca6b.DEFAULT;
        if (_0x82e1189e < 0 || _0x82e1189e >= _0x868e2cfd.Instance.Panels.Count)
            return null;
        _0x39e04600 _0xc4354449 = _0x868e2cfd.Instance.Panels[_0x82e1189e];
        if (_0xc4354449 == null || _0xc4354449.Content == null)
            return null;
        return _0xc4354449.Content.transform;
    }

    private void _0x9eaf4dea()
    {
        if (this._0x1c3afaed == null)
            return;
        _0xcecf7be6.Clear(this._0x1c3afaed);
        Sprite _0x097663a5 = this._art != null ? this._art._0xfae782aa : null;
        int _0x482b2f17 = _0xaa0251af._0x1a827b81;
        Color _0xe1e8862b = RoomTint(_0x482b2f17);
        _0xcecf7be6.Frame(this._0x1c3afaed, _0x41092f04._0xafac7cc7(new byte[10] { 84, 115, 102, 96, 98, 87, 107, 102, 115, 98 }, 7), new Vector2(StageW * 0.5f, StageH * 0.5f), new Vector2(StageW, StageH), _0x097663a5, _0xe058d175.Alpha(_0xe1e8862b, 0.85f), _0xe058d175.Alpha(_0xe058d175.Ground, 0.92f), 40f, 6f);
        _0xcecf7be6.Picture(this._0x1c3afaed, _0x41092f04._0xafac7cc7(new byte[9] { 228, 195, 214, 208, 210, 246, 194, 197, 214 }, 183), new Vector2(StageW * 0.5f, 330f), new Vector2(760f, 760f), this._art != null ? this._art._0x38f9d754 : null, _0xe058d175.Alpha(_0xe1e8862b, 0.3f));
        this._0xda01bf4c = _0xcecf7be6.Picture(this._0x1c3afaed, _0x41092f04._0xafac7cc7(new byte[9] { 25, 62, 43, 45, 47, 2, 37, 57, 62 }, 74), new Vector2(StageW * 0.5f, 330f), new Vector2(600f, 600f), this._art != null ? this._art._0x9cc196ff : null, _0xe058d175.White);
        _0xcecf7be6.Label(this._0x1c3afaed, _0x41092f04._0xafac7cc7(new byte[9] { 243, 212, 193, 199, 197, 238, 193, 205, 197 }, 160), new Vector2(StageW * 0.5f, 660f), new Vector2(880f, 70f), RoomName(_0x482b2f17), 44f, 28f, _0xe058d175.Gold, this._font, TextAlignmentOptions.Center);
        int _0x8a0cc5e2 = _0xaa0251af.CompletedSets();
        _0xcecf7be6.Label(this._0x1c3afaed, _0x41092f04._0xafac7cc7(new byte[9] { 30, 57, 44, 42, 40, 30, 40, 57, 62 }, 77), new Vector2(StageW * 0.5f, 58f), new Vector2(880f, 56f), _0x41092f04._0xafac7cc7(new byte[9] { 90, 88, 80, 61, 78, 88, 73, 78, 61 }, 29) + _0x8a0cc5e2.ToString() + _0x41092f04._0xafac7cc7(new byte[3] { 168, 167, 168 }, 136) + _0xaa0251af.AlbumSize.ToString() + _0x41092f04._0xafac7cc7(new byte[9] { 143, 143, 143, 253, 224, 224, 226, 252, 143 }, 175) + _0xaa0251af._0x7129f7f3.ToString() + _0x41092f04._0xafac7cc7(new byte[3] { 35, 44, 35 }, 3) + _0xaa0251af.RoomCount.ToString(), 32f, 28f, _0xe058d175.TextSecondary, this._font, TextAlignmentOptions.Center);
        if (_0xaa0251af._0x70f7e906 || this._0xda01bf4c == null)
            return;
        this._0xda01bf4c.rectTransform.DOScale(1.03f, 2.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0xda01bf4c.gameObject);
    }

    private void _0x8dfd0045()
    {
        if (this._vault != null)
            this._vault._0xb025f3b5();
    }

    private const float ChipRowW = 1060f;
    [SerializeField]
    private _0x3bad075c _missions;
    private void _0xa0dd7eab()
    {
        if (this._0x2625d63f != null)
        {
            DOTween.Kill(this._0x2625d63f.rectTransform, false);
            this._0x2625d63f.rectTransform.localScale = Vector3.one;
        }

        if (this._0xda01bf4c != null)
        {
            DOTween.Kill(this._0xda01bf4c.rectTransform, false);
            this._0xda01bf4c.rectTransform.localScale = Vector3.one;
        }

        if (this._0x2a8d4022 != null)
        {
            DOTween.Kill(this._0x2a8d4022, false);
            this._0x2a8d4022.localScale = Vector3.one;
        }
    }

    private Image _0x2625d63f;
    /// <summary>Redraws everything that can change while the lobby is up.</summary>
    public void _0xa8b264be()
    {
        this._0xf62b6590();
        this._0x9eaf4dea();
        this._0x43e1606a();
        if (this._missions != null)
            this._missions._0x2860035d();
    }

    /// <summary>
    /// Empties every panel this scene never opens. The menu template ships five tutorial
    /// panels carrying the base prefab's "Lorem Ipsum", and this game leaves the tutorial
    /// switched off, so without this they travel into the store unread but present (C.15).
    ///
    /// They are emptied, never deactivated: the controller addresses panels by index, and
    /// pulling one out of the list breaks the navigation of the ones that remain.
    /// </summary>
    private void _0xff9246ac()
    {
        _0x868e2cfd _0xe8abd1c0 = _0x868e2cfd.Instance;
        if (_0xe8abd1c0 == null || _0xe8abd1c0.Panels == null)
            return;
        int _0xa5a7593f = 0;
        for (int _0x49cbf1ff = 0; _0x49cbf1ff < _0xe8abd1c0.Panels.Count; _0x49cbf1ff++)
        {
            if (_0x49cbf1ff == _0x4fc558d7._0xb679ca6b.SPLASH || _0x49cbf1ff == _0x4fc558d7._0xb679ca6b.DEFAULT)
                continue;
            _0x39e04600 _0xa44bdf9b = _0xe8abd1c0.Panels[_0x49cbf1ff];
            if (_0xa44bdf9b == null)
                continue;
            // Content is a serialized reference and the template leaves it UNASSIGNED on some
            // panels of this family (SplashPanel ships one such component). Skipping those
            // would leave exactly the placeholder C.15 is about, so fall back to the panel's
            // own object and sweep from there.
            GameObject _0x15d6c226 = _0xa44bdf9b.Content != null ? _0xa44bdf9b.Content : _0xa44bdf9b.gameObject;
            TMP_Text[] _0xde0f5a5f = _0x15d6c226.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x64854866 = 0; _0x64854866 < _0xde0f5a5f.Length; _0x64854866++)
            {
                if (_0xde0f5a5f[_0x64854866] == null)
                    continue;
                _0xde0f5a5f[_0x64854866].text = string.Empty;
                _0xa5a7593f++;
            }
        }

        // The sweep above runs over every index, so the tutorial group is emptied without a
        // single one of them being addressed by name. What the sweep CANNOT notice is a
        // tutorial index that is not in the list at all: a shorter Panels list simply ends the
        // loop early and the panel keeps the base prefab's "Lorem Ipsum" with nothing to show
        // for it. These are the indices C.15 is about, so they are checked explicitly.
        int[] _0x35b36ab5 = new int[]
        {
            _0x4fc558d7._0xb679ca6b.TUTORIAL0,
            _0x4fc558d7._0xb679ca6b.TUTORIAL1,
            _0x4fc558d7._0xb679ca6b.TUTORIAL2,
            _0x4fc558d7._0xb679ca6b.TUTORIAL3,
            _0x4fc558d7._0xb679ca6b.TUTORIAL4,
            _0x4fc558d7._0xb679ca6b.TUTORIAL5,
            _0x4fc558d7._0xb679ca6b.TUTORIAL6,
        };
        int _0x690a47eb = 0;
        for (int _0x007cba49 = 0; _0x007cba49 < _0x35b36ab5.Length; _0x007cba49++)
            if (_0x35b36ab5[_0x007cba49] >= 0 && _0x35b36ab5[_0x007cba49] < _0xe8abd1c0.Panels.Count)
                _0x690a47eb++;
        {
#if B_LOGS
            {
                Debug.Log(_0x41092f04._0xafac7cc7(new byte[17] { 218, 242, 232, 237, 228, 239, 226, 228, 220, 161, 241, 224, 239, 228, 237, 242, 188 }, 129) + _0xe8abd1c0.Panels.Count.ToString() + _0x41092f04._0xafac7cc7(new byte[8] { 118, 58, 55, 52, 51, 58, 37, 107 }, 86) + _0xa5a7593f.ToString() + _0x41092f04._0xafac7cc7(new byte[18] { 48, 100, 101, 100, 127, 98, 121, 113, 124, 99, 83, 127, 102, 117, 98, 117, 116, 45 }, 16) + _0x690a47eb.ToString() + _0x41092f04._0xafac7cc7(new byte[1] { 216 }, 247) + _0x35b36ab5.Length.ToString());
            }
#endif
        }
    }

    private const float StageW = 980f;
    [SerializeField]
    private _0x952fe249 _album;
    /// <summary>The album moved the parlour to another room.</summary>
    public void _0x35adba6b()
    {
        this._0x9eaf4dea();
        this._0x43e1606a();
    }

    /// <summary>The accent a room dresses the stage in, so switching rooms is visible at once.</summary>
    private static Color RoomTint(int _0xa63260b2)
    {
        switch (_0xa63260b2)
        {
            case 0:
                return _0xe058d175.Ruby;
            case 1:
                return _0xe058d175.Violet;
            case 2:
                return _0xe058d175.Gold;
            default:
                return _0xe058d175.VioletSoft;
        }
    }

    /// <summary>Everything was wiped: redraw the lobby against the defaults.</summary>
    public void _0x8617ee6a()
    {
        this._0xa8b264be();
    }

    [SerializeField]
    private _0x73518b7d _vault;
    private void Start()
    {
        _0xaa0251af.EnsureSeeded();
        int _0xbbdc9013 = _0xaa0251af.NextSession();
        int _0x58f7f31e = (_0xbbdc9013 * 7919) ^ (_0xaa0251af._0x4087bef7 * 104729);
        System.Random _0x2e6f2980 = new System.Random(_0x58f7f31e);
        _0x3bad075c.EnsureDrawn(_0x2e6f2980);
        _0xaa0251af.RefreshRooms();
        {
#if B_LOGS
            {
                Debug.Log(_0x41092f04._0xafac7cc7(new byte[16] { 79, 120, 123, 118, 118, 109, 73, 52, 103, 113, 103, 103, 125, 123, 122, 41 }, 20) + _0xbbdc9013.ToString() + _0x41092f04._0xafac7cc7(new byte[6] { 234, 185, 175, 175, 174, 247 }, 202) + _0x58f7f31e.ToString() + _0x41092f04._0xafac7cc7(new byte[7] { 30, 76, 81, 81, 83, 77, 3 }, 62) + _0xaa0251af._0x7129f7f3.ToString());
            }
#endif
        }

        if (this._splash != null)
            this._splash._0x9bfd8d48(this._art, this._font);
        Transform _0xb8c91d73 = this._0x9dd40d12();
        if (_0xb8c91d73 == null)
            return;
        // Captured BEFORE anything of ours is added, so "the first Button under the panel
        // body" can only be a template one. On THIS template family the body ships empty
        // (m_Children: []) and there is no scene-loading button at all, so this is normally
        // null and DressPlay builds our own. It is still read first: on a family that does
        // ship one, dressing it is right and adding a second PLAY beside it would not be.
        Button _0x71724e37 = _0xb8c91d73.GetComponentInChildren<Button>(true);
        RectTransform _0xe030a581 = _0xcecf7be6.Branch(_0xb8c91d73, _0x41092f04._0xafac7cc7(new byte[9] { 25, 58, 55, 55, 44, 23, 52, 54, 62 }, 85));
        _0xe030a581.SetAsFirstSibling();
        this._0x16dea442(_0xe030a581);
        this._0xf2f3b634 = _0xcecf7be6.Branch(_0xb8c91d73, _0x41092f04._0xafac7cc7(new byte[10] { 47, 12, 1, 1, 26, 37, 17, 12, 13, 23 }, 99));
        this._0xf2f3b634.SetAsLastSibling();
        this._0x14a018fd();
        this._0xb5437d15(_0x71724e37);
        this._0x4a19764e(_0xb8c91d73);
        this._0xa8b264be();
        this._0xff9246ac();
    }

    private const float PlayFaceRadius = 34f;
    private RectTransform _0x08aa9d20;
    /// <summary>PLAY's explicit size, per rule G.3 - never the template's stretch.</summary>
    public const float PlayW = 760f;
    [SerializeField]
    private _0x30d693a6 _art;
    private RectTransform _0xe45e9de3;
    /// <summary>
    /// A vignette over the room art so every caption reads, and a soft violet breath behind
    /// the stage. Both go UNDER the content: a glow created after the thing it lights would
    /// cover it, and sibling order is the only draw order UGUI has (C.13).
    /// </summary>
    private void _0x16dea442(RectTransform _0xab4250d1)
    {
        Image _0x28bc4541 = _0xcecf7be6.Plate(_0xab4250d1, _0x41092f04._0xafac7cc7(new byte[9] { 243, 208, 221, 221, 198, 232, 222, 204, 215 }, 191), new Vector2(_0xcecf7be6.MidX, _0xcecf7be6.PanelHeight * 0.5f), new Vector2(_0xcecf7be6.PanelWidth, _0xcecf7be6.PanelHeight), null, _0xe058d175.Alpha(_0xe058d175.Abyss, 0.35f), 1f);
        _0x28bc4541.raycastTarget = false;
        this._0x2625d63f = _0xcecf7be6.Picture(_0xab4250d1, _0x41092f04._0xafac7cc7(new byte[11] { 110, 77, 64, 64, 91, 96, 80, 71, 67, 86, 74 }, 34), new Vector2(_0xcecf7be6.MidX, 2043f), new Vector2(1180f, 1180f), this._art != null ? this._art._0x38f9d754 : null, _0xe058d175.Alpha(_0xe058d175.Violet, 0.16f));
        if (_0xaa0251af._0x70f7e906)
            return;
        this._0x2625d63f.rectTransform.DOScale(1.06f, 4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0x2625d63f.gameObject);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x14a018fd()
    {
        Sprite _0x4fe4ae2d = this._art != null ? this._art._0xfae782aa : null;
        // -- coin pill -------------------------------------------------------------------
        this._0x08aa9d20 = _0xcecf7be6.Frame(this._0xf2f3b634, _0x41092f04._0xafac7cc7(new byte[8] { 246, 218, 220, 219, 229, 220, 217, 217 }, 181), new Vector2(_0xcecf7be6.MidX, 2539f), new Vector2(PillW, PillH), _0x4fe4ae2d, _0xe058d175.Gold, _0xe058d175.Alpha(_0xe058d175.Surface, 0.96f), 26f, 4f);
        _0xcecf7be6.Picture(this._0x08aa9d20, _0x41092f04._0xafac7cc7(new byte[8] { 183, 142, 139, 139, 164, 136, 142, 137 }, 231), new Vector2(62f, PillH * 0.5f), new Vector2(72f, 72f), this._art != null ? this._art._0x6cba7c24 : null, _0xe058d175.White);
        // Two bands that never share x: the coin gutter ends at 98, the value starts at 128,
        // and the caption starts at 380 - 42 clear of the value's right edge (C.25).
        this._0x4c8b7e80 = _0xcecf7be6.Label(this._0x08aa9d20, _0x41092f04._0xafac7cc7(new byte[9] { 215, 238, 235, 235, 209, 230, 235, 242, 226 }, 135), new Vector2(233f, PillH * 0.5f), new Vector2(210f, 60f), _0x41092f04._0xafac7cc7(new byte[1] { 55 }, 7), 46f, 28f, _0xe058d175.Gold, this._font, TextAlignmentOptions.Left);
        _0xcecf7be6.Label(this._0x08aa9d20, _0x41092f04._0xafac7cc7(new byte[11] { 19, 42, 47, 47, 0, 34, 51, 55, 42, 44, 45 }, 67), new Vector2(465f, PillH * 0.5f), new Vector2(170f, 48f), _0x41092f04._0xafac7cc7(new byte[10] { 150, 130, 149, 149, 240, 147, 159, 153, 158, 131 }, 208), 28f, 28f, _0xe058d175.TextMuted, this._font, TextAlignmentOptions.Right);
        // -- room stage ------------------------------------------------------------------
        this._0x1c3afaed = _0xcecf7be6.Node(this._0xf2f3b634, _0x41092f04._0xafac7cc7(new byte[9] { 38, 27, 27, 25, 39, 0, 21, 19, 17 }, 116), new Vector2(_0xcecf7be6.MidX, 2043f), new Vector2(StageW, StageH));
        // -- room selector ---------------------------------------------------------------
        this._0xe45e9de3 = _0xcecf7be6.Node(this._0xf2f3b634, _0x41092f04._0xafac7cc7(new byte[9] { 129, 188, 188, 190, 144, 187, 186, 163, 160 }, 211), new Vector2(_0xcecf7be6.MidX, 1599f), new Vector2(ChipRowW, ChipRowH));
        // -- mission strip ---------------------------------------------------------------
        RectTransform _0x840fd015 = _0xcecf7be6.Node(this._0xf2f3b634, _0x41092f04._0xafac7cc7(new byte[12] { 54, 18, 8, 8, 18, 20, 21, 40, 15, 9, 18, 11 }, 123), new Vector2(_0xcecf7be6.MidX, 1263f), new Vector2(1060f, 420f));
        if (this._missions != null)
            this._missions._0x3c59bc32(_0x840fd015, this._art, this._font, this);
        // -- secondary navigation --------------------------------------------------------
        RectTransform _0x0be522f5 = _0xcecf7be6.Node(this._0xf2f3b634, _0x41092f04._0xafac7cc7(new byte[8] { 31, 60, 49, 49, 42, 29, 50, 37 }, 83), new Vector2(_0xcecf7be6.MidX, 470f), new Vector2(1140f, NavH));
        Button _0xc6604ebc = this._0xa11e0b44(_0x0be522f5, _0x41092f04._0xafac7cc7(new byte[8] { 112, 95, 72, 124, 81, 80, 75, 77 }, 62), 0, _0x41092f04._0xafac7cc7(new byte[11] { 231, 226, 234, 239, 250, 169, 225, 236, 237, 246, 240 }, 163), _0xe058d175.Gold);
        _0xc6604ebc.onClick.AddListener(() => this._0x8dfd0045());
        Button _0x6f80e41d = this._0xa11e0b44(_0x0be522f5, _0x41092f04._0xafac7cc7(new byte[8] { 239, 192, 215, 224, 205, 195, 212, 204 }, 161), 1, _0x41092f04._0xafac7cc7(new byte[9] { 197, 199, 207, 136, 195, 206, 192, 215, 207 }, 130), _0xe058d175.VioletSoft);
        _0x6f80e41d.onClick.AddListener(() => this._0x05a9e167());
        Button _0x07daffea = this._0xa11e0b44(_0x0be522f5, _0x41092f04._0xafac7cc7(new byte[8] { 102, 73, 94, 122, 93, 68, 77, 91 }, 40), 2, _0x41092f04._0xafac7cc7(new byte[10] { 174, 168, 164, 172, 227, 187, 188, 165, 172, 186 }, 233), _0xe058d175.TextSecondary);
        _0x07daffea.onClick.AddListener(() => this._0x27a90969());
        Button _0xcdaf436b = this._0xa11e0b44(_0x0be522f5, _0x41092f04._0xafac7cc7(new byte[11] { 126, 81, 70, 99, 85, 68, 68, 89, 94, 87, 67 }, 48), 3, _0x41092f04._0xafac7cc7(new byte[8] { 158, 136, 153, 153, 132, 131, 138, 158 }, 205), _0xe058d175.TextSecondary);
        _0xcdaf436b.onClick.AddListener(() => this._0xe31ff72a());
        _0xcecf7be6.Label(this._0xf2f3b634, _0x41092f04._0xafac7cc7(new byte[9] { 229, 198, 203, 203, 208, 231, 198, 221, 204 }, 169), new Vector2(_0xcecf7be6.MidX, 193f), new Vector2(1120f, 64f), _0x41092f04._0xafac7cc7(new byte[49] { 41, 32, 61, 79, 42, 33, 59, 42, 61, 59, 46, 38, 33, 34, 42, 33, 59, 79, 32, 33, 35, 54, 79, 66, 79, 33, 32, 79, 61, 42, 46, 35, 79, 34, 32, 33, 42, 54, 67, 79, 33, 32, 79, 63, 61, 38, 53, 42, 60 }, 111), 30f, 28f, _0xe058d175.TextMuted, this._font, TextAlignmentOptions.Center);
    }

    private RectTransform _0x2a8d4022;
    /// <summary>Grouped integers, no currency symbol anywhere: the coins are fictional.</summary>
    public static string Money(int _0x856f9c98)
    {
        string _0x20a79f03 = Mathf.Max(0, _0x856f9c98).ToString();
        string _0xe98ffeb7 = "";
        int _0x673314c2 = 0;
        for (int _0x3a03acb8 = _0x20a79f03.Length - 1; _0x3a03acb8 >= 0; _0x3a03acb8--)
        {
            _0xe98ffeb7 = _0x20a79f03[_0x3a03acb8] + _0xe98ffeb7;
            _0x673314c2++;
            if (_0x673314c2 % 3 == 0 && _0x3a03acb8 > 0)
                _0xe98ffeb7 = _0x41092f04._0xafac7cc7(new byte[1] { 226 }, 206) + _0xe98ffeb7;
        }

        return _0xe98ffeb7;
    }

    private void OnDestroy()
    {
        this._0xa0dd7eab();
        DOTween.Kill(this.transform, false);
    }

    private void _0xc57f3384(int _0x79537e54)
    {
        if (_0x79537e54 >= _0xaa0251af._0x7129f7f3)
            return;
        _0xaa0251af._0x1a827b81 = _0x79537e54;
        _0xaa0251af.Save();
        this._0x9eaf4dea();
        this._0x43e1606a();
    }

    private void _0x05a9e167()
    {
        if (this._album != null)
            this._album._0x849c9006();
    }

    /// <summary>
    /// Rule G.3 fixes the button's RECT in the scene file. Its face is a different problem:
    /// on this template family the instance renders nothing at all (its only active graphic
    /// is a Fade with raycastTarget off), so the plate, the caption AND a hit layer are ours.
    /// The template Button component and its scene-loading driver are left exactly as they
    /// are - a second listener here would load the scene twice from one tap.
    /// </summary>
    private void _0xb5437d15(Button _0x7d06663f)
    {
        if (_0x7d06663f == null)
        {
            this._0xd78bcc55();
            return;
        }

        RectTransform _0xab137faf = _0xcecf7be6.Branch(_0x7d06663f.transform, _0x41092f04._0xafac7cc7(new byte[8] { 226, 222, 211, 203, 244, 211, 209, 215 }, 178));
        Sprite _0xdd29a5a2 = this._art != null ? this._art._0xfae782aa : null;
        // Every layer is pinned to the button's own rect rather than drawn at a size of its
        // own, so the face stays exact whatever rect the scene gives the button. The nominal
        // size below is only what the corner radius is computed against (rule G.3 fixes the
        // button at 760 x 168 in the scene file).
        Vector2 _0x84413f18 = new Vector2(760f, 168f);
        Vector2 _0xc5e275da = _0x84413f18 * 0.5f;
        Pin(_0xcecf7be6.Plate(_0xab137faf, _0x41092f04._0xafac7cc7(new byte[8] { 242, 206, 195, 219, 240, 203, 204, 197 }, 162), _0xc5e275da, _0x84413f18, _0xdd29a5a2, _0xe058d175.Gold, PlayFaceRadius).rectTransform, 0f);
        Pin(_0xcecf7be6.Plate(_0xab137faf, _0x41092f04._0xafac7cc7(new byte[8] { 222, 226, 239, 247, 204, 225, 234, 247 }, 142), _0xc5e275da, _0x84413f18, _0xdd29a5a2, _0xe058d175.Ruby, PlayFaceRadius - 6f).rectTransform, 7f);
        RectTransform _0x4f5b2d86 = _0xcecf7be6.Plate(_0xab137faf, _0x41092f04._0xafac7cc7(new byte[9] { 90, 102, 107, 115, 89, 98, 111, 111, 100 }, 10), _0xc5e275da, new Vector2(700f, 54f), _0xdd29a5a2, _0xe058d175.Alpha(_0xe058d175.GoldSoft, 0.22f), 22f).rectTransform;
        _0x4f5b2d86.anchorMin = new Vector2(0.06f, 0.58f);
        _0x4f5b2d86.anchorMax = new Vector2(0.94f, 0.86f);
        _0x4f5b2d86.offsetMin = Vector2.zero;
        _0x4f5b2d86.offsetMax = Vector2.zero;
        // The hit layer comes before the caption so the label is never drawn under anything.
        _0xcecf7be6.HitLayer(_0xab137faf, _0x41092f04._0xafac7cc7(new byte[7] { 171, 151, 154, 130, 179, 146, 143 }, 251));
        TextMeshProUGUI _0x4fd3615b = _0xcecf7be6.Label(_0xab137faf, _0x41092f04._0xafac7cc7(new byte[11] { 120, 68, 73, 81, 107, 73, 88, 92, 65, 71, 70 }, 40), Vector2.zero, Vector2.one, _0x41092f04._0xafac7cc7(new byte[4] { 153, 133, 136, 144 }, 201), 68f, 36f, _0xe058d175.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0x4fd3615b.rectTransform.anchorMin = new Vector2(0.06f, 0.16f);
        _0x4fd3615b.rectTransform.anchorMax = new Vector2(0.94f, 0.84f);
        _0x4fd3615b.rectTransform.offsetMin = Vector2.zero;
        _0x4fd3615b.rectTransform.offsetMax = Vector2.zero;
        if (_0xaa0251af._0x70f7e906)
            return;
        this._0x2a8d4022 = _0xab137faf;
        _0xab137faf.DOScale(1.025f, 1.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0xab137faf.gameObject);
    }

    private void _0xf62b6590()
    {
        if (this._0x4c8b7e80 != null)
            this._0x4c8b7e80.text = Money(_0xaa0251af._0xa151f4ff);
    }

    /// <summary>Saves first, then hands over to the reels.</summary>
    private void _0x91f49893()
    {
        _0xaa0251af.Save();
        if (_0x697b0043.Instance != null)
            _0x697b0043.Instance._0x3abfd880(_0x4fc558d7._0xf3e0f416.SCENE_1);
    }

    private Image _0xda01bf4c;
    private void _0x27a90969()
    {
        if (this._rules != null)
            this._rules._0x8c61fc16();
    }

    /// <summary>
    /// Reduce Effects was toggled: the idle loops stop (or come back on the next repaint) at
    /// once, so the row visibly does something. Each loop is killed by ITS OWN target -
    /// DOTween indexes tweens by target, and killing this component's transform would leave
    /// every one of them running.
    /// </summary>
    public void _0xd649f68e()
    {
        if (_0xaa0251af._0x70f7e906)
        {
            this._0xa0dd7eab();
        }
        else if (this._0x2a8d4022 != null)
        {
            this._0x2a8d4022.DOScale(1.025f, 1.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0x2a8d4022.gameObject);
        }

        this._0x9eaf4dea();
    }

    private const float NavGap = 20f;
    private const float NavH = 130f;
    private const float NavW = 270f;
    /// <summary>PLAY's explicit height: 0.062 of the panel, well under the 0.25 ceiling.</summary>
    public const float PlayH = 168f;
    private RectTransform _0xf2f3b634;
    [SerializeField]
    private _0xb324b964 _settings;
    /// <summary>A claim paid out: show the new balance and punch the pill so the tap reads.</summary>
    public void _0x850577a0(int delta)
    {
        this._0xf62b6590();
        if (this._0x08aa9d20 == null)
            return;
        this._0x08aa9d20.DOPunchScale(new Vector3(0.08f, 0.08f, 0f), 0.34f, 7, 0.7f).SetLink(this._0x08aa9d20.gameObject);
        if (delta > 0 && _0xaa0251af._0x82fe9f6a)
            Handheld.Vibrate();
    }

    private Button _0xa11e0b44(RectTransform _0x2d292b16, string _0x38f5ef06, int _0x36dfe61e, string _0x36f5cd8d, Color _0xe41a6d1a)
    {
        float _0x7d55ea85 = (NavW * 0.5f) + (_0x36dfe61e * (NavW + NavGap));
        return _0xcecf7be6.Cta(_0x2d292b16, _0x38f5ef06, new Vector2(_0x7d55ea85, NavH * 0.5f), new Vector2(NavW, NavH), this._art != null ? this._art._0xfae782aa : null, _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, 0.96f), _0x36f5cd8d, 34f, 28f, _0xe41a6d1a, this._font, 24f);
    }

    /// <summary>A sheet closed: the balance and the missions may have moved underneath it.</summary>
    public void _0x8dc68993()
    {
        this._0xa8b264be();
    }

    private TextMeshProUGUI _0x4c8b7e80;
    private void _0x4a19764e(Transform _0x753dcabf)
    {
        if (this._vault != null)
            this._vault._0x44ec4587(_0xcecf7be6.Branch(_0x753dcabf, _0x41092f04._0xafac7cc7(new byte[10] { 13, 58, 46, 55, 47, 8, 51, 62, 62, 47 }, 91)), this._art, this._font, this);
        if (this._album != null)
            this._album._0x1ff48388(_0xcecf7be6.Branch(_0x753dcabf, _0x41092f04._0xafac7cc7(new byte[10] { 162, 143, 129, 150, 142, 176, 139, 134, 134, 151 }, 227)), this._art, this._font, this);
        if (this._rules != null)
            this._rules._0x62b3b3eb(_0xcecf7be6.Branch(_0x753dcabf, _0x41092f04._0xafac7cc7(new byte[10] { 211, 244, 237, 228, 242, 210, 233, 228, 228, 245 }, 129)), this._art, this._font, this);
        if (this._settings != null)
            this._settings._0x9a6e1938(_0xcecf7be6.Branch(_0x753dcabf, _0x41092f04._0xafac7cc7(new byte[13] { 49, 7, 22, 22, 11, 12, 5, 17, 49, 10, 7, 7, 22 }, 98)), this._art, this._font, this);
    }

    private RectTransform _0x1c3afaed;
    private const float StageH = 720f;
    private const float ChipW = 250f;
    private const float ChipRowH = 96f;
    /// <summary>
    /// Builds the primary call to action when the template supplies no scene-loading button.
    ///
    /// Its size is set EXPLICITLY - 760 x 168 at a collapsed anchor point, computed from the
    /// canvas reference resolution (760 is 0.61 of 1242; 168 is 0.062 of 2688, far under the
    /// quarter-screen ceiling). That is rule G.3's whole point: a BASE_BUTTON instance left on
    /// the template's stretching anchors becomes a slab across the full width and most of the
    /// height of the menu, which is how five shipped games ended up with geometrically
    /// identical menus and no room for anything else.
    ///
    /// The scene is addressed by SETTINGS index through the template controller, and the
    /// handler is a LAMBDA - a method group here compiles and then dies in the obfuscated
    /// cloud build with CS0103, because Plana renames the declaration and leaves the bare
    /// reference (C.1).
    /// </summary>
    private void _0xd78bcc55()
    {
        Button _0x330bb113 = _0xcecf7be6.Cta(this._0xf2f3b634, _0x41092f04._0xafac7cc7(new byte[10] { 193, 253, 240, 232, 211, 228, 229, 229, 254, 255 }, 145), new Vector2(_0xcecf7be6.MidX, PlayPanelY), new Vector2(PlayW, PlayH), this._art != null ? this._art._0xfae782aa : null, _0xe058d175.Ruby, _0x41092f04._0xafac7cc7(new byte[4] { 194, 222, 211, 203 }, 146), 68f, 36f, _0xe058d175.TextPrimary, this._font, PlayFaceRadius);
        _0x330bb113.onClick.AddListener(() => this._0x91f49893());
        this._0x2a8d4022 = _0x330bb113.GetComponent<RectTransform>();
        if (_0xaa0251af._0x70f7e906 || this._0x2a8d4022 == null)
            return;
        this._0x2a8d4022.DOScale(1.025f, 1.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0x2a8d4022.gameObject);
    }

    private const float PillH = 104f;
    private const float ChipGap = 20f;
    /// <summary>Panel centre of PLAY: 0.3 of the 2688-unit panel. The scenario taps here.</summary>
    public const float PlayPanelY = 806.4f;
    private void _0x43e1606a()
    {
        if (this._0xe45e9de3 == null)
            return;
        _0xcecf7be6.Clear(this._0xe45e9de3);
        Sprite _0xa58c3904 = this._art != null ? this._art._0xfae782aa : null;
        int _0x5ebcadb3 = _0xaa0251af.RefreshRooms();
        int _0x0686e729 = _0xaa0251af._0x1a827b81;
        for (int _0x5a18b9a7 = 0; _0x5a18b9a7 < _0xaa0251af.RoomCount; _0x5a18b9a7++)
        {
            bool _0x5e8e7019 = _0x5a18b9a7 < _0x5ebcadb3;
            bool _0x35093a1f = _0x5a18b9a7 == _0x0686e729;
            float _0x23aa296c = (ChipW * 0.5f) + (_0x5a18b9a7 * (ChipW + ChipGap));
            Color _0xc9031125 = _0x35093a1f ? _0xe058d175.Alpha(_0xe058d175.Ruby, 0.95f) : _0xe058d175.Alpha(_0xe058d175.SurfaceRaise, _0x5e8e7019 ? 0.95f : 0.6f);
            Color _0xcd17086a = _0x5e8e7019 ? _0xe058d175.TextPrimary : _0xe058d175.TextMuted;
            string _0xf8c212f5 = _0x5e8e7019 ? RoomName(_0x5a18b9a7).Replace(_0x41092f04._0xafac7cc7(new byte[1] { 75 }, 107), _0x41092f04._0xafac7cc7(new byte[1] { 20 }, 30)) : _0xaa0251af.SetsNeeded(_0x5a18b9a7).ToString() + _0x41092f04._0xafac7cc7(new byte[9] { 58, 119, 117, 125, 16, 99, 117, 100, 99 }, 48);
            Button _0x2c019af5 = _0xcecf7be6.Cta(this._0xe45e9de3, _0x41092f04._0xafac7cc7(new byte[8] { 22, 43, 43, 41, 7, 44, 45, 52 }, 68), new Vector2(_0x23aa296c, ChipRowH * 0.5f), new Vector2(ChipW, ChipRowH), _0xa58c3904, _0xc9031125, _0xf8c212f5, 30f, 28f, _0xcd17086a, this._font, 20f);
            _0x2c019af5.interactable = _0x5e8e7019;
            int _0x05a8981c = _0x5a18b9a7;
            _0x2c019af5.onClick.AddListener(() => this._0xc57f3384(_0x05a8981c));
        }
    }

    [SerializeField]
    private _0x98683103 _splash;
    private const float PillW = 560f;
    [SerializeField]
    private _0x1ea45921 _rules;
    /// <summary>Pins a rect to its parent with an equal inset on every side.</summary>
    private static void Pin(RectTransform _0x686da8c4, float _0xacd97c81)
    {
        _0x686da8c4.anchorMin = Vector2.zero;
        _0x686da8c4.anchorMax = Vector2.one;
        _0x686da8c4.offsetMin = new Vector2(_0xacd97c81, _0xacd97c81);
        _0x686da8c4.offsetMax = new Vector2(-_0xacd97c81, -_0xacd97c81);
    }
}

internal static class _0x41092f04
{
    internal static string _0xafac7cc7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}