# ThemeSwitch
![KakaoTalk_20231031_192326142](https://github.com/jamesnet214/themeswitch/assets/101777355/04becee5-667b-4df8-a11a-59151610a338)
### 🔍 Preview

| Video demo 1 |  Video demo 2 | 
|:----:|:----:|
|  <video src="https://github.com/jamesnet214/themeswitch/assets/101777355/6bcd95fd-63cd-4b3b-8bec-9c0b8ad4006e" />  | <video src="https://github.com/jamesnet214/themeswitch/assets/101777355/1b0522cf-cbc6-4826-a697-9a061c81b503" /> |



## ⛅️/🌙 ThemeSwitch


#### ThemeSwitch 버튼은 ToggleButton을 상속 받아 만든 CustomControl입니다. 이 컨트롤은 NuGet Package를 통해 다운로드 받을 수 있고, GitHub 레포지터리를 통해 원본 소스코드와 사용 방법이 포함된 데모 프로젝트 실행이 가능합니다.

### ✨ 사용된 애니메이션
#### 🔘 ValueItem(DoubleAnimation): 
#### 🔘 ThickItem(ThicknessAnimation)： 
#### 🔘 ColorItem(ColorAnimation): 

```xml
<Storyboard x:Key="SlideOut">
    <james:ThickItem TargetName="cloud1" Property="Margin" Mode="EaseInOut" Duration="0:0:0.5" To="-70 20 0 0"/>
    <james:ThickItem TargetName="cloud2" Property="Margin" Mode="EaseInOut" Duration="0:0:0.5" To="-60 30 0 0"/>
    <james:ThickItem TargetName="cloud3" Property="Margin" Mode="EaseInOut" Duration="0:0:0.5" To="135 20 0 0"/>
    <james:ThickItem TargetName="cloud4" Property="Margin" Mode="EaseInOut" Duration="0:0:0.5" To="125 30 0 0"/>
    <james:ThickItem TargetName="ellipse" Property="Margin" Mode="EaseInOut" Duration="0:0:0.5" To="74 4 4 4"/>
    <james:ThickItem TargetName="galaxy" Property="Margin" Mode="EaseInOut" Duration="0:0:0.5" To="0 0 0 0"/>
    <james:ColorItem TargetName="ellipse" Property="(Fill).Color" Mode="EaseInOut" Duration="0:0:0.5" To="#E5B91A"/>
    <james:ColorItem TargetName="border" Property="(Background).Color" Mode="EaseInOut" Duration="0:0:0.5" To="#191C25"/>
    <james:ValueItem TargetName="galaxy" Property="Opacity" Mode="EaseInOut" Duration="0:0:0.5" To="1"/>
</Storyboard>
```

### 사용된 이미지
##### *Visual Studio에서 직접 그리는 방법도 유튜브영상에 공개할 예정
#### 구름
#### 밤하늘의 별들






