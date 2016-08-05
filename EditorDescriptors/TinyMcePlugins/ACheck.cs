using EPiServer.Editor.TinyMCE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OxxCommerceStarterKit.Web.EditorDescriptors.TinyMcePlugins
{
    [TinyMCEPluginButton(
        PlugInName = "acheck", 
        //EditorInitConfigurationOptions = "{ accessibility_warnings: true }", 
        ButtonName = "acheck", 
        GroupName = "misc",
        LanguagePath = "admin/tinymce/plugins/acheck", 
        IconUrl = "Editor/tinymce/plugins/acheck/img/acheck.gif",
        Description = "Accessibility Checker",
        DisplayName = "Accessibility Check")]
    public class ACheck
    {
    }
}