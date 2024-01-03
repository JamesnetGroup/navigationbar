#### 제목
WPF에서도 CSS 못지 않게 놀라운 애니메이션을 구현할 수 있습니다.

#### 이 기술에 대해
WPF의 애니메이션 기술은 다양하게 제공하지만 메뉴와 같은 복잡한 애니메이션 구성을 할 경우 구현 방법이 매우 어렵습니다. 따라서 이번 내용에서는 ListBox와 같은 하위 자식이 명확하게 나뉘어져 있는 ItemsControl 계열의 구조에서 어떻게 러블리한 애니메이션 동작을 구현하는지에 대해 자세하고 수준 높게  설명하고 있습니다.

#### 프로젝트 구성
- DemoApp: WPF Application
- NavigationBar: WPF CustomControl Library

이 컨트롤은 복잡한 커스터마이징이 들어가기 때문에 WPF Application에서 직접 구현하지 않고 별도의 CustomControl Library 프로젝트를 통해 재사용가능한 모듈 라이브러리로 구성하고 있습니다. 따라서 Application 프로젝트인 DemoApp은 단순 실행만을 위한 프로젝트로 사용됩니다.

#### 개발환경
- Windows 11 OS
- WPF (WIndows Presentation Foundation)
- Visual Studio 2022
- NET 8.0




