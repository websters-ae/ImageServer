# ImageServer

### Usage
Add handlers in a `web.config` file
```xml
...
<system.webServer>
    <handlers>
      <add name="Handler for JPG" path="*.jpg" verb="GET" type="ImageServer.ImageHandler" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for JPEG" path="*.jpeg" verb="GET" type="ImageServer.ImageHandler" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for TIFF" path="*.tiff" verb="GET" type="ImageServer.ImageHandler" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for BMP" path="*.bmp" verb="GET" type="ImageServer.ImageHandler" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for PNG" path="*.png" verb="GET" type="ImageServer.ImageHandler" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for GIF" path="*.gif" verb="GET" type="ImageServer.ImageHandler" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="Handler for ICO" path="*.ico" verb="GET" type="ImageServer.ImageHandler" preCondition="integratedMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
    </handlers>
<system.webServer>
...
```