using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class TitlesListDetail
    {
        partial void Method_Execute()
        {
            // Write your code here.

        }

        partial void AddToCachedMovies_Execute()
        {
            Title selectedMovie = this.Titles.SelectedItem;

            CachedMovies cachedMovie = this.DataWorkspace.ApplicationData.CachedMoviesSet.AddNew();
            cachedMovie.Title = selectedMovie.Name;
            cachedMovie.Rating = selectedMovie.Rating;
            cachedMovie.ReleaseYear = selectedMovie.ReleaseYear.Value;

            this.DataWorkspace.ApplicationData.SaveChanges();

        }
    }
}
