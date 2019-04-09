[← Packages](5-Packages-EN.md) | Log[(中文)](6-Log-CN.md) | [Client →](7-Client-EN.md)
***

# Log
The logger is mainly used to provide support for auditing, to record each call, similar to the server's access log.

## Set Logger
To start the logger, pass in the [Logger](https://github.com/aliyun/aliyun-openapi-net-sdk/blob/master/aliyun-net-sdk-core/Utils/Logger.cs) object to client and you must configure the path address where the log will be stored. 
The log output level, log output template, and channel have default values ​​that you can specify explicitly.

```csharp
// Configure the Logger path
var logger = new Logger("< your log path >");
// Explicitly specify Level
var logger = new Logger(loggerPath : "< your log path >", level : "Error")

client.SetLogger(logger);
```

## Log Format
- `LoggerPath` must be specified.
- The default `LoggerTemplate` value is: `{start_time} {channel} [{level}] {method} {uri} {version} {code} {cost} {hostname} {pid} {NewLine}`.
- The default `Level` value is `Info`.
- The default `Channel` value is `AlibabaCloud`.

## Variables

| Variable      |   Description       |
|----------|-------------|
| {level}     | Level of the log |
| {channel}     | name of the log |
| {request}     | Full HTTP request message |
| {response}     | Full HTTP response message |
| {host}     | Host of the request |
| {method}     | Method of the request |
| {uri}     | URI of the request |
| {version}     | Protocol version |
| {target}     | Request target of the request (path + query + fragment) |
| {hostname}     | Hostname of the machine that sent the request |
| {code}     | Status code of the response (if available) |
| {error}     | Any error messages (if available) |
| {req_headers}     | Request headers |
| {res_headers}     | Response headers |
| {pid}     | PID |
| {cost}     | Cost Time |
| {start_time}     | Start Time |

***
[← Packages](5-Packages-EN.md) | Log[(中文)](6-Log-CN.md) | [Client →](7-Client-EN.md)