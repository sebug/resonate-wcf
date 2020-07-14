# Resonate WCF
Trying out [Core WCF](https://github.com/CoreWCF/CoreWCF) and the movie database API to discover some movies to watch.

This project will be structured like a legacy N tiers application, seeing
what is available on this API surface.

There's currently no deployed version, but I guess I'll put it on Kubernetes
at one point.

To consume the service reference on the client layer you'll need dotnet-svcutil

	dotnet tool install --global dotnet-svcutil
