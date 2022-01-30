# Web API token based authentication

Web API token based authentication.

Token-based authentication is a process where the client application first sends a request to Authentication server with a valid credentials. The Authentication server sends an Access token to the client as a response. This token contains enough data to identify a particular user and it has an expiry time. The client application then uses the token to access the restricted resources in the next requests until the token is valid. If the Access token is expired, then the client application can request for a new access token by using Refresh token.


Error Handling:
Authentication failure when incoming request contains invalied client key, ivalid access token or refresh token or has invalid signature.
