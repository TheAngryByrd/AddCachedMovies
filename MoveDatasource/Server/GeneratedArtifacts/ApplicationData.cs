//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace ApplicationData.Implementation
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ApplicationDataObjectContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ApplicationDataObjectContext object using the connection string found in the 'ApplicationDataObjectContext' section of the application configuration file.
        /// </summary>
        public ApplicationDataObjectContext() : base("name=ApplicationDataObjectContext", "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ApplicationDataObjectContext object.
        /// </summary>
        public ApplicationDataObjectContext(string connectionString) : base(connectionString, "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ApplicationDataObjectContext object.
        /// </summary>
        public ApplicationDataObjectContext(EntityConnection connection) : base(connection, "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CachedMovies> CachedMoviesSet
        {
            get
            {
                if ((_CachedMoviesSet == null))
                {
                    _CachedMoviesSet = base.CreateObjectSet<CachedMovies>("CachedMoviesSet");
                }
                return _CachedMoviesSet;
            }
        }
        private ObjectSet<CachedMovies> _CachedMoviesSet;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CachedMoviesSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCachedMoviesSet(CachedMovies cachedMovies)
        {
            base.AddObject("CachedMoviesSet", cachedMovies);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="CachedMovies")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CachedMovies : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CachedMovies object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="rowVersion">Initial value of the RowVersion property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="rating">Initial value of the Rating property.</param>
        /// <param name="releaseYear">Initial value of the ReleaseYear property.</param>
        public static CachedMovies CreateCachedMovies(global::System.Int32 id, global::System.Byte[] rowVersion, global::System.String title, global::System.String rating, global::System.Int32 releaseYear)
        {
            CachedMovies cachedMovies = new CachedMovies();
            cachedMovies.Id = id;
            cachedMovies.RowVersion = rowVersion;
            cachedMovies.Title = title;
            cachedMovies.Rating = rating;
            cachedMovies.ReleaseYear = releaseYear;
            return cachedMovies;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = value;
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] RowVersion
        {
            get
            {
                return StructuralObject.GetValidValue(_RowVersion);
            }
            set
            {
                OnRowVersionChanging(value);
                ReportPropertyChanging("RowVersion");
                _RowVersion = value;
                ReportPropertyChanged("RowVersion");
                OnRowVersionChanged();
            }
        }
        private global::System.Byte[] _RowVersion;
        partial void OnRowVersionChanging(global::System.Byte[] value);
        partial void OnRowVersionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = value;
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Rating
        {
            get
            {
                return _Rating;
            }
            set
            {
                OnRatingChanging(value);
                ReportPropertyChanging("Rating");
                _Rating = value;
                ReportPropertyChanged("Rating");
                OnRatingChanged();
            }
        }
        private global::System.String _Rating;
        partial void OnRatingChanging(global::System.String value);
        partial void OnRatingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ReleaseYear
        {
            get
            {
                return _ReleaseYear;
            }
            set
            {
                OnReleaseYearChanging(value);
                ReportPropertyChanging("ReleaseYear");
                _ReleaseYear = value;
                ReportPropertyChanged("ReleaseYear");
                OnReleaseYearChanged();
            }
        }
        private global::System.Int32 _ReleaseYear;
        partial void OnReleaseYearChanging(global::System.Int32 value);
        partial void OnReleaseYearChanged();

        #endregion

    
    }

    #endregion

    
}
