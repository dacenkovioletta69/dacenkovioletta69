using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x05a8478b : MonoBehaviour
{
    private Touch? _0x24dbef6b()
    {
        if (!_0x697b0043.Instance._0x0316e3ef)
            return null;
        foreach (Touch _0x45e88e0a in Touch.activeTouches)
            if (_0x45e88e0a.ended)
                if (this._0x6303ad4e(_0x45e88e0a))
                    return _0x45e88e0a;
        return null;
    }

    private bool _0x5ea87583(Touch? _0x5f46b412, Bounds _0x1d0696a0, TouchPhase _0x4c7a7f6b)
    {
        if (!_0x697b0043.Instance._0x0316e3ef)
        {
            _0x5f46b412 = null;
            return false;
        }

        if (_0x5f46b412 != null)
            if (_0x5f46b412.Value.phase == _0x4c7a7f6b)
            {
                Vector3 _0x30ef286d = Camera.main.ScreenToWorldPoint(_0x5f46b412.Value.screenPosition);
                Vector3 _0xea5e5d0e = new(_0x30ef286d.x, _0x30ef286d.y, _0x1d0696a0.center.z);
                if (_0x1d0696a0.Contains(_0xea5e5d0e) && this._0x6303ad4e(_0x5f46b412.Value))
                    return true;
            }

        return false;
    }

    private bool _0x6303ad4e(Touch? _0x6ec85b0d)
    {
        if (!_0x6ec85b0d.HasValue)
            return false;
        Vector3 _0xfd4cc561 = Camera.main.ScreenToWorldPoint(_0x6ec85b0d.Value.screenPosition);
        Vector3 _0xd59d748f = _0xfd4cc561;
        _0xd59d748f.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xd59d748f))
            return true;
        _0x6ec85b0d = null;
        return false;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xf5bf6062 = this.gameObject.GetComponent<_0x05a8478b>();
    }

    private Touch? _0xbe7083e4(Bounds _0x6556c5b2)
    {
        if (!_0x697b0043.Instance._0x0316e3ef)
            return null;
        foreach (Touch _0x86982363 in Touch.activeTouches)
            if (!_0x86982363.ended)
            {
                Vector3 _0xac4030a2 = Camera.main.ScreenToWorldPoint(_0x86982363.screenPosition);
                Vector3 _0x8b7556c3 = new(_0xac4030a2.x, _0xac4030a2.y, _0x6556c5b2.center.z);
                if (_0x6556c5b2.Contains(_0x8b7556c3) && this._0x6303ad4e(_0x86982363))
                    return _0x86982363;
            }

        return null;
    }

    private static _0x05a8478b _0xf5bf6062;
    public BoxCollider2D CameraTouchBounds;
    private Touch? _0xcba257ee()
    {
        if (!_0x697b0043.Instance._0x0316e3ef)
            return null;
        foreach (Touch _0x47279d3d in Touch.activeTouches)
            if (!_0x47279d3d.ended)
                if (this._0x6303ad4e(_0x47279d3d))
                    return _0x47279d3d;
        return null;
    }

    private Touch? _0xbb6e700f(Bounds _0xc2e8e182)
    {
        if (!_0x697b0043.Instance._0x0316e3ef)
            return null;
        foreach (Touch _0x32b993ea in Touch.activeTouches)
            if (_0x32b993ea.ended)
            {
                Vector3 _0xe877322a = Camera.main.ScreenToWorldPoint(_0x32b993ea.screenPosition);
                Vector3 _0xd6822b3a = new(_0xe877322a.x, _0xe877322a.y, _0xc2e8e182.center.z);
                if (_0xc2e8e182.Contains(_0xd6822b3a) && this._0x6303ad4e(_0x32b993ea))
                    return _0x32b993ea;
            }

        return null;
    }

    private void _0x4dd10039(Touch? _0xc3e47850)
    {
        if (!_0x697b0043.Instance._0x0316e3ef)
        {
            _0xc3e47850 = null;
            return;
        }

        int _0x32c51ca3 = _0xc3e47850.Value.touchId;
        _0xc3e47850 = Touch.activeTouches.FirstOrDefault(_0x2b29a750 => _0x2b29a750.touchId == _0x32c51ca3);
        if (!this._0x6303ad4e(_0xc3e47850.Value))
            _0xc3e47850 = null;
    }

    private Touch? _0xeaf26b22(Bounds _0x78a2133c, TouchPhase _0xc5fa3777)
    {
        if (!_0x697b0043.Instance._0x0316e3ef)
            return null;
        foreach (Touch _0xd88a4dd1 in Touch.activeTouches)
            if (_0xd88a4dd1.phase == _0xc5fa3777)
            {
                Vector3 _0x02398b20 = Camera.main.ScreenToWorldPoint(_0xd88a4dd1.screenPosition);
                Vector3 _0xc5dffe4b = new(_0x02398b20.x, _0x02398b20.y, _0x78a2133c.center.z);
                if (_0x78a2133c.Contains(_0xc5dffe4b) && this._0x6303ad4e(_0xd88a4dd1))
                    return _0xd88a4dd1;
            }

        return null;
    }
}