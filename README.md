# Proxy

In this example, the Client class interacts with the RealSubject class through the Subject interface, and the Proxy class acts as a substitute for the RealSubject. 

The Request method of the RealSubject returns the string "RealSubject", but the Request method of the Proxy returns the same string, even though it may be deferring the work to the RealSubject. 

The proxy acts as an intermediary between the client and the real subject, and it can add additional functionality, such as access control, caching, and lazy initialization, to the underlying object. 

The Proxy pattern provides a flexible and reusable way to control the access to an object, without having to modify its underlying implementation.