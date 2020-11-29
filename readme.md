# 好耶，是API

> BiliBili的部分API封装库
> 不会对账号或使用cookie的相关接口进行支持（如：登陆，发送动态等）

写这个库是因为想更方便的使用B站的Web API

对API的接口进行了封装

并且API返回值也封装为了抽象类

因为这个库是从[AntiRainBot](https://github.com/Yukari316/AntiRainBot)项目中单独分离出来的库，所以这个库的更新进度也和机器人的使用有关联

~~所以对我不使用接口可能不会进行适配~~

<details>
    <summary>目前支持的接口</summary>

    动态：纯文本、图片动态、转发动态、视频动态
    
    直播间：直播状态，房间信息
    
    用户：用户基本信息（空间）
</details>

