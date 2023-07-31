# The Dark Theme app
I started making this so that me, or anyone really, can easily have a nice looking theme on their program without needing to write any extra code. 
Here's a preview of the latest update
![](newPreview.png)
---

# Using the themes (new)
For both the new and old versions, you need to reference `PresentationFramework.Aero2.dll` in order for drop shadows to work. Right click References in the solution explorer bit, Add Reference, goto Assemblies and double click/include `PresentationFramework.Aero2`

[Click here](#using-the-old-themes) if you want to use the old version which is slightly easier to use but is deprecated

Firstly, add the theme, control colours and controls dictionaries. This assumes that you don't change the folder structure used by this project

```xml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <!-- Contains all of the colours and brushes for a theme -->
            <ResourceDictionary Source="Themes/ColourDictionaries/SoftDark.xaml"/>
            <!-- Contains most of the control-specific brushes which reference -->
            <!-- the above theme. I aim for this to contain ALL brushes, not most  -->
            <ResourceDictionary Source="Themes/ControlColours.xaml"/>
            <!-- Contains all of the control styles (Button, ListBox, etc) -->
            <ResourceDictionary Source="Themes/Controls.xaml"/>        
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```

### Window Style
To style windows, just add this to your windows' XAML:
```
Style="{StaticResource CustomWindowStyleEx}"
```

---

# Using the old themes

I remade the entire theme library a while back for my other projects, and I'm adding it to this repo... finally lol

The old theme library stores every controls' style in each resource dictionary which, although grands the easiest control over what colours are used, is annoying to have to add new styles

If you want to use it anyway, then just drag and drop the theme(s) you want (located in the ThemesOLD folder folder) into your project (i'd recommend putting them inside a Themes folder just to be organised) and inside App.xaml place this: (and replace DarkTheme with whatever theme you want, like LightTheme, ColourfulDarkTheme, etc)
```xml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="/ThemesFolder/DarkTheme.xaml"/>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```
And then most things like buttons, ListBoxes, etc, will automatically be styled

## Window styles
In your window XAML code (where you define height/width, etc), add:
```
Style="{DynamicResource CustomWindowStyle}"
```

This styles styles the title bar, its buttons, etc. There's also `CustomToolWindowStyle` which is the same as `CustomWindowStyle` but can't be resized, and `MainWindowStyle` which is the exact same as the default window but with a dark background

---

# Update Logs (time is from bottom to top)
- Deprecated the old themes (renamed folder to ThemesOLD), and moved to using the new library
- Added version 2. I only added dark themes to V2 so far, but i might add a light themes. They are located in the ThemesV2 folder. I made the app use them (in App.xaml, which shows how to install them, i commented out the older version)
- Made menuitems autostyle, improved the looks of disabled controls (which use a textblock as their content, e.g. buttons or menuitems), and also made the maximize/restore button change based on the window state
- Finally added a shadow to windows. Also added drop shadows to tooltips, context menus and menuitems. These shadows however do introduct another thing... when resizing the window, a white border apears along the axis youre resizing in. It dissapears as soon as the window has fully re-drawn (aka after you stop resizing). idk how to fix this but tbh its not that big of a deal so it can just be ignored
- Had to change the slider to fix the orientations and the tick placements. they now no longer have the blue trail after them. although i could try and add it later
- Colourful Light/Dark theme has arrived! i find the Colourful light theme and original dark theme go well, but that's my opinion ;)
- Themed the titlebar! All of the buttons' functionality (close, minimize, autothing) automatically apply to any window.
- Improved the ComboBox; themed the ComboBoxItems and other controls too
- added more colours to be used for styling, and a "special primary colour", which is dark blue atm.
- Improved the slider; rounded corners on the slider thumb, and the slider uses the "special primary colours" instead of plain grey.
- Also improved the ScrollBars (the scroll handle bit was darker than the backgroundy bit, so i changed that.
- Added some colours to the light theme too (not sure why you'd want to use it but eh)
- And finally improved the RadioBoxes by giving them a more circular shape, like they normally have.