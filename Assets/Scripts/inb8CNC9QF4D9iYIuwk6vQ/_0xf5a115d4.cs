using UnityEngine;

/// <summary>
/// Turns a vector of reel stops into the 3x5 window and scores it across the nine paylines.
///
/// Pure evaluation, no Unity objects and no state of its own, because the SAME code has to
/// score the spin the player sees and the two thousand spins
/// <see cref = "ReelStripFactory"/> runs to prove a generated strip set is usable. Two scorers
/// that drift apart would let an unplayable machine through with a healthy-looking report.
///
/// No constructor anywhere: a result object is a field-initialised struct the caller fills
/// through <c>Init</c> (CLAUDE-unity.md C.59).
/// </summary>
public static class _0xf5a115d4
{
    /// <summary>
    /// Reads one payline. Two readings are tried and the better one wins: the line as a run of
    /// jokers, and the line as a run of the first non-joker symbol with jokers substituting.
    /// Only the best reading of a line counts, which is what "highest win per line" means.
    /// </summary>
    public static LineResult ReadLine(_0x65cc6a73[, ] _0xfbcf2c71, int _0x9e3c26c8)
    {
        LineResult _0xd102a751 = new LineResult()._0xb48ea4ea(_0x9e3c26c8, _0x65cc6a73.Sapphire, 0, 0f, false);
        int _0xa860f97b = 0;
        while (_0xa860f97b < _0xbb4bed3e.Columns && _0xfbcf2c71[_0xbb4bed3e.RowOf(_0x9e3c26c8, _0xa860f97b), _0xa860f97b] == _0x65cc6a73.Joker)
            _0xa860f97b++;
        if (_0xa860f97b >= _0xbb4bed3e.MinRun)
        {
            float _0x758d1bc8 = _0xbb4bed3e.Multiplier(_0x65cc6a73.Joker, _0xa860f97b);
            _0xd102a751 = new LineResult()._0xb48ea4ea(_0x9e3c26c8, _0x65cc6a73.Joker, _0xa860f97b, _0x758d1bc8, false);
        }

        if (_0xa860f97b < _0xbb4bed3e.Columns)
        {
            _0x65cc6a73 _0xac1de1bf = _0xfbcf2c71[_0xbb4bed3e.RowOf(_0x9e3c26c8, _0xa860f97b), _0xa860f97b];
            int _0x3e03c772 = 0;
            while (_0x3e03c772 < _0xbb4bed3e.Columns)
            {
                _0x65cc6a73 _0xf5f401b9 = _0xfbcf2c71[_0xbb4bed3e.RowOf(_0x9e3c26c8, _0x3e03c772), _0x3e03c772];
                if (_0xf5f401b9 != _0xac1de1bf && _0xf5f401b9 != _0x65cc6a73.Joker)
                    break;
                _0x3e03c772++;
            }

            if (_0x3e03c772 >= _0xbb4bed3e.MinRun)
            {
                bool _0xf2f7770c = _0xa860f97b > 0;
                float _0xf12701e2 = _0xbb4bed3e.Multiplier(_0xac1de1bf, _0x3e03c772) * (_0xf2f7770c ? 2f : 1f);
                if (_0xf12701e2 > _0xd102a751.Multiplier)
                    _0xd102a751 = new LineResult()._0xb48ea4ea(_0x9e3c26c8, _0xac1de1bf, _0x3e03c772, _0xf12701e2, _0xf2f7770c);
            }
        }

        return _0xd102a751;
    }

    /// <summary>What one payline paid, and why.</summary>
    public struct LineResult
    {
        /// <summary>Index into the payline table.</summary>
        public int Line;
        /// <summary>The symbol the run was read as; a wild-only run reads as the joker.</summary>
        public _0x65cc6a73 Symbol;
        /// <summary>How many columns matched, left to right.</summary>
        public int Run;
        /// <summary>Bet multiplier this line paid, wild doubling already applied.</summary>
        public float Multiplier;
        /// <summary>True when a joker stood in for the symbol and doubled the line.</summary>
        public bool Wild;
        /// <summary>Fills the struct. Never a constructor (C.59).</summary>
        public LineResult _0xb48ea4ea(int _0x0c70bfa8, _0x65cc6a73 _0xe5e93ded, int _0x724c90ec, float _0xd69975c1, bool _0x6b83b4ca)
        {
            this.Line = _0x0c70bfa8;
            this.Symbol = _0xe5e93ded;
            this.Run = _0x724c90ec;
            this.Multiplier = _0xd69975c1;
            this.Wild = _0x6b83b4ca;
            return this;
        }
    }

    /// <summary>
    /// Scores the whole window. <paramref name = "lines"/> is filled with every line's reading so
    /// the board can light the winning cells without evaluating twice.
    /// </summary>
    public static SpinResult Score(_0x65cc6a73[, ] _0x717c2e99, int _0x80866223, LineResult[] _0xb185ce15)
    {
        SpinResult _0x6dd4f9c7 = new SpinResult();
        _0x6dd4f9c7.Best = new LineResult()._0xb48ea4ea(0, _0x65cc6a73.Sapphire, 0, 0f, false);
        for (int _0x1678381c = 0; _0x1678381c < _0xbb4bed3e._0x181d0f56; _0x1678381c++)
        {
            LineResult _0x3f918307 = ReadLine(_0x717c2e99, _0x1678381c);
            if (_0xb185ce15 != null && _0x1678381c < _0xb185ce15.Length)
                _0xb185ce15[_0x1678381c] = _0x3f918307;
            if (_0x3f918307.Multiplier <= 0f)
                continue;
            _0x6dd4f9c7.Multiplier += _0x3f918307.Multiplier;
            _0x6dd4f9c7.PayingLines++;
            if (_0x3f918307.Multiplier > _0x6dd4f9c7.Best.Multiplier)
                _0x6dd4f9c7.Best = _0x3f918307;
        }

        _0x6dd4f9c7.Payout = Mathf.RoundToInt(_0x6dd4f9c7.Multiplier * _0x80866223);
        return _0x6dd4f9c7;
    }

    /// <summary>
    /// Fills <paramref name = "grid"/> with the window each reel shows at its stop.
    /// <c>grid[row, column]</c>, row 0 on top.
    /// </summary>
    public static void Window(_0x65cc6a73[][] _0x4bd51fa6, int[] _0x13f1aaaa, _0x65cc6a73[, ] _0x94cdfba2)
    {
        if (_0x4bd51fa6 == null || _0x13f1aaaa == null || _0x94cdfba2 == null)
            return;
        for (int _0x36e103ee = 0; _0x36e103ee < _0xbb4bed3e.Columns; _0x36e103ee++)
        {
            _0x65cc6a73[] _0xf417c259 = _0x4bd51fa6[_0x36e103ee];
            int _0x5e2df415 = _0xf417c259.Length;
            int _0xb8301743 = ((_0x13f1aaaa[_0x36e103ee] % _0x5e2df415) + _0x5e2df415) % _0x5e2df415;
            for (int _0xb5c5b307 = 0; _0xb5c5b307 < _0xbb4bed3e.Rows; _0xb5c5b307++)
                _0x94cdfba2[_0xb5c5b307, _0x36e103ee] = _0xf417c259[(_0xb8301743 + _0xb5c5b307) % _0x5e2df415];
        }
    }

    /// <summary>Everything one spin produced.</summary>
    public struct SpinResult
    {
        /// <summary>Sum of every paying line, as a multiplier of the bet.</summary>
        public float Multiplier;
        /// <summary>Coins paid out at the bet that was staked.</summary>
        public int Payout;
        /// <summary>The single best line, or Run 0 when nothing paid.</summary>
        public LineResult Best;
        /// <summary>How many lines paid at all.</summary>
        public int PayingLines;
    }
}