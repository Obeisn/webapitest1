使用'Content-Type': 'application/json'</br>
options需先預檢請求</br>
webapi 需刪除<remove name="OPTIONSVerbHandler" /></br>
並加入</br>
system.webServer</br>
       ->httpProtocol</br>
             ->customHeaders</br>
        <add name="Access-Control-Allow-Origin" value="*" /></br>
        <add name="Access-Control-Allow-Methods" value="GET, PUT, POST, DELETE, HEAD" /></br>
        <add name="Access-Control-Allow-Headers" value="Origin, X-Requested-With, Content-Type, Accept" /></br>
