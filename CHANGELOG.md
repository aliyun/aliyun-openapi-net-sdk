# Unreleased

- Use HMAC-SHA256 by default for Signature V2 requests signed with AccessKey credentials, including STS credentials. SignatureVersion remains 1.0; RSA and bearer token signing are unchanged.
- Add DefaultAcsClient.UseHmacSHA1 for user-configured HMAC-SHA1 compatibility without changing RSA or bearer token authentication. Keep explicit signer selection through DoAction.
