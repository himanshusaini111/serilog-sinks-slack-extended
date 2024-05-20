# serilog-sinks-slackextended

Extending the features of https://github.com/serilog-contrib/serilog-sinks-slack

NuGet
====
```
Install-Package Serilog.Sinks.SlackExtended
```

Usage
====

```csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Slack(new SlackSinkOptions
    {
        WebHookUrl = "https://hooks.slack.com/services/XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
        MaxFieldLength = int.MaxValue,
        MustHaveProperty = "LogToSlack"
    })
    .CreateLogger();
```
Other Options can be configured the same as the original package
