[← 产品Nuget包](5-Packages-CN.md) | 日志[(English)](6-Log-EN.md) | [环境要求 →](0-Requirements-CN.md)
***

# 日志
logger 主要用于提供支持审计的能力，用于记录每次的调用情况，类似服务端的 access log。

## 设置 Logger
若要启动日志功能，请传入 [Logger](..\aliyun-net-sdk-core\Utils\Logger.cs) 对象，您必须配置存放日志的路径地址。而日志输出级别，日志输出模板以及 channel 都有默认值，您可以显式指定。

```csharp
// 配置 Logger 路径
var logger = new Logger("< your log path >");
// 显式指定 Level 等
var logger = new Logger(loggerPath : "< your log path>", level : "Error")

client.SetLogger(logger);
```

## 日志格式化
- 必须指定 `LoggerPath`。
- 默认 `LoggerTemplate` 为：`{start_time} {channel} [{level}] {method} {uri} {version} {code} {cost} {hostname} {pid} {NewLine}`。
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
[← 产品Nuget包](5-Packages-CN.md) | 日志[(English)](6-Log-EN.md) | [环境要求 →](0-Requirements-CN.md)