#pragma checksum "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a0d1e4c5e0240d8c74c847b94756af660df5d88"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
using WebApplication1.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/film")]
    public partial class Film : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "filmInfo");
            __builder.AddMarkupContent(2, "<h4>Result</h4>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "fInfo");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, 
#nullable restore
#line 10 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
              title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "fInfo");
            __builder.AddMarkupContent(10, "<label>Year</label>\r\n        ");
            __builder.OpenElement(11, "label");
            __builder.AddContent(12, 
#nullable restore
#line 15 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
                year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "<thead><tr><th>Stars:</th>\r\n                <th>Birth:</th></tr></thead>\r\n        ");
            __builder.OpenElement(17, "tbody");
#nullable restore
#line 25 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
             foreach (var item in filmStars)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 28 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
                         item.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 29 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
                         item.birth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table");
            __builder.AddMarkupContent(27, "<thead><tr><th>Directors:</th>\r\n            <th>Birth:</th></tr></thead>\r\n        ");
            __builder.OpenElement(28, "tbody");
#nullable restore
#line 43 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
         foreach (var item in directors)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 46 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
                     item.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 47 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
                     item.birth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
                      addFilm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Add to my favorite! ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
       

    private IMovieService movieService;
    public string title { set; get; }
    public int year { set; get; }
    public int Id { set; get; }
    public IList<People> filmStars { set; get; } = new List<People>();
    public IList<People> directors { set; get; } = new List<People>();
    public IList<Movie> movies { set; get; } = new List<Movie>();

    public IList<Film> allFilms;

    public Film(int Id) { this.Id = Id; }
    public async void addFilm()
    {
        Console.WriteLine("111111111111111111111111111111");
        Movie movie = await movieService.getMovieById(16906);
        Console.WriteLine("now the title is -----"+title);
        title = movie.title;
        Console.WriteLine("now the title is -----" + title);
        year = movie.year;
        directors = await movieService.getDirectorsById(16906);
        filmStars = await movieService.getStasById(16906);
        Console.WriteLine("add film add film  add film  add film  add film  add film  add film");
        //    NavigationManager.NavigateTo("/LogIn");
        IList<Movie> list = new List<Movie>();
        list = await movieService.getMoviesByTitle("Faceless");
        for (int i =0;i<list.Count;i++)
        {
            Console.WriteLine(list[i].title);
        }

        Console.WriteLine("now the title is -----" + title);
    }

    protected  override  async Task OnInitializedAsync()
    {

        try
        {

            movieService = new CloudMovieService();
            Movie movie = await movieService.getMovieById(Id);
            title = movie.title;
            year = movie.year;
            directors = await movieService.getDirectorsById(Id);
            Console.WriteLine("the director is" + directors[0].name);
            filmStars = await movieService.getStasById(Id);

            movies = await movieService.getMoviesByTitle(title);
            Console.WriteLine("this is" + movies[0].title);
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMovieService MovieService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
