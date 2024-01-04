## MagicNavigationBar 프로젝트 소개: 배경 및 개요
WPF 기술에 대한 깊은 열정을 가진 개발자로서, 저는 WPF의 잠재력이 일반적으로 인식하는 것 이상임을 확신합니다. WPF는 단순히 강력한 UI 프레임워크가 아니라, 다양성과 우수한 성능으로 개발자들에게 창의적인 작업 공간을 제공합니다. 저의 목표는 WPF 기술에 관심이 있는 사람들과 현재 WPF 기술을 사용하는 사람들에게 기술 지원과 영감을 제공하면서, WPF의 다양한 측면을 점진적으로 공개하는 것입니다.

## Magic Navigation Bar의 디자인 철학:
이 프로젝트의 본질은 간단하면서도 활기찬 Magic Navigation Bar를 만드는 것입니다. 현대 프로그래밍 세계에서 비슷한 네비게이션 바는 일반적으로 HTML, CSS, JavaScript를 사용하여 구현됩니다. 이 기술들의 장점은 그들의 광범위한 적용 가능성과 유연성에 있습니다. HTML은 구조를 제공하고, CSS는 스타일과 레이아웃을 담당하며, JavaScript는 상호 작용과 애니메이션을 관리합니다. 이러한 기술들이 함께 사용되어 시각적으로 매력적이고 기능적으로 견고한 웹 애플리케이션을 만듭니다.

그러나 WPF 기술을 사용하여 이러한 프로젝트를 구축하는 것은 프로젝트 구조와 애니메이션 제시 측면에서 복잡하고 도전적으로 여겨집니다. 여기에 도전이 있습니다: WPF의 유연성과 강력한 기능에 대한 깊은 이해를 통해, 이 과정을 단순화할 수 있을 뿐만 아니라 코드를 통해 우아하게 구현할 수 있습니다.

## 프로젝트 개요
### WPF의 힘:
이 프로젝트에서는 WPF의 강력한 기능, 특히 XAML과 C# 백엔드 코드의 풍부한 조합을 활용하여 시각적으로 매력적이고 완전히 기능하는 Magic Navigation Bar를 구축합니다. WPF는 선언적 언어(XAML)를 사용하여 UI를 디자인할 수 있게 하며, C#의 강력한 타입 및 객체 지향 기능을 사용하여 논리와 동작을 처리합니다. 이 조합은 복잡하고 동적인 UI를 생성하기 위한 엄청난 유연성을 제공합니다.

### 구조 및 구현:
프로젝트 구조는 프론트엔드 UI와 백엔드 로직으로 나뉩니다. UI 부분에서는 XAML을 사용하여 컨트롤의 레이아웃, 스타일 및 애니메이션을 정의합니다. 이에는 컨트롤의 외관 정의, 애니메이션 효과 구현 및 사용자 상호 작용에 대한 반응이 포함됩니다. C# 백엔드 코드에서는 사용자 상호 작용 이벤트를 처리하고, 애니메이션 재생을 제어하며, 컨트롤의 상태 변경을 관리합니다. 이 구조는 코드의 명확성과 유지 관리 가능성을 보장할 뿐만 아니라 UI와 로직을 분리하여 코드의 재사용성과 확장성을 향상시킵니다.

이 프로젝트를 통해 현대적이고 동적이며 반응성이 뛰어난 사용자 인터페이스를 생성하는 WPF의 강력한 기능을 보여줄 수 있습니다. 또한 WPF가 전통적으로 프론트엔드 개발 영역으로 간주되는 프로젝트에 대해 우아하고 효율적인 해결책을 제공할 수 있음을 보여줍니다.


## XAML 코드 설명

### 기하학 및 레이아웃
Magic Navigation Bar의 XAML 코드 핵심은 ListBoxItem의 사용자 정의와 다양한 요소들의 현명한 조합을 통해 미적으로 만족스럽고 완전히 기능하는 네비게이션 바를 만드는 데 중점을 둡니다.
### ListBoxItem 구조:
ListBoxItem은 MagicBar의 기본 구성 요소입니다. 각 ListBoxItem은 아이콘(JamesIcon 사용)과 텍스트(TextBlock 사용)를 포함합니다. 이 구조는 각 탐색 항목에 아이콘과 해당 텍스트 레이블을 제공하여 사용자에게 직관적인 탐색 경험을 제공합니다.
```xaml
<Style TargetType="{x:Type ListBoxItem}" x:Key="MagicBarItem">
    <Setter Property="FocusVisualStyle" Value="{x:Null}"/>
    <Setter Property="Background" Value="Transparent"/>
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type ListBoxItem}">
                <Grid Background="{TemplateBinding Background}">
                    <james:JamesIcon x:Name="icon" Style="{StaticResource Icon}"/>
                    <TextBlock x:Name="name" Style="{StaticResource Name}"/>
                </Grid>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```
### 아이콘 사용 및 사용자 정의:

jamesnet.wpf 라이브러리를 사용하면 다양한 아이콘 자료를 쉽게 추가하고 사용할 수 있습니다. 이를 통해 아이콘 사용 과정이 크게 단순화되며, 사용자 정의 컨트롤을 통해 아이콘의 크기와 색상을 사용자 지정할 수 있습니다. 이러한 유연성은 MagicBar의 각 항목이 독특하면서도 일관성을 유지하도록 보장합니다.

```xaml
<Style TargetType="{x:Type james:JamesIcon}" x:Key="Icon">
    <Setter Property="Icon" Value="{Binding ...}"/>
    <Setter Property="Width" Value="40"/>
    <Setter Property="Height" Value="40"/>
    <Setter Property="Fill" Value="#44333333"/>
</Style>
```


### RelativeSource 바인딩 적용:
RelativeSource 바인딩을 사용함으로써, 우리는 ListBoxItem 영역 내에 처음 정의된 아이콘과 텍스트의 TemplateBinding을 JamesIcon 및 TextBlock 영역으로 개별적으로 이동시킬 수 있습니다. 이 접근법은 각 구성 요소(아이콘 및 텍스트)가 자체 정의와 스타일을 가질 수 있게 하여, 코드를 더 모듈화하고 유지 관리하기 쉽고 재사용 가능하게 만듭니다. 바인딩과 스타일을 각각의 영역으로 분리함으로써 전체 코드 구조를 명확하게 하여 이해하고 수정하기 쉽게 만듭니다. 또한, 이러한 분리는 더 큰 유연성을 제공하여, 다른 구성 요소에 영향을 주지 않고 개별 구성 요소의 스타일과 행동을 조정할 수 있습니다.
```xaml
Value="{Binding RelativeSource={RelativeSource AncestorType=ListBoxItem}, Path=Tag}"
```
## 2. Microsoft Blend: WPF 및 XAML 개발 가속화
프로젝트 개발 과정에서 개발자가 특정 디자인 기술을 마스터할 수 있다면 프로젝트 인터페이스의 미학을 크게 향상시킬 수 있습니다. 하지만 모든 개발자가 새로운 기술을 배우는데 시간이나 관심이 있는 것은 아닙니다. 이런 경우, 사용하기 쉽고 개발자 친화적인 도구를 선택하여 간단한 그래픽 디자인 및 생성을 하는 것이 특히 중요합니다.

Microsoft Blend는 바로 그런 도구입니다. 이는 WPF 및 기타 XAML 기반 애플리케이션을 위해 특별히 설계되었으며, 전문적인 UI 디자인 도구의 전체 스위트를 제공합니다. 이를 통해 개발자와 디자이너는 효율적으로 복잡하고 매력적인 사용자 인터페이스를 생성할 수 있습니다.

### WPF 개발자와 XAML을 사용하는 프로그래머들에게 Blend의 주요 장점은 다음과 같습니다:
- #### 직관적인 비주얼 디자인 도구:
Blend는 WYSIWYG 인터페이스를 제공하여 개발자들이 직관적으로 사용자 인터페이스를 생성하고 편집할 수 있게 합니다. 이는 복잡한 레이아웃과 애니메이션을 디자인하는 데 특히 유용합니다.
- #### UI 구성 요소 및 스타일 편집 지원:
Blend는 사용자 정의 컨트롤, 스타일, 템플릿을 포함한 고급 UI 요소의 생성 및 편집을 지원합니다. 강력한 스타일링 및 리소스 관리 기능으로 깔끔하고 정돈된 코드를 유지할 수 있습니다.
- #### 경로 도구 및 모양 편집:
Blend의 경로 도구와 모양 편집 기능은 복잡한 그래픽 생성을 단순화합니다.
- #### 통합 코드 편집 및 Visual Studio 통합:
Blend는 비주얼 디자인뿐만 아니라 코드 편집기도 제공하여 애플리케이션 내에서 코드의 직접 편집 및 디버깅을 가능하게 합니다. Visual Studio와의 원활한 통합으로 개발자들에게 완벽한 개발 및 디자인 환경을 제공합니다.
- #### 애니메이션 및 비주얼 상태 관리:
Blend를 사용하면 개발자들은 복잡한 애니메이션과 비주얼 상태를 쉽게 디자인할 수 있습니다. 직관적인 타임라인과 애니메이션 도구로 애니메이션 생성 및 조정 과정을 단순화합니다.
- #### 신속한 프로토타이핑 및 반복:
Blend는 신속한 프로토타이핑을 가능하게 하여, 디자이너와 개발자들이 빠르게 UI 개념을 생성하고 피드백에 기반한 반복을 할 수 있게 합니다.
- #### 크로스 플랫폼 지원:
Blend는 WPF뿐만 아니라 UWP 및 Silverlight와 같은 다른 XAML 기반 플랫폼도 지원하여 크로스 플랫폼 개발을 용이하게 합니다.

결론적으로, Blend는 개발자들이 광범위한 디자인 학습 없이도 전문적이고 매력적인 사용자 인터페이스를 생성할 수 있게 하는 강력하고 접근하기 쉬운 도구로, 프로젝트의 전반적인 품질과 사용자 경험을 향상시킵니다.

## 🔵서클 섹션의 비주얼 디자인 분석
매직 네비게이션 바 프로젝트에서 서클 섹션은 시각적인 하이라이트로, 영리한 디자인과 기술적 구현을 통해 전체 네비게이션 바의 매력을 향상시킵니다.
다양한 위치와 색상의 두 개의 원을 추가함으로써 시각적으로 공간감과 계층을 만들어냈습니다. 또한, 서클 섹션에서 매직바 영역으로 자연스럽게 전환되는 멀티-아크 모양을 디자인했습니다. WPF에서 이러한 모양을 구현하는 방법에는 미리 그려진 이미지를 사용하거나 프로젝트에서 직접 Path 속성을 사용하여 그리는 방법이 있습니다. 이 모양의 독특함과 계산 복잡성을 고려하여, 우리는 더 간단하고 편리한 방법을 찾았습니다.

이때 Microsoft Blend가 이 특별한 모양을 쉽게 그리는 데 유용합니다.

### 그리기 방법:
디자인 과정은 아래쪽에 볼록한 아크가 있는 큰 원을 그린 다음, 큰 원의 양쪽에 같은 높이에 작은 원을 추가하는 것을 포함합니다. 큰 원의 지름을 조정함으로써 큰 원과 작은 원이 완벽하게 교차하게 합니다.

다음으로, 병합 기능을 사용하여 먼저 큰 원의 필요 없는 부분을 잘라내고, 빼기 기능을 사용하여 작은 원의 원하지 않는 부분을 제거하여, 교차점에서 아크 모양만 남깁니다. 마지막으로 사각형을 추가하고 필요 없는 부분을 제거하여 독특하고 자연스러운 아크 모양을 만듭니다.

이 혁신적인 디자인 방법은 복잡한 그래픽을 처리하는 WPF와 Blend의 강력한 기능을 보여줄 뿐만 아니라, 디자인 문제를 생각하고 해결하는 새로운 관점을 제공합니다. 이 접근 방식을 통해 서클 섹션의 디자인은 미적으로 매력적일 뿐만 아니라 기술적 실행에서도 혁신적이고 유연하며, 전체 매직 네비게이션 바에 독특한 매력을 추가합니다.

## 3.애니메이션 생성
### ✨ ListBoxItem 영역 아이콘 및 텍스트 이동 애니메이션:

XAML에서 IsSelected 속성 트리거를 추가함으로써 ListBoxItem 영역에서 아이콘과 텍스트가 상하로 움직이는 애니메이션을 구현할 수 있습니다. ListBoxItem이 선택되거나 선택 해제될 때의 동작을 정의할 수 있습니다.
### Storyboard 개념:
WPF에서 Storyboard는 일련의 애니메이션을 정의하는 데 사용되는 컨테이너입니다. 시간축에서 순차적 또는 동시에 재생되는 여러 애니메이션 요소를 포함할 수 있어 복잡한 애니메이션 시퀀스를 만들 수 있습니다. 여기에서, 선택된 및 선택되지 않은 Storyboard를 추가하여 아이콘과 텍스트의 위치를 이동하면서 동시에 색상을 변경하는 애니메이션 효과를 표시합니다.
```xaml
<ControlTemplate.Triggers>
<Trigger Property="IsSelected" Value="True">
<Trigger.EnterActions>
<BeginStoryboard Storyboard="{StaticResource Selected}"/>
</Trigger.EnterActions>
<Trigger.ExitActions>
<BeginStoryboard Storyboard="{StaticResource UnSelected}"/>
</Trigger.ExitActions>
</Trigger>
</ControlTemplate.Triggers>
```
## ⚙️ 애니메이션 속성:
- ### 모드:
CubicEaseInOut은 애니메이션의 가속 및 감속을 제어하는 이징 함수로, 더 자연스러운 느낌을 줍니다.
- ### TargetName:
애니메이션을 적용할 요소의 이름을 지정합니다.
- ### Duration:
애니메이션의 총 지속 시간입니다.
- ### Property:
Margin 또는 Fill.Color과 같은 애니메이션을 적용할 속성을 정의합니다.
```xaml
<Storyboard x:Key="Selected">
    <james:ThickItem Mode="CubicEaseInOut" TargetName="icon"
                     Duration="0:0:0.5" Property="Margin" To="0 -80 0 0"/>
    <james:ThickItem Mode="CubicEaseInOut" TargetName="name"
                     Duration="0:0:0.5" Property="Margin" To="0 45 0 0"/>
    <james:ColorItem Mode="CubicEaseInOut" TargetName="icon"
                     Duration="0:0:0.5" Property="Fill.Color" To="#333333"/>
    <james:ColorItem Mode="CubicEaseInOut" TargetName="name"
                     Duration="0:0:0.5" Property="Foreground.Color" To="#333333"/>
</Storyboard>
<Storyboard x:Key="UnSelected">
    <james:ThickItem Mode="CubicEaseInOut" TargetName="icon"
                     Duration="0:0:0.5" Property="Margin" To="0 0 0 0"/>
    <james:ThickItem Mode="CubicEaseInOut" TargetName="name"
                     Duration="0:0:0.5" Property="Margin" To="0 60 0 0"/>
    <james:ColorItem Mode="CubicEaseInOut" TargetName="icon"
                     Duration="0:0:0.5" Property="Fill.Color" To="#44333333"/>
    <james:ColorItem Mode="CubicEaseInOut" TargetName="name"
                     Duration="0:0:0.5" Property="Foreground.Color" To="#00000000"/>
</Storyboard>
```

### ✨ 원형 구성 요소의 움직임:


원형 구성 요소의 움직임은 클릭된 위치에 따라 정확하게 계산되어야 하므로 XAML에서 구현할 수 없고 C# 코드에서 처리해야 합니다.

- ### OnApplyTemplate 메소드:
이 메소드는 MagicBar 컨트롤의 라이프사이클에서 중요한 메소드입니다. 컨트롤의 템플릿이 적용될 때 호출됩니다. 이 메소드 내에서, 우리는 기본 클래스의 OnApplyTemplate 메소드를 호출하여 모든 표준 초기화 단계가 실행되도록 합니다. 그런 다음 GetTemplateChild 메소드를 사용하여 "PART_Circle"이라는 이름의 Grid 요소를 검색합니다. 이 Grid는 사용자 상호작용 중에 애니메이션 효과를 표시하는 애니메이션의 대상 요소일 가능성이 높습니다.
```css
public override void OnApplyTemplate()
{
    base.OnApplyTemplate();
    Grid grid = (Grid)GetTemplateChild("PART_Circle");

    InitStoryboard(grid);
}
```

- ### InitStoryboard 메소드:
이 메소드는 애니메이션을 초기화하는 역할을 합니다. ValueItem (_vi) 및 Storyboard (_sb)의 인스턴스를 먼저 생성합니다. ValueItem에 설정된 이징 함수는 QuinticEaseInOut으로, 애니메이션의 시작과 끝에서 느려지고 중간에 가속되어 애니메이션을 부드럽고 자연스럽게 보이게 합니다. 애니메이션은 Canvas.LeftProperty 속성에 영향을 미치며, 이는 대상 요소의 수평 위치를 변경한다는 것을 나타냅니다. 애니메이션의 지속 시간은 0.5초로 설정됩니다. 마지막으로, 애니메이션 대상은 전달된 원형 (Grid) 요소로 설정되며, 애니메이션은 스토리보드에 추가됩니다.
```css
private void InitStoryboard(Grid circle)
{
    _vi = new();
    _sb = new();

    _vi.Mode = EasingFunctionBaseMode.QuinticEaseInOut;
    _vi.Property = new PropertyPath(Canvas.LeftProperty);
    _vi.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));

    Storyboard.SetTarget(_vi, circle);
    Storyboard.SetTargetProperty(_vi, _vi.Property);

    _sb.Children.Add(_vi);
}
```
OnSelectionChanged 메소드:
이 오버라이드된 메소드는 MagicBar의 선택된 항목이 변경될 때 트리거됩니다. 메소드는 기본 클래스의 OnSelectionChanged 메소드를 호출하여 표준 동작이 실행되도록 합니다. 그런 다음, 선택된 항목의 인덱스를 기준으로 _vi의 To 속성을 설정하여 애니메이션 종료 시 Canvas.LeftProperty의 값을 결정합니다. 애니메이션은 요소를 SelectedIndex에 비례하는 위치로 이동시킵니다. 마지막으로 _sb.Begin()을 호출함으로써 스토리보드가 시작되고 애니메이션이 재생됩니다.

```css
protected override void OnSelectionChanged(SelectionChangedEventArgs e)
{
    base.OnSelectionChanged(e);

    _vi.To = SelectedIndex * 80;
    _sb.Begin();
}
```





