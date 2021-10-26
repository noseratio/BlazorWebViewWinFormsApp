# Trying out `BlazorWebView` with Windows Forms and .NET 6 RC2

## To run:

- Install 6.0.0-rc.2:<br> 
  https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-6.0.100-rc.2-windows-x64-installer
- Clone the repo:<br> 
  `git clone https://github.com/noseratio/BlazorWebViewWinFormsApp .`
- Run:<br>
  `dotnet run`

## Problems

- tabbing out of the native WinForms `TextBox` looses the focus
- Some windows system accelerators (<s><kbd>Alt-F4</kbd></s>, <kbd>Alt-Space</kbd>) don't work when the focus is inside `BlazorWebView`
- <s>the arrow keys don't work inside HTML `textarea` within `BlazorWebView`</s>
- the native WinForms menu is not dismissed when the focus moves into `BlazorWebView` by clicking it:<br>
    ![BlazorWebView](https://i.stack.imgur.com/hWIP0m.png)

## More info: https://github.com/dotnet/maui/issues/2341
