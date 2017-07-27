# uwp-zxing-crash
tl;dr couldn't replicate crash - sample app trying to replicate a uwp crash on navigation away from a page that has a zxing scanner in xaml that isn't scanning yet.

note to self (what was this project):
* xamarin forms .netStandard Prism with Unity cross platform app.
* two pages: main has next button and "activate zxing" button.
* activate sets a zxing (defined in xaml) scanner to visible, scanning and analyzing == true.
