Build with Release|iPhone or Release|iPhoneSimulator config

It will fail with:

```
MTOUCH : error MT2101: Can't resolve the reference 'System.Void System.IO.FileSystemAclExtensions::Create(System.IO.DirectoryInfo,System.Security.AccessControl.DirectorySecurity)', referenced from the method 'System.Void System.IO.Abstractions.DirectoryInfoWrapper::Create(System.Security.AccessControl.DirectorySecurity)' in 'System.IO.FileSystem.AccessControl, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.
```