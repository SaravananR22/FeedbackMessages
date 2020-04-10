# FeedbackMessages

[![Build status](https://ci.appveyor.com/api/projects/status/p8ia0pbkjtqx9i50?svg=true)](https://ci.appveyor.com/project/try0/feedbackmessages)

ASP.NET feedback messages utility.  
Feedback messages to web-client, users easily.  
Messages that could not be rendered in the current request are persisted in the session.


## Usage

[NuGet](https://www.nuget.org/packages/FeedbackMessages/)

In code behind of component that inherits System.Web.UI.Control
```C#
using FeedbackMessages.Extensions;

...

this.InfoMessage("Information feedback message.");
this.SuccessMessage("Success feedback message.");
this.WarnMessage("Warning feedback message.");
this.ErrorMessage("Error feedback message.");

```


.aspx file
```xml
  <%@ Register Assembly="FeedbackMessages" Namespace="FeedbackMessages.Components" TagPrefix="fm" %>
  
   <!-- render message area -->
  <fm:FeedbackMessagePanel runat="server" ID="FeedbackMessagePanel"></fm:FeedbackMessagePanel>
```
