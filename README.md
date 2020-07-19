# Resonate WCF
Trying out [Core WCF](https://github.com/CoreWCF/CoreWCF) and the movie database API to discover some movies to watch.

This project will be structured like a legacy N tiers application, seeing
what is available on this API surface.

There's currently no deployed version, but I guess I'll put it on Kubernetes
at one point.

## Environment variables for local testing
You'll have to hint at the service layer base address by setting RESONATE_ServiceBaseAddress. On a Mac, if you want it to be picked up, put it in ~/Library/LaunchAgents/environment.plist :

	launchctl setenv RESONATE_ServiceBaseAddress https://localhost:5001
