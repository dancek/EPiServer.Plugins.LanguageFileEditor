# Language file editor for EPiServer CMS 7

This is basically [Mathias Kunto's language editor for EPiServer CMS 6 R2](http://blog.mathiaskunto.com/2011/09/04/allowing-web-administrators-to-dynamically-update-episerver-language-files/), with just enough modifications to make it work with EPiServer 7.

There are a lot of things to improve, but it does work. I've made it more difficult to shoot yourself in the foot with this, but it's probably still possible. :)


## Original README, with installation instructions.

Language File Editor version 1.0 for EPiServer CMS 6 R2
http://blog.mathiaskunto.com/rss

Installation instructions:

* Drop the files in your solution.
* Update namespaces where necessary.
* Update JavaScript and CSS paths in LanguageFileEditor.aspx if necessary.
* Update Plugin path in LanguageFileEditor.aspx.cs if necessary.
* Update LoadControl path in EditableXmlNode.ascx.cs if necessary.
* Reference Newtonsoft.Json.Net35.dll or later (Available at http://json.codeplex.com/releases/view/64935)

More information at:
http://blog.mathiaskunto.com/2011/09/04/allowing-web-administrators-to-dynamically-update-episerver-language-files

Well formulated bug reports and constructive feedback is always welcome.

Disclaimer:
Always make backups. You are using this at your own risk,
and cannot hold the author responsible for anything that this may cause.

## TODO

I'm not sure I'll ever actually start doing these, but for the record:

* make this a project, instead of code that you copy to your project
* make a NuGet package
* allow changing language for a file (I prevented this because invalid language codes break the entire site)
* support multiple localization providers (the first one with a virtual path is picked now)
* enhance UI
* add an open source license (need to discuss with Mathias, as he's the author of almost all the code; current terms are "Go ahead and use it / change it as you wish :)")
