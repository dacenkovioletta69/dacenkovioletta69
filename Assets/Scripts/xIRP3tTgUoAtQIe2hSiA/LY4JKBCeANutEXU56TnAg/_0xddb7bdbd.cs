using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xddb7bdbd : MonoBehaviour
{
    private Vector3 _0x6a34ee4d { get; set; }

    private float _0x3fb95756 = 1;
    private float _0x300eb505 { get; set; }
    private Vector3 _0x0c122efa { get; set; }
    private Vector3 _0xceec57fc { get; set; }
    private Vector3 _0xae0bc51e { get; set; }
    private Vector3 _0xb8e29c49 { get; set; }

    public enum _0xbc9e0530
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xb23492bb { get; set; }

    private new Camera _0x1de32ee4;
    private void _0x4161697c()
    {
        float _0x78a5a772, _0xd7802807, _0x4b1ceed8, _0xd8d09209;
        if (this._0x1320ca5a == _0xbc9e0530.Landscape)
            this._0x1de32ee4.orthographicSize = 1f / this._0x1de32ee4.aspect * this._0x3fb95756 / 2f;
        else
            this._0x1de32ee4.orthographicSize = this._0x3fb95756 / 2f;
        this._0x300eb505 = 2f * this._0x1de32ee4.orthographicSize;
        this._0x292254c1 = this._0x300eb505 * this._0x1de32ee4.aspect;
        float _0x73f9e678 = this._0x1de32ee4.transform.position.x;
        float _0x08cd9c05 = this._0x1de32ee4.transform.position.y;
        _0x78a5a772 = _0x73f9e678 - this._0x292254c1 / 2;
        _0xd7802807 = _0x73f9e678 + this._0x292254c1 / 2;
        _0x4b1ceed8 = _0x08cd9c05 + this._0x300eb505 / 2;
        _0xd8d09209 = _0x08cd9c05 - this._0x300eb505 / 2;
        this._0x16c4514c = new Vector3(_0x78a5a772, _0xd8d09209, 0);
        this._0xceec57fc = new Vector3(_0x73f9e678, _0xd8d09209, 0);
        this._0x6a34ee4d = new Vector3(_0xd7802807, _0xd8d09209, 0);
        this._0x0c122efa = new Vector3(_0x78a5a772, _0x08cd9c05, 0);
        this._0xb23492bb = new Vector3(_0x73f9e678, _0x08cd9c05, 0);
        this._0xdf011a55 = new Vector3(_0xd7802807, _0x08cd9c05, 0);
        this._0xae0bc51e = new Vector3(_0x78a5a772, _0x4b1ceed8, 0);
        this._0xb8e29c49 = new Vector3(_0x73f9e678, _0x4b1ceed8, 0);
        this._0x8cacd5ed = new Vector3(_0xd7802807, _0x4b1ceed8, 0);
    }

    private _0xbc9e0530 _0x1320ca5a = _0xbc9e0530.Portrait;
    private void Awake()
    {
        this._0x1de32ee4 = this.GetComponent<Camera>();
        _0x11bf5a73 = this;
        this._0x4161697c();
    }

    //public bool executeInUpdate;
    private float _0x292254c1 { get; set; }
    private Vector3 _0xdf011a55 { get; set; }
    private Vector3 _0x16c4514c { get; set; }

    private Color _0x8e3d3b15 = Color.white;
    private Vector3 _0x8cacd5ed { get; set; }

    private static _0xddb7bdbd _0x11bf5a73;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x8e3d3b15;
        Matrix4x4 _0x6778769e = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x1de32ee4.orthographic)
        {
            float _0x856e8e28 = this._0x1de32ee4.farClipPlane - this._0x1de32ee4.nearClipPlane;
            float _0x5e10b838 = (this._0x1de32ee4.farClipPlane + this._0x1de32ee4.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x5e10b838), new Vector3(this._0x1de32ee4.orthographicSize * 2 * this._0x1de32ee4.aspect, this._0x1de32ee4.orthographicSize * 2, _0x856e8e28));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x1de32ee4.fieldOfView, this._0x1de32ee4.farClipPlane, this._0x1de32ee4.nearClipPlane, this._0x1de32ee4.aspect);
        }

        Gizmos.matrix = _0x6778769e;
    }
}