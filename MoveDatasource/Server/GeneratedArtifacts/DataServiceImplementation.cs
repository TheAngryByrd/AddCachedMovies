//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class NetflixCatalogDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::NetflixCatalogData.Implementation.NetflixCatalogDataObjectContext>
    {
    
        public NetflixCatalogDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService()
        {
            return new global::LightSwitchApplication.DataWorkspace().NetflixCatalogData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class NetflixCatalogDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.AstoriaDataServiceImplementation<global::NetflixCatalogData.Implementation.NetflixCatalogDataObjectContext, global::NetflixCatalogData.NetflixCatalogDataService.NetflixCatalog>
    {
        public NetflixCatalogDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::NetflixCatalogData.Implementation.Title))
            {
                return new global::NetflixCatalogData.Implementation.Title();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::NetflixCatalogData.Implementation.NetflixCatalogDataObjectContext CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::NetflixCatalogData.Implementation.NetflixCatalogDataObjectContext(base.GetEntityConnectionString(
                "NetflixCatalogData", 
                "res://" + assemblyName + "/NetflixCatalogData.csdl|res://" + assemblyName + "/NetflixCatalogData.ssdl|res://" + assemblyName + "/NetflixCatalogData.msl", 
                "System.Data.SqlClient"));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Title))
            {
                return new global::NetflixCatalogData.Implementation.Title();
            }
            return null;
        }
    
        protected override string WebConfigurationConnectionStringName
        {
            get
            {
                return "NetflixCatalogData";
            }
        }
    
        protected override global::System.Type ConvertType(global::System.Type outerType)
        {
            if (outerType == typeof(global::NetflixCatalogData.Implementation.Title))
            {
                return typeof(global::NetflixCatalogData.NetflixCatalogDataService.Title);
            }
            return base.ConvertType(outerType);
        }
    
        protected override object ConvertEntity(object outerEntity)
        {
            global::NetflixCatalogData.Implementation.Title title = outerEntity as global::NetflixCatalogData.Implementation.Title;
            if (title != null)
            {
                global::NetflixCatalogData.NetflixCatalogDataService.Title result = new global::NetflixCatalogData.NetflixCatalogDataService.Title();
                result.Id = title.Id;
                result.Name = title.Name;
                result.ShortName = title.ShortName;
                result.Synopsis = title.Synopsis;
                result.ShortSynopsis = title.ShortSynopsis;
                result.AverageRating = title.AverageRating;
                result.ReleaseYear = title.ReleaseYear;
                result.Url = title.Url;
                result.Runtime = title.Runtime;
                result.Rating = title.Rating;
                result.DateModified = title.DateModified;
                result.Type = title.Type;
                result.WebsiteUrl = title.WebsiteUrl;
                result.NetflixApiId = title.NetflixApiId;
                result.TinyUrl = title.TinyUrl;
                return result;
            }
            return null;
        }
    
        protected override void UpdateResult(object outerEntity, object innerResult)
        {
            global::NetflixCatalogData.Implementation.Title outerTitle = outerEntity as global::NetflixCatalogData.Implementation.Title;
            global::NetflixCatalogData.NetflixCatalogDataService.Title innerTitle = innerResult as global::NetflixCatalogData.NetflixCatalogDataService.Title;
            if ((outerTitle != null) && (innerTitle != null))
            {
                outerTitle.Id = innerTitle.Id;
                outerTitle.Name = innerTitle.Name;
                outerTitle.ShortName = innerTitle.ShortName;
                outerTitle.Synopsis = innerTitle.Synopsis;
                outerTitle.ShortSynopsis = innerTitle.ShortSynopsis;
                outerTitle.AverageRating = innerTitle.AverageRating;
                outerTitle.ReleaseYear = innerTitle.ReleaseYear;
                outerTitle.Url = innerTitle.Url;
                outerTitle.Runtime = innerTitle.Runtime;
                outerTitle.Rating = innerTitle.Rating;
                outerTitle.DateModified = innerTitle.DateModified;
                outerTitle.Type = innerTitle.Type;
                outerTitle.WebsiteUrl = innerTitle.WebsiteUrl;
                outerTitle.NetflixApiId = innerTitle.NetflixApiId;
                outerTitle.TinyUrl = innerTitle.TinyUrl;
                return;
            }
            base.UpdateResult(outerEntity, innerResult);
        }
    
    #endregion
    
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService()
        {
            return new global::LightSwitchApplication.DataWorkspace().ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::ApplicationData.Implementation.CachedMovies))
            {
                return new global::ApplicationData.Implementation.CachedMovies();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::ApplicationData.Implementation.ApplicationDataObjectContext CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::ApplicationData.Implementation.ApplicationDataObjectContext(base.GetEntityConnectionString(
                "_IntrinsicData", 
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl", 
                "System.Data.SqlClient"));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.CachedMovies))
            {
                return new global::ApplicationData.Implementation.CachedMovies();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.NetflixCatalogData))
            {
                return new global::LightSwitchApplication.NetflixCatalogDataService();
            }
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.NetflixCatalogData))
            {
                return new global::LightSwitchApplication.Implementation.NetflixCatalogDataServiceImplementation(dataService);
            }
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
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
                return typeof(global::NetflixCatalogData.Implementation.Title);
            }
            if (typeof(global::LightSwitchApplication.CachedMovies) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.CachedMovies);
            }
            return null;
        }
    }
}

namespace NetflixCatalogData.Implementation
{

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Title :
        global::LightSwitchApplication.Title.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation
    {
    
        [global::System.Runtime.Serialization.DataMember]
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
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Title.DetailsClass.IImplementation.Disc
        {
            get
            {
                return this.Disc;
            }
            set
            {
                this.Disc = (global::NetflixCatalogData.Implementation.Title)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Disc");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Title.DetailsClass.IImplementation.Season
        {
            get
            {
                return this.Season;
            }
            set
            {
                this.Season = (global::NetflixCatalogData.Implementation.Title)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Season");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Title.DetailsClass.IImplementation.Series
        {
            get
            {
                return this.Series;
            }
            set
            {
                this.Series = (global::NetflixCatalogData.Implementation.Title)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Series");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Title.DetailsClass.IImplementation.Movie
        {
            get
            {
                return this.Movie;
            }
            set
            {
                this.Movie = (global::NetflixCatalogData.Implementation.Title)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Movie");
                }
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

namespace ApplicationData.Implementation
{

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class CachedMovies :
        global::LightSwitchApplication.CachedMovies.DetailsClass.IImplementation
    {
    
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}
