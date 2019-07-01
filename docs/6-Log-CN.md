[← 产品Nuget包](5-Packages-CN.md) | 日志[(English)](6-Log-EN.md) | [客户端 →](7-Client-CN.md)
***

# 日志
logger 主要用于提供支持审计的能力，用于记录每次的调用情况，类似服务端的 access log，兼容了 NLog，Log4Net，Serilog 主流的日志类库，如果您的日志记录类库是以上的任意一种，无需额外配置即可打印出相应的 SDK 日志。

## 设置 Logger
若要启动日志功能，您可以通过 `DefaultAcsClient.EnableLogger()` 来开启默认日志格式的记录。

```csharp
DefaultAcsClient.EnableLogger("<输出格式>（可选）";

// 若不指定格式，则为下面的默认输出格式
DefaultAcsClient.EnableLogger();

DefaultAcsClient.DisableLogger();
```

## 日志格式化
- 默认 `LoggerTemplate` 为：`{channel} {method} {uri} {version} {code} {cost} {hostname} {pid}`。
- 默认 `Level` 为 `Info`。
- 默认 `Channel` 为 `AlibabaCloud`。

## 变量

| 变量      |   描述       |
|----------|-------------|
| {level}     | 日志级别 |
| {channel}     | 日志的对象 |
| {request}     | 完整的HTTP请求消息 |
| {response}     | 完整的HTTP响应消息 |
| {host}     | 请求主机 |
| {method}     | 请求方法 |
| {uri}     | 请求的URI |
| {version}     | 协议版本 |
| {target}     | 请求目标 (path + query + fragment) |
| {hostname}     | 发送请求的计算机的主机名 |
| {code}     | 响应的状态代码（如果可用） |
| {error}     | 任何错误消息（如果有） |
| {req_headers}     | 请求头 |
| {res_headers}     | 响应头 |
| {pid}     | PID |
| {cost}     | 耗时 |
| {start_time}     | 开始时间 |

***
[← 产品Nuget包](5-Packages-CN.md) | 日志[(English)](6-Log-EN.md) | [客户端 →](7-Client-CN.md)