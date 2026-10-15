using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The five reels, drawn in UGUI like the rest of the game. There is no SpriteRenderer and no
/// world-space text anywhere in this project, so draw order is purely sibling order and no
/// layout number is ever derived from the camera.
///
/// The spin is PRESENTATION ONLY. Every stop is chosen by <see cref = "SlotRunDirector"/> the
/// instant the spin starts and handed here as a finished vector; this class moves symbols and
/// then lands on exactly those stops. The quick-stop tap shortens the animation and can never
/// change what the reels read - which is the whole difference between a slot machine and a
/// reaction test.
///
/// Motion is integrated in <see cref = "Update"/> rather than tweened. A tween writing the same
/// offset that Update also advances gives two owners for one number, and the reel visibly
/// stutters where they hand over; one owner and an explicit easing curve cannot.
/// </summary>
public sealed class _0x561b26c9 : MonoBehaviour
{
    private const int PhaseStopping = 2;
    private float[] _0xfa285455;
    /// <summary>The cell object currently sitting in a visible row of a column.</summary>
    private RectTransform _0xec84877b(int _0x8cd3d772, int _0x310d05a3)
    {
        if (this._0xd7920439 == null)
            return null;
        int _0x23ec9202 = Mathf.FloorToInt(this._0xc83ddc7c[_0x8cd3d772]);
        int _0x83d014cf = _0x23ec9202 + 1 + _0x310d05a3;
        for (int _0x62b1d431 = 0; _0x62b1d431 < CellsPerReel; _0x62b1d431++)
            if (_0x23ec9202 + _0x62b1d431 == _0x83d014cf)
                return this._0xd7920439[_0x8cd3d772, _0x62b1d431];
        return null;
    }

    /// <summary>Visible rows plus one spare above and one below, so no gap can open.</summary>
    private const int CellsPerReel = 5;
    /// <summary>Places the window on a stop vector with no animation, for the opening board.</summary>
    public void _0x0f3eaef1(int[] _0xe74fbf32)
    {
        if (!this._0xe626ecc2 || this._0xf34e3903 == null || _0xe74fbf32 == null)
            return;
        for (int _0x7207d30b = 0; _0x7207d30b < _0xbb4bed3e.Columns; _0x7207d30b++)
        {
            this._0x1489ea6e[_0x7207d30b] = _0xe74fbf32[_0x7207d30b];
            this._0xc83ddc7c[_0x7207d30b] = _0xe74fbf32[_0x7207d30b] - 1;
            this._0xf120c3b8[_0x7207d30b] = PhaseRest;
            this._0x75bd2754(_0x7207d30b);
        }

        this._0xa4e772e5 = false;
    }

    private _0x65cc6a73[, ] _0xe0cd0a0a;
    /// <summary>
    /// Makes sure the board exists before anything reads it. Nothing here relies on the order
    /// of Start calls between components (C.59).
    /// </summary>
    public bool _0x62799093()
    {
        return this._0xe626ecc2;
    }

    /// <summary>
    /// Draws the board once. <paramref name = "onTap"/> is the quick-stop handler; it is wired
    /// to a full-board Button rather than to raw touch, so the EventSystem owns the tap and a
    /// tap that dismissed a popup can never also reach the reels.
    /// </summary>
    public void _0x6fbf89bf(RectTransform _0x08748262, _0x30d693a6 _0xf82fbb0f, TMP_FontAsset _0x8bc197d2, System.Action _0xf180ee34)
    {
        if (_0x08748262 == null)
            return;
        this._0x3156510e = _0xf82fbb0f;
        Sprite _0xb451b0a9 = _0xf82fbb0f != null ? _0xf82fbb0f._0xfae782aa : null;
        RectTransform _0xdf1c4d35 = _0xcecf7be6.Node(_0x08748262, _0xe036bb56._0x8a4165e5(new byte[9] { 201, 254, 254, 247, 217, 244, 250, 233, 255 }, 155), new Vector2(_0xcecf7be6.MidX, BoardCentreY), new Vector2(BoardWidth, BoardHeight));
        // The trim is drawn BEFORE the symbols. Its body is opaque, and a frame created after
        // the content it surrounds covers that content's middle (C.13).
        _0xcecf7be6.Frame(_0xdf1c4d35, _0xe036bb56._0x8a4165e5(new byte[9] { 109, 64, 78, 93, 75, 123, 93, 70, 66 }, 47), new Vector2(BoardWidth * 0.5f, BoardHeight * 0.5f), new Vector2(BoardWidth, BoardHeight), _0xb451b0a9, _0xe058d175.Gold, _0xe058d175.Alpha(_0xe058d175.Abyss, 0.96f), 36f, 8f);
        this._0x3b6d5af6 = new Image[_0xbb4bed3e.Columns, CellsPerReel];
        this._0xd7920439 = new RectTransform[_0xbb4bed3e.Columns, CellsPerReel];
        this._0xe0cd0a0a = new _0x65cc6a73[_0xbb4bed3e.Columns, CellsPerReel];
        this._0xc83ddc7c = new float[_0xbb4bed3e.Columns];
        this._0xf120c3b8 = new int[_0xbb4bed3e.Columns];
        this._0x26837009 = new float[_0xbb4bed3e.Columns];
        this._0xff96fc1f = new float[_0xbb4bed3e.Columns];
        this._0x1002bd5e = new float[_0xbb4bed3e.Columns];
        this._0xfa285455 = new float[_0xbb4bed3e.Columns];
        this._0x2657b755 = new float[_0xbb4bed3e.Columns];
        this._0x1489ea6e = new int[_0xbb4bed3e.Columns];
        float _0x860764f3 = (Cell * 3f) + (Gap * 2f);
        for (int _0x4ff14ffc = 0; _0x4ff14ffc < _0xbb4bed3e.Columns; _0x4ff14ffc++)
        {
            float _0xf7e1f8d2 = Frame + (Cell * 0.5f) + (_0x4ff14ffc * Pitch);
            RectTransform _0xaec4fb7b = _0xcecf7be6.Node(_0xdf1c4d35, _0xe036bb56._0x8a4165e5(new byte[4] { 76, 123, 123, 114 }, 30), new Vector2(_0xf7e1f8d2, BoardHeight * 0.5f), new Vector2(Cell, _0x860764f3));
            // Without a mask the spare cells above and below the window draw over the trim.
            _0xaec4fb7b.gameObject.AddComponent<RectMask2D>();
            for (int _0x8c207681 = 0; _0x8c207681 < CellsPerReel; _0x8c207681++)
            {
                // Seeded with a real sprite, never null: Unity draws an Image without one as a
                // solid WHITE RECTANGLE and reports no error at all (B.1).
                Sprite _0xfb75b3d8 = _0xf82fbb0f != null ? _0xf82fbb0f._0x2b16b7b0(_0x65cc6a73.Ruby) : null;
                Image _0x9f77acf9 = _0xcecf7be6.Picture(_0xaec4fb7b, _0xe036bb56._0x8a4165e5(new byte[4] { 76, 107, 105, 111 }, 10), new Vector2(Cell * 0.5f, TopRowY), new Vector2(Cell * 0.9f, Cell * 0.9f), _0xfb75b3d8, _0xe058d175.White);
                _0x9f77acf9.enabled = _0xfb75b3d8 != null;
                this._0x3b6d5af6[_0x4ff14ffc, _0x8c207681] = _0x9f77acf9;
                this._0xd7920439[_0x4ff14ffc, _0x8c207681] = _0x9f77acf9.rectTransform;
            }
        }

        // Marks come after the reels so a lit cell is drawn ON TOP of its symbol.
        this._0x0cc80da7 = new RectTransform[_0xbb4bed3e.Rows * _0xbb4bed3e.Columns];
        for (int _0x286215e3 = 0; _0x286215e3 < _0xbb4bed3e.Rows; _0x286215e3++)
        {
            for (int _0x2e3179d3 = 0; _0x2e3179d3 < _0xbb4bed3e.Columns; _0x2e3179d3++)
            {
                RectTransform _0x86cdb210 = _0xcecf7be6.Node(_0xdf1c4d35, _0xe036bb56._0x8a4165e5(new byte[7] { 180, 138, 141, 174, 130, 145, 136 }, 227), CellCentre(_0x286215e3, _0x2e3179d3), new Vector2(Cell, Cell));
                _0xcecf7be6.Plate(_0x86cdb210, _0xe036bb56._0x8a4165e5(new byte[8] { 176, 156, 143, 150, 175, 148, 147, 154 }, 253), new Vector2(Cell * 0.5f, Cell * 0.5f), new Vector2(Cell, Cell), _0xb451b0a9, _0xe058d175.Alpha(_0xe058d175.Gold, 0.9f), 26f);
                _0xcecf7be6.Plate(_0x86cdb210, _0xe036bb56._0x8a4165e5(new byte[8] { 54, 26, 9, 16, 56, 20, 9, 30 }, 123), new Vector2(Cell * 0.5f, Cell * 0.5f), new Vector2(Cell - 16f, Cell - 16f), _0xb451b0a9, _0xe058d175.Alpha(_0xe058d175.Ruby, 0.16f), 20f);
                _0x86cdb210.gameObject.SetActive(false);
                this._0x0cc80da7[(_0x286215e3 * _0xbb4bed3e.Columns) + _0x2e3179d3] = _0x86cdb210;
            }
        }

        // A low-alpha highlight is the one thing allowed above the content (C.13).
        _0xcecf7be6.Plate(_0xdf1c4d35, _0xe036bb56._0x8a4165e5(new byte[10] { 176, 157, 147, 128, 150, 161, 154, 151, 151, 156 }, 242), new Vector2(BoardWidth * 0.5f, BoardHeight - 96f), new Vector2(BoardWidth - 60f, 150f), _0xb451b0a9, _0xe058d175.Alpha(_0xe058d175.GoldSoft, 0.1f), 30f);
        Button _0x9e4aeaa5 = _0xcecf7be6.Shade(_0xdf1c4d35, _0xe036bb56._0x8a4165e5(new byte[8] { 148, 185, 183, 164, 178, 130, 183, 166 }, 214), new Color(1f, 1f, 1f, 0.004f));
        if (_0xf180ee34 != null)
            _0x9e4aeaa5.onClick.AddListener(() => _0xf180ee34());
        this._0xe626ecc2 = true;
    }

    private const float QuickSpinUp = 0.25f;
    private const float SpinUp = 0.6f;
    private const float StopDuration = 0.45f;
    /// <summary>Board width in panel units. The panel is 1242 wide, so this leaves 63 a side.</summary>
    public const float BoardWidth = 1116f;
    private const float QuickStagger = 0.1f;
    /// <summary>
    /// Back-out easing with a modest overshoot, so a reel settles with the small bounce a
    /// mechanical one has. Written out rather than taken from DOTween because the offset is
    /// integrated here, not tweened.
    /// </summary>
    private static float OutBack(float _0x79cff943)
    {
        float _0xead24bd2 = 1.1f;
        float _0x780c2bc7 = _0x79cff943 - 1f;
        return (_0x780c2bc7 * _0x780c2bc7 * (((_0xead24bd2 + 1f) * _0x780c2bc7) + _0xead24bd2)) + 1f;
    }

    private float[] _0x26837009;
    /// <summary>True while any reel is still moving.</summary>
    public bool _0xf65a1466
    {
        get
        {
            return this._0xa4e772e5;
        }
    }

    private float _0xac86e37d;
    private const float QuickStopDuration = 0.22f;
    /// <summary>Puts every cell back to its resting look.</summary>
    public void _0x3af12fda()
    {
        if (this._0x0cc80da7 == null)
            return;
        for (int _0xc44943d7 = 0; _0xc44943d7 < this._0x0cc80da7.Length; _0xc44943d7++)
        {
            RectTransform _0xd3b62ab6 = this._0x0cc80da7[_0xc44943d7];
            if (_0xd3b62ab6 == null)
                continue;
            DOTween.Kill(_0xd3b62ab6, false);
            _0xd3b62ab6.gameObject.SetActive(false);
        }
    }

    /// <summary>Lights every cell on a paying line and punches its symbol.</summary>
    public void _0x5f38ac76(_0xf5a115d4.LineResult[] _0x2359b5a8)
    {
        this._0x3af12fda();
        if (!this._0xe626ecc2 || _0x2359b5a8 == null)
            return;
        for (int _0xabbcff05 = 0; _0xabbcff05 < _0x2359b5a8.Length; _0xabbcff05++)
        {
            _0xf5a115d4.LineResult _0x02e6b618 = _0x2359b5a8[_0xabbcff05];
            if (_0x02e6b618.Multiplier <= 0f || _0x02e6b618.Run < _0xbb4bed3e.MinRun)
                continue;
            for (int _0x139a3a2a = 0; _0x139a3a2a < _0x02e6b618.Run && _0x139a3a2a < _0xbb4bed3e.Columns; _0x139a3a2a++)
            {
                int _0x787a10f3 = _0xbb4bed3e.RowOf(_0x02e6b618.Line, _0x139a3a2a);
                RectTransform _0xccc844df = this._0x0cc80da7[(_0x787a10f3 * _0xbb4bed3e.Columns) + _0x139a3a2a];
                if (_0xccc844df == null || _0xccc844df.gameObject.activeSelf)
                    continue;
                _0xccc844df.gameObject.SetActive(true);
                if (_0xaa0251af._0x70f7e906)
                    continue;
                Image _0x87128b45 = _0xccc844df.GetComponentInChildren<Image>(true);
                if (_0x87128b45 != null)
                {
                    _0x87128b45.color = _0xe058d175.Alpha(_0xe058d175.Gold, 0.2f);
                    _0x87128b45.DOFade(0.92f, 0.34f).SetLoops(6, LoopType.Yoyo).SetLink(_0x87128b45.gameObject);
                }

                RectTransform _0xc6126ad9 = this._0xec84877b(_0x139a3a2a, _0x787a10f3);
                if (_0xc6126ad9 != null)
                    _0xc6126ad9.DOPunchScale(Vector3.one * 0.16f, 0.45f, 8, 0.6f).SetLink(_0xc6126ad9.gameObject);
            }
        }
    }

    private System.Action _0x4dd313e3;
    /// <summary>
    /// Picks the landing offset: the first value at or below the current one that is at least
    /// <see cref = "MinTravel"/> symbols away AND reads as the chosen stop. The reel therefore
    /// always keeps travelling downwards into its result and never jumps backwards.
    /// </summary>
    private void _0x0552978d(int _0x0e63f082, int _0xaed8f591)
    {
        float _0x7317e902 = this._0x1489ea6e[_0x0e63f082] - 1;
        float _0xf128668c = this._0x2657b755[_0x0e63f082] <= SnapDuration ? QuickTravel : MinTravel;
        float _0x7b9b1d67 = this._0xc83ddc7c[_0x0e63f082] - _0xf128668c;
        this._0xff96fc1f[_0x0e63f082] = this._0xc83ddc7c[_0x0e63f082];
        this._0x1002bd5e[_0x0e63f082] = _0x7b9b1d67 - Mod(_0x7b9b1d67 - _0x7317e902, _0xaed8f591);
        this._0xfa285455[_0x0e63f082] = this._0xac86e37d;
        this._0xf120c3b8[_0x0e63f082] = PhaseStopping;
    }

    /// <summary>
    /// Brings every reel that is still free down onto the stop it was already given. The
    /// outcome does not move - only the time it takes to show it.
    /// </summary>
    public void _0xc44f4cf1()
    {
        if (!this._0xe626ecc2 || !this._0xa4e772e5)
            return;
        for (int _0xfebc9564 = 0; _0xfebc9564 < _0xbb4bed3e.Columns; _0xfebc9564++)
        {
            if (this._0xf120c3b8[_0xfebc9564] != PhaseFree)
                continue;
            this._0x26837009[_0xfebc9564] = this._0xac86e37d;
            this._0x2657b755[_0xfebc9564] = SnapDuration;
        }
    }

    /// <summary>Hands the session's verified strips to the view.</summary>
    public void _0x7ee7a7ba(_0x65cc6a73[][] _0xad8eab8a)
    {
        this._0xf34e3903 = _0xad8eab8a;
    }

    private const int PhaseRest = 0;
    private const float Cell = 204f;
    private int[] _0xf120c3b8;
    private int[] _0x1489ea6e;
    /// <summary>Always &gt;= 0 and &lt; <paramref name = "span"/>, for a value that may be negative.</summary>
    private static float Mod(float _0x12780fff, float _0x245c1b30)
    {
        return _0x12780fff - (_0x245c1b30 * Mathf.Floor(_0x12780fff / _0x245c1b30));
    }

    private const int QuickTravel = 6;
    private float[] _0xff96fc1f;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private const int MinTravel = 14;
    private const float Gap = 14f;
    private RectTransform[] _0x0cc80da7;
    private _0x65cc6a73[][] _0xf34e3903;
    private RectTransform[, ] _0xd7920439;
    /// <summary>Integer twin of <see cref = "Mod(float, float)"/>, for strip indices.</summary>
    private static int Mod(int _0x7aca5848, int _0x1d6ec515)
    {
        int _0xb63562fc = _0x7aca5848 % _0x1d6ec515;
        return _0xb63562fc < 0 ? _0xb63562fc + _0x1d6ec515 : _0xb63562fc;
    }

    private const float Frame = 20f;
    /// <summary>Panel centre of the board, between the mission ticker and the win readout.</summary>
    public const float BoardCentreY = 1560f;
    private _0x30d693a6 _0x3156510e;
    /// <summary>Board height, derived below from the cell size - not picked separately.</summary>
    public const float BoardHeight = 680f;
    /// <summary>
    /// Starts the animation towards an ALREADY DECIDED stop vector. The reels spin up together
    /// and stop left to right; <paramref name = "onSettled"/> fires once the last one lands.
    /// </summary>
    public void _0xc399b654(int[] _0x47237533, bool _0x854ec594, System.Action _0x40025a57)
    {
        if (!this._0xe626ecc2 || this._0xf34e3903 == null || _0x47237533 == null)
            return;
        this._0x4dd313e3 = _0x40025a57;
        this._0xac86e37d = 0f;
        this._0xa4e772e5 = true;
        float _0x91b0d000 = _0x854ec594 ? QuickSpinUp : SpinUp;
        float _0xb95e7a5b = _0x854ec594 ? QuickStagger : Stagger;
        float _0x86939e91 = _0x854ec594 ? QuickStopDuration : StopDuration;
        for (int _0x4dd4fe93 = 0; _0x4dd4fe93 < _0xbb4bed3e.Columns; _0x4dd4fe93++)
        {
            this._0x1489ea6e[_0x4dd4fe93] = _0x47237533[_0x4dd4fe93];
            this._0xf120c3b8[_0x4dd4fe93] = PhaseFree;
            this._0x26837009[_0x4dd4fe93] = _0x91b0d000 + (_0x4dd4fe93 * _0xb95e7a5b);
            this._0x2657b755[_0x4dd4fe93] = _0x86939e91;
        }
    }

    private void Update()
    {
        if (!this._0xe626ecc2 || this._0xf34e3903 == null || !this._0xa4e772e5)
            return;
        float delta = Mathf.Min(Time.deltaTime, 0.05f);
        this._0xac86e37d += delta;
        int _0xbfbf35cf = this._0xf34e3903[0].Length;
        bool _0x664521b8 = false;
        for (int _0xfa2842d8 = 0; _0xfa2842d8 < _0xbb4bed3e.Columns; _0xfa2842d8++)
        {
            if (this._0xf120c3b8[_0xfa2842d8] == PhaseFree)
            {
                if (this._0xac86e37d >= this._0x26837009[_0xfa2842d8])
                    this._0x0552978d(_0xfa2842d8, _0xbfbf35cf);
                else
                    this._0xc83ddc7c[_0xfa2842d8] -= FreeSpeed * delta;
            }

            if (this._0xf120c3b8[_0xfa2842d8] == PhaseStopping)
            {
                float _0xa500fd8b = (this._0xac86e37d - this._0xfa285455[_0xfa2842d8]) / Mathf.Max(0.01f, this._0x2657b755[_0xfa2842d8]);
                if (_0xa500fd8b >= 1f)
                {
                    this._0xc83ddc7c[_0xfa2842d8] = this._0x1002bd5e[_0xfa2842d8];
                    this._0xf120c3b8[_0xfa2842d8] = PhaseRest;
                }
                else
                {
                    this._0xc83ddc7c[_0xfa2842d8] = Mathf.LerpUnclamped(this._0xff96fc1f[_0xfa2842d8], this._0x1002bd5e[_0xfa2842d8], OutBack(_0xa500fd8b));
                }
            }

            if (this._0xf120c3b8[_0xfa2842d8] != PhaseRest)
                _0x664521b8 = true;
            this._0x75bd2754(_0xfa2842d8);
        }

        if (_0x664521b8)
            return;
        this._0xa4e772e5 = false;
        System.Action _0xe5dc265a = this._0x4dd313e3;
        this._0x4dd313e3 = null;
        if (_0xe5dc265a != null)
            _0xe5dc265a();
    }

    private const float Stagger = 0.3f;
    /// <summary>Lays a column's cells out for its current offset and gives each its face.</summary>
    private void _0x75bd2754(int _0x6d400bb1)
    {
        if (this._0xf34e3903 == null)
            return;
        _0x65cc6a73[] _0x7de78a6e = this._0xf34e3903[_0x6d400bb1];
        int _0xfcae5792 = _0x7de78a6e.Length;
        float _0x74a18ba2 = this._0xc83ddc7c[_0x6d400bb1];
        int _0x57c2c265 = Mathf.FloorToInt(_0x74a18ba2);
        float _0xa2dea886 = _0x74a18ba2 - _0x57c2c265;
        for (int _0x979f6188 = 0; _0x979f6188 < CellsPerReel; _0x979f6188++)
        {
            RectTransform _0xfb25b435 = this._0xd7920439[_0x6d400bb1, _0x979f6188];
            if (_0xfb25b435 == null)
                continue;
            _0xfb25b435.anchoredPosition = new Vector2(Cell * 0.5f, TopRowY + (Pitch * (1f - _0x979f6188 + _0xa2dea886)));
            _0x65cc6a73 _0xd5bb7eb6 = _0x7de78a6e[Mod(_0x57c2c265 + _0x979f6188, _0xfcae5792)];
            if (this._0xe0cd0a0a[_0x6d400bb1, _0x979f6188] == _0xd5bb7eb6 && this._0x3b6d5af6[_0x6d400bb1, _0x979f6188].sprite != null)
                continue;
            this._0xe0cd0a0a[_0x6d400bb1, _0x979f6188] = _0xd5bb7eb6;
            Image _0xffee3618 = this._0x3b6d5af6[_0x6d400bb1, _0x979f6188];
            _0xffee3618.sprite = this._0x3156510e != null ? this._0x3156510e._0x2b16b7b0(_0xd5bb7eb6) : null;
            _0xffee3618.preserveAspect = true;
            _0xffee3618.enabled = _0xffee3618.sprite != null;
        }
    }

    private const float FreeSpeed = 18f;
    private const int PhaseFree = 1;
    /// <summary>Panel-space centre of a cell, used by the win marks.</summary>
    private static Vector2 CellCentre(int _0xeaa4274f, int _0x49e55d31)
    {
        float _0x4c9b08b9 = Frame + (Cell * 0.5f) + (_0x49e55d31 * Pitch);
        float _0x1b87bc35 = BoardHeight - Frame - (Cell * 0.5f) - (_0xeaa4274f * Pitch);
        return new Vector2(_0x4c9b08b9, _0x1b87bc35);
    }

    private Image[, ] _0x3b6d5af6;
    private const float Pitch = Cell + Gap;
    private float[] _0x1002bd5e;
    private bool _0xa4e772e5;
    /// <summary>What a tap cuts the remaining stop time down to.</summary>
    private const float SnapDuration = 0.14f;
    private float[] _0x2657b755;
    private float[] _0xc83ddc7c;
    /// <summary>Row 0's centre inside a reel column, measured from the column's bottom.</summary>
    private const float TopRowY = (Cell * 3f) + (Gap * 2f) - (Cell * 0.5f);
    private bool _0xe626ecc2;
}

internal static class _0xe036bb56
{
    internal static string _0x8a4165e5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}