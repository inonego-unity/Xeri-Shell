# Xeri Shell 문서

Xeri Shell는 `com.inonego.xeri` 위에서 Window, Tray, View Session을 조합하는 독립 확장 패키지입니다.

## 처음이라면

1. [설치](getting-started/installation.md)
2. [구조와 의존 방향](concepts/architecture.md)
3. 필요한 모듈 문서
4. 실제 조립이 필요하면 [Window와 View Source 연결하기](guides/create-window-view.md)

## 모듈

- [Window](modules/window.md): 이동, 크기 변경, 최소화, 최대화, focus와 Registry
- [Tray](modules/tray.md): 선택, 닫기 요청, 재정렬이 가능한 entry 표시
- [View](modules/view.md): stable ID 기반 View 생성과 Session 저장·복원

## 의존 방향

```text
com.inonego.xeri.shell
        ↓
com.inonego.xeri
```

base Xeri는 Window 패키지 타입을 참조하지 않습니다.
