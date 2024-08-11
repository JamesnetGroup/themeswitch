# ThemeSwitch [![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md) 

매력적인 애니메이션이 있는 주야간 테마 전환을 위한 사용자 정의 WPF ToggleButton 기반 컨트롤

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/vickyqu115/themeswitch.svg)](https://github.com/vickyqu115/themeswitch/stargazers)
[![Issues](https://img.shields.io/github/issues/vickyqu115/themeswitch.svg)](https://github.com/vickyqu115/themeswitch/issues)

## 프로젝트 개요

ThemeSwitch는 WPF ToggleButton을 기반으로 구축된 CustomControl로, WPF 애플리케이션에서 테마 전환을 위한 매력적인 시각적 요소를 제공하도록 설계되었습니다. 주간과 야간 테마 사이의 부드러운 전환을 위한 애니메이션을 특징으로 하며, 고급 WPF 기술과 사용자 정의 컨트롤 개발을 보여줍니다.

<img src="https://github.com/user-attachments/assets/b8d3b29e-2398-49b2-bb9d-59c5b0fa0aa1" width="49%"/>
<img src="https://github.com/user-attachments/assets/9c835cdf-dd08-4e2d-bacb-4183d8366b1e" width="49%"/>
<img src="https://github.com/user-attachments/assets/d77d1c5c-0f39-4d80-bbab-a47523c4a5f0" width="49%"/>
<img src="https://github.com/user-attachments/assets/334aaa17-493d-4e24-b9b5-d1fd2a6ad8aa" width="49%"/>
<img src="https://github.com/user-attachments/assets/83e5cbb5-c8d2-4dad-acd0-b3cae7dc9a6d" width="49%"/>
<img src="https://github.com/user-attachments/assets/f2fe09b0-1fc1-43d5-8351-df7e348bad67" width="49%"/>

## 주요 기능 및 구현 사항
#### 1. 사용자 정의 WPF 컨트롤 개발
- [x] 특수 기능을 위한 WPF ToggleButton 확장
- [x] XAML을 사용한 복잡한 UI 요소 구현

#### 2. 고급 애니메이션 기술
- [x] 세 가지 유형의 애니메이션: ValueItem (DoubleAnimation), ThickItem (ThicknessAnimation), ColorItem (ColorAnimation)
- [x] 주간과 야간 테마 사이의 부드러운 전환

#### 3. XAML 기반 디자인
- [x] 순수 XAML을 사용한 복잡한 모양 (태양, 구름, 달, 별) 생성
- [x] 현실적인 효과를 위한 불투명도 및 위치 조정 활용

#### 4. 성능 최적화
- [x] 클리핑 및 레이아웃 기술을 사용한 효율적인 렌더링
- [x] 외부 종속성 없는 부드러운 애니메이션

#### 5. 다중 프레임워크 호환성
- [x] 다중 타겟팅을 통한 다양한 .NET 프레임워크 지원

## 기술 스택
- WPF (Windows Presentation Foundation)
- .NET (다중 타겟팅 지원)
- C#

## 시작하기
### 필요 조건
- Visual Studio 2022 이상
- .NET SDK (프로젝트에 따른 버전)

### 설치 및 실행
#### 1. 리포지토리 복제:

```
git clone https://github.com/vickyqu115/themeswitch.git
```

#### 2. 솔루션 열기
- [x] Visual Studio
- [x] Visual Studio Code
- [x] JetBrains Rider

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

#### 3. 빌드 및 실행
- [x] 시작 프로젝트 설정
- [x] F5를 누르거나 실행 버튼 클릭
- [x] Windows 11 권장

## 학습 자료
- [구현에 대한 상세 아티클 (jamesnet.dev)](https://jamesnet.dev/article/109)
- [YouTube 튜토리얼 (영어)](https://bit.ly/3uBkFlQ)
- [BiliBili 튜토리얼 (중국어)](https://bit.ly/3uHFe08)
- [CodeProject 아티클](https://www.codeproject.com/Articles/5372268/Use-WPF-to-Create-a-Day-and-Night-Theme-Switch-But)  

## 기여하기
ThemeSwitch에 대한 기여를 환영합니다! 이슈를 제출하거나, 풀 리퀘스트를 생성하거나, 개선 사항을 제안해 주세요.

## 라이선스
이 프로젝트는 MIT 라이선스 하에 배포됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 연락처
- 웹사이트: https://jamesnet.dev
- 이메일: vickyqu115@hotmail.com, james@jamesnet.dev

매력적인 ThemeSwitch 컨트롤로 WPF 애플리케이션을 향상시켜 보세요!
