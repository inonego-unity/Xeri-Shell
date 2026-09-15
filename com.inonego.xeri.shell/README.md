# Xeri Shell

`com.inonego.xeri.shell`는 Xeri 기반의 Window, Tray, View Session 기능을 제공하는 Unity Package Manager 패키지입니다.

이 패키지는 `com.inonego.xeri`에 의존하며, base Xeri가 Window 패키지를 역참조하지 않는 단방향 경계를 유지합니다.

## 구성

- `Runtime/Window`: Window 상태, Registry, UITK Canvas/Panel, 이동·크기 변경·전환
- `Runtime/Tray`: Window/Tab류 entry 표시, 선택, 닫기 요청, 재정렬
- `Runtime/View`: stable ID 기반 View Source/Resolver와 UI Session
- `Editor`: Window Editor 확장 assembly
- `Tests`: Edit/Play/Editor Test assembly
- `Documentation~`: Window/Tray/View 사용자 문서

## 로컬 패키지 연결

```json
"com.inonego.xeri.shell": "file:../../Xeri-Shell/com.inonego.xeri.shell"
```

자세한 사용법은 [`Documentation~/index.md`](Documentation~/index.md)를 참고합니다.
