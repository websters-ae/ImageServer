# ImageServer

### Usage
Add handlers in a `web.config` file
```xml
...
<system.webServer>
    <handlers>
      <remove name="Handler for PNG"/>
      <remove name="Handler for JPG"/>
      <remove name="Handler for JPEG"/>
      <remove name="Handler for TIFF"/>
      <remove name="Handler for BMP"/>
      <remove name="Handler for GIF"/>
      <remove name="Handler for ICO"/>
      <add name="Handler for JPG" path="*.jpg" verb="GET" type="Websters.Web.ImageHandler, Websters.Web" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for JPEG" path="*.jpeg" verb="GET" type="Websters.Web.ImageHandler, Websters.Web" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for TIFF" path="*.tiff" verb="GET" type="Websters.Web.ImageHandler, Websters.Web" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for BMP" path="*.bmp" verb="GET" type="Websters.Web.ImageHandler, Websters.Web" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for PNG" path="*.png" verb="GET" type="Websters.Web.ImageHandler, Websters.Web" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for GIF" path="*.gif" verb="GET" type="Websters.Web.ImageHandler, Websters.Web" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for ICO" path="*.ico" verb="GET" type="Websters.Web.ImageHandler, Websters.Web" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
    </handlers>
<system.webServer>
...
```