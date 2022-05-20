# UnityCode
记录一些收集的代码

# Android打包失败记录
buildtools 31 以上不兼容老版本

修改步骤
1. 勾选 curstom launcher gradle template
2. 勾选 curstom main gradle template
3. launcherTemplate修改 buildToolsVersion 'BUILDTOOLS'-》buildToolsVersion '30.0.3'
4. mainTemplate修改 buildToolsVersion 'BUILDTOOLS'-》buildToolsVersion '30.0.3'
