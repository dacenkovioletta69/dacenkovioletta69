using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x81086c60 : MonoBehaviour
{
    private bool _0x42ee1497 = false;
    private bool _0x95600005 = false;
    private void _0x97facf50()
    {
        if (_0x7f50f1ad == null)
            return;
        if (_0x30d2d721)
            _0x7f50f1ad.SetUserAgent(_0x604fec9e());
        else
            _0x7f50f1ad.SetUserAgent("");
    }

    private string _0x824630d0()
    {
        return _0x985a3ffa._0x73234e59(new byte[12] { 97, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50 }, 73) + _0x985a3ffa._0x73234e59(new byte[8] { 34, 53, 38, 116, 33, 53, 105, 115 }, 84) + WindowsDesktopUserAgent + _0x985a3ffa._0x73234e59(new byte[2] { 127, 99 }, 88) + _0x985a3ffa._0x73234e59(new byte[30] { 153, 142, 157, 207, 159, 157, 128, 155, 128, 210, 161, 142, 153, 134, 136, 142, 155, 128, 157, 193, 159, 157, 128, 155, 128, 155, 150, 159, 138, 212 }, 239) + _0x985a3ffa._0x73234e59(new byte[121] { 225, 242, 233, 228, 243, 238, 232, 233, 167, 227, 226, 225, 175, 232, 229, 237, 171, 236, 226, 254, 171, 241, 230, 235, 174, 252, 243, 245, 254, 252, 200, 229, 237, 226, 228, 243, 169, 227, 226, 225, 238, 233, 226, 215, 245, 232, 247, 226, 245, 243, 254, 175, 232, 229, 237, 171, 236, 226, 254, 171, 252, 224, 226, 243, 189, 225, 242, 233, 228, 243, 238, 232, 233, 175, 174, 252, 245, 226, 243, 242, 245, 233, 167, 241, 230, 235, 188, 250, 171, 228, 232, 233, 225, 238, 224, 242, 245, 230, 229, 235, 226, 189, 243, 245, 242, 226, 250, 174, 188, 250, 228, 230, 243, 228, 239, 175, 226, 174, 252, 250, 250 }, 135) + _0x985a3ffa._0x73234e59(new byte[26] { 182, 183, 180, 250, 162, 160, 189, 166, 189, 254, 245, 167, 161, 183, 160, 147, 181, 183, 188, 166, 245, 254, 167, 179, 251, 233 }, 210) + _0x985a3ffa._0x73234e59(new byte[130] { 162, 163, 160, 238, 182, 180, 169, 178, 169, 234, 225, 167, 182, 182, 144, 163, 180, 181, 175, 169, 168, 225, 234, 225, 243, 232, 246, 230, 238, 145, 175, 168, 162, 169, 177, 181, 230, 136, 146, 230, 247, 246, 232, 246, 253, 230, 145, 175, 168, 240, 242, 253, 230, 190, 240, 242, 239, 230, 135, 182, 182, 170, 163, 145, 163, 164, 141, 175, 178, 233, 243, 245, 241, 232, 245, 240, 230, 238, 141, 142, 146, 139, 138, 234, 230, 170, 175, 173, 163, 230, 129, 163, 165, 173, 169, 239, 230, 133, 174, 180, 169, 171, 163, 233, 247, 244, 246, 232, 246, 232, 246, 232, 246, 230, 149, 167, 160, 167, 180, 175, 233, 243, 245, 241, 232, 245, 240, 225, 239, 253 }, 198) + _0x985a3ffa._0x73234e59(new byte[30] { 186, 187, 184, 246, 174, 172, 177, 170, 177, 242, 249, 174, 178, 191, 170, 184, 177, 172, 179, 249, 242, 249, 137, 183, 176, 237, 236, 249, 247, 229 }, 222) + _0x985a3ffa._0x73234e59(new byte[34] { 153, 152, 155, 213, 141, 143, 146, 137, 146, 209, 218, 139, 152, 147, 153, 146, 143, 218, 209, 218, 186, 146, 146, 154, 145, 152, 221, 180, 147, 158, 211, 218, 212, 198 }, 253) + _0x985a3ffa._0x73234e59(new byte[30] { 243, 242, 241, 191, 231, 229, 248, 227, 248, 187, 176, 250, 246, 239, 195, 248, 226, 244, 255, 199, 248, 254, 249, 227, 228, 176, 187, 167, 190, 172 }, 151) + _0x985a3ffa._0x73234e59(new byte[449] { 162, 164, 175, 173, 160, 183, 164, 246, 163, 183, 178, 235, 173, 180, 164, 183, 184, 178, 165, 236, 141, 173, 180, 164, 183, 184, 178, 236, 241, 149, 190, 164, 185, 187, 191, 163, 187, 241, 250, 160, 179, 164, 165, 191, 185, 184, 236, 241, 231, 228, 230, 241, 171, 250, 173, 180, 164, 183, 184, 178, 236, 241, 145, 185, 185, 177, 186, 179, 246, 149, 190, 164, 185, 187, 179, 241, 250, 160, 179, 164, 165, 191, 185, 184, 236, 241, 231, 228, 230, 241, 171, 250, 173, 180, 164, 183, 184, 178, 236, 241, 152, 185, 162, 235, 151, 233, 148, 164, 183, 184, 178, 241, 250, 160, 179, 164, 165, 191, 185, 184, 236, 241, 228, 226, 241, 171, 139, 250, 187, 185, 180, 191, 186, 179, 236, 176, 183, 186, 165, 179, 250, 166, 186, 183, 162, 176, 185, 164, 187, 236, 241, 129, 191, 184, 178, 185, 161, 165, 241, 250, 177, 179, 162, 158, 191, 177, 190, 147, 184, 162, 164, 185, 166, 175, 128, 183, 186, 163, 179, 165, 236, 176, 163, 184, 181, 162, 191, 185, 184, 254, 255, 173, 164, 179, 162, 163, 164, 184, 246, 134, 164, 185, 187, 191, 165, 179, 248, 164, 179, 165, 185, 186, 160, 179, 254, 173, 183, 164, 181, 190, 191, 162, 179, 181, 162, 163, 164, 179, 236, 241, 174, 238, 224, 241, 250, 180, 191, 162, 184, 179, 165, 165, 236, 241, 224, 226, 241, 250, 187, 185, 180, 191, 186, 179, 236, 176, 183, 186, 165, 179, 250, 187, 185, 178, 179, 186, 236, 241, 241, 250, 166, 186, 183, 162, 176, 185, 164, 187, 236, 241, 129, 191, 184, 178, 185, 161, 165, 241, 250, 166, 186, 183, 162, 176, 185, 164, 187, 128, 179, 164, 165, 191, 185, 184, 236, 241, 231, 227, 248, 230, 248, 230, 241, 250, 163, 183, 144, 163, 186, 186, 128, 179, 164, 165, 191, 185, 184, 236, 241, 231, 228, 230, 248, 230, 248, 230, 248, 230, 241, 171, 255, 237, 171, 171, 237, 153, 180, 188, 179, 181, 162, 248, 178, 179, 176, 191, 184, 179, 134, 164, 185, 166, 179, 164, 162, 175, 254, 166, 164, 185, 162, 185, 250, 241, 163, 165, 179, 164, 151, 177, 179, 184, 162, 146, 183, 162, 183, 241, 250, 173, 177, 179, 162, 236, 176, 163, 184, 181, 162, 191, 185, 184, 254, 255, 173, 164, 179, 162, 163, 164, 184, 246, 163, 183, 178, 237, 171, 250, 181, 185, 184, 176, 191, 177, 163, 164, 183, 180, 186, 179, 236, 162, 164, 163, 179, 171, 255, 237, 171, 181, 183, 162, 181, 190, 254, 179, 255, 173, 171 }, 214) + _0x985a3ffa._0x73234e59(new byte[112] { 95, 94, 93, 19, 72, 88, 73, 94, 94, 85, 23, 28, 76, 82, 95, 79, 83, 28, 23, 10, 2, 9, 11, 18, 0, 95, 94, 93, 19, 72, 88, 73, 94, 94, 85, 23, 28, 83, 94, 82, 92, 83, 79, 28, 23, 10, 11, 3, 11, 18, 0, 95, 94, 93, 19, 72, 88, 73, 94, 94, 85, 23, 28, 90, 77, 90, 82, 87, 108, 82, 95, 79, 83, 28, 23, 10, 2, 9, 11, 18, 0, 95, 94, 93, 19, 72, 88, 73, 94, 94, 85, 23, 28, 90, 77, 90, 82, 87, 115, 94, 82, 92, 83, 79, 28, 23, 10, 11, 15, 11, 18, 0 }, 59) + _0x985a3ffa._0x73234e59(new byte[45] { 190, 184, 179, 177, 189, 163, 164, 174, 165, 189, 228, 165, 164, 190, 165, 191, 169, 162, 185, 190, 171, 184, 190, 247, 191, 164, 174, 175, 172, 163, 164, 175, 174, 241, 183, 169, 171, 190, 169, 162, 226, 175, 227, 177, 183 }, 202) + _0x985a3ffa._0x73234e59(new byte[721] { 140, 138, 129, 131, 142, 153, 138, 216, 151, 138, 145, 159, 197, 143, 145, 150, 156, 151, 143, 214, 149, 153, 140, 155, 144, 181, 157, 156, 145, 153, 214, 154, 145, 150, 156, 208, 143, 145, 150, 156, 151, 143, 209, 195, 143, 145, 150, 156, 151, 143, 214, 149, 153, 140, 155, 144, 181, 157, 156, 145, 153, 197, 158, 141, 150, 155, 140, 145, 151, 150, 208, 137, 209, 131, 142, 153, 138, 216, 139, 197, 171, 140, 138, 145, 150, 159, 208, 137, 209, 214, 140, 151, 180, 151, 143, 157, 138, 187, 153, 139, 157, 208, 209, 195, 145, 158, 208, 139, 214, 145, 150, 156, 157, 128, 183, 158, 208, 223, 136, 151, 145, 150, 140, 157, 138, 194, 216, 155, 151, 153, 138, 139, 157, 223, 209, 198, 197, 200, 132, 132, 139, 214, 145, 150, 156, 157, 128, 183, 158, 208, 223, 144, 151, 142, 157, 138, 194, 216, 150, 151, 150, 157, 223, 209, 198, 197, 200, 132, 132, 139, 214, 145, 150, 156, 157, 128, 183, 158, 208, 223, 149, 153, 128, 213, 143, 145, 156, 140, 144, 223, 209, 198, 197, 200, 132, 132, 139, 214, 145, 150, 156, 157, 128, 183, 158, 208, 223, 149, 153, 128, 213, 156, 157, 142, 145, 155, 157, 213, 143, 145, 156, 140, 144, 223, 209, 198, 197, 200, 209, 138, 157, 140, 141, 138, 150, 216, 131, 149, 153, 140, 155, 144, 157, 139, 194, 158, 153, 148, 139, 157, 212, 149, 157, 156, 145, 153, 194, 137, 212, 151, 150, 155, 144, 153, 150, 159, 157, 194, 150, 141, 148, 148, 212, 153, 156, 156, 180, 145, 139, 140, 157, 150, 157, 138, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 133, 212, 138, 157, 149, 151, 142, 157, 180, 145, 139, 140, 157, 150, 157, 138, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 133, 212, 153, 156, 156, 189, 142, 157, 150, 140, 180, 145, 139, 140, 157, 150, 157, 138, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 133, 212, 138, 157, 149, 151, 142, 157, 189, 142, 157, 150, 140, 180, 145, 139, 140, 157, 150, 157, 138, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 133, 212, 156, 145, 139, 136, 153, 140, 155, 144, 189, 142, 157, 150, 140, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 138, 157, 140, 141, 138, 150, 216, 158, 153, 148, 139, 157, 195, 133, 133, 195, 145, 158, 208, 139, 214, 145, 150, 156, 157, 128, 183, 158, 208, 223, 136, 151, 145, 150, 140, 157, 138, 194, 216, 158, 145, 150, 157, 223, 209, 198, 197, 200, 132, 132, 139, 214, 145, 150, 156, 157, 128, 183, 158, 208, 223, 144, 151, 142, 157, 138, 194, 216, 144, 151, 142, 157, 138, 223, 209, 198, 197, 200, 209, 138, 157, 140, 141, 138, 150, 216, 131, 149, 153, 140, 155, 144, 157, 139, 194, 140, 138, 141, 157, 212, 149, 157, 156, 145, 153, 194, 137, 212, 151, 150, 155, 144, 153, 150, 159, 157, 194, 150, 141, 148, 148, 212, 153, 156, 156, 180, 145, 139, 140, 157, 150, 157, 138, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 133, 212, 138, 157, 149, 151, 142, 157, 180, 145, 139, 140, 157, 150, 157, 138, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 133, 212, 153, 156, 156, 189, 142, 157, 150, 140, 180, 145, 139, 140, 157, 150, 157, 138, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 133, 212, 138, 157, 149, 151, 142, 157, 189, 142, 157, 150, 140, 180, 145, 139, 140, 157, 150, 157, 138, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 133, 212, 156, 145, 139, 136, 153, 140, 155, 144, 189, 142, 157, 150, 140, 194, 158, 141, 150, 155, 140, 145, 151, 150, 208, 209, 131, 138, 157, 140, 141, 138, 150, 216, 158, 153, 148, 139, 157, 195, 133, 133, 195, 138, 157, 140, 141, 138, 150, 216, 151, 138, 145, 159, 208, 137, 209, 195, 133, 195, 133, 155, 153, 140, 155, 144, 208, 157, 209, 131, 133 }, 248) + _0x985a3ffa._0x73234e59(new byte[5] { 163, 247, 246, 247, 229 }, 222);
    }

    private void StopCurrentFailedLoad(UniWebView _0xdfab03f6)
    {
        _0xb9392db6(false);
        if (_0xdfab03f6 == null)
            return;
        _0xdfab03f6.Stop();
        if (_0xdfab03f6.CanGoBack)
            _0xdfab03f6.GoBack();
    }

    private void _0x05385a51(string _0x439839e6)
    {
        _0x403d920f();
        StartCoroutine(_0x2b19a352(_0x439839e6));
    }

    private Text _0xedc39fc2;
    private float _0x910f3ae9 = 0f;
    private readonly string[] _0x4d5ddffd = new string[]
    {
        _0x985a3ffa._0x73234e59(new byte[60] { 113, 30, 15, 49, 161, 213, 233, 228, 161, 243, 228, 228, 237, 242, 161, 224, 243, 228, 161, 233, 238, 245, 161, 243, 232, 230, 233, 245, 161, 239, 238, 246, 161, 99, 1, 18, 161, 229, 238, 239, 99, 1, 24, 245, 161, 236, 232, 242, 242, 161, 248, 238, 244, 243, 161, 242, 241, 232, 239, 160 }, 129),
        _0x985a3ffa._0x73234e59(new byte[52] { 176, 223, 205, 192, 96, 9, 52, 96, 35, 47, 53, 44, 36, 96, 34, 37, 96, 57, 47, 53, 50, 96, 44, 53, 35, 43, 57, 96, 45, 47, 45, 37, 46, 52, 96, 162, 192, 211, 96, 55, 40, 57, 96, 51, 52, 47, 48, 96, 46, 47, 55, 127 }, 64),
        _0x985a3ffa._0x73234e59(new byte[66] { 79, 55, 12, 66, 21, 34, 141, 239, 196, 202, 141, 218, 196, 195, 222, 141, 204, 223, 200, 141, 197, 196, 217, 217, 196, 195, 202, 141, 192, 194, 223, 200, 141, 194, 203, 217, 200, 195, 141, 217, 194, 201, 204, 212, 141, 79, 45, 62, 141, 222, 217, 204, 212, 141, 196, 195, 141, 217, 197, 200, 141, 202, 204, 192, 200, 131 }, 173),
        _0x985a3ffa._0x73234e59(new byte[54] { 220, 179, 185, 190, 12, 120, 68, 69, 95, 12, 69, 95, 12, 92, 94, 69, 65, 73, 12, 88, 69, 65, 73, 12, 206, 172, 191, 12, 88, 68, 73, 12, 78, 73, 95, 88, 12, 92, 64, 77, 85, 73, 94, 95, 12, 92, 64, 77, 85, 12, 66, 67, 91, 2 }, 44),
        _0x985a3ffa._0x73234e59(new byte[48] { 45, 66, 73, 120, 253, 132, 178, 168, 175, 253, 170, 180, 179, 179, 180, 179, 186, 253, 174, 169, 175, 184, 188, 182, 253, 190, 178, 168, 177, 185, 253, 191, 184, 253, 178, 179, 184, 253, 174, 173, 180, 179, 253, 188, 170, 188, 164, 243 }, 221),
        _0x985a3ffa._0x73234e59(new byte[65] { 8, 103, 98, 120, 216, 178, 153, 155, 147, 136, 151, 140, 139, 216, 153, 138, 157, 216, 149, 151, 138, 157, 216, 153, 155, 140, 145, 142, 157, 216, 140, 151, 150, 145, 159, 144, 140, 216, 26, 120, 107, 216, 139, 140, 153, 129, 216, 153, 150, 156, 216, 140, 138, 129, 216, 129, 151, 141, 138, 216, 148, 141, 155, 147, 214 }, 248),
        _0x985a3ffa._0x73234e59(new byte[55] { 7, 104, 121, 69, 215, 178, 129, 146, 133, 142, 215, 132, 135, 158, 153, 215, 148, 152, 130, 153, 131, 132, 215, 21, 119, 100, 215, 131, 159, 146, 215, 153, 146, 143, 131, 215, 152, 153, 146, 215, 148, 152, 130, 155, 147, 215, 149, 146, 215, 142, 152, 130, 133, 132, 217 }, 247),
        _0x985a3ffa._0x73234e59(new byte[63] { 192, 143, 178, 205, 154, 173, 2, 114, 78, 67, 91, 71, 80, 81, 2, 80, 75, 69, 74, 86, 2, 76, 77, 85, 2, 67, 80, 71, 2, 85, 75, 76, 76, 75, 76, 69, 2, 192, 162, 177, 2, 70, 77, 76, 192, 162, 187, 86, 2, 85, 67, 78, 73, 2, 67, 85, 67, 91, 2, 91, 71, 86, 12 }, 34),
        _0x985a3ffa._0x73234e59(new byte[51] { 186, 213, 197, 204, 106, 5, 36, 38, 51, 106, 62, 34, 37, 57, 47, 106, 61, 34, 37, 106, 57, 62, 43, 51, 106, 35, 36, 106, 62, 34, 47, 106, 45, 43, 39, 47, 106, 61, 35, 36, 106, 62, 34, 47, 106, 58, 56, 35, 48, 47, 100 }, 74),
        _0x985a3ffa._0x73234e59(new byte[64] { 176, 200, 243, 189, 234, 221, 114, 31, 61, 63, 55, 60, 38, 39, 63, 114, 59, 33, 114, 55, 36, 55, 32, 43, 38, 58, 59, 60, 53, 114, 176, 210, 193, 114, 57, 55, 55, 34, 114, 33, 34, 59, 60, 60, 59, 60, 53, 114, 52, 61, 32, 114, 43, 61, 39, 32, 114, 49, 58, 51, 60, 49, 55, 124 }, 82)
    };
    private int _0x77056e5e = -1;
    private bool TryOpenExternalLikeChrome(string _0x2327471d)
    {
        if (string.IsNullOrEmpty(_0x2327471d))
            return false;
        if (_0x2327471d.StartsWith(_0x985a3ffa._0x73234e59(new byte[9] { 125, 122, 96, 113, 122, 96, 46, 59, 59 }, 20), StringComparison.OrdinalIgnoreCase))
            return _0x325a9702(_0x2327471d);
        if (_0xcb7efd1c(_0x2327471d))
            return _0x41c47c77(_0x2327471d, null);
        if (!_0x2327471d.StartsWith(_0x985a3ffa._0x73234e59(new byte[7] { 223, 195, 195, 199, 141, 152, 152 }, 183), StringComparison.OrdinalIgnoreCase) && !_0x2327471d.StartsWith(_0x985a3ffa._0x73234e59(new byte[8] { 94, 66, 66, 70, 69, 12, 25, 25 }, 54), StringComparison.OrdinalIgnoreCase) && !_0x2327471d.StartsWith(_0x985a3ffa._0x73234e59(new byte[11] { 130, 129, 140, 150, 151, 217, 129, 143, 130, 141, 136 }, 227), StringComparison.OrdinalIgnoreCase))
        {
            return _0xe1581a09(_0x2327471d);
        }

        return false;
    }

    private string _0x40a3ee68 = "";
    private void _0x69c40b27()
    {
        {
#if B_LOGS
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[22] { 156, 147, 162, 180, 179, 154, 231, 148, 179, 168, 181, 162, 131, 162, 177, 174, 164, 162, 142, 169, 161, 168 }, 199));
#endif
        }

        _0x240f7fae = SystemInfo.deviceModel;
        _0x26ac9173 = Application.version;
        _0x6581ca7b = Application.installMode;
        _0x40a3ee68 = Application.installerName;
        _0x621ee779 = Application.identifier;
        _0x891b3b46 = _0x5fcddbd6();
        _0x7142879e = _0xaf12a4ea();
        _0x3d379e1b = SystemInfo.deviceUniqueIdentifier;
        _0x92800f4a = SystemInfo.graphicsDeviceName;
        _0xbfadd85a = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x26ac9173 = _0x985a3ffa._0x73234e59(new byte[5] { 253, 228, 253, 228, 253 }, 202);
                _0x6581ca7b = ApplicationInstallMode.Store;
                _0x40a3ee68 = _0x985a3ffa._0x73234e59(new byte[19] { 135, 139, 137, 202, 133, 138, 128, 150, 139, 141, 128, 202, 146, 129, 138, 128, 141, 138, 131 }, 228);
                _0x7142879e = _0x985a3ffa._0x73234e59(new byte[8] { 151, 159, 130, 134, 139, 210, 135, 147 }, 242);
                _0x3d379e1b = Guid.NewGuid().ToString().Replace(_0x985a3ffa._0x73234e59(new byte[1] { 149 }, 184), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[17] { 185, 182, 135, 145, 150, 191, 194, 134, 135, 148, 175, 141, 134, 135, 142, 216, 194 }, 226) + _0x240f7fae);
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[19] { 168, 167, 150, 128, 135, 174, 211, 146, 131, 131, 165, 150, 129, 128, 154, 156, 157, 201, 211 }, 243) + _0x26ac9173);
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[20] { 4, 11, 58, 44, 43, 2, 127, 54, 49, 44, 43, 62, 51, 51, 18, 48, 59, 58, 101, 127 }, 95) + _0x6581ca7b);
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[23] { 106, 101, 84, 66, 69, 108, 17, 88, 95, 66, 69, 80, 93, 93, 84, 67, 98, 69, 94, 67, 84, 11, 17 }, 49) + _0x40a3ee68);
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[14] { 75, 68, 117, 99, 100, 77, 48, 113, 96, 96, 89, 116, 42, 48 }, 16) + _0x621ee779);
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[14] { 124, 115, 66, 84, 83, 122, 7, 70, 67, 81, 110, 67, 29, 7 }, 39) + _0x891b3b46);
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[18] { 126, 113, 64, 86, 81, 120, 5, 80, 86, 64, 87, 100, 66, 64, 75, 81, 31, 5 }, 37) + _0x7142879e);
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[17] { 137, 134, 183, 161, 166, 143, 242, 161, 171, 161, 150, 183, 164, 155, 182, 232, 242 }, 210) + _0x3d379e1b);
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[12] { 86, 89, 104, 126, 121, 80, 45, 106, 125, 120, 55, 45 }, 13) + _0x92800f4a);
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[12] { 165, 170, 155, 141, 138, 163, 222, 157, 142, 139, 196, 222 }, 254) + _0xbfadd85a);
#endif
        }
    }

    private ApplicationInstallMode _0x6581ca7b = ApplicationInstallMode.Unknown;
    internal bool IsHttpUrl(string _0x2e8b960e)
    {
        if (string.IsNullOrEmpty(_0x2e8b960e))
            return false;
        return _0x2e8b960e.StartsWith(_0x985a3ffa._0x73234e59(new byte[7] { 17, 13, 13, 9, 67, 86, 86 }, 121), StringComparison.OrdinalIgnoreCase) || _0x2e8b960e.StartsWith(_0x985a3ffa._0x73234e59(new byte[8] { 126, 98, 98, 102, 101, 44, 57, 57 }, 22), StringComparison.OrdinalIgnoreCase);
    }

    private async Task<bool> _0x3136e469()
    {
        _0xe551054e.Instance?._0x40691c81();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xf8802dc0) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[32] { 24, 23, 38, 48, 55, 30, 99, 22, 45, 42, 55, 58, 99, 19, 54, 48, 43, 99, 13, 44, 55, 42, 37, 42, 32, 34, 55, 42, 44, 45, 121, 99 }, 67) + string.Join(_0x985a3ffa._0x73234e59(new byte[1] { 222 }, 215), _0xf8802dc0));
                }
#endif
            }
        };
        try
        {
            _0xb85a6f17 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[31] { 227, 236, 221, 203, 204, 229, 152, 254, 217, 209, 212, 221, 220, 152, 204, 215, 152, 223, 221, 204, 152, 200, 205, 203, 208, 152, 204, 215, 211, 221, 214 }, 184));
                }
#endif
            }

            _0xb85a6f17 = "";
        }

        _0xb92e131c = !string.IsNullOrEmpty(_0xb85a6f17);
        _0xd98d5f04 = _0xa66497f7();
        {
#if B_LOGS
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[25] { 165, 170, 155, 141, 138, 163, 222, 171, 144, 151, 138, 135, 222, 174, 139, 141, 150, 222, 170, 145, 149, 155, 144, 196, 222 }, 254) + _0xb85a6f17);
#endif
        }

        _0xe551054e.Instance?._0xf98b8b96();
        return false;
    }

    private string _0x02b4a505(string _0xbafb2156, string _0xbb6ea1cc)
    {
        if (string.IsNullOrEmpty(_0xbb6ea1cc))
            return _0xbafb2156;
        if (_0xbafb2156.Contains(_0x985a3ffa._0x73234e59(new byte[1] { 109 }, 82)))
            return _0xbafb2156 + _0x985a3ffa._0x73234e59(new byte[8] { 221, 136, 158, 149, 159, 146, 159, 198 }, 251) + UnityWebRequest.EscapeURL(_0xbb6ea1cc);
        else
            return _0xbafb2156 + _0x985a3ffa._0x73234e59(new byte[8] { 45, 97, 119, 124, 118, 123, 118, 47 }, 18) + UnityWebRequest.EscapeURL(_0xbb6ea1cc);
    }

    private void _0x0e295952()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0x7142879e = "";
    private void _0x2c8c3a79(string _0x7add566f)
    {
        bool _0x52c030be = !string.IsNullOrEmpty(_0x7add566f);
        if (_0x52c030be)
        {
            {
#if B_LOGS
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[13] { 137, 134, 183, 161, 166, 143, 242, 129, 186, 189, 165, 232, 242 }, 210) + _0x7add566f);
#endif
            }

            _0x05385a51(_0x7add566f);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[39] { 162, 173, 156, 138, 141, 164, 217, 191, 152, 149, 149, 155, 152, 154, 146, 217, 27, 127, 107, 217, 190, 152, 148, 156, 217, 209, 151, 150, 217, 159, 144, 151, 152, 149, 217, 172, 171, 181, 208 }, 249));
#endif
            }

            _0x93fd8ac6();
            return;
        }
    }

    private bool _0x41c47c77(string _0xf1f58420, string _0x6a175c55)
    {
        string _0x0d7c547e = _0xc983238c(_0xf1f58420);
        if (string.IsNullOrEmpty(_0x0d7c547e))
            _0x0d7c547e = _0x6a175c55;
        if (_0x4b4a34c8(_0x0d7c547e))
            return true;
        string _0xd291d535 = string.IsNullOrEmpty(_0x0d7c547e) ? _0x985a3ffa._0x73234e59(new byte[29] { 56, 36, 36, 32, 35, 106, 127, 127, 32, 60, 49, 41, 126, 55, 63, 63, 55, 60, 53, 126, 51, 63, 61, 127, 35, 36, 63, 34, 53 }, 80) : _0x985a3ffa._0x73234e59(new byte[46] { 91, 71, 71, 67, 64, 9, 28, 28, 67, 95, 82, 74, 29, 84, 92, 92, 84, 95, 86, 29, 80, 92, 94, 28, 64, 71, 92, 65, 86, 28, 82, 67, 67, 64, 28, 87, 86, 71, 82, 90, 95, 64, 12, 90, 87, 14 }, 51) + _0x0d7c547e;
        WLog(_0x985a3ffa._0x73234e59(new byte[35] { 77, 102, 124, 97, 99, 107, 66, 103, 101, 107, 46, 99, 111, 124, 101, 107, 122, 46, 104, 111, 98, 98, 108, 111, 109, 101, 46, 111, 125, 46, 121, 107, 108, 52, 46 }, 14) + _0xd291d535);
        return _0xe1581a09(_0xd291d535);
    }

    private void _0x403d920f()
    {
        using (var _0x9cc4f318 = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[30] { 254, 242, 240, 179, 232, 243, 244, 233, 228, 174, 249, 179, 237, 241, 252, 228, 248, 239, 179, 200, 243, 244, 233, 228, 205, 241, 252, 228, 248, 239 }, 157)))
        using (var _0xc7be4fe4 = _0x9cc4f318.GetStatic<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[15] { 23, 1, 6, 6, 17, 26, 0, 53, 23, 0, 29, 2, 29, 0, 13 }, 116)))
        using (var _0xe4c9ce8f = _0xc7be4fe4.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[9] { 124, 126, 111, 82, 117, 111, 126, 117, 111 }, 27)))
        {
            if (_0xe4c9ce8f == null)
                return;
            using (var _0xfedf3108 = _0xe4c9ce8f.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[9] { 247, 245, 228, 213, 232, 228, 226, 241, 227 }, 144)))
            {
                if (_0xfedf3108 == null)
                    return;
                using (var _0xdcf3beb1 = new AndroidJavaObject(_0x985a3ffa._0x73234e59(new byte[19] { 149, 136, 157, 212, 144, 137, 149, 148, 212, 176, 169, 181, 180, 181, 152, 144, 159, 153, 142 }, 250)))
                using (var _0x8481171d = _0xfedf3108.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[6] { 92, 82, 78, 100, 82, 67 }, 55)))
                using (var _0xe9bf01e6 = _0x8481171d.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[8] { 162, 191, 174, 185, 170, 191, 164, 185 }, 203)))
                {
                    while (_0xe9bf01e6.Call<bool>(_0x985a3ffa._0x73234e59(new byte[7] { 152, 145, 131, 190, 149, 136, 132 }, 240)))
                    {
                        string _0xe7fbfbf4 = _0xe9bf01e6.Call<string>(_0x985a3ffa._0x73234e59(new byte[4] { 38, 45, 48, 60 }, 72));
                        using (var _0x0e92a329 = _0xfedf3108.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[3] { 117, 119, 102 }, 18), _0xe7fbfbf4))
                        {
                            _0xdcf3beb1.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[3] { 102, 99, 98 }, 22), _0xe7fbfbf4, _0x0e92a329);
                        }
                    }

                    string _0x34b1f081 = _0xdcf3beb1.Call<string>(_0x985a3ffa._0x73234e59(new byte[8] { 157, 134, 186, 157, 155, 128, 135, 142 }, 233));
                    if (!string.IsNullOrEmpty(_0x34b1f081))
                    {
                        _0x5f6b651d(_0x34b1f081);
                        _0xceccaf59(_0x34b1f081);
                    }
                }
            }
        }
    }

    private string _0x41033cfe = "";
    private Canvas _0xd748b7ab;
    private void OnApplicationFocus(bool _0x1b756375)
    {
        isApplicationFocus = _0x1b756375;
        if (_0x1b756375 && _0xc2c17895)
        {
            _0x403d920f();
        }
    }

    internal bool isApplicationPause = false;
    private void _0x6a9704dc(UniWebView _0x39f6e0ca)
    {
        _0x39f6e0ca.BackgroundColor = Color.clear;
        _0x39f6e0ca.SetSupportMultipleWindows(true, true);
        _0x39f6e0ca.SetBackButtonEnabled(false);
        _0x7f50f1ad.SetUserAgent(_0x604fec9e());
    }

    private string _0xaf12a4ea()
    {
        try
        {
            using (var _0x5a780216 = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[30] { 64, 76, 78, 13, 86, 77, 74, 87, 90, 16, 71, 13, 83, 79, 66, 90, 70, 81, 13, 118, 77, 74, 87, 90, 115, 79, 66, 90, 70, 81 }, 35)))
            {
                var _0x2dcebfea = _0x5a780216.GetStatic<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[15] { 108, 122, 125, 125, 106, 97, 123, 78, 108, 123, 102, 121, 102, 123, 118 }, 15));
                var _0x2f01d82e = _0x2dcebfea.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[21] { 250, 248, 233, 220, 237, 237, 241, 244, 254, 252, 233, 244, 242, 243, 222, 242, 243, 233, 248, 229, 233 }, 157));
                using (var _0x95699c97 = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[26] { 100, 107, 97, 119, 106, 108, 97, 43, 114, 96, 103, 110, 108, 113, 43, 82, 96, 103, 86, 96, 113, 113, 108, 107, 98, 118 }, 5)))
                {
                    return _0x95699c97.CallStatic<string>(_0x985a3ffa._0x73234e59(new byte[19] { 223, 221, 204, 252, 221, 222, 217, 205, 212, 204, 237, 203, 221, 202, 249, 223, 221, 214, 204 }, 184), _0x2f01d82e);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private void OnApplicationPause(bool _0x584e1627)
    {
        isApplicationPause = _0x584e1627;
    }

    internal bool firstLoadShown = false;
    private bool _0x58332c0b(int _0x5d8695aa, string _0xb4747e15, string _0x9c997c4c)
    {
        if (string.IsNullOrEmpty(_0x9c997c4c))
            return false;
        if (!IsHttpUrl(_0x9c997c4c))
            return true;
        if (string.IsNullOrEmpty(_0xb4747e15))
            return false;
        return _0xb4747e15.IndexOf(_0x985a3ffa._0x73234e59(new byte[20] { 98, 117, 117, 120, 100, 104, 105, 105, 98, 100, 115, 110, 104, 105, 120, 117, 98, 116, 98, 115 }, 39), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb4747e15.IndexOf(_0x985a3ffa._0x73234e59(new byte[22] { 175, 184, 184, 181, 169, 165, 164, 164, 175, 169, 190, 163, 165, 164, 181, 184, 175, 172, 191, 185, 175, 174 }, 234), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb4747e15.IndexOf(_0x985a3ffa._0x73234e59(new byte[21] { 103, 112, 112, 125, 97, 109, 108, 108, 103, 97, 118, 107, 109, 108, 125, 97, 110, 109, 113, 103, 102 }, 34), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb4747e15.IndexOf(_0x985a3ffa._0x73234e59(new byte[22] { 149, 130, 130, 143, 133, 158, 155, 158, 159, 135, 158, 143, 133, 130, 156, 143, 131, 147, 152, 149, 157, 149 }, 208), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x889c6349 = "";
    private string _0x3cfbb6c6 = "";
    private Action _0xf57efd2a;
    private IEnumerator _0x414b9e77(Dictionary<string, object> _0x897d3539)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[30] { 102, 105, 88, 78, 73, 96, 29, 123, 88, 73, 94, 85, 29, 120, 69, 73, 79, 92, 29, 109, 72, 78, 85, 29, 121, 92, 73, 92, 7, 29 }, 61) + string.Join(_0x985a3ffa._0x73234e59(new byte[1] { 198 }, 207), _0x897d3539));
#endif
            }
        }

        string _0x0c5c8236 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x897d3539 != null && _0x897d3539.TryGetValue(_0x985a3ffa._0x73234e59(new byte[16] { 176, 177, 170, 183, 184, 183, 189, 191, 170, 183, 177, 176, 154, 191, 170, 191 }, 222), out var raw))
        {
            try
            {
                var _0x70fbb3e2 = raw?.ToString();
                var _0xcf124392 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x70fbb3e2);
                if (_0xcf124392 != null && _0xcf124392.TryGetValue(_0x985a3ffa._0x73234e59(new byte[6] { 14, 24, 19, 25, 20, 25 }, 125), out var val))
                {
                    _0x0c5c8236 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x985a3ffa._0x73234e59(new byte[30] { 191, 176, 129, 151, 144, 196, 180, 145, 151, 140, 185, 196, 174, 183, 171, 170, 196, 148, 133, 150, 151, 129, 196, 129, 150, 150, 139, 150, 222, 196 }, 228) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x0c5c8236) && _0x897d3539 != null && _0x897d3539.TryGetValue(_0x985a3ffa._0x73234e59(new byte[6] { 6, 16, 27, 17, 28, 17 }, 117), out var lab))
        {
            _0x0c5c8236 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[38] { 149, 154, 171, 189, 186, 238, 158, 187, 189, 166, 147, 238, 136, 171, 186, 173, 166, 171, 170, 238, 189, 171, 160, 170, 167, 170, 238, 168, 188, 161, 163, 238, 164, 189, 161, 160, 244, 238 }, 206) + _0x0c5c8236);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x0c5c8236))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[38] { 136, 135, 182, 160, 167, 243, 131, 166, 160, 187, 142, 243, 132, 178, 186, 167, 243, 167, 188, 243, 188, 163, 182, 189, 243, 164, 186, 167, 187, 243, 160, 182, 189, 183, 186, 183, 233, 243 }, 211) + _0x0c5c8236);
            }
#endif
        }

        _0xcde0a61f = _0x0c5c8236;
        yield return new WaitUntil(() => _0xc2c17895);
        var _0x6e7388fa = _0xfebd89d4(2, 100);
        yield return new WaitUntil(() => _0x6e7388fa.IsCompleted);
        string _0x0a13898b = _0x6e7388fa.Result;
        if (!string.IsNullOrEmpty(_0x0a13898b))
        {
            string _0x88d2755f = _0x02b4a505(_0x0a13898b, _0x0c5c8236);
            {
#if B_LOGS
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[33] { 123, 116, 69, 83, 84, 0, 112, 85, 83, 72, 125, 0, 114, 69, 76, 79, 65, 68, 0, 119, 69, 66, 118, 73, 69, 87, 0, 87, 73, 84, 72, 26, 0 }, 32) + _0x88d2755f);
#endif
            }

            _0x7f50f1ad.Load(_0x88d2755f);
        }
    }

    internal Rect lastSafe = Rect.zero;
    private IEnumerator _0x7ccd73df(IEnumerator _0xcc793ab7, TaskCompletionSource<bool> _0x43eeb190)
    {
        yield return _0xcc793ab7;
        _0x43eeb190.SetResult(true);
    }

    private bool _0x5bddf221 = false;
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x93fd8ac6();
    }

    internal void _0x8b72ed32()
    {
        Rect _0xb9e19e14 = Screen.safeArea;
        Vector2 _0x78a5d2c3 = new Vector2(Screen.width, Screen.height);
        if (_0xb9e19e14 == lastSafe && _0x78a5d2c3 == lastSize)
            return;
        // Apply manual padding
        _0xb9e19e14.xMin += _0xaf7b912a;
        _0xb9e19e14.xMax -= _0x38d6a517;
        _0xb9e19e14.yMin += _0x3beec2ff;
        _0xb9e19e14.yMax -= _0xac27b51a;
        // Convert Unity safe area -> native WebView frame
        Rect _0x2deb0bcd = new Rect(_0xb9e19e14.x, _0x78a5d2c3.y - _0xb9e19e14.y - _0xb9e19e14.height, // Y flip for native coordinate system
 _0xb9e19e14.width, _0xb9e19e14.height);
        _0x7f50f1ad.Frame = _0x2deb0bcd;
        lastSafe = Screen.safeArea;
        lastSize = _0x78a5d2c3;
    }

    private Canvas _0x5476c10f()
    {
        if (_0xd748b7ab != null)
            return _0xd748b7ab;
        var _0x9da9a2b9 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x9da9a2b9 == null)
        {
            var _0x69a51794 = new GameObject(_0x985a3ffa._0x73234e59(new byte[6] { 253, 223, 208, 200, 223, 205 }, 190), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x9da9a2b9 = _0x69a51794.GetComponent<Canvas>();
            _0x9da9a2b9.transform.SetParent(transform, false);
            _0x9da9a2b9.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xd748b7ab = _0x9da9a2b9;
        return _0xd748b7ab;
    }

    // MAIN FLOW
    private bool _0xddf4eeb5 { get; set; }

    private IEnumerator _0x2b19a352(string _0xb94d7c12)
    {
        if (_0x7f50f1ad != null && _0xc2c17895)
            yield break;
        _0x7f50f1ad = gameObject.AddComponent<UniWebView>();
        _0x6a9704dc(_0x7f50f1ad);
        _0xae8aca63(_0x7f50f1ad);
        _0x7f50f1ad.BackgroundColor = Color.clear;
        var _0x3373355e = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x8b72ed32();
        yield return new WaitForEndOfFrame();
        _0xc2c17895 = true;
        _0xab750141();
        _0xb9392db6(true);
        _0x2974f2e9 = false;
        _0x30d2d721 = false;
        _0xf34740b2.Clear();
        _0x77056e5e = -1;
        firstLoadShown = false;
        _0x95600005 = false;
        _0x94d26329 = false;
        _0x7f50f1ad.SetUserAgent("");
        _0x910f3ae9 = Time.realtimeSinceStartup;
        _0x7f50f1ad.Stop();
        _0x7f50f1ad.Load(_0xb94d7c12);
        _0x7f50f1ad.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x985a3ffa._0x73234e59(new byte[25] { 222, 242, 250, 253, 179, 196, 246, 241, 197, 250, 246, 228, 179, 218, 253, 250, 231, 250, 242, 255, 179, 192, 251, 252, 228 }, 147));
    }

    private IEnumerator _0xc135ee1b(float _0x164b774c)
    {
        yield return new WaitForSeconds(_0x164b774c);
        if (!_0xddf4eeb5)
        {
            _0xddf4eeb5 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xc37862b9}");
                }
#endif
            }
        }
    }

    private Task _0x8662dab1(IEnumerator _0x6e8c2eec)
    {
        var _0x35f976da = new TaskCompletionSource<bool>();
        StartCoroutine(_0x7ccd73df(_0x6e8c2eec, _0x35f976da));
        return _0x35f976da.Task;
    }

    private IEnumerator _0xd775c88e()
    {
        yield return _0xc3efae74(Permission.Camera);
    }

    // WS_SOURCE MONO
    public static _0x81086c60 _0xe57755da { get; private set; }

    private async Task<bool> _0xaeea2f1d()
    {
        {
#if B_LOGS
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[29] { 154, 149, 164, 178, 181, 156, 225, 136, 178, 145, 179, 168, 183, 160, 162, 184, 128, 175, 165, 146, 160, 183, 164, 165, 130, 169, 164, 162, 170 }, 193));
#endif
        }

        string _0xd25118a8 = "";
        for (int _0x3dd57a76 = 0; _0x3dd57a76 < 2; _0x3dd57a76++)
        {
            if (await _0x8ae22398(1, 100))
            {
                await _0x43235274(_0x985a3ffa._0x73234e59(new byte[7] { 51, 61, 62, 50, 58, 52, 53 }, 81));
                _0x93fd8ac6();
                return true;
            }

            _0xd25118a8 = await _0xfebd89d4(1, 100);
            if (!string.IsNullOrEmpty(_0xd25118a8))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xd25118a8))
            {
                if (!string.IsNullOrEmpty(_0xcde0a61f))
                {
                    _0xd25118a8 = _0x02b4a505(_0xd25118a8, _0xcde0a61f);
                    {
#if B_LOGS
                        Debug.Log(_0x985a3ffa._0x73234e59(new byte[53] { 200, 199, 246, 224, 231, 206, 179, 208, 242, 240, 251, 246, 247, 179, 245, 250, 253, 242, 255, 198, 225, 255, 179, 228, 250, 231, 251, 179, 224, 246, 253, 247, 250, 247, 179, 113, 21, 1, 179, 224, 251, 252, 228, 179, 196, 246, 241, 197, 250, 246, 228, 169, 179 }, 147) + _0xd25118a8);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x985a3ffa._0x73234e59(new byte[39] { 192, 207, 254, 232, 239, 198, 187, 216, 250, 248, 243, 254, 255, 187, 253, 242, 245, 250, 247, 206, 233, 247, 187, 121, 29, 9, 187, 232, 243, 244, 236, 187, 204, 254, 249, 205, 242, 254, 236 }, 155));
#endif
                    }
                }

                _0x5bddf221 = true;
                _0x05385a51(_0xd25118a8);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[44] { 87, 88, 105, 127, 120, 81, 44, 73, 116, 111, 105, 124, 120, 101, 99, 98, 44, 123, 100, 101, 96, 105, 44, 111, 100, 105, 111, 103, 101, 98, 107, 44, 127, 109, 122, 105, 104, 44, 96, 101, 98, 103, 54, 44 }, 12) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0x621ee779 = "";
    // WEB VIEW LOGIC END
    internal void _0xe418205c()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x13fc0169 = new AndroidNotificationChannel
        {
            Id = _0x985a3ffa._0x73234e59(new byte[15] { 240, 241, 242, 245, 225, 248, 224, 203, 247, 252, 245, 250, 250, 241, 248 }, 148),
            Name = _0x985a3ffa._0x73234e59(new byte[15] { 146, 179, 176, 183, 163, 186, 162, 246, 149, 190, 183, 184, 184, 179, 186 }, 214),
            Importance = Importance.High,
            Description = _0x985a3ffa._0x73234e59(new byte[21] { 146, 176, 187, 176, 167, 180, 185, 245, 187, 186, 161, 188, 179, 188, 182, 180, 161, 188, 186, 187, 166 }, 213)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x13fc0169);
        // Build notification
        var _0xc416a765 = new AndroidNotification
        {
            Title = _0x4d5ddffd[UnityEngine.Random.Range(0, _0x4d5ddffd.Length)],
            Text = _0x985a3ffa._0x73234e59(new byte[21] { 114, 65, 86, 19, 74, 92, 70, 19, 64, 70, 65, 86, 19, 71, 92, 19, 86, 75, 90, 71, 12 }, 51),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xc416a765, _0x985a3ffa._0x73234e59(new byte[15] { 227, 226, 225, 230, 242, 235, 243, 216, 228, 239, 230, 233, 233, 226, 235 }, 135));
    }

    private int _0xac27b51a = 5, _0x3beec2ff = 5, _0xaf7b912a = 5, _0x38d6a517 = 5;
    private bool _0x94d26329 = false;
    private void Awake()
    {
        if (_0xe57755da != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xe57755da = gameObject.GetComponent<_0x81086c60>();
        DontDestroyOnLoad(gameObject);
        _0xb85a6f17 = _0x3876ae03 = _0xcd25fef6 = "";
        _0xb62e6704 = "";
        _0xc2c17895 = false;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xa367fd97)
    {
        if (_0xa367fd97 == null || _0xa367fd97.Extra == null)
            return null;
        object _0x9f113f9d;
        if (!_0xa367fd97.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x9f113f9d))
            return null;
        return _0x9f113f9d as string;
    }

    private bool _0x798bc304()
    {
        var _0xb61e9963 = Keyboard.current;
        return _0xb61e9963 != null && _0xb61e9963.escapeKey.wasPressedThisFrame;
    }

    private string _0xcde0a61f;
    private string _0x26ac9173 = "";
    private bool _0x1446eb7e()
    {
        var _0x51642012 = _0xe2aa0b2e();
        if (_0x51642012 == null)
            return false;
        WLog(_0x985a3ffa._0x73234e59(new byte[31] { 133, 172, 191, 169, 186, 172, 191, 168, 237, 175, 172, 174, 166, 237, 224, 243, 237, 189, 162, 189, 184, 189, 237, 138, 162, 143, 172, 174, 166, 247, 237 }, 205) + _0x51642012.Id);
        _0x51642012.GoBack();
        return true;
    }

    private string Decrypt(string _0x75b6fb66, string _0xfc3a562b)
    {
        try
        {
            var _0xa6624735 = Convert.FromBase64String(_0x75b6fb66);
            using var _0x21a28cbb = Aes.Create();
            _0x21a28cbb.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xfc3a562b));
            var _0x37015ddd = new byte[16];
            Buffer.BlockCopy(_0xa6624735, 0, _0x37015ddd, 0, 16);
            _0x21a28cbb.IV = _0x37015ddd;
            using var _0x7fed3455 = new MemoryStream(_0xa6624735, 16, _0xa6624735.Length - 16);
            using var _0x703dc3ca = new CryptoStream(_0x7fed3455, _0x21a28cbb.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xc0e8ae7c = new StreamReader(_0x703dc3ca, Encoding.UTF8);
            return _0xc0e8ae7c.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private JObject _0x19373fb8(params string[] _0xb309966d)
    {
        JObject _0x4e4276ee = new JObject();
        foreach (var _0xd09eaa95 in _0xb309966d)
        {
            string _0x66cb06f5 = _0xb1080a06();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x66cb06f5} val={_0xd09eaa95}");
#endif
            }

            _0x4e4276ee.Add(_0x66cb06f5, _0xd09eaa95 == null ? "" : _0xd09eaa95);
        }

        return _0x4e4276ee;
    }

    private void _0x5f6b651d(string _0x7ebab537)
    {
        Dictionary<string, object> _0xdb2bb265;
        try
        {
            _0xdb2bb265 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x7ebab537);
        }
        catch
        {
            return;
        }

        var _0x544f87a7 = ReadPushField(_0xdb2bb265, _0x985a3ffa._0x73234e59(new byte[3] { 68, 67, 93 }, 49));
        if (string.IsNullOrWhiteSpace(_0x544f87a7))
            return;
        _0x544f87a7 = _0x544f87a7.Trim();
        if (!IsHttpUrl(_0x544f87a7))
            return;
        if (string.Equals(_0x544f87a7, _0xc35a9da5, StringComparison.Ordinal))
            return;
        _0xc35a9da5 = _0x544f87a7;
        OpenUrlExternally(_0x544f87a7);
    }

    private bool _0xd00837b5 = false;
    private string _0x3ea6d764 = "";
    private GameObject _0x78b63360;
    private string _0x92800f4a = "";
    private async Task<string> _0xfebd89d4(int _0x0b65f516 = 5, int _0x87d085ef = 500)
    {
        try
        {
            List<EntityData> _0x4b20eeb2 = new List<EntityData>();
            int _0x2dcbf426 = 0;
            do
            {
                _0x4b20eeb2 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x985a3ffa._0x73234e59(new byte[8] { 178, 174, 163, 187, 167, 176, 139, 166 }, 194), _0x3cfbb6c6, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x3cfbb6c6 }), new QueryOptions())).ToList();
                await Task.Delay(_0x87d085ef);
            }
            while (_0x4b20eeb2.Count == 0 && _0x2dcbf426++ < _0x0b65f516);
            {
#if B_LOGS
                {
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[33] { 150, 153, 168, 190, 185, 144, 237, 158, 172, 187, 168, 169, 237, 129, 164, 163, 166, 237, 156, 184, 168, 191, 180, 237, 191, 168, 190, 184, 161, 185, 190, 247, 237 }, 205) + JsonConvert.SerializeObject(_0x4b20eeb2, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[39] { 135, 136, 185, 175, 168, 129, 252, 143, 189, 170, 185, 184, 252, 144, 181, 178, 183, 252, 141, 169, 185, 174, 165, 252, 174, 185, 175, 169, 176, 168, 175, 252, 191, 179, 169, 178, 168, 230, 252 }, 220) + _0x4b20eeb2.Count);
                }
#endif
            }

            var _0x41eff61e = _0x4b20eeb2.SelectMany(_0xc2fb5684 => _0xc2fb5684.Data).FirstOrDefault(_0xa537080c => _0xa537080c.Key == _0x3cfbb6c6)?.Value.GetAs<string>() ?? string.Empty;
            _0x41eff61e = Decrypt(_0x41eff61e, _0x3cfbb6c6);
            {
#if B_LOGS
                {
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[24] { 31, 16, 33, 55, 48, 25, 100, 8, 43, 37, 32, 100, 55, 37, 50, 33, 32, 100, 40, 45, 42, 47, 126, 100 }, 68) + _0x41eff61e);
                }
#endif
            }

            return _0x41eff61e;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[39] { 4, 11, 58, 44, 43, 2, 127, 24, 58, 43, 127, 48, 45, 127, 47, 62, 45, 44, 58, 127, 44, 62, 41, 58, 59, 127, 51, 54, 49, 52, 127, 57, 62, 54, 51, 58, 59, 101, 127 }, 95) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private async void Start()
    {
        await _0xaf3af3bc();
    }

    private async Task _0x61e07820()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x889c6349 = _0x985a3ffa._0x73234e59(new byte[5] { 107, 108, 97, 126, 104 }, 13);
        _0x3ea6d764 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x891f1674 = DateTime.UtcNow.Ticks.ToString();
        _0x41033cfe = "";
        JObject _0x10d27eaa = _0x19373fb8(_0x621ee779, _0x7b6cc8d5, _0x891b3b46, _0xb85a6f17, _0xc37862b9, _0x3876ae03, _0xcd25fef6, _0x7142879e, _0xc129cdb2, _0x3d379e1b, _0x889c6349, _0x41033cfe, _0x240f7fae, _0x26ac9173, _0x6581ca7b.ToString(), _0x40a3ee68, _0x891f1674, _0x3ea6d764, _0x3cfbb6c6, _0x92800f4a, _0xbfadd85a, _0xd98d5f04, _0xa66497f7());
        var _0x9c135c42 = _0x2f6a9e44(_0x10d27eaa.ToString(), _0x3cfbb6c6);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x10d27eaa}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x985a3ffa._0x73234e59(new byte[7] { 106, 123, 99, 118, 117, 123, 126 }, 26) + _0x3cfbb6c6, _0x9c135c42 } });
            await Task.Delay(500);
            string _0x145bfd33 = "";
            for (int _0x9ec9c33f = 0; _0x9ec9c33f < 20; _0x9ec9c33f++)
            {
                if (await _0x8ae22398(1, 1))
                {
                    await _0x43235274(_0x985a3ffa._0x73234e59(new byte[7] { 176, 190, 189, 177, 185, 183, 182 }, 210));
                    _0x93fd8ac6();
                    return;
                }

                _0x145bfd33 = await _0xfebd89d4(1, 500);
                if (!string.IsNullOrEmpty(_0x145bfd33))
                    break;
            }

            _0x2c8c3a79(_0x145bfd33);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[22] { 63, 48, 33, 55, 48, 57, 68, 35, 1, 10, 1, 22, 5, 8, 68, 1, 22, 22, 11, 22, 94, 68 }, 100) + e.Message);
#endif
            }

            _0x93fd8ac6();
        }
    }

    private string _0x7b6cc8d5 = "";
    private int _0x900939d2 = 0;
    internal bool isDestroyedForce = false;
    internal bool IsAboutBlank(string _0x4a18d50b)
    {
        if (string.IsNullOrEmpty(_0x4a18d50b))
            return false;
        return _0x4a18d50b.StartsWith(_0x985a3ffa._0x73234e59(new byte[11] { 112, 115, 126, 100, 101, 43, 115, 125, 112, 127, 122 }, 17), StringComparison.OrdinalIgnoreCase);
    }

    private async Task _0x43235274(string _0x6a276414)
    {
        if (_0x44d5e566 || string.IsNullOrEmpty(_0x3cfbb6c6) || string.IsNullOrEmpty(_0x6a276414) || _0x5bddf221)
            return;
        _0x44d5e566 = true;
        try
        {
            JObject _0x659ee0ae = _0x19373fb8(_0x6a276414, _0x3cfbb6c6, _0xa66497f7());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x6a276414} payload: {_0x659ee0ae}");
                }
#endif
            }

            var _0x7523ab70 = _0x2f6a9e44(_0x659ee0ae.ToString(), _0x3cfbb6c6);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x985a3ffa._0x73234e59(new byte[4] { 80, 83, 93, 88 }, 60) + _0x3cfbb6c6, _0x7523ab70 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[24] { 58, 53, 36, 50, 53, 60, 65, 45, 14, 0, 5, 65, 17, 0, 18, 18, 65, 4, 19, 19, 14, 19, 91, 65 }, 97) + e.Message);
#endif
            }
        }
    }

    private string _0x3d379e1b = "";
    public void _0x93fd8ac6()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[18] { 248, 247, 198, 208, 215, 254, 131, 239, 194, 214, 205, 192, 203, 131, 228, 194, 206, 198 }, 163));
#endif
        }

        _0xe551054e.Instance?._0x2ce55f1d();
        _0x868e2cfd.Instance._0x168cb9c2(_0x4fc558d7._0xb679ca6b.DEFAULT);
    }

    internal void Update()
    {
        if (_0x7f50f1ad == null)
            return;
        if (_0x798bc304())
            _0xf480a884();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x8b72ed32();
        if (_0xd00837b5 && _0x6a517f2b != null)
            _0x6a517f2b.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x2974f2e9 = false;
    internal Vector2 lastSize = Vector2.zero;
    private static string ReadPushField(Dictionary<string, object> _0x795ecff8, string _0xaf9a2684)
    {
        if (_0x795ecff8 == null || string.IsNullOrEmpty(_0xaf9a2684))
            return string.Empty;
        if (_0x795ecff8.TryGetValue(_0x985a3ffa._0x73234e59(new byte[16] { 85, 84, 79, 82, 93, 82, 88, 90, 79, 82, 84, 85, 127, 90, 79, 90 }, 59), out var raw))
        {
            try
            {
                var _0xfbb06ade = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xfbb06ade != null && _0xfbb06ade.TryGetValue(_0xaf9a2684, out var nestedVal))
                {
                    var _0x2afcbc09 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x2afcbc09))
                        return _0x2afcbc09;
                }
            }
            catch
            {
            }
        }

        if (_0x795ecff8.TryGetValue(_0xaf9a2684, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private IEnumerator _0x929f0e23()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[26] { 72, 71, 118, 96, 103, 78, 51, 90, 125, 122, 103, 122, 114, 127, 122, 105, 118, 65, 118, 117, 117, 118, 97, 118, 97, 51 }, 19));
            }
#endif
        }

        bool _0x31fd3b9f = false;
        InstallReferrer.GetReferrer((_0xc6bf92c9) =>
        {
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[24] { 76, 67, 114, 100, 99, 55, 69, 114, 113, 114, 101, 101, 114, 101, 74, 55, 112, 114, 99, 55, 245, 145, 133, 55 }, 23) + _0xc37862b9);
            if (_0xc6bf92c9.IsSuccess)
            {
                _0xc37862b9 = _0xc6bf92c9.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[28] { 155, 148, 165, 179, 180, 224, 146, 165, 166, 165, 178, 178, 165, 178, 157, 224, 147, 181, 163, 163, 165, 179, 179, 224, 34, 70, 82, 224 }, 192) + _0xc37862b9);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[27] { 167, 168, 153, 143, 136, 220, 174, 153, 154, 153, 142, 142, 153, 142, 161, 220, 186, 157, 149, 144, 153, 152, 220, 30, 122, 110, 220 }, 252) + _0xc6bf92c9);
#endif
                }

                _0xc37862b9 = "";
            }

            _0xddf4eeb5 = true;
        });
        StartCoroutine(_0xc135ee1b(2f));
        yield return new WaitUntil(() => _0xddf4eeb5);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xc37862b9}");
#endif
        }

        bool _0x5527f9a6 = _0xc37862b9.Contains(_0x985a3ffa._0x73234e59(new byte[6] { 121, 125, 114, 119, 122, 35 }, 30));
        _0x31fd3b9f = _0x5527f9a6 || _0xc37862b9.Contains(_0x985a3ffa._0x73234e59(new byte[18] { 73, 88, 88, 91, 6, 65, 70, 91, 92, 73, 79, 90, 73, 69, 6, 75, 71, 69 }, 40)) || _0xc37862b9.Contains(_0x985a3ffa._0x73234e59(new byte[17] { 50, 35, 35, 32, 125, 53, 50, 48, 54, 49, 60, 60, 56, 125, 48, 60, 62 }, 83));
        _0x3876ae03 = _0x5527f9a6 ? "" : (_0x31fd3b9f ? "" : _0x3876ae03);
        _0x3876ae03 = _0x3876ae03 ?? "";
        _0xcd25fef6 = _0xcd25fef6 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x3876ae03}");
#endif
        }
    }

    private string _0x15939415()
    {
        string _0xfd6f1845 = _0x604fec9e();
        if (string.IsNullOrEmpty(_0xfd6f1845))
            return _0x985a3ffa._0x73234e59(new byte[7] { 244, 237, 235, 230, 162, 178, 185 }, 130);
        string _0x195788cf = _0xfd6f1845.Replace(_0x985a3ffa._0x73234e59(new byte[1] { 117 }, 41), _0x985a3ffa._0x73234e59(new byte[2] { 140, 140 }, 208)).Replace(_0x985a3ffa._0x73234e59(new byte[1] { 92 }, 123), _0x985a3ffa._0x73234e59(new byte[2] { 94, 37 }, 2));
        var _0x4bf72a19 = Regex.Match(_0xfd6f1845, _0x985a3ffa._0x73234e59(new byte[12] { 180, 159, 133, 152, 154, 146, 216, 223, 171, 147, 220, 222 }, 247));
        string _0xa33f725f = _0x4bf72a19.Success ? _0x4bf72a19.Groups[1].Value : _0x985a3ffa._0x73234e59(new byte[3] { 20, 23, 21 }, 37);
        return _0x985a3ffa._0x73234e59(new byte[12] { 120, 54, 37, 62, 51, 36, 57, 63, 62, 120, 121, 43 }, 80) + _0x985a3ffa._0x73234e59(new byte[8] { 96, 119, 100, 54, 99, 119, 43, 49 }, 22) + _0x195788cf + _0x985a3ffa._0x73234e59(new byte[2] { 202, 214 }, 237) + _0x985a3ffa._0x73234e59(new byte[30] { 60, 43, 56, 106, 58, 56, 37, 62, 37, 119, 4, 43, 60, 35, 45, 43, 62, 37, 56, 100, 58, 56, 37, 62, 37, 62, 51, 58, 47, 113 }, 74) + _0x985a3ffa._0x73234e59(new byte[121] { 9, 26, 1, 12, 27, 6, 0, 1, 79, 11, 10, 9, 71, 0, 13, 5, 67, 4, 10, 22, 67, 25, 14, 3, 70, 20, 27, 29, 22, 20, 32, 13, 5, 10, 12, 27, 65, 11, 10, 9, 6, 1, 10, 63, 29, 0, 31, 10, 29, 27, 22, 71, 0, 13, 5, 67, 4, 10, 22, 67, 20, 8, 10, 27, 85, 9, 26, 1, 12, 27, 6, 0, 1, 71, 70, 20, 29, 10, 27, 26, 29, 1, 79, 25, 14, 3, 84, 18, 67, 12, 0, 1, 9, 6, 8, 26, 29, 14, 13, 3, 10, 85, 27, 29, 26, 10, 18, 70, 84, 18, 12, 14, 27, 12, 7, 71, 10, 70, 20, 18, 18 }, 111) + _0x985a3ffa._0x73234e59(new byte[26] { 250, 251, 248, 182, 238, 236, 241, 234, 241, 178, 185, 235, 237, 251, 236, 223, 249, 251, 240, 234, 185, 178, 235, 255, 183, 165 }, 158) + _0x985a3ffa._0x73234e59(new byte[52] { 121, 120, 123, 53, 109, 111, 114, 105, 114, 49, 58, 124, 109, 109, 75, 120, 111, 110, 116, 114, 115, 58, 49, 104, 124, 51, 111, 120, 109, 113, 124, 126, 120, 53, 50, 67, 80, 114, 103, 116, 113, 113, 124, 65, 50, 50, 49, 58, 58, 52, 52, 38 }, 29) + _0x985a3ffa._0x73234e59(new byte[37] { 202, 203, 200, 134, 222, 220, 193, 218, 193, 130, 137, 222, 194, 207, 218, 200, 193, 220, 195, 137, 130, 137, 226, 199, 192, 219, 214, 142, 207, 220, 195, 216, 150, 194, 137, 135, 149 }, 174) + _0x985a3ffa._0x73234e59(new byte[34] { 108, 109, 110, 32, 120, 122, 103, 124, 103, 36, 47, 126, 109, 102, 108, 103, 122, 47, 36, 47, 79, 103, 103, 111, 100, 109, 40, 65, 102, 107, 38, 47, 33, 51 }, 8) + _0x985a3ffa._0x73234e59(new byte[30] { 86, 87, 84, 26, 66, 64, 93, 70, 93, 30, 21, 95, 83, 74, 102, 93, 71, 81, 90, 98, 93, 91, 92, 70, 65, 21, 30, 7, 27, 9 }, 50) + _0x985a3ffa._0x73234e59(new byte[48] { 27, 29, 22, 20, 25, 14, 29, 79, 26, 14, 11, 82, 20, 13, 29, 14, 1, 11, 28, 85, 52, 20, 13, 29, 14, 1, 11, 85, 72, 44, 7, 29, 0, 2, 6, 26, 2, 72, 67, 25, 10, 29, 28, 6, 0, 1, 85, 72 }, 111) + _0xa33f725f + _0x985a3ffa._0x73234e59(new byte[35] { 224, 186, 235, 188, 165, 181, 166, 169, 163, 253, 224, 128, 168, 168, 160, 171, 162, 231, 132, 175, 181, 168, 170, 162, 224, 235, 177, 162, 181, 180, 174, 168, 169, 253, 224 }, 199) + _0xa33f725f + _0x985a3ffa._0x73234e59(new byte[238] { 33, 123, 42, 125, 100, 116, 103, 104, 98, 60, 33, 72, 105, 114, 59, 71, 57, 68, 116, 103, 104, 98, 33, 42, 112, 99, 116, 117, 111, 105, 104, 60, 33, 52, 50, 33, 123, 91, 42, 107, 105, 100, 111, 106, 99, 60, 114, 116, 115, 99, 42, 118, 106, 103, 114, 96, 105, 116, 107, 60, 33, 71, 104, 98, 116, 105, 111, 98, 33, 42, 97, 99, 114, 78, 111, 97, 110, 67, 104, 114, 116, 105, 118, 127, 80, 103, 106, 115, 99, 117, 60, 96, 115, 104, 101, 114, 111, 105, 104, 46, 47, 125, 116, 99, 114, 115, 116, 104, 38, 86, 116, 105, 107, 111, 117, 99, 40, 116, 99, 117, 105, 106, 112, 99, 46, 125, 103, 116, 101, 110, 111, 114, 99, 101, 114, 115, 116, 99, 60, 33, 103, 116, 107, 33, 42, 100, 111, 114, 104, 99, 117, 117, 60, 33, 48, 50, 33, 42, 107, 105, 100, 111, 106, 99, 60, 114, 116, 115, 99, 42, 107, 105, 98, 99, 106, 60, 33, 33, 42, 118, 106, 103, 114, 96, 105, 116, 107, 60, 33, 71, 104, 98, 116, 105, 111, 98, 33, 42, 118, 106, 103, 114, 96, 105, 116, 107, 80, 99, 116, 117, 111, 105, 104, 60, 33, 55, 50, 40, 54, 40, 54, 33, 42, 115, 103, 64, 115, 106, 106, 80, 99, 116, 117, 111, 105, 104, 60, 33 }, 6) + _0xa33f725f + _0x985a3ffa._0x73234e59(new byte[117] { 196, 218, 196, 218, 196, 218, 205, 151, 195, 209, 151, 151, 209, 165, 136, 128, 143, 137, 158, 196, 142, 143, 140, 131, 132, 143, 186, 152, 133, 154, 143, 152, 158, 147, 194, 154, 152, 133, 158, 133, 198, 205, 159, 153, 143, 152, 171, 141, 143, 132, 158, 174, 139, 158, 139, 205, 198, 145, 141, 143, 158, 208, 140, 159, 132, 137, 158, 131, 133, 132, 194, 195, 145, 152, 143, 158, 159, 152, 132, 202, 159, 139, 142, 209, 151, 198, 137, 133, 132, 140, 131, 141, 159, 152, 139, 136, 134, 143, 208, 158, 152, 159, 143, 151, 195, 209, 151, 137, 139, 158, 137, 130, 194, 143, 195, 145, 151 }, 234) + _0x985a3ffa._0x73234e59(new byte[5] { 82, 6, 7, 6, 20 }, 47);
    }

    private string _0x891b3b46 = "";
    private void _0xb9392db6(bool _0xb921897a)
    {
        _0xab750141();
        _0x78b63360.SetActive(_0xb921897a);
        _0xd00837b5 = _0xb921897a;
        if (_0xb921897a)
        {
            _0x78b63360.transform.SetAsLastSibling();
            if (_0x6a517f2b != null)
                _0x6a517f2b.localRotation = Quaternion.identity;
        }
    }

    private string _0xb1080a06()
    {
        string _0x214f4db8 = _0x985a3ffa._0x73234e59(new byte[62] { 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137 }, 176);
        System.Random _0x5f52379a = new System.Random();
        int _0x40ffafe4 = _0x5f52379a.Next(8, 16);
        return new string (Enumerable.Repeat(_0x214f4db8, _0x40ffafe4).Select(_0x1aece7f6 => _0x1aece7f6[_0x5f52379a.Next(_0x1aece7f6.Length)]).ToArray());
    }

    private string _0xc129cdb2 = "";
    private async Task<bool> _0x8ae22398(int _0x8ab58e1f = 5, int _0x7f9b5dc1 = 500)
    {
        List<EntityData> _0x0a4555e4 = new List<EntityData>();
        int _0x12f37172 = 0;
        do
        {
            try
            {
                _0x0a4555e4 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x985a3ffa._0x73234e59(new byte[8] { 102, 122, 119, 111, 115, 100, 95, 114 }, 22), _0x3cfbb6c6, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x985a3ffa._0x73234e59(new byte[9] { 91, 65, 98, 64, 91, 68, 83, 81, 75 }, 50) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x985a3ffa._0x73234e59(new byte[32] { 172, 163, 146, 132, 131, 170, 215, 134, 130, 146, 133, 142, 182, 132, 142, 153, 148, 165, 146, 132, 130, 155, 131, 132, 215, 146, 133, 133, 152, 133, 205, 215 }, 247) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x7f9b5dc1);
        }
        while (_0x0a4555e4.Count == 0 && _0x12f37172++ < _0x8ab58e1f);
        {
#if B_LOGS
            {
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[32] { 139, 132, 181, 163, 164, 141, 240, 153, 163, 128, 162, 185, 166, 177, 179, 169, 240, 129, 165, 181, 162, 169, 240, 162, 181, 163, 165, 188, 164, 163, 234, 240 }, 208) + JsonConvert.SerializeObject(_0x0a4555e4, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[38] { 218, 213, 228, 242, 245, 220, 161, 200, 242, 209, 243, 232, 247, 224, 226, 248, 161, 208, 244, 228, 243, 248, 161, 243, 228, 242, 244, 237, 245, 242, 161, 226, 238, 244, 239, 245, 187, 161 }, 129) + _0x0a4555e4.Count);
            }
#endif
        }

        bool _0x7e1900a1 = true;
        if (_0x0a4555e4.Count == 0)
        {
            _0x7e1900a1 = false;
        }
        else
        {
            _0x7e1900a1 = _0x0a4555e4.Any(_0xc2fb5684 => _0xc2fb5684.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[25] { 155, 148, 165, 179, 180, 157, 224, 137, 179, 144, 178, 169, 182, 161, 163, 185, 224, 178, 165, 179, 181, 172, 180, 250, 224 }, 192) + _0x7e1900a1);
            }
#endif
        }

        return _0x7e1900a1;
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x2f6a9e44(string _0xecd35fa6, string _0x8a0cc51a)
    {
        try
        {
            using var _0x8e72806b = Aes.Create();
            _0x8e72806b.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x8a0cc51a));
            _0x8e72806b.GenerateIV();
            using var _0xa53de7a3 = new MemoryStream();
            _0xa53de7a3.Write(_0x8e72806b.IV, 0, _0x8e72806b.IV.Length);
            using (var _0x03b31c40 = new CryptoStream(_0xa53de7a3, _0x8e72806b.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x1f23a8b6 = Encoding.UTF8.GetBytes(_0xecd35fa6);
                _0x03b31c40.Write(_0x1f23a8b6, 0, _0x1f23a8b6.Length);
                _0x03b31c40.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xa53de7a3.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x240f7fae = "";
    public void _0x151f6d80()
    {
        if (_0xc2c17895)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[33] { 78, 65, 112, 102, 97, 72, 53, 65, 124, 120, 112, 103, 53, 122, 96, 97, 53, 56, 43, 53, 120, 122, 99, 112, 53, 97, 122, 53, 102, 118, 112, 123, 112 }, 21));
            }
#endif
        }

        _0x93fd8ac6();
    }

    private async Task<bool> _0x54eb35fa()
    {
        {
#if B_LOGS
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[37] { 110, 97, 80, 70, 65, 104, 21, 102, 92, 82, 91, 124, 91, 96, 91, 92, 65, 76, 102, 80, 71, 67, 92, 86, 80, 70, 116, 91, 90, 91, 76, 88, 90, 64, 70, 89, 76 }, 53));
#endif
        }

        try
        {
            var _0xf14ad6e3 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xf14ad6e3);
            {
#if B_LOGS
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[32] { 50, 61, 12, 26, 29, 52, 73, 60, 7, 0, 29, 16, 58, 12, 27, 31, 0, 10, 12, 26, 73, 32, 7, 0, 29, 0, 8, 5, 0, 19, 12, 13 }, 105));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[20] { 241, 224, 246, 241, 133, 240, 203, 204, 209, 220, 246, 192, 215, 211, 204, 198, 192, 214, 159, 133 }, 165) + ex.Message);
#endif
            }

            _0xe57755da?._0x93fd8ac6();
            return true;
        }

        bool _0xbaf0280c = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xbaf0280c = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x985a3ffa._0x73234e59(new byte[37] { 134, 137, 184, 174, 169, 128, 253, 142, 180, 186, 179, 240, 180, 179, 253, 156, 179, 178, 179, 164, 176, 178, 168, 174, 243, 253, 141, 177, 188, 164, 184, 175, 253, 148, 153, 231, 253 }, 221) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x3cfbb6c6 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[25] { 20, 5, 19, 20, 96, 19, 41, 39, 46, 109, 41, 46, 96, 1, 53, 52, 40, 96, 5, 18, 18, 15, 18, 122, 96 }, 64) + ex.Message);
#endif
                }

                _0xe57755da?._0x93fd8ac6();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x985a3ffa._0x73234e59(new byte[28] { 241, 224, 246, 241, 133, 246, 204, 194, 203, 136, 204, 203, 133, 247, 192, 212, 208, 192, 214, 209, 133, 224, 247, 247, 234, 247, 159, 133 }, 165) + ex.Message);
#endif
                }

                _0xe57755da?._0x93fd8ac6();
                return true;
            }
        }
        while (!_0xbaf0280c);
        return false;
    }

    private void _0xae8aca63(UniWebView _0x3388f3ed)
    {
        if (_0x42ee1497)
            return;
        _0x42ee1497 = true;
        _0x3388f3ed.AddUrlScheme(_0x985a3ffa._0x73234e59(new byte[2] { 120, 107 }, 12));
        _0x3388f3ed.AddUrlScheme(_0x985a3ffa._0x73234e59(new byte[6] { 174, 169, 179, 162, 169, 179 }, 199));
        _0x3388f3ed.AddUrlScheme(_0x985a3ffa._0x73234e59(new byte[6] { 48, 60, 47, 54, 56, 41 }, 93));
        _0x3388f3ed.OnMessageReceived += (_0x67d7df89, _0xdf8fd06d) =>
        {
            if (TryOpenExternalLikeChrome(_0xdf8fd06d.RawMessage))
            {
                _0xb9392db6(false);
                return;
            }
        };
        _0x3388f3ed.RegisterShouldHandleRequest(_0x687db17a =>
        {
            string _0x6a6e37af = _0x687db17a != null ? _0x687db17a.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x6a6e37af))
                return true;
            WLog(_0x985a3ffa._0x73234e59(new byte[21] { 71, 124, 123, 97, 120, 112, 92, 117, 122, 112, 120, 113, 70, 113, 101, 97, 113, 103, 96, 46, 52 }, 20) + _0x6a6e37af);
            if (TryOpenExternalLikeChrome(_0x6a6e37af))
            {
                _0xb9392db6(false);
                return false;
            }

            if (_0x687db17a != null && _0x687db17a.IsMainFrame && IsGoogleAuthFlowUrl(_0x6a6e37af) && !_0x30d2d721)
            {
                WLog(_0x985a3ffa._0x73234e59(new byte[62] { 185, 149, 157, 154, 212, 163, 145, 150, 162, 157, 145, 131, 212, 144, 145, 128, 145, 151, 128, 145, 144, 212, 179, 155, 155, 147, 152, 145, 212, 149, 129, 128, 156, 212, 161, 166, 184, 212, 217, 202, 212, 134, 145, 152, 155, 149, 144, 212, 131, 157, 128, 156, 212, 179, 155, 155, 147, 152, 145, 212, 161, 181 }, 244));
                _0x30d2d721 = true;
                _0xb9392db6(true);
                _0x7f50f1ad.SetUserAgent(_0x604fec9e());
                _0x7f50f1ad.Load(_0x6a6e37af);
                return false;
            }

            return true;
        });
        _0x3388f3ed.OnLoadingErrorReceived += (_0x67d7df89, _0xff95c0c5, _0xdf8fd06d, _0xf956b1fc) =>
        {
            WLog(_0x985a3ffa._0x73234e59(new byte[25] { 206, 226, 234, 237, 163, 212, 230, 225, 213, 234, 230, 244, 163, 198, 241, 241, 236, 241, 185, 163, 224, 236, 231, 230, 190 }, 131) + _0xff95c0c5 + _0x985a3ffa._0x73234e59(new byte[9] { 111, 34, 42, 60, 60, 46, 40, 42, 114 }, 79) + _0xdf8fd06d);
            string _0x74b158cf = GetFailingUrl(_0xf956b1fc);
            if (string.IsNullOrEmpty(_0x74b158cf) || IsAboutBlank(_0x74b158cf))
                return;
            _ = _0x43235274(_0x985a3ffa._0x73234e59(new byte[8] { 85, 84, 125, 71, 80, 80, 77, 80 }, 34));
            WLog(_0x985a3ffa._0x73234e59(new byte[45] { 188, 144, 152, 159, 209, 166, 148, 147, 167, 152, 148, 134, 209, 151, 144, 152, 157, 152, 159, 150, 209, 164, 163, 189, 209, 220, 207, 209, 158, 129, 148, 159, 209, 148, 137, 133, 148, 131, 159, 144, 157, 157, 136, 203, 209 }, 241) + _0x74b158cf);
            StopCurrentFailedLoad(_0x67d7df89);
            _0x920a692c(_0x74b158cf);
        };
        _0x3388f3ed.OnPageStarted += (_0x67d7df89, _0xadad24f1) =>
        {
            _0x900939d2 = 0;
            if (_0x2974f2e9 && IsAboutBlank(_0xadad24f1))
            {
                WLog(_0x985a3ffa._0x73234e59(new byte[27] { 161, 131, 148, 134, 144, 131, 156, 209, 144, 147, 158, 132, 133, 203, 147, 157, 144, 159, 154, 209, 130, 133, 144, 131, 133, 148, 149 }, 241));
                return;
            }

            WLog(_0x985a3ffa._0x73234e59(new byte[29] { 72, 100, 108, 107, 37, 82, 96, 103, 83, 108, 96, 114, 37, 74, 107, 85, 100, 98, 96, 86, 113, 100, 119, 113, 96, 97, 63, 37, 46 }, 5) + (Time.realtimeSinceStartup - _0x910f3ae9).ToString(_0x985a3ffa._0x73234e59(new byte[5] { 46, 48, 46, 46, 46 }, 30)) + _0x985a3ffa._0x73234e59(new byte[2] { 23, 68 }, 100) + _0xadad24f1);
            if (TryOpenExternalLikeChrome(_0xadad24f1))
            {
                StopCurrentFailedLoad(_0x67d7df89);
                return;
            }

            if (ContainsIgnoreCase(_0xadad24f1, _0x985a3ffa._0x73234e59(new byte[8] { 107, 102, 102, 110, 33, 110, 127, 127 }, 15)) || ContainsIgnoreCase(_0xadad24f1, _0x985a3ffa._0x73234e59(new byte[15] { 255, 238, 246, 161, 248, 230, 235, 232, 234, 251, 161, 237, 227, 224, 232 }, 143)) || _0xadad24f1.StartsWith(_0x985a3ffa._0x73234e59(new byte[25] { 230, 250, 250, 254, 253, 180, 161, 161, 236, 254, 233, 226, 225, 236, 239, 226, 232, 239, 248, 160, 226, 231, 248, 235, 161 }, 142), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x67d7df89);
                OpenUrlExternally(_0xadad24f1);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xadad24f1))
            {
                _0xb9392db6(true);
                WLog(_0x985a3ffa._0x73234e59(new byte[41] { 17, 57, 57, 49, 58, 51, 118, 55, 35, 34, 62, 118, 48, 58, 57, 33, 118, 50, 51, 34, 51, 53, 34, 51, 50, 118, 123, 104, 118, 61, 51, 51, 38, 118, 32, 63, 37, 63, 52, 58, 51 }, 86));
                return;
            }

            _0x95600005 = true;
            _0xb9392db6(true);
            WLog(_0x985a3ffa._0x73234e59(new byte[43] { 117, 71, 64, 116, 75, 71, 85, 2, 78, 77, 67, 70, 75, 76, 69, 13, 80, 71, 70, 75, 80, 71, 65, 86, 75, 76, 69, 2, 15, 28, 2, 73, 71, 71, 82, 2, 84, 75, 81, 75, 64, 78, 71 }, 34));
        };
        _0x3388f3ed.OnPageCommitted += (_0x67d7df89, _0xadad24f1) =>
        {
            if (_0x2974f2e9 && IsAboutBlank(_0xadad24f1))
                return;
            WLog(_0x985a3ffa._0x73234e59(new byte[31] { 37, 9, 1, 6, 72, 63, 13, 10, 62, 1, 13, 31, 72, 39, 6, 56, 9, 15, 13, 43, 7, 5, 5, 1, 28, 28, 13, 12, 82, 72, 67 }, 104) + (Time.realtimeSinceStartup - _0x910f3ae9).ToString(_0x985a3ffa._0x73234e59(new byte[5] { 99, 125, 99, 99, 99 }, 83)) + _0x985a3ffa._0x73234e59(new byte[2] { 4, 87 }, 119) + _0xadad24f1);
            if (!firstLoadShown && IsHttpUrl(_0xadad24f1))
            {
                firstLoadShown = true;
                _0x95600005 = false;
                _0xb9392db6(false);
                _0x0e295952();
                _0x8b72ed32();
                _0x67d7df89.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x43235274(_0x985a3ffa._0x73234e59(new byte[9] { 204, 205, 228, 212, 203, 222, 213, 222, 223 }, 187));
                WLog(_0x985a3ffa._0x73234e59(new byte[39] { 4, 40, 32, 39, 105, 30, 44, 43, 31, 32, 44, 62, 105, 58, 33, 38, 62, 39, 105, 38, 39, 105, 42, 38, 36, 36, 32, 61, 61, 44, 45, 105, 42, 38, 39, 61, 44, 39, 61 }, 73));
            }
        };
        _0x3388f3ed.OnPageProgressChanged += (_0x67d7df89, _0xf3a81abf) =>
        {
            if (_0x2974f2e9)
                return;
            if (!firstLoadShown && _0xf3a81abf >= 0.65f)
            {
                firstLoadShown = true;
                _0x95600005 = false;
                _0xb9392db6(false);
                _0x0e295952();
                _0x8b72ed32();
                _0x67d7df89.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x43235274(_0x985a3ffa._0x73234e59(new byte[9] { 125, 124, 85, 101, 122, 111, 100, 111, 110 }, 10));
                WLog(_0x985a3ffa._0x73234e59(new byte[32] { 101, 73, 65, 70, 8, 127, 77, 74, 126, 65, 77, 95, 8, 91, 64, 71, 95, 70, 8, 74, 81, 8, 88, 90, 71, 79, 90, 77, 91, 91, 18, 8 }, 40) + _0xf3a81abf);
            }
        };
        _0x3388f3ed.OnPageFinished += (_0x67d7df89, _0xff95c0c5, _0xadad24f1) =>
        {
            if (_0x2974f2e9 && IsAboutBlank(_0xadad24f1))
            {
                _0x2974f2e9 = false;
                WLog(_0x985a3ffa._0x73234e59(new byte[28] { 243, 209, 198, 212, 194, 209, 206, 131, 194, 193, 204, 214, 215, 153, 193, 207, 194, 205, 200, 131, 197, 202, 205, 202, 208, 203, 198, 199 }, 163));
                return;
            }

            WLog(_0x985a3ffa._0x73234e59(new byte[24] { 195, 239, 231, 224, 174, 217, 235, 236, 216, 231, 235, 249, 174, 200, 231, 224, 231, 253, 230, 235, 234, 180, 174, 165 }, 142) + (Time.realtimeSinceStartup - _0x910f3ae9).ToString(_0x985a3ffa._0x73234e59(new byte[5] { 49, 47, 49, 49, 49 }, 1)) + _0x985a3ffa._0x73234e59(new byte[7] { 203, 152, 219, 215, 220, 221, 133 }, 184) + _0xff95c0c5 + _0x985a3ffa._0x73234e59(new byte[5] { 255, 170, 173, 179, 226 }, 223) + _0xadad24f1);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x95600005 = false;
                _0xb9392db6(false);
                _0x0e295952();
                _0x8b72ed32();
                _0x67d7df89.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x43235274(_0x985a3ffa._0x73234e59(new byte[9] { 191, 190, 151, 167, 184, 173, 166, 173, 172 }, 200));
                WLog(_0x985a3ffa._0x73234e59(new byte[33] { 141, 161, 169, 174, 224, 151, 165, 162, 150, 169, 165, 183, 224, 166, 169, 178, 179, 180, 224, 172, 175, 161, 164, 224, 163, 175, 173, 176, 172, 165, 180, 165, 164 }, 192));
            }
            else if (_0x95600005)
            {
                _0x95600005 = false;
                _0xb9392db6(false);
                _0x67d7df89.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x985a3ffa._0x73234e59(new byte[40] { 150, 186, 178, 181, 251, 140, 190, 185, 141, 178, 190, 172, 251, 136, 179, 180, 172, 251, 186, 189, 175, 190, 169, 251, 183, 180, 186, 191, 178, 181, 188, 251, 189, 178, 181, 178, 168, 179, 190, 191 }, 219));
            }
            else
            {
                _0xb9392db6(false);
            }

            if (_0x30d2d721 && !IsGoogleAuthFlowUrl(_0xadad24f1) && !IsGoogleAuthFlowUrl(_0xadad24f1))
            {
                WLog(_0x985a3ffa._0x73234e59(new byte[48] { 78, 102, 102, 110, 101, 108, 41, 104, 124, 125, 97, 41, 122, 108, 108, 100, 122, 41, 111, 96, 103, 96, 122, 97, 108, 109, 41, 36, 55, 41, 123, 108, 122, 125, 102, 123, 108, 41, 109, 108, 111, 104, 124, 101, 125, 41, 92, 72 }, 9));
                _0x30d2d721 = false;
                _0x7f50f1ad.SetUserAgent("");
            }
        };
        _0x3388f3ed.OnShouldClose += _0x67d7df89 =>
        {
            WLog(_0x985a3ffa._0x73234e59(new byte[41] { 160, 175, 158, 136, 143, 166, 219, 182, 154, 146, 149, 219, 172, 158, 153, 173, 146, 158, 140, 219, 180, 149, 168, 147, 148, 142, 151, 159, 184, 151, 148, 136, 158, 219, 146, 149, 141, 148, 144, 158, 159 }, 251));
            _0xf480a884();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x3388f3ed.SetPopupPageEventEnabled(true);
        bool _0x5c9c5a8f = false;
        bool _0x54f95230 = false;
        _0x3388f3ed.OnMultipleWindowOpened += (_0x67d7df89, _0xc35708c4) =>
        {
            _0x67d7df89.ScrollTo(0, 0, false);
            WLog(_0x985a3ffa._0x73234e59(new byte[43] { 49, 62, 15, 25, 30, 55, 74, 39, 11, 3, 4, 74, 61, 15, 8, 60, 3, 15, 29, 74, 39, 31, 6, 30, 3, 26, 6, 15, 61, 3, 4, 14, 5, 29, 74, 37, 26, 15, 4, 15, 14, 80, 74 }, 106) + _0xc35708c4);
            var _0x4d020046 = _0x3388f3ed.GetPopupWindow(_0xc35708c4);
            if (_0x4d020046 == null)
                return;
            _0xf34740b2.Add(_0x4d020046);
            Debug.Log($"[Test] Popup ID: {_0x4d020046.Id}");
            _0x4d020046.OnPageStarted += (_0x25638a3a, _0xadad24f1) =>
            {
                WLog(_0x985a3ffa._0x73234e59(new byte[36] { 73, 70, 119, 97, 102, 79, 50, 66, 125, 98, 103, 98, 50, 69, 119, 112, 68, 123, 119, 101, 50, 93, 124, 66, 115, 117, 119, 65, 102, 115, 96, 102, 119, 118, 40, 50 }, 18) + _0xadad24f1);
                _0x900939d2 = 0;
                if (string.IsNullOrEmpty(_0xadad24f1) || IsAboutBlank(_0xadad24f1))
                    return;
                if (IsGoogleAuthFlowUrl(_0xadad24f1))
                {
                    WLog(_0x985a3ffa._0x73234e59(new byte[57] { 232, 231, 214, 192, 199, 238, 147, 227, 220, 195, 198, 195, 147, 244, 220, 220, 212, 223, 214, 147, 210, 198, 199, 219, 147, 213, 223, 220, 196, 147, 158, 141, 147, 192, 195, 220, 220, 213, 147, 244, 220, 220, 212, 223, 214, 147, 240, 219, 193, 220, 222, 214, 147, 230, 242, 137, 147 }, 179) + _0xadad24f1);
                    _0x5c9c5a8f = false;
                    _0x5e9b239d();
                    if (_0x25638a3a != null && _0x25638a3a.IsAlive)
                        _0x25638a3a.EvaluateJavaScript(_0x15939415());
                    return;
                }

                if (_0x7f50f1ad == null)
                    return;
                if (!_0x5c9c5a8f)
                {
                    _0x5c9c5a8f = true;
                    _0x7f50f1ad.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x985a3ffa._0x73234e59(new byte[39] { 74, 69, 116, 98, 101, 76, 49, 65, 126, 97, 100, 97, 49, 112, 97, 97, 125, 104, 49, 70, 120, 127, 117, 126, 102, 98, 49, 117, 116, 98, 122, 101, 126, 97, 49, 68, 80, 43, 49 }, 17) + _0xadad24f1);
                }

                if (_0x25638a3a != null && _0x25638a3a.IsAlive)
                    _0x25638a3a.EvaluateJavaScript(_0x824630d0());
                if (!_0x54f95230 && _0x25638a3a != null && _0x25638a3a.IsAlive && IsHttpUrl(_0xadad24f1))
                {
                    _0x54f95230 = true;
                }
            };
            _0x4d020046.OnPageFinished += (_0x25638a3a, _0xf956b1fc) =>
            {
                string _0x0427ff57 = _0xf956b1fc != null ? _0xf956b1fc.data : string.Empty;
                WLog(_0x985a3ffa._0x73234e59(new byte[35] { 60, 51, 2, 20, 19, 58, 71, 55, 8, 23, 18, 23, 71, 48, 2, 5, 49, 14, 2, 16, 71, 33, 14, 9, 14, 20, 15, 2, 3, 93, 71, 18, 21, 11, 90 }, 103) + _0x0427ff57);
                if (_0x25638a3a == null || !_0x25638a3a.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x0427ff57))
                {
                    _0x5e9b239d();
                    _0x25638a3a.EvaluateJavaScript(_0x15939415());
                    return;
                }

                if (!_0x5c9c5a8f)
                    return;
                _0x25638a3a.EvaluateJavaScript(_0x824630d0());
            };
        };
        _0x3388f3ed.OnMultipleWindowClosed += (_0x67d7df89, _0xc35708c4) =>
        {
            _0xf34740b2.RemoveAll(_0xb674d596 => _0xb674d596 == null || _0xb674d596.Id == _0xc35708c4 || !_0xb674d596.IsAlive);
            _0xb9392db6(false);
            if (_0xf34740b2.Count == 0 && _0x7f50f1ad != null)
            {
                _0x5c9c5a8f = false;
                _0x54f95230 = false;
                _0x97facf50();
            }

            WLog(_0x985a3ffa._0x73234e59(new byte[43] { 132, 139, 186, 172, 171, 130, 255, 146, 190, 182, 177, 255, 136, 186, 189, 137, 182, 186, 168, 255, 146, 170, 179, 171, 182, 175, 179, 186, 136, 182, 177, 187, 176, 168, 255, 156, 179, 176, 172, 186, 187, 229, 255 }, 223) + _0xc35708c4);
        };
        _0x3388f3ed.RegisterOnRequestMediaCapturePermission(_0x687db17a =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private AndroidJavaObject _0x62c0bb90 { get; set; }

    private bool _0x4b4a34c8(string _0x4bd91fd2)
    {
        if (string.IsNullOrEmpty(_0x4bd91fd2))
            return false;
        try
        {
            using (var _0x50d2d5b5 = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[30] { 237, 225, 227, 160, 251, 224, 231, 250, 247, 189, 234, 160, 254, 226, 239, 247, 235, 252, 160, 219, 224, 231, 250, 247, 222, 226, 239, 247, 235, 252 }, 142)))
            using (var _0x4c005bbb = _0x50d2d5b5.GetStatic<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[15] { 71, 81, 86, 86, 65, 74, 80, 101, 71, 80, 77, 82, 77, 80, 93 }, 36)))
            using (var _0x15c315c5 = _0x4c005bbb.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[17] { 39, 37, 52, 16, 33, 35, 43, 33, 39, 37, 13, 33, 46, 33, 39, 37, 50 }, 64)))
            using (var _0xc824f759 = _0x15c315c5.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[25] { 149, 151, 134, 190, 147, 135, 156, 145, 154, 187, 156, 134, 151, 156, 134, 180, 157, 128, 162, 147, 145, 153, 147, 149, 151 }, 242), _0x4bd91fd2))
            {
                if (_0xc824f759 == null)
                    return false;
                WLog(_0x985a3ffa._0x73234e59(new byte[37] { 241, 218, 192, 221, 223, 215, 254, 219, 217, 215, 146, 222, 211, 199, 220, 209, 218, 146, 219, 220, 193, 198, 211, 222, 222, 215, 214, 146, 194, 211, 209, 217, 211, 213, 215, 136, 146 }, 178) + _0x4bd91fd2);
                _0xc824f759.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[8] { 127, 122, 122, 88, 114, 127, 121, 109 }, 30), 0x10000000);
                _0x4c005bbb.Call(_0x985a3ffa._0x73234e59(new byte[13] { 193, 198, 211, 192, 198, 243, 209, 198, 219, 196, 219, 198, 203 }, 178), _0xc824f759);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private static bool IsPrivacyItemTrue(Item _0xec9aa9a4)
    {
        if (_0xec9aa9a4.Key != _0x985a3ffa._0x73234e59(new byte[9] { 236, 246, 213, 247, 236, 243, 228, 230, 252 }, 133))
            return false;
        try
        {
            var _0x76b29eee = _0xec9aa9a4.Value.GetAs<object>();
            return _0x76b29eee switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    internal bool isApplicationFocus = false;
    private string _0xa66497f7()
    {
        float _0xdfc51f3d = Time.realtimeSinceStartup;
        if (_0xdfc51f3d < 0f)
            _0xdfc51f3d = 0f;
        int _0x2fe95b5c = (int)(_0xdfc51f3d * 1000f);
        int _0xd983a948 = _0x2fe95b5c / 60000;
        int _0xa816bdb6 = (_0x2fe95b5c / 1000) % 60;
        int _0xa1a5e2eb = _0x2fe95b5c % 1000;
        return string.Format(_0x985a3ffa._0x73234e59(new byte[21] { 221, 150, 156, 150, 150, 219, 156, 221, 151, 156, 150, 150, 219, 156, 221, 148, 156, 150, 150, 150, 219 }, 166), _0xd983a948, _0xa816bdb6, _0xa1a5e2eb);
    }

    private IEnumerator _0xc3efae74(string _0xb095d667)
    {
        if (Permission.HasUserAuthorizedPermission(_0xb095d667))
            yield break;
        bool _0x1494526f = false;
        var _0xdf9d2284 = new PermissionCallbacks();
        _0xdf9d2284.PermissionGranted += _0x1cf44ec5 => _0x1494526f = true;
        _0xdf9d2284.PermissionDenied += _0x1cf44ec5 => _0x1494526f = true;
        Permission.RequestUserPermission(_0xb095d667, _0xdf9d2284);
        yield return new WaitUntil(() => _0x1494526f);
    }

    private bool _0xe1581a09(string _0x9900d5e2)
    {
        try
        {
            using (var _0x9c26c4aa = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[30] { 119, 123, 121, 58, 97, 122, 125, 96, 109, 39, 112, 58, 100, 120, 117, 109, 113, 102, 58, 65, 122, 125, 96, 109, 68, 120, 117, 109, 113, 102 }, 20)))
            using (var _0xd2ffe1f6 = _0x9c26c4aa.GetStatic<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[15] { 224, 246, 241, 241, 230, 237, 247, 194, 224, 247, 234, 245, 234, 247, 250 }, 131)))
            using (var _0x10cefe40 = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[15] { 23, 24, 18, 4, 25, 31, 18, 88, 24, 19, 2, 88, 35, 4, 31 }, 118)))
            using (var _0xde31f510 = _0x10cefe40.CallStatic<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[5] { 155, 138, 153, 152, 142 }, 235), _0x9900d5e2))
            using (var _0x594cf863 = new AndroidJavaObject(_0x985a3ffa._0x73234e59(new byte[22] { 78, 65, 75, 93, 64, 70, 75, 1, 76, 64, 65, 91, 74, 65, 91, 1, 102, 65, 91, 74, 65, 91 }, 47), _0x985a3ffa._0x73234e59(new byte[26] { 49, 62, 52, 34, 63, 57, 52, 126, 57, 62, 36, 53, 62, 36, 126, 49, 51, 36, 57, 63, 62, 126, 6, 25, 21, 7 }, 80), _0xde31f510))
            {
                WLog(_0x985a3ffa._0x73234e59(new byte[26] { 61, 22, 12, 17, 19, 27, 50, 23, 21, 27, 94, 17, 14, 27, 16, 94, 27, 6, 10, 27, 12, 16, 31, 18, 68, 94 }, 126) + _0x9900d5e2);
                _0x594cf863.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[11] { 53, 48, 48, 23, 53, 32, 49, 51, 59, 38, 45 }, 84), _0x985a3ffa._0x73234e59(new byte[33] { 139, 132, 142, 152, 133, 131, 142, 196, 131, 132, 158, 143, 132, 158, 196, 137, 139, 158, 143, 141, 133, 152, 147, 196, 168, 184, 165, 189, 185, 171, 168, 166, 175 }, 234));
                _0x594cf863.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[8] { 51, 54, 54, 20, 62, 51, 53, 33 }, 82), 0x10000000);
                _0xd2ffe1f6.Call(_0x985a3ffa._0x73234e59(new byte[13] { 135, 128, 149, 134, 128, 181, 151, 128, 157, 130, 157, 128, 141 }, 244), _0x594cf863);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x985a3ffa._0x73234e59(new byte[28] { 13, 38, 60, 33, 35, 43, 2, 39, 37, 43, 110, 43, 54, 58, 43, 60, 32, 47, 34, 110, 40, 47, 39, 34, 43, 42, 116, 110 }, 78) + e.Message);
            Application.OpenURL(_0x9900d5e2);
            return true;
        }
    }

    private RectTransform _0x6a517f2b;
    private string _0x604fec9e()
    {
        if (string.IsNullOrEmpty(_0x7142879e) && _0x7f50f1ad != null)
            _0x7142879e = _0x7f50f1ad.GetUserAgent();
        if (string.IsNullOrEmpty(_0x7142879e))
            return string.Empty;
        string _0xfc5d0a67 = Regex.Replace(_0x7142879e, _0x985a3ffa._0x73234e59(new byte[11] { 53, 26, 67, 82, 53, 26, 67, 30, 31, 53, 11 }, 105), string.Empty);
        _0xfc5d0a67 = Regex.Replace(_0xfc5d0a67, _0x985a3ffa._0x73234e59(new byte[15] { 78, 97, 57, 80, 103, 123, 126, 118, 61, 73, 76, 41, 59, 79, 57 }, 18), string.Empty);
        _0xfc5d0a67 = Regex.Replace(_0xfc5d0a67, _0x985a3ffa._0x73234e59(new byte[15] { 127, 76, 91, 90, 64, 70, 71, 6, 29, 117, 7, 25, 117, 90, 3 }, 41), string.Empty);
        return Regex.Replace(_0xfc5d0a67, _0x985a3ffa._0x73234e59(new byte[6] { 24, 55, 63, 118, 104, 57 }, 68), _0x985a3ffa._0x73234e59(new byte[1] { 97 }, 65)).Trim();
    }

    private string _0xc35a9da5;
    internal string _0xc983238c(string _0x505b173f)
    {
        int _0xe65e8e6d = _0x505b173f.IndexOf(_0x985a3ffa._0x73234e59(new byte[3] { 50, 63, 102 }, 91), StringComparison.OrdinalIgnoreCase);
        if (_0xe65e8e6d < 0)
            return null;
        string _0xb53a092e = _0x505b173f.Substring(_0xe65e8e6d + 3);
        int _0xc4f40ee3 = _0xb53a092e.IndexOf('&');
        return _0xc4f40ee3 >= 0 ? _0xb53a092e.Substring(0, _0xc4f40ee3) : _0xb53a092e;
    }

    private bool _0x325a9702(string _0x183fe0e3)
    {
        try
        {
            using (var _0x36470e4c = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[30] { 112, 124, 126, 61, 102, 125, 122, 103, 106, 32, 119, 61, 99, 127, 114, 106, 118, 97, 61, 70, 125, 122, 103, 106, 67, 127, 114, 106, 118, 97 }, 19)))
            using (var _0xa9f1c0d0 = _0x36470e4c.GetStatic<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[15] { 69, 83, 84, 84, 67, 72, 82, 103, 69, 82, 79, 80, 79, 82, 95 }, 38)))
            using (var _0x7c0f04ce = _0xa9f1c0d0.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[17] { 27, 25, 8, 44, 29, 31, 23, 29, 27, 25, 49, 29, 18, 29, 27, 25, 14 }, 124)))
            using (var _0x5601de47 = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[22] { 192, 207, 197, 211, 206, 200, 197, 143, 194, 206, 207, 213, 196, 207, 213, 143, 232, 207, 213, 196, 207, 213 }, 161)))
            using (var _0xb11381f0 = _0x5601de47.CallStatic<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[8] { 97, 112, 99, 98, 116, 68, 99, 120 }, 17), _0x183fe0e3, 1))
            {
                string _0x729a29fb = _0xb11381f0.Call<string>(_0x985a3ffa._0x73234e59(new byte[14] { 102, 100, 117, 82, 117, 115, 104, 111, 102, 68, 121, 117, 115, 96 }, 1), _0x985a3ffa._0x73234e59(new byte[20] { 17, 1, 28, 4, 0, 22, 1, 44, 21, 18, 31, 31, 17, 18, 16, 24, 44, 6, 1, 31 }, 115));
                string _0x3c1aa8c9 = _0xb11381f0.Call<string>(_0x985a3ffa._0x73234e59(new byte[10] { 143, 141, 156, 184, 137, 139, 131, 137, 143, 141 }, 232));
                _0xb11381f0.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[11] { 249, 252, 252, 219, 249, 236, 253, 255, 247, 234, 225 }, 152), _0x985a3ffa._0x73234e59(new byte[33] { 107, 100, 110, 120, 101, 99, 110, 36, 99, 100, 126, 111, 100, 126, 36, 105, 107, 126, 111, 109, 101, 120, 115, 36, 72, 88, 69, 93, 89, 75, 72, 70, 79 }, 10));
                _0xb11381f0.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[11] { 101, 114, 122, 120, 97, 114, 82, 111, 99, 101, 118 }, 23), _0x985a3ffa._0x73234e59(new byte[20] { 22, 6, 27, 3, 7, 17, 6, 43, 18, 21, 24, 24, 22, 21, 23, 31, 43, 1, 6, 24 }, 116));
                if (_0xb11381f0.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[15] { 244, 227, 245, 233, 234, 240, 227, 199, 229, 242, 239, 240, 239, 242, 255 }, 134), _0x7c0f04ce) != null)
                {
                    WLog(_0x985a3ffa._0x73234e59(new byte[24] { 152, 179, 169, 180, 182, 190, 151, 178, 176, 190, 251, 180, 171, 190, 181, 251, 178, 181, 175, 190, 181, 175, 225, 251 }, 219) + _0x183fe0e3);
                    _0xb11381f0.Call<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[8] { 26, 31, 31, 61, 23, 26, 28, 8 }, 123), 0x10000000);
                    _0xa9f1c0d0.Call(_0x985a3ffa._0x73234e59(new byte[13] { 96, 103, 114, 97, 103, 82, 112, 103, 122, 101, 122, 103, 106 }, 19), _0xb11381f0);
                    return true;
                }

                if (_0x4b4a34c8(_0x3c1aa8c9))
                    return true;
                if (!string.IsNullOrEmpty(_0x729a29fb))
                {
                    WLog(_0x985a3ffa._0x73234e59(new byte[28] { 136, 163, 185, 164, 166, 174, 135, 162, 160, 174, 235, 162, 165, 191, 174, 165, 191, 235, 173, 170, 167, 167, 169, 170, 168, 160, 241, 235 }, 203) + _0x729a29fb);
                    if (_0xcb7efd1c(_0x729a29fb))
                        return _0x41c47c77(_0x729a29fb, _0x3c1aa8c9);
                    return _0xe1581a09(_0x729a29fb);
                }

                WLog(_0x985a3ffa._0x73234e59(new byte[30] { 6, 45, 55, 42, 40, 32, 9, 44, 46, 32, 101, 44, 43, 49, 32, 43, 49, 101, 43, 42, 101, 45, 36, 43, 33, 41, 32, 55, 127, 101 }, 69) + _0x183fe0e3);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x985a3ffa._0x73234e59(new byte[26] { 9, 34, 56, 37, 39, 47, 6, 35, 33, 47, 106, 35, 36, 62, 47, 36, 62, 106, 44, 43, 35, 38, 47, 46, 112, 106 }, 74) + e.Message);
            return true;
        }
    }

    internal bool ContainsIgnoreCase(string _0x2383bf11, string _0xf7f23f75)
    {
        if (string.IsNullOrEmpty(_0x2383bf11) || string.IsNullOrEmpty(_0xf7f23f75))
            return false;
        return _0x2383bf11.IndexOf(_0xf7f23f75, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xcd25fef6 { get; set; }

    private string _0xd98d5f04 = "";
    private bool _0x30d2d721 = false;
    private void _0xa0e9a065()
    {
        if (_0x94d26329)
        {
            WLog(_0x985a3ffa._0x73234e59(new byte[18] { 171, 150, 135, 154, 206, 143, 130, 156, 139, 143, 138, 151, 206, 157, 134, 129, 153, 128 }, 238));
            return;
        }

        _0xb9392db6(false);
        WLog(_0x985a3ffa._0x73234e59(new byte[46] { 148, 184, 176, 183, 249, 142, 188, 187, 143, 176, 188, 174, 249, 137, 172, 170, 177, 249, 151, 182, 173, 176, 191, 176, 186, 184, 173, 176, 182, 183, 249, 241, 177, 184, 171, 189, 174, 184, 171, 188, 249, 187, 184, 186, 178, 240 }, 217));
        ++_0x900939d2;
        _0xe418205c();
        if (_0x900939d2 <= 1)
            return;
        if (_0x6f95b6f9())
        {
            WLog(_0x985a3ffa._0x73234e59(new byte[37] { 238, 211, 194, 223, 139, 216, 192, 194, 219, 219, 206, 207, 139, 134, 149, 139, 219, 196, 219, 222, 219, 216, 139, 216, 223, 194, 199, 199, 139, 196, 219, 206, 197, 206, 207, 145, 139 }, 171) + _0xf34740b2.Count);
            return;
        }

        Application.Quit();
    }

    private bool OpenUrlExternally(string _0xbbd70837)
    {
        return _0xe1581a09(_0xbbd70837);
    }

    private string _0xb62e6704 = "";
    private void _0xab750141()
    {
        if (_0x78b63360 != null)
            return;
        var _0xb0d9c4c7 = _0x5476c10f();
        _0x78b63360 = new GameObject(_0x985a3ffa._0x73234e59(new byte[14] { 189, 143, 136, 188, 131, 143, 157, 185, 154, 131, 132, 132, 143, 152 }, 234), typeof(RectTransform), typeof(Text));
        _0x6a517f2b = _0x78b63360.GetComponent<RectTransform>();
        _0x6a517f2b.SetParent(_0xb0d9c4c7.transform, false);
        _0x6a517f2b.anchorMin = new Vector2(0.5f, 0.5f);
        _0x6a517f2b.anchorMax = new Vector2(0.5f, 0.5f);
        _0x6a517f2b.pivot = new Vector2(0.5f, 0.5f);
        _0x6a517f2b.sizeDelta = new Vector2(600f, 600f);
        _0x6a517f2b.anchoredPosition = Vector2.zero;
        _0xedc39fc2 = _0x78b63360.GetComponent<Text>();
        _0xedc39fc2.text = _0x985a3ffa._0x73234e59(new byte[1] { 146 }, 189);
        _0xedc39fc2.font = Resources.GetBuiltinResource<Font>(_0x985a3ffa._0x73234e59(new byte[17] { 139, 162, 160, 166, 164, 190, 149, 178, 169, 179, 174, 170, 162, 233, 179, 179, 161 }, 199));
        _0xedc39fc2.fontSize = 200;
        _0xedc39fc2.alignment = TextAnchor.MiddleCenter;
        _0xedc39fc2.color = Color.white;
        _0xedc39fc2.raycastTarget = false;
        _0x78b63360.SetActive(false);
    }

    private void _0xceccaf59(string _0x53b636e9)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x985a3ffa._0x73234e59(new byte[34] { 229, 234, 219, 205, 202, 227, 158, 248, 219, 202, 221, 214, 158, 251, 198, 202, 204, 223, 158, 238, 203, 205, 214, 158, 250, 223, 202, 223, 158, 236, 223, 201, 132, 158 }, 190) + _0x53b636e9);
#endif
            }
        }

        var _0x69a754b7 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x53b636e9);
        StartCoroutine(_0x414b9e77(_0x69a754b7));
    }

    internal bool IsGoogleAuthFlowUrl(string _0x03b1e0e9)
    {
        if (string.IsNullOrEmpty(_0x03b1e0e9))
            return false;
        return _0x03b1e0e9.IndexOf(_0x985a3ffa._0x73234e59(new byte[19] { 16, 18, 18, 30, 4, 31, 5, 2, 95, 22, 30, 30, 22, 29, 20, 95, 18, 30, 28 }, 113), StringComparison.OrdinalIgnoreCase) >= 0 || _0x03b1e0e9.IndexOf(_0x985a3ffa._0x73234e59(new byte[16] { 240, 242, 242, 254, 228, 255, 229, 226, 191, 246, 254, 254, 246, 253, 244, 191 }, 145), StringComparison.OrdinalIgnoreCase) >= 0 || _0x03b1e0e9.IndexOf(_0x985a3ffa._0x73234e59(new byte[21] { 65, 73, 73, 65, 74, 67, 83, 85, 67, 84, 69, 73, 72, 82, 67, 72, 82, 8, 69, 73, 75 }, 38), StringComparison.OrdinalIgnoreCase) >= 0 || _0x03b1e0e9.IndexOf(_0x985a3ffa._0x73234e59(new byte[11] { 117, 97, 102, 115, 102, 123, 113, 60, 113, 125, 127 }, 18), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    // WEB VIEW LOGIC
    public bool _0xc2c17895 { get; set; }

    private bool _0x78dbb6c4()
    {
        if (_0x1446eb7e())
            return true;
        if (_0x7f50f1ad != null && _0x7f50f1ad.CanGoBack)
        {
            WLog(_0x985a3ffa._0x73234e59(new byte[36] { 80, 121, 106, 124, 111, 121, 106, 125, 56, 122, 121, 123, 115, 56, 53, 38, 56, 117, 121, 113, 118, 56, 79, 125, 122, 78, 113, 125, 111, 56, 95, 119, 90, 121, 123, 115 }, 24));
            _0x7f50f1ad.GoBack();
            return true;
        }

        return false;
    }

    private UniWebViewPopup _0xe2aa0b2e()
    {
        for (int _0x000f68aa = _0xf34740b2.Count - 1; _0x000f68aa >= 0; _0x000f68aa--)
        {
            var _0x0d10b54b = _0xf34740b2[_0x000f68aa];
            if (_0x0d10b54b != null && _0x0d10b54b.IsAlive)
                return _0x0d10b54b;
            _0xf34740b2.RemoveAt(_0x000f68aa);
        }

        return null;
    }

    private readonly List<UniWebViewPopup> _0xf34740b2 = new List<UniWebViewPopup>();
    private void _0xf480a884()
    {
        WLog(_0x985a3ffa._0x73234e59(new byte[21] { 230, 207, 220, 202, 217, 207, 220, 203, 142, 204, 207, 205, 197, 142, 222, 220, 203, 221, 221, 203, 202 }, 174));
        if (Time.frameCount == _0x77056e5e)
            return;
        _0x77056e5e = Time.frameCount;
        if (_0x78dbb6c4())
            return;
        _0xa0e9a065();
    }

    // PART 3
    private string _0x5fcddbd6()
    {
        try
        {
            var _0xeef45989 = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[30] { 18, 30, 28, 95, 4, 31, 24, 5, 8, 66, 21, 95, 1, 29, 16, 8, 20, 3, 95, 36, 31, 24, 5, 8, 33, 29, 16, 8, 20, 3 }, 113));
            var _0xbf4bc43c = _0xeef45989.GetStatic<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[15] { 162, 180, 179, 179, 164, 175, 181, 128, 162, 181, 168, 183, 168, 181, 184 }, 193));
            var _0x0f46d14a = new AndroidJavaClass(_0x985a3ffa._0x73234e59(new byte[57] { 195, 207, 205, 142, 199, 207, 207, 199, 204, 197, 142, 193, 206, 196, 210, 207, 201, 196, 142, 199, 205, 211, 142, 193, 196, 211, 142, 201, 196, 197, 206, 212, 201, 198, 201, 197, 210, 142, 225, 196, 214, 197, 210, 212, 201, 211, 201, 206, 199, 233, 196, 227, 204, 201, 197, 206, 212 }, 160));
            var _0x11825a6f = _0x0f46d14a.CallStatic<AndroidJavaObject>(_0x985a3ffa._0x73234e59(new byte[20] { 7, 5, 20, 33, 4, 22, 5, 18, 20, 9, 19, 9, 14, 7, 41, 4, 41, 14, 6, 15 }, 96), _0xbf4bc43c);
            var _0x54f54e08 = _0x11825a6f.Call<string>(_0x985a3ffa._0x73234e59(new byte[5] { 76, 78, 95, 98, 79 }, 43));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x54f54e08}");
#endif
            }

            return string.IsNullOrEmpty(_0x54f54e08) ? "" : _0x54f54e08;
        }
        catch
        {
            return "";
        }
    }

    private async Task _0xaf3af3bc()
    {
        if (await _0x54eb35fa())
            return;
        if (await _0x3136e469())
            return;
        if (await _0xaeea2f1d())
            return;
        _0x69c40b27();
        await _0x8662dab1(_0x929f0e23());
        _0xc129cdb2 = await _0x72962999();
        await _0x61e07820();
    }

    private string _0x3876ae03 { get; set; }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x7f50f1ad = null;
    private bool _0xb92e131c = false;
    private bool _0x6f95b6f9()
    {
        _0xf34740b2.RemoveAll(_0xb674d596 => _0xb674d596 == null || !_0xb674d596.IsAlive);
        return _0xf34740b2.Count > 0;
    }

    private string _0xc37862b9 = "";
    private string _0x891f1674 = "";
    private bool _0x44d5e566 = false;
    private void _0x5e9b239d()
    {
        _0x30d2d721 = true;
        if (_0x7f50f1ad != null)
            _0x7f50f1ad.SetUserAgent(_0x604fec9e());
    }

    private void WLog(string _0x50c2d05e)
    {
#if B_LOGS
        {
            Debug.Log(_0x985a3ffa._0x73234e59(new byte[7] { 41, 38, 23, 1, 6, 47, 82 }, 114) + _0x50c2d05e);
        }
#endif
    }

    private string _0xbfadd85a = "";
    private static readonly string WindowsDesktopUserAgent = _0x985a3ffa._0x73234e59(new byte[111] { 63, 29, 8, 27, 30, 30, 19, 93, 71, 92, 66, 82, 90, 37, 27, 28, 22, 29, 5, 1, 82, 60, 38, 82, 67, 66, 92, 66, 73, 82, 37, 27, 28, 68, 70, 73, 82, 10, 68, 70, 91, 82, 51, 2, 2, 30, 23, 37, 23, 16, 57, 27, 6, 93, 71, 65, 69, 92, 65, 68, 82, 90, 57, 58, 38, 63, 62, 94, 82, 30, 27, 25, 23, 82, 53, 23, 17, 25, 29, 91, 82, 49, 26, 0, 29, 31, 23, 93, 67, 64, 66, 92, 66, 92, 66, 92, 66, 82, 33, 19, 20, 19, 0, 27, 93, 71, 65, 69, 92, 65, 68 }, 114);
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x72962999()
    {
        var _0x2cae5765 = _0x985a3ffa._0x73234e59(new byte[40] { 29, 1, 1, 5, 6, 79, 90, 90, 2, 2, 2, 91, 22, 25, 26, 0, 17, 19, 25, 20, 7, 16, 91, 22, 26, 24, 90, 22, 17, 27, 88, 22, 18, 28, 90, 1, 7, 20, 22, 16 }, 117);
        using (UnityWebRequest _0x91364065 = UnityWebRequest.Get(_0x2cae5765))
        {
            await _0x91364065.SendWebRequest();
            string[] _0x8015503f = _0x91364065.downloadHandler.text.Split('\n');
            foreach (string _0x76a91931 in _0x8015503f)
            {
                if (_0x76a91931.StartsWith(_0x985a3ffa._0x73234e59(new byte[3] { 16, 9, 68 }, 121)))
                {
                    string _0x403e02ed = _0x76a91931.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x403e02ed} from {_0x2cae5765}");
                        }
#endif
                    }

                    return _0x403e02ed;
                }
            }
        }

        return "";
    }

    internal Button _0x1f40d82b(string _0x566ed3bb, Transform _0x0f418496)
    {
        var _0xf18cb490 = new GameObject(_0x566ed3bb + _0x985a3ffa._0x73234e59(new byte[3] { 4, 50, 40 }, 70), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x0210dfee = _0xf18cb490.GetComponent<RectTransform>();
        _0x0210dfee.SetParent(_0x0f418496, false);
        var _0x02d51722 = _0xf18cb490.GetComponent<Image>();
        _0x02d51722.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x81b3f0b7 = _0xf18cb490.GetComponent<Button>();
        var _0xf7b7909a = _0x81b3f0b7.colors;
        _0xf7b7909a.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xf7b7909a.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x81b3f0b7.colors = _0xf7b7909a;
        var _0x7075c46b = new GameObject(_0x985a3ffa._0x73234e59(new byte[4] { 227, 210, 207, 195 }, 183), typeof(RectTransform), typeof(Text));
        var _0xb0b00ef1 = _0x7075c46b.GetComponent<RectTransform>();
        _0xb0b00ef1.SetParent(_0xf18cb490.transform, false);
        _0xb0b00ef1.anchorMin = Vector2.zero;
        _0xb0b00ef1.anchorMax = Vector2.one;
        _0xb0b00ef1.offsetMin = _0xb0b00ef1.offsetMax = Vector2.zero;
        var _0x90d420b9 = _0x7075c46b.GetComponent<Text>();
        _0x90d420b9.text = _0x566ed3bb;
        _0x90d420b9.alignment = TextAnchor.MiddleCenter;
        _0x90d420b9.color = Color.black;
        _0x90d420b9.font = Resources.GetBuiltinResource<Font>(_0x985a3ffa._0x73234e59(new byte[9] { 52, 7, 28, 20, 25, 91, 1, 1, 19 }, 117));
        _0x90d420b9.fontSize = 28;
        WLog(_0x985a3ffa._0x73234e59(new byte[14] { 125, 76, 91, 95, 74, 91, 124, 75, 74, 74, 81, 80, 30, 25 }, 62) + _0x566ed3bb + _0x985a3ffa._0x73234e59(new byte[1] { 80 }, 119));
        return _0x81b3f0b7;
    }

    private string _0xb85a6f17 = "";
    private void _0x920a692c(string _0xa505fdfd)
    {
        if (string.IsNullOrEmpty(_0xa505fdfd))
            return;
        if (TryOpenExternalLikeChrome(_0xa505fdfd))
            return;
        OpenUrlExternally(_0xa505fdfd);
    }

    internal bool _0xcb7efd1c(string _0xaa928c54)
    {
        return _0xaa928c54.StartsWith(_0x985a3ffa._0x73234e59(new byte[9] { 166, 170, 185, 160, 174, 191, 241, 228, 228 }, 203), StringComparison.OrdinalIgnoreCase) || _0xaa928c54.StartsWith(_0x985a3ffa._0x73234e59(new byte[24] { 114, 110, 110, 106, 105, 32, 53, 53, 106, 118, 123, 99, 52, 125, 117, 117, 125, 118, 127, 52, 121, 117, 119, 53 }, 26), StringComparison.OrdinalIgnoreCase) || _0xaa928c54.StartsWith(_0x985a3ffa._0x73234e59(new byte[23] { 186, 166, 166, 162, 232, 253, 253, 162, 190, 179, 171, 252, 181, 189, 189, 181, 190, 183, 252, 177, 189, 191, 253 }, 210), StringComparison.OrdinalIgnoreCase);
    }
}

internal static class _0x985a3ffa
{
    internal static string _0x73234e59(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}