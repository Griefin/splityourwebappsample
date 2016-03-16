# Split your Web App Sample

A sample web application comprised of several ASP.NET MVC applications that work seamlessly together

This sample is an hypothetical store that sells music and movies. The main application is configured to deal with signing in users and then there are two other sub web applications, one for music, and another for movies. 

When you run the apps it looks like just one website. Read more about this here: [Split your web application into smaller web applications](http://www.blinkingcaret.com/2016/03/16/split-your-web-application-into-smaller-web-applications/)

The apps are setup to run in (Local) IIS, you’ll have to setup the main app to run on port 48000 using IIS Manager or else you’ll get an error while opening the project in Visual Studio, also you will need to make sure all projects are built before running the main web application

