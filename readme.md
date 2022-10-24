# Project Structure
## Pages folder: 
Contains the routable components/pages (.razor) that make up the Blazor app and the root Razor page of a Blazor Server app. The route for each page is specified using the @page directive. The template includes the following:

* _Host.cshtml: The root page of the app implemented as a Razor Page:
 * When any page of the app is initially requested, this page is rendered and returned in the response.
 * The Host page specifies where the root App component (App.razor) is rendered.
* _Layout.cshtml: The layout page for the _Host.cshtml root page of the app.
Counter component (Counter.razor): Implements the Counter page.
* Error component (Error.razor): Rendered when an unhandled exception occurs in the app.
* Index component (Index.razor): Implements the Home page.

App.razor: The root component of the app that sets up client-side routing using the Router component. The Router component intercepts browser navigation and renders the page that matches the requested address.

_Imports.razor: Includes common Razor directives to include in the app's components (.razor), such as @using directives for namespaces.

# Project History
* Start by adding services.AddRazorPages() inside the ConfigureServices method. It is needed since Blazor needs Razor Pages support to work.
* Next, add services.AddServerSideBlazor() inside the ConfigureServices method. This adds Server-Side Blazor services to the service collection.
* Next add endpoints.MapBlazorHub() inside the app.UseEndpoints() method of the Configure method. This integrates the Blazor with ASP.NET Core Endpoint Routing. This will also let SignalR which is the part of ASP.NET Core that handles the persistent HTTP request to work properly.

# Razor Components

Blazor apps are built using components. These components are implemented in Razor Component files and these files have a .razor extension. In razor component you write your Blazor codes. They typically contains:

* The razor component file contains a mixture of HTML and C# and uses the familiar Razor syntax.
* C# code is defined in an @code block

# _Imports.razor

Blazor Imports File (_Imports.razor) let you to import commonly used namespaces at one place so that you don’t have to import them separately on each Razor component that needs them.

Right click on the project name in the Solution Explorer and select Add ➤ New Item. You will see an Add New Item window opens up and it contains a lot of different files that can be selected. Here select Razor Component and name it as _Imports.razor. Click the Add button to create this file in the application’s root folder.

Once the Blazor Imports file is created simply add the following 2 codes lines to it:

```csharp 
@using Microsoft.AspNetCore.Components.Routing
@using BlazorFirstApp.Shared
```
* You can add a file called _Imports.razor to every folder of the application. The .NET will include the directives specified in the Blazor Imports File for all of the Razor templates that lie in the same folder or any of it’s subfolders.
* You can also specify layouts in the Blazor Imports file for razor component. For example – @layout MyLayout ensures that all of the components in a folder and subfolder uses MyLayout.

# App.razor 

Blazor Router component. 

Blazor uses ASP.NET Core Routing system for selecting component based on URLs. So Blazor applications responds to changes in the URL by displaying different Razor Components. To get started, add a new Razor Component on the application’s root folder and call it App.razor. Add the following given codes to it:

```csharp 
<Router AppAssembly="@typeof(Startup).Assembly">
    <Found Context="routeData">
        <RouteView RouteData="@routeData" DefaultLayout="@typeof(MainLayout)" />
    </Found>
    <NotFound>
        <LayoutView Layout="@typeof(MainLayout)">
            <p>Sorry, there's nothing at this address.</p>
        </LayoutView>
    </NotFound>
</Router>
```

# Endpoint Routing integration in Blazor

Blazor works with ASP.NET Core Endpoint Routing. I have already integrated it by adding the code – endpoints.MapBlazorHub() inside the app.UseEndpoints method of the Configure method of Startup.cs class.

# Fallback Route _Host.cshtml

In case if we are using a standalone Blazor app, where there are only Components and no Views or Razor Pages, then we have to use a Fallback Route which will call a Razor page by the name of _Host.cshtml. The fallback route has a very low priority in routing matching and so this route is initiated when other routes didn’t match.

Create a new Razor View called _Host.cshtml inside the Pages folder of your app. Add the following code to it:

```csharp
@page "/"
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@{
    Layout = null;
}
 
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Blazor First App</title>
    <base href="~/" />
</head>
<body>
    <component type="typeof(BlazorFirstApp.App)" render-mode="ServerPrerendered" />
 
    <script src="_framework/blazor.server.js"></script>
</body>
</html>
```

# Blazor Layouts

You must have noticed that in a website or an app, the header and footer elements remain same through the app. The things which are kept on the header and footer elements are logos, copyright text, navigation menu, etc and these never change.

The best approach would be to keep the header and footer elements in a common area called layout files and all the component of the Blazor app should call these layout files and show up these common areas (header & footer) on their respective places.

Since the layout is shared with other components therefore the layout file is kept inside the Shared folder. The Shared folder is kept just inside the root folder of the APP. If you haven’t created it till now so first create it by right clicking the name of the app and selecting Add ➤ New Folder then name this folder as "Shared".

Next, inside this shared folder create a new razor component called MainLayout.razor, and add the below code to it:

```csharp
@inherits LayoutComponentBase
 
<header>
    <nav>
        <a href="/">Home</a>
        <a href="about">About</a>
        <a href="contact">Contact</a>
    </nav>
</header>
 
@Body
 
<footer>
    All Rights Reserved
</footer>
```

The important thing to note is that the layout must inherit from the LayoutComponentBase which is done by the code – @inherits LayoutComponentBase.

The Razor syntax @Body specifies the location in the layout where the component’s content is rendered.




``` powershell 

# Project Structure
BlazorZero> mkdir BlazorZero
BlazorZero> cd BlazorZero
BlazorZero\BlazorZero> dotnet new web
BlazorZero\BlazorZero> cd ..
BlazorZero> dotnet new sln
BlazorZero> dotnet sln add .\BlazorZero\.

```

# Termian Window (Ctrl+")

# VSCode Commands (Ctrl+Shift+P )

* .NET: Generate Assetst for Build and Debug 
#IF Error: Unable to generate assets to build and debug. OmniSharp server is not running.
* OmniSharp: Restart OmniSharp

# Git

```bash
# First Commit
git init
git add .
git commit -m "First Commit"
git remote add origin https://github.com/emremumcu/blazorzero.git
git remote -v
git push -f origin master

# Next Commits
git add .
git status
git commit -m "Bug fixes and updates"
git status
git push -f origin master
```


``` text
[Feature name]                          [AddMVC] [AddControllersWithViews] [AddControllers] [Add RazorPages]
Core Services (AddMvcCore())            | Yes | Yes | Yes | Yes |
Controllers                             | Yes | Yes | Yes | Yes |
Model Binding                           | Yes | Yes | Yes | Yes |
API Explorer                            | Yes | Yes | Yes | No  |
Authorization                           | Yes | Yes | Yes | Yes |
CORS                                    | Yes | Yes | Yes | No  |
Validations                             | Yes | Yes | Yes | Yes |
Formatter Mapping                       | Yes | Yes | Yes | No  |
Antiforgery                             | Yes | Yes | No  | Yes |
Temp Data                               | Yes | Yes | No  | Yes |
Views                                   | Yes | Yes | No  | Yes |
Razor Pages                             | Yes | No  | No  | Yes |
Razor View Engine(Tag helpers etc.      | Yes | Yes | No  | Yes |
Memory  cache                           | Yes | Yes | No  | Yes |
```

# References

https://learn.microsoft.com/en-us/aspnet/core/blazor/project-structure?view=aspnetcore-6.0


http://binaryintellect.net/articles/c50d3f14-7048-4b4f-84f4-1b28cb0f9d96.aspx


Store MVC views in a different location

services.Configure<RazorViewEngineOptions>(o =>
    {
        o.ViewLocationFormats.Clear();
        o.ViewLocationFormats.Add
("/MyViewsFolder/{1}/{0}" + RazorViewEngine.ViewExtension);
        o.ViewLocationFormats.Add
("/MyViewsFolder/Shared/{0}" + RazorViewEngine.ViewExtension);
    });

Store Razor Pages in a different location

services.AddRazorPages(); or services.AddMvc();
services.Configure<RazorPagesOptions>
(options => options.RootDirectory = "/MyPagesFolder");

services.AddRazorPages()
            .WithRazorPagesRoot("/MyPagesFolder");