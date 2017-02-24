# v2rayloader
My V2Ray Loader

配合GreenChrome食用。https://www.shuax.com/archives/ChromeUpdater.html

将`v2ray.exe`、`config.json`与`loader.exe`置于同一目录下。

`配置好GreenChrome后，v2ray将随Chrome启动，随Chrome关闭`，最重要的是不会出现控制台黑窗口。
```text
GreenChrome.ini
[启动时运行]
"%app%\V2Ray\loader.exe"
[关闭时运行]
"%app%\V2Ray\loader.exe" -exit
[基本设置]
自动结束运行程序=0
```
