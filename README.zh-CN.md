# NavigationBar [![English](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/Language-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/Language-한국어-red.svg)](README.ko.md) 

一个基于WPF ListBox的高级CustomControl，用于创建动画效果的移动风格导航栏

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/vickyqu115/navigationbar.svg)](https://github.com/vickyqu115/navigationbar/stargazers)
[![Issues](https://img.shields.io/github/issues/vickyqu115/navigationbar.svg)](https://github.com/vickyqu115/navigationbar/issues)

## 项目概述

NavigationBar是一个自定义WPF控件，展示了创建移动风格导航界面的高级技术。它展示了WPF在实现复杂UI行为和动画方面的强大功能和灵活性，特别关注CustomControl开发和高效动画设计。

[图片部分与英文版相同]

## 主要特性和实现
#### 1. 高级CustomControl开发
- [x] 扩展WPF ListBox以实现专门的导航功能
- [x] 使用纯XAML和C#实现复杂的UI元素
- [x] 优化的项目结构，通过单独的应用程序和库项目实现模块化

#### 2. 复杂的动画技术
- [x] 利用Jamesnet.Wpf动画包装类（ValueItem, ThickItem, ColorItem）实现简洁高效的动画
- [x] 自定义动画逻辑，实现导航项目之间的平滑过渡
- [x] 创新设计，使动画在ItemsPresenter外部运行，提高灵活性

#### 3. 基于XAML的矢量图形
- [x] 在Visual Studio for Blend中使用Path和Geometry创建复杂形状
- [x] 实现基于矢量的图标，实现可扩展和高质量的视觉效果

#### 4. 高级WPF概念
- [x] 为ListBox设计精妙的ControlTemplate，实现独特的布局和行为
- [x] 实现自定义ItemsPanel，实现灵活的项目布局

#### 5. 性能优化
- [x] 使用裁剪和布局技术实现高效渲染
- [x] 通过精心的资源管理优化动画性能

## 技术深入探讨
- **CustomControl架构**: 展示了WPF中CustomControl的强大功能，允许完全控制行为和外观。
- **ItemsPresenter外部动画**: 创新的方法设计在ItemsPresenter外部运行的动画，这是该控件的关键特性。
- **Jamesnet.Wpf动画集成**: 利用Jamesnet.Wpf的ValueItem, ThickItem和ColorItem实现简化且更易读的动画代码。
- **在Blend中创建Geometry**: 展示了使用Visual Studio for Blend直接创建复杂几何图形的方法，增强了设计过程。
- **ListBox ControlTemplate重新设计**: 完全重新设计ListBox模板，实现独特的导航栏布局和功能。

## 技术栈
- WPF (Windows Presentation Foundation)
- .NET 8.0
- C# 10.0
- XAML
- Jamesnet.Wpf (用于动画包装类)

## 项目结构
- 用于演示和测试的应用程序项目
- 用于NavigationBar控件的库项目，提高可重用性

## 入门指南
### 先决条件
- Visual Studio 2022或更高版本
- .NET 8.0 SDK

### 安装和执行
#### 1. 克隆仓库：

```
git clone https://github.com/vickyqu115/navigationbar.git
```

#### 2. 打开解决方案
- [x] Visual Studio
- [x] Visual Studio Code
- [x] Blend for Visual Studio
- [x] JetBrains Rider

[开发环境图片与英文版相同]

#### 3. 构建和运行
- [x] 设置启动项目
- [x] 按F5或点击运行按钮
- [x] 推荐使用Windows 11

## 学习资源
- [详细实现文章](https://jamesnet.dev/article/edit/110)
- [YouTube教程](https://bit.ly/3TVeRhF)
- [BiliBili教程](https://bit.ly/3UvaOsl)
- [CodeProject](https://www.codeproject.com/Articles/5375482/Customizing-ListBox-for-a-Smooth-Animated-Navigati)

## 贡献
欢迎为NavigationBar做出贡献！随时提交问题、创建拉取请求或提出改进建议。

## 许可证
该项目基于MIT许可证分发。有关详细信息，请参阅[LICENSE](LICENSE)文件。

## 联系方式
- 网站：https://jamesnet.dev
- 电子邮件：vickyqu115@hotmail.com, james@jamesnet.dev

使用NavigationBar探索高级WPF技术，创造引人入胜的导航体验！
