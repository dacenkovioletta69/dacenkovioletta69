using UnityEngine;

/// <summary>
/// The paytable and the nine fixed paylines of the 3x5 grid, plus the reading of a single
/// line. Pure arithmetic: no Unity objects, no state, so the same code scores a spin on the
/// device and scores the Monte-Carlo run that verifies a freshly generated strip set.
///
/// Payouts are multipliers of the bet. They were tuned against the strip weights in
/// <see cref = "ReelStripFactory"/> so an UNFILTERED draw already lands inside the acceptance
/// window: measured over 120 draws of 4000 spins, return 0.85/0.95/1.05 at p02/p50/p98 and hit
/// frequency 0.26/0.28/0.29.
/// </summary>
public static class _0xbb4bed3e
{
    private static readonly string[] _0x7d869b28 =
    {
        _0x7dc19d68._0x2e25c473(new byte[8] { 8, 26, 11, 11, 19, 18, 9, 30 }, 91),
        _0x7dc19d68._0x2e25c473(new byte[7] { 215, 223, 215, 192, 211, 222, 214 }, 146),
        _0x7dc19d68._0x2e25c473(new byte[4] { 158, 153, 144, 144 }, 220),
        _0x7dc19d68._0x2e25c473(new byte[4] { 17, 22, 3, 16 }, 66),
        _0x7dc19d68._0x2e25c473(new byte[5] { 78, 95, 66, 90, 67 }, 13),
        _0x7dc19d68._0x2e25c473(new byte[5] { 41, 63, 44, 63, 52 }, 122),
        _0x7dc19d68._0x2e25c473(new byte[4] { 250, 253, 234, 241 }, 168),
        _0x7dc19d68._0x2e25c473(new byte[5] { 40, 45, 41, 39, 48 }, 98)
    };
    /// <summary>Matching faces needed before a line pays anything.</summary>
    public const int MinRun = 3;
    /// <summary>The reading name of a symbol, for the HUD and the result card.</summary>
    public static string NameOf(_0x65cc6a73 _0xb0c5e504)
    {
        int _0x680c0159 = (int)_0xb0c5e504;
        if (_0x680c0159 < 0 || _0x680c0159 >= _0x7d869b28.Length)
            return _0x7d869b28[0];
        return _0x7d869b28[_0x680c0159];
    }

    /// <summary>Multiplier of the bet for three, four and five of a kind, in symbol order.</summary>
    private static readonly float[][] _0x8e2e9d22 =
    {
        new[]
        {
            0.6f,
            1.8f,
            6f
        },
        new[]
        {
            0.8f,
            2.4f,
            8f
        },
        new[]
        {
            1.2f,
            4f,
            12f
        },
        new[]
        {
            1.6f,
            5f,
            18f
        },
        new[]
        {
            2.4f,
            8f,
            30f
        },
        new[]
        {
            4f,
            12f,
            60f
        },
        new[]
        {
            6f,
            22f,
            120f
        },
        new[]
        {
            9f,
            40f,
            240f
        }
    };
    /// <summary>Reels across the board.</summary>
    public const int Columns = 5;
    /// <summary>
    /// Row index per column for each of the nine lines: three rows, a V, an inverted V and
    /// four zig-zags. Read left to right, which is the only direction that pays.
    /// </summary>
    private static readonly int[][] _0x038ea388 =
    {
        new[]
        {
            1,
            1,
            1,
            1,
            1
        },
        new[]
        {
            0,
            0,
            0,
            0,
            0
        },
        new[]
        {
            2,
            2,
            2,
            2,
            2
        },
        new[]
        {
            0,
            1,
            2,
            1,
            0
        },
        new[]
        {
            2,
            1,
            0,
            1,
            2
        },
        new[]
        {
            0,
            0,
            1,
            2,
            2
        },
        new[]
        {
            2,
            2,
            1,
            0,
            0
        },
        new[]
        {
            1,
            0,
            1,
            2,
            1
        },
        new[]
        {
            1,
            2,
            1,
            0,
            1
        }
    };
    private static string Trim(float _0x9e632b9a)
    {
        if (Mathf.Approximately(_0x9e632b9a, Mathf.Round(_0x9e632b9a)))
            return Mathf.RoundToInt(_0x9e632b9a).ToString();
        return _0x9e632b9a.ToString(_0x7dc19d68._0x2e25c473(new byte[3] { 194, 220, 194 }, 242));
    }

    /// <summary>Rows in the visible window.</summary>
    public const int Rows = 3;
    /// <summary>The bet multiplier for a run, or zero when the run is too short.</summary>
    public static float Multiplier(_0x65cc6a73 _0x493813dd, int _0xc1453263)
    {
        if (_0xc1453263 < MinRun)
            return 0f;
        int _0xa797c79f = (int)_0x493813dd;
        if (_0xa797c79f < 0 || _0xa797c79f >= _0x8e2e9d22.Length)
            return 0f;
        int _0xb7bcfca5 = Mathf.Clamp(_0xc1453263 - MinRun, 0, _0x8e2e9d22[_0xa797c79f].Length - 1);
        return _0x8e2e9d22[_0xa797c79f][_0xb7bcfca5];
    }

    /// <summary>A payout of this many bets or more raises the big-win card.</summary>
    public const float BigWinBets = 12f;
    /// <summary>The row this line visits in a given column.</summary>
    public static int RowOf(int _0xb228a6f1, int _0xc2ee62b7)
    {
        if (_0xb228a6f1 < 0 || _0xb228a6f1 >= _0x038ea388.Length || _0xc2ee62b7 < 0 || _0xc2ee62b7 >= Columns)
            return 0;
        return _0x038ea388[_0xb228a6f1][_0xc2ee62b7];
    }

    /// <summary>
    /// The three rows of the paytable a HUD can print for one symbol, as "x3 0.6  x4 1.8
    /// x5 6". ASCII only: the atlas carries 32..126 and has no fallback font.
    /// </summary>
    public static string Row(_0x65cc6a73 _0x7d368ef1)
    {
        int _0xb725a5bd = Mathf.Clamp((int)_0x7d368ef1, 0, _0x8e2e9d22.Length - 1);
        float[] _0xc6c31876 = _0x8e2e9d22[_0xb725a5bd];
        return _0x7dc19d68._0x2e25c473(new byte[3] { 235, 160, 179 }, 147) + Trim(_0xc6c31876[0]) + _0x7dc19d68._0x2e25c473(new byte[6] { 79, 79, 79, 23, 91, 79 }, 111) + Trim(_0xc6c31876[1]) + _0x7dc19d68._0x2e25c473(new byte[6] { 141, 141, 141, 213, 152, 141 }, 173) + Trim(_0xc6c31876[2]);
    }

    /// <summary>How many paylines this machine runs.</summary>
    public static int _0x181d0f56
    {
        get
        {
            return _0x038ea388.Length;
        }
    }
}

internal static class _0x7dc19d68
{
    internal static string _0x2e25c473(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}