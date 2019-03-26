[← Requirements](0-Requirements-EN.md) | SSL Verify[(中文)](1-Verify-CN.md) | [Debug →](2-Debug-EN.md)
***

# SSL Verify
## Summary
Describes the SSL certificate verification behavior of a request.
- Set `false` to disable certificate validation, (This is not safe, please set certificates! ). When you want to turn off the verification of the HTTPS certificate on the client, you can set it at the Client or Request level.

## Default
- `false` 

## Setting
### Setting on Client and Request

```c#
//  Client level certificate ignores verification
client.SetHttpsInsecure(true);

// Request level certificate ignores verification
request.SetHttpsInsecure(true);
```

***
[← Requirements](0-Requirements-EN.md) | SSL Verify[(中文)](1-Verify-CN.md) | [Debug →](2-Debug-EN.md)
