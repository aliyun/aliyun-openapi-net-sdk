# Unreleased

- Use HMAC-SHA256 by default for Signature V2 requests signed with AccessKey credentials, including STS credentials. SignatureVersion remains 1.0; RSA and bearer token signing are unchanged.
- Allow selecting a signer in DefaultAcsClient constructors for GetAcsResponse and GetCommonResponse, including HmacSHA1Signer compatibility requests. Keep existing per-request signer overrides.
- Add offline RPC/ROA signing and compatibility regression tests.
