Source: https://www.codeproject.com/Articles/4193/Magic-Library-Docking-Manager-Designer  
Disclaimer: All information is provided "as is" without any warranty.  
Upgrade: Upgraded to .NET 9 and everything seems to be working fine.

---------------------------------------

Original README:

![Magic Logo](Articles/images3/logo_full.jpg)

Version 1.7
-----------

This release contains two major and one minor addition to the library.

`WizardControl / WizardDialog`  
To speed up the process of creating wizard/configuration style processes the new _WizardControl_ provides much of the basic infrastructure needed. It can be used as an embedded control within any _Form_ you like. The most common usage will be as part of a modal dialog and so the _WizardDialog_ is provided to meet that need. The new sample demonstrates just one of the three different _Profiles_ it provides. Check out the documentation for more details.

`TabbedGroups`  
This new control provides the same functionality as the _Tabbed MDI_ feature found in _Visual Studio_. You can create a sequence of either vertical or horizontal tab groups that the user can customize. This takes us one step closer to the ultimate goal of _Magic_, the ability to replicate the look and feel of both _OfficeXP_ and _Visual Studio .NET_. Check out the new sample which demonstrates this feature.

A smaller but also very useful change is the addition of the _Multiline_ property to the _TabControl_.


New features
============

WizardControl
-------------

Use this new control to create simple wizard style operations. There are three different profiles to choose from. Each profile controls which buttons are automatically shown and the layout of the wizard control presentation. See the new documentation article for more details and use the 'SampleWizard' for a demonstration.

WizardDialog
------------

Contains an instance on the _WizardControl_ and provides some default implementation. You can use visual inheritance from this _Form_ to speed up the development times. This prevents needing to create a new 'Form' and embedding a _WizardControl_ instance within it every time you want to create a new wizard. See documentation for more details.

TabbedGroups
------------

Allows the creation of a vertical or horizontal sequence of groups. The user can create or remove the groups as well as move pages between groups. This can be done either using the appropriate context menu or using drag and drop. See the new sample to see this in operation.

TabControl
----------

Property _Multiline_ has been added but always defaults to false. Note that some other properties will not work when in multiline mode. For example the _ShrinkPagesToFit_ is invalid when presenting multiple lines of tabs.

Property _MultilineFullWidth_ has been added and is used when the _Multiline_ property has been defined. By default the last line of tabs does not take up the whole width of the control. When the property is defined then all the lines of the multiline are stretched to occupy the full width.

Proprety _IDEPixelTabArea_ has been added. When in _Style.IDE_ and positioning is at the top a dark line is drawn above the tabs area. When positioning is at the bottom is draws an extra line the same as the control color. This was the default behaviour just using this new property allows the effect to be turned off.

Property _BoldSelectedPage_ has been added. Previously the _Appearance.MultiDocument_ was always set to have the selected page in bold text and all others did not. This is the default but you can use this property to override the behaviour as needed.

Property _ContextPopupMenu_ has been added and when defined will show the specified popup menu instance when the tab pages area is right-click by the user. Note that you can still assign a standard menu to the _ContextMenu_ property which wil also be used if defined. Note that if you define both then you will end up with two menus being shown in succession.

Properties _HideTabsAlways_ and _HideTabsUsingLogic_ have been removed and replaced with an enumeration property called _HideTabsMode_. Update your code to use the appropriate enum values of _HideTabsModes.HideAlways_ and _HideTabsModes.HideUsingLogic_. You can also use the new _HideTabsModes.HideWithoutMouse_ to have the tabs area show only when the mouse is over the tab control or any of its pages.

Property _LeaveTimeout_ has been added and used in conjunction with the _HideTabsModes_ property when defined as _HideWithoutMouse_. This is the delay in milliseconds before the tabs area is displayed again.

Property _DragFromControl_ has been added. By default the control generates page dragging events when user drags a page outside of the control area. When this property is set to _False_ then it generates the event sequence when the page is dragged outside the double-click box from the mouse down position.

Event _SelectionChanging_ has been added and is fired when a change in selection is about to occur but the _SelectedIndex_ and _SelectedTab_ still retain the old value.

MenuCommand
-----------

Property _Image_ has been added and will be used in preference to any _ImageList/ImageIndex_ that might also be defined.

Content
-------

Property _FullTitle_ has been added. This is the text that will be displayed in the caption bar and the existing _Title_ is used as the tab page description. By default the _FullText_ is set to the same value as the _Title_ when the instance is created.


Bug fixes
=========

TabControl
----------

Adding/Removing tabs did not always update the tabs immediately. Sometimes you needed to resize the control before the changes became apparent.

If you used a _Form_ as the content for a _TabPage_ and the property _AutoScaleBaseSize_ was defined then it would not correctly size the _Form_ inside the control until that tab was selected for the second time.

When using the _Appearance.MultiBox_ mode and also using _HotTrack_ then tab boxes would not be correctly redrawn when hot tracking leaves them. This has now been corrected.

If you had _HotTrack_ or _HoverSelect_ defined and then start a dragging operation it used to still attempt to perform the hot tracking or selection of new items. This has been corrected so that the two properties are ignored when performing a drag as it only confuses the user.

DockingManager
--------------

Floating windows would show the caption bar for a docking window when it is the only one inside the floating form. This is fixed to show captions only when two or more exist docking windows are contained inside the floating form.

Creating docking content in the floating state would not persist correctly. Instead, when config was saved the docking windows would be moved back into the main application. This has been fixed.

Double click a docked window to make it floating and then press the _ESC_ key. This used causes a nasty crash in yout application but has now been fixed.

MenuControl
-----------

When a _PopupMenu_ was showing and you used the keyboard/mouse to navigate to different top level items the drawing of some items was missed and so left black spaces.



Build instructions
==================

Building the samples
--------------------

Each sample has been written in _C#_ and _VB.NET_, so you should navigate to the appropriate language version contained below the _Magic Library 1.7\\Samples_ directory. Double click the solution file found and you will be presented with the list of available samples. Righ click the sample application of interest and select the _"Set as StartUp Project"_ option. Now select the _"Debug \\ Start"_ menu option and the projects will be automatically compiled and the selected sample started.

Building the Magic source code
------------------------------

Navigate to the _Magic Library 1.7\\Source_ directory and you will find a Visual Studio .NET solution called _MagicLibrary_. Double click this solution and you will be presented with a project that includes all the source code for building an unsigned version of the Magic Library. The output will be placed by default in the _Magic Library 1.7\\Bin_ directory and given the name _MagicLocalLibrary.dll_ to distinguish it from the official signed version that is in the same location and called _MagicLibrary.dll_.

Using Magic in your own applications
------------------------------------

Either create a new project or load the existing project of interest and right click the _References_ folder. The will present a dialog box with the _.NET_ tab already selected. Navigate down the list of assemblies in this tab until you find the _Magic_ entry which should then be selected. Your project now has a reference to the official signed build of _Magic_. When you decide to distribute your project you will need to also distribute the signed assembly which is contained in the _Magic Library 1.7\\Bin_ directory and called _MagicLibrary.dll_. It is recommended that you add the signed version into the GAC during your own installation process.


License terms
------------------------------------

There is no license fee or royalty fee to be paid at any time for using the Magic Library. You are however requested to acknowledge the use of the library and provide a link to our home page _www.dotnetmagic.com_ from the _About_ box of your application.

You may include the source code, modified source code, signed assembly or modified built assembly within your own projects for either personal or commercial use but excluding the restrictions outlined below.

The following restrictions apply to all parts of the library, including all source code, assemblies, samples and documentation...

*   The above items cannot be sold as is, either individually or together.
*   The above items cannot be modified and then sold as a library component, either individually or together.

In other words, if you are using the library to enhance your project then you are fine. If you are trying to gain commercically from the library itself rather than using it to enhance your own work then you are prohibited from its use.

If in any doubt they please contact us at ** for a quick determination. ** email is not working

Copyright 2002 Crownwood Consulting Ltd. All Rights Reserved
