# 구조와 의존 방향

Xeri Shell는 Window, Tray, View Session을 하나의 UI shell 경계로 묶되 base Xeri와의 의존 방향을 단방향으로 유지합니다.

```text
com.inonego.xeri.shell
        ↓
com.inonego.xeri
```

base Xeri는 Xeri Shell 타입을 참조하지 않습니다.

## 책임 분리

- **Window**: 상태, 위치·크기, focus/z-order, drag/resize, 전환 정책
- **Tray**: entry 표시, 선택, 닫기 요청, reorder
- **View**: stable ID 기반 view 생성과 session 저장·복원
- **Xeri UI Core**: Presentation, Alpha, Visibility, Transition 같은 범용 UI primitive

Window의 `Normal/Minimized/Maximized/Closed`, Registry, bounds, stack layer는 이 패키지의 도메인 책임입니다.
범용 표시 상태나 transition executor는 base Xeri의 UI Core를 소비하는 방향으로 확장합니다.

## 확장 원칙

새 기능이 Window lifecycle이나 shell chrome에 속하면 이 패키지에서 확장합니다.
반대로 모든 UI에서 재사용 가능한 primitive라면 base Xeri UI Core에 두고 이 패키지가 소비합니다.

이 기준은 Docking, Menu/Toolbar, Status Bar, Layout persistence 같은 후속 기능을 추가할 때도 동일하게 적용합니다.
