# Accessibility Checker for Episerver TinyMCE

Simple addition of an accessibility checker plugin from ATutor to the TinyMCE editor found in Episerver 7.5+. This was added to a 9.x instance of Episerver and tested in only two sites.

Installation is simple. Add all folders/files to your project and correct the namespace of the class found in `~/EditorDescriptors/TinyMcePlugins`. Add languages as preferred in the included XML file.

Note that simply copying and pasting the folders into your project using Visual Studio might exclude the subfolders. Enable "Show All Files" in Solution Explorer to reveal the excluded folders. Right-click and "Include in Project" for all files and folders excluded. Usually, simply including folders at the top level will include all child folders and files as well.

Build, run, and enter admin mode to add the button to your desired editor configurations.
