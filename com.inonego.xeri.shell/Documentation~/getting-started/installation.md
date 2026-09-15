# 설치

Xeri Shell는 `com.inonego.xeri.shell` UPM 패키지이며 `com.inonego.xeri`에 의존합니다.

## 요구 사항

- Unity 6000.0 이상
- `com.inonego.xeri` 0.0.1 이상

실제 최소 버전과 직접 의존성은 패키지 루트의 `package.json`을 기준으로 확인합니다.

## Git / UPM

```json
"com.inonego.xeri": "https://github.com/inonego-unity/Xeri.git?path=/com.inonego.xeri#main",
"com.inonego.xeri.shell": "https://github.com/inonego-unity/Xeri-Shell.git?path=/com.inonego.xeri.shell#main"
```

안정화 뒤에는 `#main` 대신 호환 버전 태그를 고정하는 방식을 권장합니다.

## 로컬 checkout 연결

KnackH처럼 `Xeri-Shell`와 Unity 프로젝트가 같은 상위 디렉터리에 있다면 `Packages/manifest.json`에 다음과 같이 연결할 수 있습니다.

```json
"com.inonego.xeri.shell": "file:../../Xeri-Shell/com.inonego.xeri.shell"
```

테스트를 Test Runner에 표시하려면 `testables`에도 패키지를 추가합니다.

```json
"testables": ["com.inonego.xeri.shell"]
```

## 다음 단계

설치 후 [구조와 의존 방향](../concepts/architecture.md)을 확인하고, 필요한 기능에 따라 [Window](../modules/window.md), [Tray](../modules/tray.md), [View](../modules/view.md)를 선택합니다.
