using System;
using UnityEngine;

/// <summary>
/// Every sprite the game draws, as ONE serialized block, so each director carries a single
/// <c>_art</c> field instead of eighteen. A serialized object reference is the only wiring
/// obfuscation cannot break: no name, no path, no Resources.Load (C).
/// </summary>
[Serializable]
public sealed class _0x30d693a6
{
    public Sprite _0x028932ee
    {
        get
        {
            return this._iconClose;
        }
    }

    public Sprite _0x6cba7c24
    {
        get
        {
            return this._coin;
        }
    }

    [SerializeField]
    private Sprite _host;
    [SerializeField]
    private Sprite _shard;
    /// <summary>The template's soft 9-slice shadow, used under raised cards.</summary>
    public Sprite _0x8675b43b
    {
        get
        {
            return this._shadow;
        }
    }

    [SerializeField]
    private Sprite _symCrown;
    /// <summary>The abstract brand mark. No letters anywhere on it.</summary>
    public Sprite _0xfb27b785
    {
        get
        {
            return this._emblem;
        }
    }

    [SerializeField]
    private Sprite _symStar;
    /// <summary>The abstract room crest, reused as the mission gutter chip.</summary>
    public Sprite _0xe39fd6d8
    {
        get
        {
            return this._crest;
        }
    }

    [SerializeField]
    private Sprite _iconPause;
    [SerializeField]
    private Sprite _emblem;
    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _iconClose;
    [SerializeField]
    private Sprite _symBell;
    /// <summary>A soft radial glow. Always drawn BEFORE the thing it sits behind (C.13).</summary>
    public Sprite _0x38f9d754
    {
        get
        {
            return this._glow;
        }
    }

    [SerializeField]
    private Sprite _iconBack;
    [SerializeField]
    private Sprite _glow;
    /// <summary>The template's own 9-slice rounded plate: a guid that can never dangle (B.1).</summary>
    public Sprite _0xfae782aa
    {
        get
        {
            return this._plate;
        }
    }

    /// <summary>The reel face for a symbol, in <see cref = "GemSymbol"/> order.</summary>
    public Sprite _0x2b16b7b0(_0x65cc6a73 _0xcf33de3c)
    {
        switch (_0xcf33de3c)
        {
            case _0x65cc6a73.Sapphire:
                return this._symSapphire;
            case _0x65cc6a73.Emerald:
                return this._symEmerald;
            case _0x65cc6a73.Bell:
                return this._symBell;
            case _0x65cc6a73.Star:
                return this._symStar;
            case _0x65cc6a73.Crown:
                return this._symCrown;
            case _0x65cc6a73.Seven:
                return this._symSeven;
            case _0x65cc6a73.Ruby:
                return this._symRuby;
            default:
                return this._symJoker;
        }
    }

    public Sprite _0x1b3bad39
    {
        get
        {
            return this._shard;
        }
    }

    [SerializeField]
    private Sprite _symSapphire;
    public Sprite _0xb27602ab
    {
        get
        {
            return this._iconPause;
        }
    }

    /// <summary>The parlour host, the lobby's one large piece of art.</summary>
    public Sprite _0x9cc196ff
    {
        get
        {
            return this._host;
        }
    }

    [SerializeField]
    private Sprite _symJoker;
    public Sprite _0x8ceb8881
    {
        get
        {
            return this._iconBack;
        }
    }

    [SerializeField]
    private Sprite _symRuby;
    [SerializeField]
    private Sprite _chest;
    [SerializeField]
    private Sprite _shadow;
    [SerializeField]
    private Sprite _crest;
    [SerializeField]
    private Sprite _symEmerald;
    [SerializeField]
    private Sprite _coin;
    [SerializeField]
    private Sprite _symSeven;
    public Sprite _0x2c273d07
    {
        get
        {
            return this._chest;
        }
    }
}