# guid

Simple tool to make a guid.

```sh
> guid
f17286c8-b9e5-4d28-936c-922b36619695


> guid --help
guid version 1.0.0
guid creates a Version 4 Universally Unique Identifier (UUID) as described in RFC 4122, Sec. 4.4.
Options:
-h|--help       This help.
-v|--version    The version of guid.

Print options
d is the default option.
n   cd5c62eb3f1a49f28df95142f60489f4
d   cd5c62eb-3f1a-49f2-8df9-5142f60489f4
b   {cd5c62eb-3f1a-49f2-8df9-5142f60489f4}
p   (cd5c62eb-3f1a-49f2-8df9-5142f60489f4)
x   {0xcd5c62eb,0x3f1a,0x49f2,{0x8d,0xf9,0x51,0x42,0xf6,0x04,0x89,0xf4}}
N   CD5C62EB3F1A49F28DF95142F60489F4
D   CD5C62EB-3F1A-49F2-8DF9-5142F60489F4
B   {CD5C62EB-3F1A-49F2-8DF9-5142F60489F4}
P   (CD5C62EB-3F1A-49F2-8DF9-5142F60489F4)
X   {0xCD5C62EB,0x3F1A,0x49F2,{0x8D,0xF9,0x51,0x42,0xF6,0x04,0x89,0xF4}}
```

## Building
If you have dotnet installed:  
```sh
dotnet publish --runtime linux-x64 -p:PublishSingleFile=true -p:PublishTrimmed=true
sudo cp _build/guid/bin/Release/net10.0/linux-x64/publish/guid /usr/bin
```
Otherwise, google it.  
