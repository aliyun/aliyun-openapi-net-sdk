[← Packages](5-Packages-EN.md) | Log[(中文)](6-Log-CN.md) | [Client →](7-Client-EN.md)
***

# Log
The logger is mainly used to provide support for auditing. It is used to record each call, similar to the server's access log, compatible with NLog, Log4Net, Serilog mainstream log class library, if your logging class library is any of the above. The corresponding SDK log can be printed without daditional configuration.

## Set Logger
To enable logging, you can enable logging of the default log format with `DefaultAcsClient.EnableLogger("<output format>"(optional))`.

```csharp
DefaultAcsClient.EnableLogger("<output format>(optional)");

// If no format is specified, it is the default output format in the Log Format Section.
DefaultAcsClient.EnableLogger();

DefaultAcsClient.DisableLogger();
```

## Log Format
- The default `LoggerTemplate` value is: `{channel} {method} {uri} {version} {code} {cost} {hostname} {pid}`.
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