# Trying out `BlazorWebView` with Windows Forms and .NET 6

## To run:

- Install [.NET 6 SDK](https://download.visualstudio.microsoft.com/download/pr/0f71eaf1-ce85-480b-8e11-c3e2725b763a/9044bfd1c453e2215b6f9a0c224d20fe/dotnet-sdk-6.0.100-win-x64.exe)<br> 

- Clone the repo:<br> 
  `git clone https://github.com/noseratio/BlazorWebViewWinFormsApp .`

- Run:<br>
  `dotnet run`

## Problems

- <s>tabbing out of the native WinForms `TextBox` looses the focus</s>
- Some windows system accelerators (<kbd><s>Alt-F4</s></kbd>, <kbd>Alt-Space</kbd>) don't work when the focus is inside `BlazorWebView`
- <s>the arrow keys don't work inside HTML `textarea` within `BlazorWebView`</s>
- the native WinForms menu is not dismissed when the focus moves into `BlazorWebView` by clicking it:<br>
    ![BlazorWebView](https://i.stack.imgur.com/hWIP0m.png)

## More info: https://github.com/dotnet/maui/issues/2341
