#pragma checksum "C:\BlazorProjects\Chap4\TicTacToe\TicTacToe\Pages\tictactoe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8710faa427a5dedda8859a17410f390c3df83e23"
// <auto-generated/>
#pragma warning disable 1591
namespace TicTacToe.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using TicTacToe;
    using TicTacToe.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/tic-tac-toe")]
    public class tictactoe : tictactoeModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Tic-Tac-Toe Using Blazor");
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
            builder.OpenElement(3, "hr");
            builder.CloseElement();
            builder.AddContent(4, "\n\n");
            builder.OpenElement(5, "div");
            builder.AddAttribute(6, "class", "container");
            builder.AddAttribute(7, "style", "background-color:slategray; border:1px solid black; width:225px");
            builder.AddContent(8, "\n\n");
#line 10 "C:\BlazorProjects\Chap4\TicTacToe\TicTacToe\Pages\tictactoe.cshtml"
     foreach (int row in gameBoard)
    {

#line default
#line hidden
            builder.AddContent(9, "        ");
            builder.OpenElement(10, "div");
            builder.AddContent(11, "\n");
#line 13 "C:\BlazorProjects\Chap4\TicTacToe\TicTacToe\Pages\tictactoe.cshtml"
             foreach (int col in gameBoard)
            {

#line default
#line hidden
            builder.AddContent(12, "                ");
            builder.OpenElement(13, "button");
            builder.AddAttribute(14, "class", "btn btn-default");
            builder.AddAttribute(15, "style", "width:50px;height:50px;margin: 5px;");
            builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(() => SetCellValue(row,col)));
            builder.AddContent(17, "\n                    ");
            builder.AddContent(18, cellValue[row, col]);
            builder.AddContent(19, "\n                ");
            builder.CloseElement();
            builder.AddContent(20, "\n");
#line 19 "C:\BlazorProjects\Chap4\TicTacToe\TicTacToe\Pages\tictactoe.cshtml"

            }

#line default
#line hidden
            builder.AddContent(21, "        ");
            builder.CloseElement();
            builder.AddContent(22, "\n");
#line 22 "C:\BlazorProjects\Chap4\TicTacToe\TicTacToe\Pages\tictactoe.cshtml"
    }

#line default
#line hidden
            builder.CloseElement();
            builder.AddContent(23, "\n");
            builder.OpenElement(24, "br");
            builder.CloseElement();
            builder.AddContent(25, "\n");
            builder.OpenElement(26, "div");
            builder.AddAttribute(27, "style", "text-align:center;");
            builder.AddContent(28, "\n    ");
            builder.OpenElement(29, "button");
            builder.AddAttribute(30, "class", "btn btn-info col-sm-3 col-md-3");
            builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ResetGame));
            builder.AddContent(32, "Reset");
            builder.CloseElement();
            builder.AddContent(33, "\n");
            builder.CloseElement();
            builder.AddContent(34, "\n\n");
            builder.OpenElement(35, "hr");
            builder.CloseElement();
            builder.AddContent(36, "\n\n");
#line 31 "C:\BlazorProjects\Chap4\TicTacToe\TicTacToe\Pages\tictactoe.cshtml"
 if (!win)
{

#line default
#line hidden
            builder.AddContent(37, "    ");
            builder.OpenElement(38, "strong");
            builder.AddContent(39, "Player \'");
            builder.AddContent(40, currentPlayer);
            builder.AddContent(41, "\' turn.");
            builder.CloseElement();
            builder.AddContent(42, "\n");
#line 34 "C:\BlazorProjects\Chap4\TicTacToe\TicTacToe\Pages\tictactoe.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(43, "    ");
            builder.OpenElement(44, "strong");
            builder.AddContent(45, "Player \'");
            builder.AddContent(46, winner);
            builder.AddContent(47, "\' has won the game.");
            builder.CloseElement();
            builder.AddContent(48, "\n");
#line 38 "C:\BlazorProjects\Chap4\TicTacToe\TicTacToe\Pages\tictactoe.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
