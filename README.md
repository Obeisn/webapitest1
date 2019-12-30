# webapitest1
使用'Content-Type': 'application/json'
options需先預檢請求
webapi 需刪除<remove name="OPTIONSVerbHandler" />
並加入
system.webServer
       ->httpProtocol
             ->customHeaders
        <add name="Access-Control-Allow-Origin" value="*" />
        <add name="Access-Control-Allow-Methods" value="GET, PUT, POST, DELETE, HEAD" />
        <add name="Access-Control-Allow-Headers" value="Origin, X-Requested-With, Content-Type, Accept" />
