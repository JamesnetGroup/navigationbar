# NavigationBar [![English](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/Language-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/Language-한국어-red.svg)](README.ko.md) 

애니메이션이 적용된 모바일 스타일의 내비게이션 바를 만들기 위한 정교한 WPF ListBox 기반 CustomControl

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/vickyqu115/navigationbar.svg)](https://github.com/vickyqu115/navigationbar/stargazers)
[![Issues](https://img.shields.io/github/issues/vickyqu115/navigationbar.svg)](https://github.com/vickyqu115/navigationbar/issues)

## 프로젝트 개요

NavigationBar는 모바일에서 영감을 받은 내비게이션 인터페이스를 만드는 고급 기술을 보여주는 사용자 정의 WPF 컨트롤입니다. 복잡한 UI 동작과 애니메이션을 구현하는 데 있어 WPF의 강력함과 유연성을 보여주며, 특히 CustomControl 개발과 효율적인 애니메이션 설계에 중점을 둡니다.

[이미지 섹션은 영문 버전과 동일]

## 주요 기능 및 구현 사항
#### 1. 고급 CustomControl 개발
- [x] 특화된 내비게이션 기능을 위한 WPF ListBox 확장
- [x] 순수 XAML과 C#을 사용한 복잡한 UI 요소 구현
- [x] 별도의 애플리케이션 및 라이브러리 프로젝트로 모듈성을 최적화한 프로젝트 구조

#### 2. 정교한 애니메이션 기법
- [x] 간결하고 효율적인 애니메이션을 위한 Jamesnet.Wpf 애니메이션 래퍼 클래스(ValueItem, ThickItem, ColorItem) 활용
- [x] 내비게이션 항목 간 부드러운 전환을 위한 사용자 정의 애니메이션 로직
- [x] 향상된 유연성을 위해 ItemsPresenter 외부에서 작동하는 혁신적인 애니메이션 설계

#### 3. XAML 기반 벡터 그래픽
- [x] Visual Studio for Blend에서 Path와 Geometry를 사용한 복잡한 형태 생성
- [x] 확장 가능하고 고품질의 시각적 효과를 위한 벡터 기반 아이콘 구현

#### 4. 고급 WPF 개념
- [x] 독특한 레이아웃과 동작을 가능하게 하는 ListBox를 위한 정교한 ControlTemplate 설계
- [x] 유연한 항목 레이아웃을 위한 사용자 정의 ItemsPanel 구현

#### 5. 성능 최적화
- [x] 클리핑 및 레이아웃 기술을 사용한 효율적인 렌더링
- [x] 세심한 리소스 관리를 통한 최적화된 애니메이션 성능

## 기술적 심층 분석
- **CustomControl 아키텍처**: WPF에서 CustomControl의 강력함을 보여주며, 동작과 외관을 완전히 제어할 수 있습니다.
- **ItemsPresenter 외부 애니메이션**: ItemsPresenter 외부에서 작동하는 애니메이션을 설계하는 혁신적인 접근 방식으로, 이 컨트롤의 핵심 기능입니다.
- **Jamesnet.Wpf 애니메이션 통합**: Jamesnet.Wpf의 ValueItem, ThickItem, ColorItem을 활용하여 간소화되고 더 읽기 쉬운 애니메이션 코드를 구현합니다.
- **Blend에서의 Geometry 생성**: Visual Studio for Blend를 사용하여 복잡한 geometry를 직접 생성하는 방법을 보여주며, 디자인 프로세스를 향상시킵니다.
- **ListBox ControlTemplate 재설계**: 독특한 내비게이션 바 레이아웃과 기능을 구현하기 위해 ListBox 템플릿을 완전히 개선했습니다.

## 기술 스택
- WPF (Windows Presentation Foundation)
- .NET 8.0
- C# 10.0
- XAML
- Jamesnet.Wpf (애니메이션 래퍼 클래스용)

## 프로젝트 구조
- 데모 및 테스트를 위한 애플리케이션 프로젝트
- 재사용성을 높이는 NavigationBar 컨트롤을 위한 라이브러리 프로젝트

## 시작하기
### 필요 조건
- Visual Studio 2022 이상
- .NET 8.0 SDK

### 설치 및 실행
#### 1. 리포지토리 복제:
```
git clone https://github.com/vickyqu115/navigationbar.git
```

#### 2. 솔루션 열기
- [x] Visual Studio
- [x] Visual Studio Code
- [x] Blend for Visual Studio
- [x] JetBrains Rider

[개발 환경 이미지는 영문 버전과 동일]

#### 3. 빌드 및 실행
- [x] 시작 프로젝트 설정
- [x] F5를 누르거나 실행 버튼 클릭
- [x] Windows 11 권장

## 학습 자료
- [구현에 대한 상세 아티클](https://jamesnet.dev/article/edit/110)
- [YouTube 튜토리얼](https://bit.ly/3TVeRhF)
- [BiliBili 튜토리얼](https://bit.ly/3UvaOsl)
- [CodeProject](https://www.codeproject.com/Articles/5375482/Customizing-ListBox-for-a-Smooth-Animated-Navigati)

## 기여하기
NavigationBar에 대한 기여를 환영합니다! 이슈를 제출하거나, 풀 리퀘스트를 생성하거나, 개선 사항을 제안해 주세요.

## 라이선스
이 프로젝트는 MIT 라이선스 하에 배포됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 연락처
- 웹사이트: https://jamesnet.dev
- 이메일: vickyqu115@hotmail.com, james@jamesnet.dev

NavigationBar로 고급 WPF 기술을 탐험하고 매력적인 내비게이션 경험을 만들어보세요!

