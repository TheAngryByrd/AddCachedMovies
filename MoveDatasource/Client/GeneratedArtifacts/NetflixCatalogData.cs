//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 8/20/2012 11:38:41 AM
namespace LightSwitchApplication.Implementation
{
    
    /// <summary>
    /// There are no comments for NetflixCatalogDataObjectContext in the schema.
    /// </summary>
    public partial class NetflixCatalogDataObjectContext : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext
    {
        /// <summary>
        /// Initialize a new NetflixCatalogDataObjectContext object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public NetflixCatalogDataObjectContext(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("LightSwitchApplication", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("LightSwitchApplication.Implementation", typeName.Substring(22)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("LightSwitchApplication.Implementation", global::System.StringComparison.Ordinal))
            {
                return string.Concat("LightSwitchApplication.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Titles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Title> Titles
        {
            get
            {
                if ((this._Titles == null))
                {
                    this._Titles = base.CreateQuery<Title>("Titles");
                }
                return this._Titles;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Title> _Titles;
        /// <summary>
        /// There are no comments for Titles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTitles(Title title)
        {
            base.AddObject("Titles", title);
        }
    }
    /// <summary>
    /// There are no comments for LightSwitchApplication.Title in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Titles")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Title : global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityBase, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Title object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="dateModified">Initial value of DateModified.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Title CreateTitle(string ID, global::System.DateTime dateModified)
        {
            Title title = new Title();
            title.Id = ID;
            title.DateModified = dateModified;
            return title;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                if (object.Equals(this.Id, value))
                {
                    return;
                }
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Id;
        partial void OnIdChanging(string value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                if (object.Equals(this.Name, value))
                {
                    return;
                }
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property ShortName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ShortName
        {
            get
            {
                return this._ShortName;
            }
            set
            {
                this.OnShortNameChanging(value);
                if (object.Equals(this.ShortName, value))
                {
                    return;
                }
                this._ShortName = value;
                this.OnShortNameChanged();
                this.OnPropertyChanged("ShortName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ShortName;
        partial void OnShortNameChanging(string value);
        partial void OnShortNameChanged();
        /// <summary>
        /// There are no comments for Property Synopsis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Synopsis
        {
            get
            {
                return this._Synopsis;
            }
            set
            {
                this.OnSynopsisChanging(value);
                if (object.Equals(this.Synopsis, value))
                {
                    return;
                }
                this._Synopsis = value;
                this.OnSynopsisChanged();
                this.OnPropertyChanged("Synopsis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Synopsis;
        partial void OnSynopsisChanging(string value);
        partial void OnSynopsisChanged();
        /// <summary>
        /// There are no comments for Property ShortSynopsis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ShortSynopsis
        {
            get
            {
                return this._ShortSynopsis;
            }
            set
            {
                this.OnShortSynopsisChanging(value);
                if (object.Equals(this.ShortSynopsis, value))
                {
                    return;
                }
                this._ShortSynopsis = value;
                this.OnShortSynopsisChanged();
                this.OnPropertyChanged("ShortSynopsis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ShortSynopsis;
        partial void OnShortSynopsisChanging(string value);
        partial void OnShortSynopsisChanged();
        /// <summary>
        /// There are no comments for Property AverageRating in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<double> AverageRating
        {
            get
            {
                return this._AverageRating;
            }
            set
            {
                this.OnAverageRatingChanging(value);
                if (object.Equals(this.AverageRating, value))
                {
                    return;
                }
                this._AverageRating = value;
                this.OnAverageRatingChanged();
                this.OnPropertyChanged("AverageRating");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<double> _AverageRating;
        partial void OnAverageRatingChanging(global::System.Nullable<double> value);
        partial void OnAverageRatingChanged();
        /// <summary>
        /// There are no comments for Property ReleaseYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ReleaseYear
        {
            get
            {
                return this._ReleaseYear;
            }
            set
            {
                this.OnReleaseYearChanging(value);
                if (object.Equals(this.ReleaseYear, value))
                {
                    return;
                }
                this._ReleaseYear = value;
                this.OnReleaseYearChanged();
                this.OnPropertyChanged("ReleaseYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ReleaseYear;
        partial void OnReleaseYearChanging(global::System.Nullable<int> value);
        partial void OnReleaseYearChanged();
        /// <summary>
        /// There are no comments for Property Url in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Url
        {
            get
            {
                return this._Url;
            }
            set
            {
                this.OnUrlChanging(value);
                if (object.Equals(this.Url, value))
                {
                    return;
                }
                this._Url = value;
                this.OnUrlChanged();
                this.OnPropertyChanged("Url");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Url;
        partial void OnUrlChanging(string value);
        partial void OnUrlChanged();
        /// <summary>
        /// There are no comments for Property Runtime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Runtime
        {
            get
            {
                return this._Runtime;
            }
            set
            {
                this.OnRuntimeChanging(value);
                if (object.Equals(this.Runtime, value))
                {
                    return;
                }
                this._Runtime = value;
                this.OnRuntimeChanged();
                this.OnPropertyChanged("Runtime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Runtime;
        partial void OnRuntimeChanging(global::System.Nullable<int> value);
        partial void OnRuntimeChanged();
        /// <summary>
        /// There are no comments for Property Rating in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this.OnRatingChanging(value);
                if (object.Equals(this.Rating, value))
                {
                    return;
                }
                this._Rating = value;
                this.OnRatingChanged();
                this.OnPropertyChanged("Rating");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Rating;
        partial void OnRatingChanging(string value);
        partial void OnRatingChanged();
        /// <summary>
        /// There are no comments for Property DateModified in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime DateModified
        {
            get
            {
                return this._DateModified;
            }
            set
            {
                this.OnDateModifiedChanging(value);
                if (object.Equals(this.DateModified, value))
                {
                    return;
                }
                this._DateModified = value;
                this.OnDateModifiedChanged();
                this.OnPropertyChanged("DateModified");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _DateModified;
        partial void OnDateModifiedChanging(global::System.DateTime value);
        partial void OnDateModifiedChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                if (object.Equals(this.Type, value))
                {
                    return;
                }
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Type;
        partial void OnTypeChanging(string value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property WebsiteUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string WebsiteUrl
        {
            get
            {
                return this._WebsiteUrl;
            }
            set
            {
                this.OnWebsiteUrlChanging(value);
                if (object.Equals(this.WebsiteUrl, value))
                {
                    return;
                }
                this._WebsiteUrl = value;
                this.OnWebsiteUrlChanged();
                this.OnPropertyChanged("WebsiteUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _WebsiteUrl;
        partial void OnWebsiteUrlChanging(string value);
        partial void OnWebsiteUrlChanged();
        /// <summary>
        /// There are no comments for Property NetflixApiId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string NetflixApiId
        {
            get
            {
                return this._NetflixApiId;
            }
            set
            {
                this.OnNetflixApiIdChanging(value);
                if (object.Equals(this.NetflixApiId, value))
                {
                    return;
                }
                this._NetflixApiId = value;
                this.OnNetflixApiIdChanged();
                this.OnPropertyChanged("NetflixApiId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _NetflixApiId;
        partial void OnNetflixApiIdChanging(string value);
        partial void OnNetflixApiIdChanged();
        /// <summary>
        /// There are no comments for Property TinyUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string TinyUrl
        {
            get
            {
                return this._TinyUrl;
            }
            set
            {
                this.OnTinyUrlChanging(value);
                if (object.Equals(this.TinyUrl, value))
                {
                    return;
                }
                this._TinyUrl = value;
                this.OnTinyUrlChanged();
                this.OnPropertyChanged("TinyUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _TinyUrl;
        partial void OnTinyUrlChanging(string value);
        partial void OnTinyUrlChanged();
        /// <summary>
        /// There are no comments for Disc in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Title Disc
        {
            get
            {
                this.@__Disc.EnsureValueInitialized();
                return this._Disc;
            }
            set
            {
                Title previous = this.Disc;
                if ((previous == value))
                {
                    return;
                }
                if ((previous != null))
                {
                    this._Disc = null;
                    this.@__Disc.OnValueSet();
                }
                this._Disc = value;
                this.@__Disc.OnValueSet();
                this.___OnPropertyChanged("Disc");
                this.OnPropertyChanged("Disc");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Title _Disc;
        /// <summary>
        /// There are no comments for Season in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Title Season
        {
            get
            {
                this.@__Season.EnsureValueInitialized();
                return this._Season;
            }
            set
            {
                Title previous = this.Season;
                if ((previous == value))
                {
                    return;
                }
                if ((previous != null))
                {
                    this._Season = null;
                    this.@__Season.OnValueSet();
                }
                this._Season = value;
                this.@__Season.OnValueSet();
                this.___OnPropertyChanged("Season");
                this.OnPropertyChanged("Season");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Title _Season;
        /// <summary>
        /// There are no comments for Series in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Title Series
        {
            get
            {
                this.@__Series.EnsureValueInitialized();
                return this._Series;
            }
            set
            {
                Title previous = this.Series;
                if ((previous == value))
                {
                    return;
                }
                if ((previous != null))
                {
                    this._Series = null;
                    this.@__Series.OnValueSet();
                }
                this._Series = value;
                this.@__Series.OnValueSet();
                this.___OnPropertyChanged("Series");
                this.OnPropertyChanged("Series");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Title _Series;
        /// <summary>
        /// There are no comments for Movie in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Title Movie
        {
            get
            {
                this.@__Movie.EnsureValueInitialized();
                return this._Movie;
            }
            set
            {
                Title previous = this.Movie;
                if ((previous == value))
                {
                    return;
                }
                if ((previous != null))
                {
                    this._Movie = null;
                    this.@__Movie.OnValueSet();
                }
                this._Movie = value;
                this.@__Movie.OnValueSet();
                this.___OnPropertyChanged("Movie");
                this.OnPropertyChanged("Movie");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Title _Movie;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
