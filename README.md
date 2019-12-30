<h1><svg
            class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true">
            <path fill-rule="evenodd"
                d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z">
            </path>
        </svg>遇過問題文件</h1>

<p><strong>NOTE:</strong></p>

<hr>

<h3 ><svg
            class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true">
            <path fill-rule="evenodd"
                d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z">
            </path>
        </svg>使用'Content-Type': 'application/json'</br></h3>
<p>options需先預檢請求</p>
<p>webapi 需刪除<remove name="OPTIONSVerbHandler" /></p>
<p>並加入</p>
<ul>
    <li><a href="#">system.webServer</a></li>
   
    <li><a href="#">httpProtocol</a></li>
      
             <li><a href="#">customHeaders</a></li>
        
                <li><a href="#">add name="Access-Control-Allow-Origin" value="*" /</a></li>
                <li><a href="#">add name="Access-Control-Allow-Methods" value="GET, PUT, POST, DELETE, HEAD" /</a></li>
              <li><a href="#">add name="Access-Control-Allow-Headers" value="Origin, X-Requested-With, Content-Type, Accept" /</a>                      </li>

          
        
   
 </ul>
