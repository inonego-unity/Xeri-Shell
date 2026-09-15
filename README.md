# Xeri Shell

`Xeri-Shell`는 Xeri 위에서 동작하는 Window, Tray, View Session 중심의 독립 Unity Package 저장소입니다.

## Package

- `com.inonego.xeri.shell`
- dependency: `com.inonego.xeri`

## Git / UPM

프로젝트의 `Packages/manifest.json`에서 Xeri와 Shell을 함께 연결합니다.

```json
"com.inonego.xeri": "https://github.com/inonego-unity/Xeri.git?path=/com.inonego.xeri#main",
"com.inonego.xeri.shell": "https://github.com/inonego-unity/Xeri-Shell.git?path=/com.inonego.xeri.shell#main"
```

릴리스 태그를 사용하기 시작하면 `#main` 대신 동일한 호환 버전 태그를 고정합니다.
## Local checkout

```json
"com.inonego.xeri.shell": "file:../../Xeri-Shell/com.inonego.xeri.shell"
```

## Documentation

- [사용자 문서](com.inonego.xeri.shell/Documentation~/index.md)
- [설치](com.inonego.xeri.shell/Documentation~/getting-started/installation.md)
- [구조와 의존 방향](com.inonego.xeri.shell/Documentation~/concepts/architecture.md)

의존 방향은 `Xeri Shell -> Xeri`만 허용하며 base Xeri는 Shell assembly를 참조하지 않습니다.
