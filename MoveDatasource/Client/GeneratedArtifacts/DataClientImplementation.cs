//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Title
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/NetflixCatalogData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Title :
        global::LightSwitchApplication.Title.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Microsoft_LightSwitch_ETag
        {
            get;
            set;
        }
    
        string global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation.ETag
        {
            get { return this.Microsoft_LightSwitch_ETag; }
            set { this.Microsoft_LightSwitch_ETag = value; }
        }
    
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        partial void OnShortNameChanged()
        {
            this.___OnPropertyChanged("ShortName");
        }
        
        partial void OnSynopsisChanged()
        {
            this.___OnPropertyChanged("Synopsis");
        }
        
        partial void OnShortSynopsisChanged()
        {
            this.___OnPropertyChanged("ShortSynopsis");
        }
        
        partial void OnAverageRatingChanged()
        {
            this.___OnPropertyChanged("AverageRating");
        }
        
        partial void OnReleaseYearChanged()
        {
            this.___OnPropertyChanged("ReleaseYear");
        }
        
        partial void OnUrlChanged()
        {
            this.___OnPropertyChanged("Url");
        }
        
        partial void OnRuntimeChanged()
        {
            this.___OnPropertyChanged("Runtime");
        }
        
        partial void OnRatingChanged()
        {
            this.___OnPropertyChanged("Rating");
        }
        
        partial void OnDateModifiedChanged()
        {
            this.___OnPropertyChanged("DateModified");
        }
        
        partial void OnTypeChanged()
        {
            this.___OnPropertyChanged("Type");
        }
        
        partial void OnWebsiteUrlChanged()
        {
            this.___OnPropertyChanged("WebsiteUrl");
        }
        
        partial void OnNetflixApiIdChanged()
        {
            this.___OnPropertyChanged("NetflixApiId");
        }
        
        partial void OnTinyUrlChanged()
        {
            this.___OnPropertyChanged("TinyUrl");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Title.DetailsClass.IImplementation.Disc
        {
            get
            {
                return this.Disc;
            }
            set
            {
                this.Disc = (global::LightSwitchApplication.Implementation.Title)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title> __Disc
        {
            get
            {
                if (this.___Disc == null)
                {
                    this.___Disc = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title>(
                        this,
                        "Disc",
                        new string[] {  },
                        null,
                        () => this._Disc,
                        e => this._Disc = e);
                }
                return this.___Disc;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title> ___Disc;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Title.DetailsClass.IImplementation.Season
        {
            get
            {
                return this.Season;
            }
            set
            {
                this.Season = (global::LightSwitchApplication.Implementation.Title)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title> __Season
        {
            get
            {
                if (this.___Season == null)
                {
                    this.___Season = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title>(
                        this,
                        "Season",
                        new string[] {  },
                        null,
                        () => this._Season,
                        e => this._Season = e);
                }
                return this.___Season;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title> ___Season;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Title.DetailsClass.IImplementation.Series
        {
            get
            {
                return this.Series;
            }
            set
            {
                this.Series = (global::LightSwitchApplication.Implementation.Title)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title> __Series
        {
            get
            {
                if (this.___Series == null)
                {
                    this.___Series = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title>(
                        this,
                        "Series",
                        new string[] {  },
                        null,
                        () => this._Series,
                        e => this._Series = e);
                }
                return this.___Series;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title> ___Series;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Title.DetailsClass.IImplementation.Movie
        {
            get
            {
                return this.Movie;
            }
            set
            {
                this.Movie = (global::LightSwitchApplication.Implementation.Title)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title> __Movie
        {
            get
            {
                if (this.___Movie == null)
                {
                    this.___Movie = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title>(
                        this,
                        "Movie",
                        new string[] {  },
                        null,
                        () => this._Movie,
                        e => this._Movie = e);
                }
                return this.___Movie;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Title> ___Movie;
        
    }
    #endregion
    
    #region CachedMovies
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class CachedMovies :
        global::LightSwitchApplication.CachedMovies.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnTitleChanged()
        {
            this.___OnPropertyChanged("Title");
        }
        
        partial void OnRatingChanged()
        {
            this.___OnPropertyChanged("Rating");
        }
        
        partial void OnReleaseYearChanged()
        {
            this.___OnPropertyChanged("ReleaseYear");
        }
        
    }
    #endregion
    
    #region NetflixCatalogDataObjectContext
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class NetflixCatalogDataObjectContext
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Title))
            {
                return new global::LightSwitchApplication.Implementation.Title();
            }
            return null;
        }
    }
    #endregion
    
    #region ApplicationDataObjectContext
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ApplicationDataObjectContext
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.CachedMovies))
            {
                return new global::LightSwitchApplication.Implementation.CachedMovies();
            }
            return null;
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.NetflixCatalogData))
            {
                return new global::LightSwitchApplication.NetflixCatalogData();
            }
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.NetflixCatalogData))
            {
                return new global::LightSwitchApplication.Implementation.NetflixCatalogDataObjectContext(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../NetflixCatalogData.svc"));
            }
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataObjectContext(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../ApplicationData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Title) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Title);
            }
            if (typeof(global::LightSwitchApplication.CachedMovies) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.CachedMovies);
            }
            return null;
        }
    }
}
