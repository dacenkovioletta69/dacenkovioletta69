using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// The game scene's brain: it draws the session's reel strips, owns the run state machine,
/// decides every spin's outcome, pays it and raises the result cards.
///
/// THE OUTCOME IS DECIDED THE INSTANT A SPIN STARTS. The stop vector is drawn here, scored by
/// <see cref = "SpinResolver"/> here, and only then handed to <see cref = "ReelBoardView"/> to be
/// animated. Tapping the reels shortens the animation and can never move the result - which is
/// what separates a slot machine from a reaction test.
///
/// THERE IS NO FAIL STATE AND NO TIMER. A baseline session - not one tap, not one pickup -
/// never ends: the idle backstop keeps spinning and a balance below the stake is refilled
/// rather than ended. That matters beyond the design: the review album's first gameplay frame
/// lands around second 15 and its last around second 30, and a run that can finish before then
/// returns five photographs of a defeat card instead of a game (C.5).
/// </summary>
public sealed class _0x097d9957 : MonoBehaviour
{
    private const int StateSpinning = 1;
    /// <summary>
    /// The game's panel body, reached by SETTINGS index. Never by name: the obfuscator renames
    /// every object in the project and a string would resolve to nothing.
    /// </summary>
    private Transform _0xbfbae215()
    {
        if (_0x868e2cfd.Instance == null || _0x868e2cfd.Instance.Panels == null)
            return null;
        int _0x8f65a0a9 = _0x4fc558d7._0xb679ca6b.DEFAULT;
        if (_0x8f65a0a9 < 0 || _0x8f65a0a9 >= _0x868e2cfd.Instance.Panels.Count)
            return null;
        _0x39e04600 _0x587ccbf5 = _0x868e2cfd.Instance.Panels[_0x8f65a0a9];
        if (_0x587ccbf5 == null || _0x587ccbf5.Content == null)
            return null;
        return _0x587ccbf5.Content.transform;
    }

    /// <summary>The pause button, raising the card through the controller's own index.</summary>
    public void _0x9af127eb()
    {
        this._0x5e2b8b2d = Time.unscaledTime;
        this._0xcc1a1a2e();
        if (this._pops != null)
            this._pops._0x270d6bd3();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    /// <summary>The SPIN button. Also the only place a stake is ever taken.</summary>
    public void _0x2a6a7868()
    {
        this._0x5e2b8b2d = Time.unscaledTime;
        this._0x22996256(true);
    }

    /// <summary>Moves the stake one step along the ladder.</summary>
    public void _0xa7cdec5e(int _0xb62016d7)
    {
        this._0x5e2b8b2d = Time.unscaledTime;
        int _0xe014ef0c = Mathf.Clamp(_0xaa0251af._0x892a39cd + _0xb62016d7, 0, _0xaa0251af._0xcb593797 - 1);
        if (_0xe014ef0c == _0xaa0251af._0x892a39cd)
            return;
        _0xaa0251af._0x892a39cd = _0xe014ef0c;
        _0xaa0251af.Save();
        if (this._hud != null)
            this._hud._0x224302ca(_0xe014ef0c);
    }

    /// <summary>
    /// Coins, shards and objectives are written out BEFORE a card goes up. The card's own
    /// buttons reload the scene, so anything still only in memory at that moment is lost.
    /// </summary>
    public void _0xcc1a1a2e()
    {
        _0xaa0251af.Save();
    }

    /// <summary>
    /// The opening two spins of a fresh install are drawn from a CLASS of outcome rather than
    /// left to chance: the first pays a line, the second pays a card. Which symbols land and
    /// where is still the generator's business - only the shape is arranged, so the review
    /// album reliably contains a lit payline and a result card without any of it being
    /// hardcoded (C.11).
    /// </summary>
    private int[] _0x725a5d84()
    {
        int _0xd9fea61c = _0xaa0251af._0x142b2a87;
        if (_0xd9fea61c >= 2)
            return null;
        _0x65cc6a73 _0x676b0934 = _0xd9fea61c == 0 ? _0x65cc6a73.Bell : _0x65cc6a73.Ruby;
        int _0x4d5b1e7c = _0xd9fea61c == 0 ? 3 : 4;
        int[] _0x6ad14268 = _0x6e1ac46d.Construct(this._0x51a2cbc5, _0x676b0934, _0x4d5b1e7c, this._0x4ff40b53);
        if (_0x6ad14268 == null)
            return null;
        _0xaa0251af._0x142b2a87 = _0xd9fea61c + 1;
        for (int _0x9c6091e9 = 0; _0x9c6091e9 < _0xbb4bed3e.Columns; _0x9c6091e9++)
            this._0x7a303baf[_0x9c6091e9] = _0x6ad14268[_0x9c6091e9];
        return this._0x7a303baf;
    }

    /// <summary>How long the counters animate before the state returns to idle.</summary>
    private const float ResolveWindow = 0.6f;
    /// <summary>
    /// A balance below the stake is topped up rather than ended. The card is the LOSE slot
    /// recaptioned, because the template has three cards and this game has no loss to show in
    /// one of them.
    /// </summary>
    private void _0x38917f40()
    {
        _0xaa0251af._0xa151f4ff = _0xaa0251af._0xa151f4ff + _0xaa0251af.RefillCoins;
        _0xaa0251af.Save();
        if (this._hud != null)
            this._hud._0x1cefc27c(_0xaa0251af._0xa151f4ff, true);
        if (this._pops != null)
            this._pops._0xa90cab98(_0xaa0251af.RefillCoins);
    }

    private float _0x5e2b8b2d;
    private System.Random _0x4ff40b53;
    [SerializeField]
    private TMP_FontAsset _font;
    private int[] _0x7a303baf;
    private void Update()
    {
        bool _0xc9cd68ae = this._pops != null && this._pops._0x5b11844c();
        // A card closing counts as activity, so the backstop never fires into the frame the
        // player is still looking at.
        if (this._0xa73498b6 && !_0xc9cd68ae)
            this._0x5e2b8b2d = Time.unscaledTime;
        this._0xa73498b6 = _0xc9cd68ae;
        if (_0xc9cd68ae)
        {
            this._0x5e2b8b2d = Time.unscaledTime;
            return;
        }

        if (this._0x5c2dc1cb == StateResolving && Time.unscaledTime >= this._0xba233f67)
        {
            this._0x5c2dc1cb = StateIdle;
            this._0x5e2b8b2d = Time.unscaledTime - (IdleBackstop - BackstopRearm);
        }

        if (this._0x5c2dc1cb != StateIdle)
            return;
        if (Time.unscaledTime - this._0x5e2b8b2d < IdleBackstop)
            return;
        this._0x5e2b8b2d = Time.unscaledTime;
        this._0x22996256(false);
    }

    private _0x65cc6a73[][] _0x51a2cbc5;
    [SerializeField]
    private _0x49e7e897 _hud;
    private float _0xba233f67;
    private bool _0xa73498b6;
    [SerializeField]
    private _0x04115943 _nav;
    private const int StateResolving = 2;
    /// <summary>
    /// Collection shards. A four-of-a-kind always drops one of its own symbol; otherwise there
    /// is a flat chance of a shard of some symbol that actually appeared in the window, so a
    /// drop is always something the player just saw.
    /// </summary>
    private void _0x2c071967(_0xf5a115d4.SpinResult _0xbe0ba528)
    {
        _0x65cc6a73 _0xbc026d21;
        if (_0xbe0ba528.Best.Run >= 4)
        {
            _0xbc026d21 = _0xbe0ba528.Best.Symbol;
        }
        else
        {
            if (this._0x4ff40b53.NextDouble() >= ShardChance)
                return;
            int _0x7ab1e4c0 = this._0x4ff40b53.Next(_0xbb4bed3e.Rows);
            int _0xde8eabe2 = this._0x4ff40b53.Next(_0xbb4bed3e.Columns);
            _0xbc026d21 = this._0x2da63e5d[_0x7ab1e4c0, _0xde8eabe2];
        }

        int _0x145866dd = _0xaa0251af.CompletedSets();
        _0xaa0251af.AddShard(_0xbc026d21, 1);
        _0x3bad075c.Report(_0x3bad075c._0x7e41363e.Shard, 1);
        int _0x92b7da7e = _0xaa0251af.CompletedSets();
        if (_0x92b7da7e > _0x145866dd)
            _0x3bad075c.Report(_0x3bad075c._0x7e41363e.SetCompleted, _0x92b7da7e - _0x145866dd);
    }

    private const int StateIdle = 0;
    private void Start()
    {
        _0xaa0251af.EnsureSeeded();
        int _0x115dddf0 = _0xaa0251af.NextSession();
        int _0x66a291e9 = (_0x115dddf0 * 7919) ^ (_0xaa0251af._0x4087bef7 * 104729);
        this._0x4ff40b53 = new System.Random(_0x66a291e9);
        _0x3bad075c.EnsureDrawn(this._0x4ff40b53);
        _0x6e1ac46d.Report _0x1664169a;
        this._0x51a2cbc5 = _0x6e1ac46d.Build(this._0x4ff40b53, out _0x1664169a);
        this._0xd9682a62 = new _0xf5a115d4.LineResult[_0xbb4bed3e._0x181d0f56];
        this._0x7a303baf = new int[_0xbb4bed3e.Columns];
        {
#if B_LOGS
            {
                Debug.Log(_0x7d8bd08a._0xb1b2bbe2(new byte[14] { 2, 42, 45, 43, 48, 41, 42, 4, 121, 42, 60, 60, 61, 100 }, 89) + _0x66a291e9.ToString() + _0x7d8bd08a._0xb1b2bbe2(new byte[5] { 50, 96, 102, 98, 47 }, 18) + _0x1664169a.Rtp.ToString(_0x7d8bd08a._0xb1b2bbe2(new byte[2] { 166, 211 }, 224)) + _0x7d8bd08a._0xb1b2bbe2(new byte[5] { 160, 232, 233, 244, 189 }, 128) + _0x1664169a.Hit.ToString(_0x7d8bd08a._0xb1b2bbe2(new byte[2] { 240, 133 }, 182)) + _0x7d8bd08a._0xb1b2bbe2(new byte[7] { 195, 135, 145, 130, 148, 144, 222 }, 227) + _0x1664169a.Draws.ToString() + _0x7d8bd08a._0xb1b2bbe2(new byte[10] { 36, 98, 101, 104, 104, 102, 101, 103, 111, 57 }, 4) + _0x1664169a.UsedFallback.ToString());
            }
#endif
        }

        if (this._splash != null)
            this._splash._0x9bfd8d48(this._art, this._font);
        Transform _0x72fb76fc = this._0xbfbae215();
        if (_0x72fb76fc == null)
            return;
        this._0x25169e3a(_0x72fb76fc);
        if (this._pops != null)
            this._pops._0xcb550624();
        this._0x5c2dc1cb = StateIdle;
        this._0x5e2b8b2d = Time.unscaledTime;
        this._0xaa666d8a(true);
    }

    /// <summary>A plain random stop vector, used for the opening board and for every spin.</summary>
    private int[] _0x66ec9f32()
    {
        int _0xc76b0d5e = this._0x51a2cbc5[0].Length;
        for (int _0x5ae384ae = 0; _0x5ae384ae < _0xbb4bed3e.Columns; _0x5ae384ae++)
            this._0x7a303baf[_0x5ae384ae] = this._0x4ff40b53.Next(_0xc76b0d5e);
        return this._0x7a303baf;
    }

    [SerializeField]
    private _0x98683103 _splash;
    /// <summary>
    /// Starts a spin if the machine is free. <paramref name = "byPlayer"/> separates a real tap
    /// from the idle backstop, so an unattended demo spin never consumes one of the two
    /// scripted openers and the two flows cannot collide.
    /// </summary>
    private void _0x22996256(bool _0xdc05d630)
    {
        if (this._0x5c2dc1cb != StateIdle || this._0x51a2cbc5 == null || this._board == null)
            return;
        if (this._pops != null && this._pops._0x5b11844c())
            return;
        int _0x837b27a5 = _0xaa0251af._0x6ceeae2c;
        if (_0xaa0251af._0xa151f4ff < _0x837b27a5)
        {
            this._0x38917f40();
            return;
        }

        _0xaa0251af._0xa151f4ff = _0xaa0251af._0xa151f4ff - _0x837b27a5;
        _0xaa0251af._0x4087bef7 = _0xaa0251af._0x4087bef7 + 1;
        _0x3bad075c.Report(_0x3bad075c._0x7e41363e.Spin, 1);
        if (_0x837b27a5 >= _0xaa0251af.BetAt(_0xaa0251af._0xcb593797 - 1))
            _0x3bad075c.Report(_0x3bad075c._0x7e41363e.HighStakeSpin, 1);
        int[] _0x19f189c8 = _0xdc05d630 ? this._0x725a5d84() : null;
        if (_0x19f189c8 == null)
            _0x19f189c8 = this._0x66ec9f32();
        this._0x5c2dc1cb = StateSpinning;
        this._board._0x3af12fda();
        if (this._hud != null)
        {
            this._hud._0x11fca156(true);
            this._hud._0x1cefc27c(_0xaa0251af._0xa151f4ff, false);
            this._hud._0x3ef9f96c(_0x7d8bd08a._0xb1b2bbe2(new byte[8] { 124, 127, 102, 97, 97, 102, 97, 104 }, 47), false);
        }

        this._board._0xc399b654(_0x19f189c8, _0xaa0251af._0xa4fcbfc3, () => this._0xda786db4(_0x837b27a5));
    }

    /// <summary>
    /// Seconds after a spin resolves before the backstop is armed again. Shorter than
    /// <see cref = "IdleBackstop"/> so a session that is already running keeps moving, but
    /// still long enough to leave a settled board between spins - the capture waits for two
    /// consecutive still frames before it photographs a scene, and a board that never rests
    /// never gives it one.
    /// </summary>
    private const float BackstopRearm = 20f;
    [SerializeField]
    private _0x60393d30 _pops;
    [SerializeField]
    private _0x30d693a6 _art;
    [SerializeField]
    private _0x561b26c9 _board;
    /// <summary>
    /// Seconds of stillness before the machine spins by itself. It is a SAFETY NET for a
    /// player (or a review tap) that never arrives, not an autoplay: the window between
    /// self-spins has to stay clearly longer than one spin, or the board is in motion most
    /// of the time and a tap that lands mid-spin is dropped by the state guard in
    /// <see cref = "Spin"/>. The review scenario taps SPIN twice to show a paid line and a
    /// result card; at a six-second cadence roughly a third of those taps would be eaten.
    /// </summary>
    private const float IdleBackstop = 26f;
    /// <summary>Chance a spin drops a collection shard.</summary>
    private const float ShardChance = 0.14f;
    private void _0x25169e3a(Transform _0x18140e69)
    {
        // Backdrop first, board second, HUD last: in UGUI sibling order IS draw order, and a
        // wash created after the reels would grey them out (C.13).
        RectTransform _0xfb5bad90 = _0xcecf7be6.Branch(_0x18140e69, _0x7d8bd08a._0xb1b2bbe2(new byte[8] { 230, 192, 204, 196, 227, 192, 194, 202 }, 161));
        _0xfb5bad90.SetAsFirstSibling();
        _0xcecf7be6.Plate(_0xfb5bad90, _0x7d8bd08a._0xb1b2bbe2(new byte[8] { 118, 80, 92, 84, 102, 80, 66, 89 }, 49), new Vector2(_0xcecf7be6.MidX, _0xcecf7be6.PanelHeight * 0.5f), new Vector2(_0xcecf7be6.PanelWidth, _0xcecf7be6.PanelHeight), null, _0xe058d175.Alpha(_0xe058d175.Abyss, 0.42f), 1f);
        _0xcecf7be6.Picture(_0xfb5bad90, _0x7d8bd08a._0xb1b2bbe2(new byte[8] { 28, 58, 54, 62, 28, 55, 52, 44 }, 91), new Vector2(_0xcecf7be6.MidX, _0x561b26c9.BoardCentreY), new Vector2(1240f, 1240f), this._art != null ? this._art._0x38f9d754 : null, _0xe058d175.Alpha(_0xe058d175.Ruby, 0.2f));
        RectTransform _0x2ff89ea9 = _0xcecf7be6.Branch(_0x18140e69, _0x7d8bd08a._0xb1b2bbe2(new byte[9] { 17, 55, 59, 51, 20, 57, 55, 36, 50 }, 86));
        if (this._board != null)
            this._board._0x6fbf89bf(_0x2ff89ea9, this._art, this._font, () => this._0x85e6ae11());
        RectTransform _0x9021b565 = _0xcecf7be6.Branch(_0x18140e69, _0x7d8bd08a._0xb1b2bbe2(new byte[9] { 208, 246, 250, 242, 209, 229, 248, 249, 227 }, 151));
        _0x9021b565.SetAsLastSibling();
        if (this._hud != null)
        {
            this._hud._0x399e9c1d(_0x9021b565, this._art, this._font, this);
            if (this._nav != null)
                this._nav._0x670a6800(this._hud._0x42e3e159, this._art, this);
        }

        if (this._board != null && this._board._0x62799093())
        {
            this._board._0x7ee7a7ba(this._0x51a2cbc5);
            this._board._0x0f3eaef1(this._0x66ec9f32());
        }
    }

    /// <summary>Rewrites every readout that can have changed.</summary>
    private void _0xaa666d8a(bool _0x87bb344a)
    {
        if (this._hud == null)
            return;
        this._hud._0x1cefc27c(_0xaa0251af._0xa151f4ff, false);
        this._hud._0x224302ca(_0xaa0251af._0x892a39cd);
        int _0x57142fbe = ActiveMissionSlot();
        if (_0x57142fbe < 0)
        {
            this._hud._0x3f26d1ba(_0x7d8bd08a._0xb1b2bbe2(new byte[48] { 128, 141, 141, 225, 142, 131, 139, 132, 130, 149, 136, 151, 132, 146, 225, 130, 141, 132, 128, 147, 132, 133, 225, 236, 225, 130, 141, 128, 136, 140, 225, 149, 137, 132, 140, 225, 136, 143, 225, 149, 137, 132, 225, 141, 142, 131, 131, 152 }, 193), 1f);
        }
        else
        {
            int _0x054bb65b = _0xaa0251af.MissionId(_0x57142fbe);
            int _0x9d769115 = Mathf.Max(1, _0x3bad075c.Target(_0x054bb65b));
            int _0x4b809539 = Mathf.Clamp(_0xaa0251af.MissionDone(_0x57142fbe), 0, _0x9d769115);
            this._hud._0x3f26d1ba(_0x3bad075c.Title(_0x054bb65b) + _0x7d8bd08a._0xb1b2bbe2(new byte[3] { 160, 160, 160 }, 128) + _0x4b809539.ToString() + _0x7d8bd08a._0xb1b2bbe2(new byte[3] { 127, 112, 127 }, 95) + _0x9d769115.ToString(), _0x4b809539 / (float)_0x9d769115);
        }

        if (_0x87bb344a)
            this._hud._0x3ef9f96c(_0x7d8bd08a._0xb1b2bbe2(new byte[26] { 132, 145, 128, 240, 131, 128, 153, 158, 240, 132, 159, 240, 159, 128, 149, 158, 240, 132, 152, 149, 240, 130, 149, 149, 156, 131 }, 208), false);
    }

    private readonly _0x65cc6a73[, ] _0x2da63e5d = new _0x65cc6a73[_0xbb4bed3e.Rows, _0xbb4bed3e.Columns];
    /// <summary>Scores the landed window, pays it and decides whether it deserves a card.</summary>
    private void _0xda786db4(int _0x55fb948c)
    {
        _0xf5a115d4.Window(this._0x51a2cbc5, this._0x7a303baf, this._0x2da63e5d);
        _0xf5a115d4.SpinResult _0xb780f095 = _0xf5a115d4.Score(this._0x2da63e5d, _0x55fb948c, this._0xd9682a62);
        this._0x5c2dc1cb = StateResolving;
        this._0xba233f67 = Time.unscaledTime + ResolveWindow;
        if (_0xb780f095.Payout > 0)
        {
            _0xaa0251af._0xa151f4ff = _0xaa0251af._0xa151f4ff + _0xb780f095.Payout;
            _0xaa0251af._0x7c9360ed = Mathf.Max(_0xaa0251af._0x7c9360ed, _0xb780f095.Payout);
            _0x3bad075c.Report(_0x3bad075c._0x7e41363e.PayingLine, _0xb780f095.PayingLines);
            _0x3bad075c.Report(_0x3bad075c._0x7e41363e.CoinsWon, _0xb780f095.Payout);
            if (_0xb780f095.Best.Wild || _0xb780f095.Best.Symbol == _0x65cc6a73.Joker)
                _0x3bad075c.Report(_0x3bad075c._0x7e41363e.JokerLine, 1);
            if (_0xb780f095.Best.Symbol == _0x65cc6a73.Ruby)
                _0x3bad075c.Report(_0x3bad075c._0x7e41363e.RubyLine, 1);
        }

        this._0x2c071967(_0xb780f095);
        this._board._0x5f38ac76(this._0xd9682a62);
        string _0x2e26ce7f = _0xb780f095.Best.Run >= _0xbb4bed3e.MinRun ? _0xbb4bed3e.NameOf(_0xb780f095.Best.Symbol) + _0x7d8bd08a._0xb1b2bbe2(new byte[7] { 2, 110, 107, 108, 103, 2, 90 }, 34) + _0xb780f095.Best.Run.ToString() : _0x7d8bd08a._0xb1b2bbe2(new byte[18] { 76, 77, 34, 78, 75, 76, 71, 34, 86, 74, 75, 81, 34, 80, 77, 87, 76, 70 }, 2);
        if (this._hud != null)
        {
            this._hud._0x11fca156(false);
            this._hud._0x1cefc27c(_0xaa0251af._0xa151f4ff, true);
            this._hud._0x3ef9f96c(_0xb780f095.Payout > 0 ? _0x7d8bd08a._0xb1b2bbe2(new byte[11] { 114, 127, 109, 106, 30, 105, 119, 112, 30, 30, 21 }, 62) + _0x999838f3.Money(_0xb780f095.Payout) + _0x7d8bd08a._0xb1b2bbe2(new byte[3] { 111, 111, 111 }, 79) + _0x2e26ce7f : _0x7d8bd08a._0xb1b2bbe2(new byte[9] { 33, 32, 79, 56, 38, 33, 79, 66, 79 }, 111) + _0x2e26ce7f, _0xb780f095.Payout > 0);
        }

        _0xaa0251af.Save();
        this._0xaa666d8a(false);
        {
#if B_LOGS
            {
                Debug.Log(_0x7d8bd08a._0xb1b2bbe2(new byte[11] { 52, 28, 31, 6, 1, 50, 79, 13, 10, 27, 82 }, 111) + _0x55fb948c.ToString() + _0x7d8bd08a._0xb1b2bbe2(new byte[8] { 225, 177, 160, 184, 174, 180, 181, 252 }, 193) + _0xb780f095.Payout.ToString() + _0x7d8bd08a._0xb1b2bbe2(new byte[7] { 229, 169, 172, 171, 160, 182, 248 }, 197) + _0xb780f095.PayingLines.ToString() + _0x7d8bd08a._0xb1b2bbe2(new byte[6] { 226, 160, 167, 177, 182, 255 }, 194) + _0x2e26ce7f);
            }
#endif
        }

        bool _0x920e9534 = _0xb780f095.Multiplier >= _0xbb4bed3e.BigWinBets;
        if (_0x920e9534)
        {
            _0x3bad075c.Report(_0x3bad075c._0x7e41363e.BigWin, 1);
            _0xaa0251af.Save();
            if (this._pops != null)
                this._pops._0x10cf7326(_0xb780f095.Payout, _0x2e26ce7f);
        }
    }

    private int _0x5c2dc1cb;
    /// <summary>The first objective still being worked on, or -1 when every slot is finished.</summary>
    private static int ActiveMissionSlot()
    {
        for (int _0xe85a8974 = 0; _0xe85a8974 < _0xaa0251af.MissionSlots; _0xe85a8974++)
        {
            int _0x830b468c = _0xaa0251af.MissionId(_0xe85a8974);
            if (_0x830b468c < 0 || _0x830b468c >= _0x3bad075c.PoolSize)
                continue;
            if (_0xaa0251af.MissionClaimed(_0xe85a8974))
                continue;
            if (_0xaa0251af.MissionDone(_0xe85a8974) >= _0x3bad075c.Target(_0x830b468c))
                continue;
            return _0xe85a8974;
        }

        return -1;
    }

    /// <summary>A tap on the reels: shorten the spin, never change it.</summary>
    private void _0x85e6ae11()
    {
        this._0x5e2b8b2d = Time.unscaledTime;
        if (this._0x5c2dc1cb == StateSpinning && this._board != null)
            this._board._0xc44f4cf1();
    }

    private _0xf5a115d4.LineResult[] _0xd9682a62;
}

internal static class _0x7d8bd08a
{
    internal static string _0xb1b2bbe2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}