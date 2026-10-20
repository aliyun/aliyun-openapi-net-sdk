# Unreleased

- Use HMAC-SHA256 by default for Signature V2 requests signed with AccessKey credentials, including STS credentials. SignatureVersion remains 1.0; RSA and bearer token signing are unchanged.
- Keep HmacSHA1Signer available for explicit compatibility requests through DoAction.
- Add offline RPC/ROA signing and compatibility regression tests.
