using System;
using UnityEngine;

/// <summary>
/// The only owner of persisted state. Everything the parlour remembers between launches lives
/// here: balance, stake, the daily ladder, shard counts, unlocked rooms, mission progress and
/// the three preference toggles.
///
/// Every key is a plain <c>private const string</c> declared in this one class. A
/// <c>static readonly</c> array built out of other static string fields is the C.52 trap: string
/// encryption turns the consts into runtime-initialised fields and the obfuscator may put the
/// array first, which kills the whole type with a TypeInitializationException that no compiler
/// and no gate sees.
///
/// The coin balance is deliberately NOT stored here - it belongs to the template
/// (<c>SETTINGS.PlayerSYSTEM.Coins</c>), which writes its own PlayerPrefs key and refreshes the
/// template's counters on every write.
/// </summary>
public static class _0xaa0251af
{
    /// <summary>The stake in coins.</summary>
    public static int _0x6ceeae2c
    {
        get
        {
            return _0x160048ad[_0x892a39cd];
        }
    }

    private static readonly string KeyScripted = _0x2e2f4459._0x6967e774(new byte[12] { 88, 64, 64, 28, 65, 81, 64, 91, 66, 70, 87, 86 }, 50);
    private static readonly string KeyQuickSpin = _0x2e2f4459._0x6967e774(new byte[9] { 233, 241, 241, 173, 242, 246, 234, 224, 232 }, 131);
    private static readonly string KeyMissionDone = _0x2e2f4459._0x6967e774(new byte[7] { 206, 214, 214, 138, 201, 192, 138 }, 164);
    /// <summary>Records progress against one mission.</summary>
    public static void SetMissionDone(int _0xc2f58f99, int _0xd5aa902b)
    {
        PlayerPrefs.SetInt(KeyMissionDone + _0xc2f58f99.ToString(), Mathf.Max(0, _0xd5aa902b));
    }

    /// <summary>Takes today's ladder step and returns the coins granted.</summary>
    public static int ClaimVault()
    {
        if (!VaultReady())
            return 0;
        int _0x4f5945e6 = PendingStep();
        _0x19db5b39 = _0x4f5945e6 >= LadderDays ? 0 : _0x4f5945e6;
        _0xc301765c = Today();
        int _0xe9c76281 = LadderReward(_0x4f5945e6);
        _0xa151f4ff = _0xa151f4ff + _0xe9c76281;
        if (_0x4f5945e6 >= LadderDays)
        {
            AddShard(_0x65cc6a73.Ruby, 1);
            AddShard(_0x65cc6a73.Joker, 1);
        }

        PlayerPrefs.Save();
        return _0xe9c76281;
    }

    /// <summary>Progress counted against one mission.</summary>
    public static int MissionDone(int _0x5adfae1c)
    {
        return Mathf.Max(0, PlayerPrefs.GetInt(KeyMissionDone + _0x5adfae1c.ToString(), 0));
    }

    private static readonly string KeyReduced = _0x2e2f4459._0x6967e774(new byte[11] { 51, 43, 43, 119, 43, 60, 61, 44, 58, 60, 61 }, 89);
    /// <summary>Shards catalogued for one symbol.</summary>
    public static int Shards(_0x65cc6a73 _0x3516245a)
    {
        return Mathf.Max(0, PlayerPrefs.GetInt(KeyShard + ((int)_0x3516245a).ToString(), 0));
    }

    /// <summary>The room the lobby is dressed as.</summary>
    public static int _0x1a827b81
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyRoom, 0), 0, RoomCount - 1);
        }

        set
        {
            PlayerPrefs.SetInt(KeyRoom, Mathf.Clamp(value, 0, RoomCount - 1));
        }
    }

    private static readonly string KeyShard = _0x2e2f4459._0x6967e774(new byte[10] { 48, 40, 40, 116, 41, 50, 59, 40, 62, 116 }, 90);
    /// <summary>Local date of the last claim, as a day number. Zero means never.</summary>
    public static int _0xc301765c
    {
        get
        {
            return PlayerPrefs.GetInt(KeyLastClaim, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyLastClaim, value);
        }
    }

    private static readonly string KeyMissionId = _0x2e2f4459._0x6967e774(new byte[7] { 172, 180, 180, 232, 171, 175, 232 }, 198);
    /// <summary>How many rooms the parlour can open.</summary>
    public const int RoomCount = 4;
    /// <summary>Seconds left in the local day, for the "next vault in" countdown.</summary>
    public static int SecondsToMidnight()
    {
        DateTime _0x2ce57803 = DateTime.Now;
        DateTime _0x9c1b22d2 = _0x2ce57803.Date.AddDays(1);
        double _0xfa43b69e = (_0x9c1b22d2 - _0x2ce57803).TotalSeconds;
        if (_0xfa43b69e < 0d)
            return 0;
        if (_0xfa43b69e > 86400d)
            return 86400;
        return (int)_0xfa43b69e;
    }

    /// <summary>How many symbols the album tracks.</summary>
    public const int AlbumSize = 8;
    /// <summary>Places a pool entry in a slot and resets its progress.</summary>
    public static void SetMission(int _0xc720d134, int _0x508b6b0d)
    {
        PlayerPrefs.SetInt(KeyMissionId + _0xc720d134.ToString(), _0x508b6b0d);
        PlayerPrefs.SetInt(KeyMissionDone + _0xc720d134.ToString(), 0);
        PlayerPrefs.SetInt(KeyMissionClaimed + _0xc720d134.ToString(), 0);
    }

    /// <summary>Index into the stake ladder.</summary>
    public static int _0x892a39cd
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyBet, 0), 0, _0x160048ad.Length - 1);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBet, Mathf.Clamp(value, 0, _0x160048ad.Length - 1));
        }
    }

    /// <summary>Counts this launch and returns the session index the run seed is built from.</summary>
    public static int NextSession()
    {
        int _0x6c228b1b = PlayerPrefs.GetInt(KeySession, 0) + 1;
        PlayerPrefs.SetInt(KeySession, _0x6c228b1b);
        PlayerPrefs.Save();
        return _0x6c228b1b;
    }

    private static readonly string KeyHaptics = _0x2e2f4459._0x6967e774(new byte[11] { 181, 173, 173, 241, 183, 190, 175, 171, 182, 188, 172 }, 223);
    /// <summary>Shards that complete one symbol of the album.</summary>
    public const int ShardsPerSet = 5;
    /// <summary>Short haptic feedback on a win and on a claim.</summary>
    public static bool _0x82fe9f6a
    {
        get
        {
            return PlayerPrefs.GetInt(KeyHaptics, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyHaptics, value ? 1 : 0);
        }
    }

    private static readonly string KeyBestWin = _0x2e2f4459._0x6967e774(new byte[8] { 139, 147, 147, 207, 131, 132, 146, 149 }, 225);
    /// <summary>The seed the mission board draws its three objectives from.</summary>
    public static int _0x082baaeb
    {
        get
        {
            return PlayerPrefs.GetInt(KeyMissionSeed, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyMissionSeed, value);
        }
    }

    /// <summary>Shorter spin-up and a tighter reel stagger.</summary>
    public static bool _0xa4fcbfc3
    {
        get
        {
            return PlayerPrefs.GetInt(KeyQuickSpin, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyQuickSpin, value ? 1 : 0);
        }
    }

    /// <summary>
    /// First run: lay down the defaults. Without a seeded balance the very first spin cannot
    /// be afforded, the refill card opens over the board and the review capture photographs a
    /// pop instead of a game.
    /// </summary>
    public static void EnsureSeeded()
    {
        if (PlayerPrefs.GetInt(KeySeeded, 0) == 1)
            return;
        PlayerPrefs.SetInt(KeySeeded, 1);
        _0x4fc558d7._0x566e4cde._0xd0203e80 = StartingCoins;
        PlayerPrefs.SetInt(KeyBet, 0);
        PlayerPrefs.SetInt(KeyRooms, 1);
        PlayerPrefs.SetInt(KeyRoom, 0);
        PlayerPrefs.SetInt(KeyHaptics, 1);
        PlayerPrefs.SetInt(KeyQuickSpin, 0);
        PlayerPrefs.SetInt(KeyReduced, 0);
        PlayerPrefs.SetInt(KeyLadderDay, 0);
        PlayerPrefs.SetInt(KeyLastClaim, 0);
        PlayerPrefs.SetInt(KeyScripted, 0);
        PlayerPrefs.Save();
    }

    /// <summary>Missions presented at once.</summary>
    public const int MissionSlots = 3;
    /// <summary>The pool entry sitting in one mission slot.</summary>
    public static int MissionId(int _0xe4c209b1)
    {
        return PlayerPrefs.GetInt(KeyMissionId + _0xe4c209b1.ToString(), -1);
    }

    private static readonly string KeyLastClaim = _0x2e2f4459._0x6967e774(new byte[13] { 127, 103, 103, 59, 118, 121, 116, 124, 120, 59, 113, 116, 108 }, 21);
    /// <summary>Free coins a fresh install opens with.</summary>
    public const int StartingCoins = 2500;
    /// <summary>A stake by index, for the chip caption.</summary>
    public static int BetAt(int _0xd6104849)
    {
        return _0x160048ad[Mathf.Clamp(_0xd6104849, 0, _0x160048ad.Length - 1)];
    }

    private static readonly string KeySeeded = _0x2e2f4459._0x6967e774(new byte[10] { 136, 144, 144, 204, 145, 135, 135, 134, 135, 134 }, 226);
    /// <summary>The stakes the bet chip cycles through.</summary>
    private static readonly int[] _0x160048ad =
    {
        10,
        20,
        50,
        100
    };
    /// <summary>Spins taken across every session, used by the mission pool.</summary>
    public static int _0x4087bef7
    {
        get
        {
            return PlayerPrefs.GetInt(KeySpins, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeySpins, Mathf.Max(0, value));
        }
    }

    /// <summary>Completed sets needed for a room, index 0 being the room that starts open.</summary>
    public static int SetsNeeded(int _0x6168aaf1)
    {
        if (_0x6168aaf1 <= 0)
            return 0;
        if (_0x6168aaf1 == 1)
            return 1;
        if (_0x6168aaf1 == 2)
            return 3;
        return 6;
    }

    /// <summary>How many stakes the chip can cycle through.</summary>
    public static int _0xcb593797
    {
        get
        {
            return _0x160048ad.Length;
        }
    }

    /// <summary>Marks a mission paid.</summary>
    public static void SetMissionClaimed(int _0xe7605609, bool _0x0fd5c750)
    {
        PlayerPrefs.SetInt(KeyMissionClaimed + _0xe7605609.ToString(), _0x0fd5c750 ? 1 : 0);
    }

    /// <summary>How many of the two opening scripted spins have been used.</summary>
    public static int _0x142b2a87
    {
        get
        {
            return PlayerPrefs.GetInt(KeyScripted, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyScripted, Mathf.Clamp(value, 0, 2));
        }
    }

    /// <summary>Writes everything through. Called before any pop is raised.</summary>
    public static void Save()
    {
        PlayerPrefs.Save();
    }

    /// <summary>The ladder step the next claim pays, 1..7.</summary>
    public static int _0x19db5b39
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyLadderDay, 0), 0, LadderDays);
        }

        set
        {
            PlayerPrefs.SetInt(KeyLadderDay, Mathf.Clamp(value, 0, LadderDays));
        }
    }

    private static readonly string KeyRoom = _0x2e2f4459._0x6967e774(new byte[8] { 223, 199, 199, 155, 199, 218, 218, 216 }, 181);
    /// <summary>The coin balance, owned by the template so its own counters stay in step.</summary>
    public static int _0xa151f4ff
    {
        get
        {
            return _0x4fc558d7._0x566e4cde._0xd0203e80;
        }

        set
        {
            _0x4fc558d7._0x566e4cde._0xd0203e80 = Mathf.Max(0, value);
        }
    }

    /// <summary>Suppresses idle loops, sparkle layers and the glass sheen.</summary>
    public static bool _0x70f7e906
    {
        get
        {
            return PlayerPrefs.GetInt(KeyReduced, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyReduced, value ? 1 : 0);
        }
    }

    /// <summary>Re-reads the set count and opens any room it has earned.</summary>
    public static int RefreshRooms()
    {
        int _0x8682fb70 = CompletedSets();
        int _0x9fee8266 = 1;
        for (int _0x359c954f = 1; _0x359c954f < RoomCount; _0x359c954f++)
        {
            if (_0x8682fb70 >= SetsNeeded(_0x359c954f))
                _0x9fee8266 = _0x359c954f + 1;
        }

        if (_0x9fee8266 > _0x7129f7f3)
            _0x7129f7f3 = _0x9fee8266;
        return _0x7129f7f3;
    }

    /// <summary>Free coins the vault grants when the balance will not cover the stake.</summary>
    public const int RefillCoins = 1000;
    /// <summary>How many symbols are fully catalogued.</summary>
    public static int CompletedSets()
    {
        int _0x11f0eea9 = 0;
        for (int _0x536719df = 0; _0x536719df < AlbumSize; _0x536719df++)
        {
            if (Shards((_0x65cc6a73)_0x536719df) >= ShardsPerSet)
                _0x11f0eea9++;
        }

        return _0x11f0eea9;
    }

    private static readonly string KeyMissionSeed = _0x2e2f4459._0x6967e774(new byte[9] { 91, 67, 67, 31, 92, 66, 84, 84, 85 }, 49);
    /// <summary>
    /// The step a claim made right now would pay. A missed day resets the ladder to one, which
    /// is read here rather than written, so opening the sheet never changes anything.
    /// </summary>
    public static int PendingStep()
    {
        if (!VaultReady())
            return Mathf.Clamp(_0x19db5b39, 1, LadderDays);
        int _0x228224c2 = _0xc301765c;
        int _0x9469f478 = Today();
        if (_0x228224c2 == 0 || _0x9469f478 - _0x228224c2 > 1)
            return 1;
        return Mathf.Clamp(_0x19db5b39 + 1, 1, LadderDays);
    }

    /// <summary>Whether a finished mission has already paid out.</summary>
    public static bool MissionClaimed(int _0xbd03623c)
    {
        return PlayerPrefs.GetInt(KeyMissionClaimed + _0xbd03623c.ToString(), 0) == 1;
    }

    /// <summary>Adds shards to one symbol and returns true when that completes the set.</summary>
    public static bool AddShard(_0x65cc6a73 _0xe18dada7, int _0x46144e9a)
    {
        int _0x9345563b = Shards(_0xe18dada7);
        if (_0x9345563b >= ShardsPerSet)
            return false;
        int _0xf1999e7b = Mathf.Min(ShardsPerSet, _0x9345563b + Mathf.Max(1, _0x46144e9a));
        PlayerPrefs.SetInt(KeyShard + ((int)_0xe18dada7).ToString(), _0xf1999e7b);
        return _0xf1999e7b >= ShardsPerSet && _0x9345563b < ShardsPerSet;
    }

    /// <summary>Today as a day number in local time. Entirely offline; no clock is trusted but this one.</summary>
    public static int Today()
    {
        DateTime _0x197aaffd = DateTime.Now;
        return (_0x197aaffd.Year * 400) + _0x197aaffd.DayOfYear;
    }

    private static readonly string KeyLadderDay = _0x2e2f4459._0x6967e774(new byte[14] { 62, 38, 38, 122, 56, 53, 48, 48, 49, 38, 122, 48, 53, 45 }, 84);
    private static readonly string KeySession = _0x2e2f4459._0x6967e774(new byte[11] { 151, 143, 143, 211, 142, 152, 142, 142, 148, 146, 147 }, 253);
    /// <summary>How many rooms are open. The first one is open from the start.</summary>
    public static int _0x7129f7f3
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyRooms, 1), 1, RoomCount);
        }

        set
        {
            PlayerPrefs.SetInt(KeyRooms, Mathf.Clamp(value, 1, RoomCount));
        }
    }

    /// <summary>
    /// Clears everything this game owns and lays the defaults down again. Keys are deleted one
    /// by one rather than with DeleteAll, which would also wipe the template's own state.
    /// </summary>
    public static void ResetAll()
    {
        for (int _0xb33a4695 = 0; _0xb33a4695 < AlbumSize; _0xb33a4695++)
            PlayerPrefs.DeleteKey(KeyShard + _0xb33a4695.ToString());
        for (int _0x8b419979 = 0; _0x8b419979 < MissionSlots; _0x8b419979++)
        {
            PlayerPrefs.DeleteKey(KeyMissionId + _0x8b419979.ToString());
            PlayerPrefs.DeleteKey(KeyMissionDone + _0x8b419979.ToString());
            PlayerPrefs.DeleteKey(KeyMissionClaimed + _0x8b419979.ToString());
        }

        PlayerPrefs.DeleteKey(KeyMissionSeed);
        PlayerPrefs.DeleteKey(KeyRooms);
        PlayerPrefs.DeleteKey(KeyRoom);
        PlayerPrefs.DeleteKey(KeyLadderDay);
        PlayerPrefs.DeleteKey(KeyLastClaim);
        PlayerPrefs.DeleteKey(KeyBet);
        PlayerPrefs.DeleteKey(KeyBestWin);
        PlayerPrefs.DeleteKey(KeySpins);
        PlayerPrefs.DeleteKey(KeyScripted);
        PlayerPrefs.DeleteKey(KeySeeded);
        EnsureSeeded();
    }

    private static readonly string KeyRooms = _0x2e2f4459._0x6967e774(new byte[9] { 60, 36, 36, 120, 36, 57, 57, 59, 37 }, 86);
    /// <summary>Coins the given ladder step pays. Step is 1..7.</summary>
    public static int LadderReward(int _0x3ab742b8)
    {
        switch (Mathf.Clamp(_0x3ab742b8, 1, LadderDays))
        {
            case 1:
                return 250;
            case 2:
                return 350;
            case 3:
                return 500;
            case 4:
                return 700;
            case 5:
                return 1000;
            case 6:
                return 1500;
            default:
                return 3000;
        }
    }

    private static readonly string KeyBet = _0x2e2f4459._0x6967e774(new byte[7] { 217, 193, 193, 157, 209, 214, 199 }, 179);
    private static readonly string KeyMissionClaimed = _0x2e2f4459._0x6967e774(new byte[7] { 139, 147, 147, 207, 140, 130, 207 }, 225);
    /// <summary>Days on the daily ladder.</summary>
    public const int LadderDays = 7;
    private static readonly string KeySpins = _0x2e2f4459._0x6967e774(new byte[9] { 116, 108, 108, 48, 109, 110, 119, 112, 109 }, 30);
    /// <summary>Biggest single payout so far, in coins.</summary>
    public static int _0x7c9360ed
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBestWin, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBestWin, Mathf.Max(0, value));
        }
    }

    /// <summary>True when today's ladder step is still unclaimed.</summary>
    public static bool VaultReady()
    {
        return _0xc301765c != Today();
    }
}

internal static class _0x2e2f4459
{
    internal static string _0x6967e774(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}