Blazor Schools Readme

Stewart Hyde

Introduction
============

This is basically a test application which I created because of problems I
notice with Blazor Webassembly. The initial plan was to have Webassembly ASP.Net
core logic call and another server which would be consider the master for some
specific information. But I decided to make a test application and to explored
creating an additional second ASP.Net Core server but while working I wonder if
the client could cause two servers.

Steps I use to create the project
=================================

1. Build Sample Blazor WebAssembly App with ASP.Core Hoot on

2. Add simple API request and page for testing purposes

3. Clone Server component for new Server with different ports

4. Update clone so it is different and update client to call it

5. Separate the Passthrough server calls from Client calls because of client
issue

6. Add External Json API as part of the test for Passthrough

Technical Issue with Calling another Service though client
==========================================================

There is a technical issue with connection gets refused with when calling a
separate Json service from the client. The connection gets refused. This is with
same code that sits in Shared folder. This code works successfully from ASP.Net
Core logic which is what I refer to Passthrough which was original plan. This
works with both 2nd clone ASP.Net Core server and external JSON API. The simple
API server request is design just to return status message in the process. This
simple API server is part of clone ASP.Net Core. I create a Stack overflow
question concerning this problem

<https://stackoverflow.com/questions/62313078/httpclientfactory-and-webassembly-net-core-hosted-crashes-on-on-client>
