# Trying out `BlazorWebView` with Windows Forms and .NET 6 Preview 7

## To run:

- Install .NET 6.0.100-preview.7 SDK:<br> 
  https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-6.0.100-preview.7-windows-x64-installer
- Clone the repo:<br> 
  `git clone https://github.com/noseratio/BlazorWebViewWinFormsApp .`
- Run:<br>
  `dotnet run`

## Problems

- tabbing out of the native WinForms `TextBox` looses the focus
- Windows system accelerators (<kbd>Alt-F4</kbd>, <kbd>Alt-Space</kbd>) don't work when the focus is inside `BlazorWebView`
- the arrow keys don't work inside HTML `textarea` within `BlazorWebView`
- the native WinForms menu is not dismissed when the focus moves into `BlazorWebView` by clicking it:<br>
    ![BlazorWebView](https://i.stack.imgur.com/hWIP0l.png)

