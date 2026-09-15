/* BLOCK_HEADER_BEGIN =======================================================================
파일명 : AssemblyInfo.cs
수정일 : 2026-09-16

# 설명
Xeri Shell Runtime 내부 계약을 같은 패키지의 Editor와 검증 Assembly에 제한 공개한다.
========================================================================= BLOCK_HEADER_END */

using System;
using System.Runtime;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("inonego.Xeri.Shell.Editor")]
[assembly: InternalsVisibleTo("inonego.Xeri.Shell.TEST.EDIT")]
[assembly: InternalsVisibleTo("inonego.Xeri.Shell.TEST.PLAY")]
[assembly: InternalsVisibleTo("inonego.Xeri.Shell.Editor.TEST.EDIT")]