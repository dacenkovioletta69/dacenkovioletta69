#!/usr/bin/env bash
# Offline type-check of the generated Unity C# with the Hub editor's OWN reference
# assemblies. The Editor itself is never launched (that would recreate Library/ and rewrite
# every .meta); only Roslyn and the reference DLLs are used.
#
# MainThreadUtil.cs is excluded and stubbed: it imports Unity.Services.* / Unity.Notifications,
# packages that are not installed on this host, and a declaration-phase error makes Roslyn skip
# binding method bodies entirely - which is exactly how a "clean" check can be blind.
set -u
ED="/c/Program Files/Unity/Hub/Editor/6000.5.10f1/Editor/Data"
PROJ="/c/AndroidWorkspace/projects/JokerRubyReels"
OUT="${1:?out dir}"
RSP="$OUT/tc.rsp"
mkdir -p "$OUT"
: > "$RSP"
for f in -nostdlib -nologo -target:library -langversion:9.0 -define:B_LOGS; do echo "$f" >> "$RSP"; done
echo "-out:$(cygpath -w "$OUT/Generated.dll")" >> "$RSP"
add() { [ -f "$1" ] && echo "\"-r:$(cygpath -w "$1")\"" >> "$RSP"; }
for d in "$ED/NetStandard/ref/2.1.0/"*.dll; do add "$d"; done
add "$ED/DotNetSdk/packs/NETStandard.Library.Ref/2.1.0/ref/netstandard2.1/mscorlib.dll"
for d in "$ED/Managed/UnityEngine/"*.dll; do add "$d"; done
LC="$ED/Resources/PackageManager/ProjectTemplates/libcache/com.unity.template.2d-cross-platform-2d-6.1.5/ScriptAssemblies"
for n in UnityEngine.UI Unity.TextMeshPro Unity.InputSystem; do add "$LC/$n.dll"; done
add "$PROJ/Assets/Plugins/Demigiant/DOTween/DOTween.dll"
src() { echo "\"$(cygpath -w "$1")\"" >> "$RSP"; }
while IFS= read -r s; do src "$s"; done < <(
  find "$PROJ/Assets" -name '*.cs' \
    ! -path '*_EXT \[DEL\]*' ! -path '*/Editor/*' ! -name 'MainThreadUtil.cs' | sort)
src "$OUT/stubs/MainThreadUtilStub.cs"
"$ED/DotNetSdk/dotnet.exe" "$ED/DotNetSdk/sdk/8.0.318/Roslyn/bincore/csc.dll" "@$(cygpath -w "$RSP")" 2>&1
