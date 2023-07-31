# New Theme Library
I decided to upgrade the theme library so that, instead of having each theme 
contain all of the control styles, there is instead just a global style file.

I may extract them into their own files at some point, e.g. ButtonStyles.xaml, 
ListBoxStyles.xaml, etc, just so that it's easier to find stuff

## Controls.xaml
Contains all of the styles

## ControlColours.xaml
This is where I (mostly attempted to) keep control-specific brushes and stuff.
However, I still sometimes used the resource keys directly, which is fine because each theme
should contain the exact same resource key names, but their colours should change

I may attempt to make a "LightThemeControlColours" and "DarkThemeControlColours", because sometimes
there are colour differences between light and dark themes that just might not work out and will look weird


