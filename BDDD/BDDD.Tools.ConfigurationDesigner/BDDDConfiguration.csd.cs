//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDDD.Tools.ConfigurationDesigner
{
    
    
    /// <summary>
    /// The BDDDConfigSection Configuration Section.
    /// </summary>
    public partial class BDDDConfigSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the BDDDConfigSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string BDDDConfigSectionSectionName = "bDDDConfigSection";
        
        /// <summary>
        /// Gets the BDDDConfigSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public static global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection Instance
        {
            get
            {
                return ((global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection)(global::System.Configuration.ConfigurationManager.GetSection(global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection.BDDDConfigSectionSectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Application Property
        /// <summary>
        /// The XML name of the <see cref="Application"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string ApplicationPropertyName = "application";
        
        /// <summary>
        /// Gets or sets the Application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Application.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection.ApplicationPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::BDDD.Tools.ConfigurationDesigner.ApplicationElement Application
        {
            get
            {
                return ((global::BDDD.Tools.ConfigurationDesigner.ApplicationElement)(base[global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection.ApplicationPropertyName]));
            }
            set
            {
                base[global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection.ApplicationPropertyName] = value;
            }
        }
        #endregion
        
        #region Interception Property
        /// <summary>
        /// The XML name of the <see cref="Interception"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string InterceptionPropertyName = "interception";
        
        /// <summary>
        /// Gets or sets the Interception.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Interception.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection.InterceptionPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::BDDD.Tools.ConfigurationDesigner.InterceptionElement Interception
        {
            get
            {
                return ((global::BDDD.Tools.ConfigurationDesigner.InterceptionElement)(base[global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection.InterceptionPropertyName]));
            }
            set
            {
                base[global::BDDD.Tools.ConfigurationDesigner.BDDDConfigSection.InterceptionPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace BDDD.Tools.ConfigurationDesigner
{
    
    
    /// <summary>
    /// The ApplicationElement Configuration Element.
    /// </summary>
    public partial class ApplicationElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Provider Property
        /// <summary>
        /// The XML name of the <see cref="Provider"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string ProviderPropertyName = "provider";
        
        /// <summary>
        /// Gets or sets the Provider.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Provider.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BDDD.Tools.ConfigurationDesigner.ApplicationElement.ProviderPropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Provider
        {
            get
            {
                return ((string)(base[global::BDDD.Tools.ConfigurationDesigner.ApplicationElement.ProviderPropertyName]));
            }
            set
            {
                base[global::BDDD.Tools.ConfigurationDesigner.ApplicationElement.ProviderPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace BDDD.Tools.ConfigurationDesigner
{
    
    
    /// <summary>
    /// The InterceptionElement Configuration Element.
    /// </summary>
    public partial class InterceptionElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Interceptors Property
        /// <summary>
        /// The XML name of the <see cref="Interceptors"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string InterceptorsPropertyName = "interceptors";
        
        /// <summary>
        /// Gets or sets the Interceptors.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Interceptors.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BDDD.Tools.ConfigurationDesigner.InterceptionElement.InterceptorsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::BDDD.Tools.ConfigurationDesigner.InterceptorElementCollection Interceptors
        {
            get
            {
                return ((global::BDDD.Tools.ConfigurationDesigner.InterceptorElementCollection)(base[global::BDDD.Tools.ConfigurationDesigner.InterceptionElement.InterceptorsPropertyName]));
            }
            set
            {
                base[global::BDDD.Tools.ConfigurationDesigner.InterceptionElement.InterceptorsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace BDDD.Tools.ConfigurationDesigner
{
    
    
    /// <summary>
    /// A collection of InterceptorElement instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::BDDD.Tools.ConfigurationDesigner.InterceptorElement), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::BDDD.Tools.ConfigurationDesigner.InterceptorElementCollection.InterceptorElementPropertyName)]
    public partial class InterceptorElementCollection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string InterceptorElementPropertyName = "interceptorElement";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        protected override string ElementName
        {
            get
            {
                return global::BDDD.Tools.ConfigurationDesigner.InterceptorElementCollection.InterceptorElementPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::BDDD.Tools.ConfigurationDesigner.InterceptorElementCollection.InterceptorElementPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::BDDD.Tools.ConfigurationDesigner.InterceptorElement)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::BDDD.Tools.ConfigurationDesigner.InterceptorElement();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public global::BDDD.Tools.ConfigurationDesigner.InterceptorElement this[int index]
        {
            get
            {
                return ((global::BDDD.Tools.ConfigurationDesigner.InterceptorElement)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public global::BDDD.Tools.ConfigurationDesigner.InterceptorElement this[object name]
        {
            get
            {
                return ((global::BDDD.Tools.ConfigurationDesigner.InterceptorElement)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="interceptorElement">The <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public void Add(global::BDDD.Tools.ConfigurationDesigner.InterceptorElement interceptorElement)
        {
            base.BaseAdd(interceptorElement);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="interceptorElement">The <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public void Remove(global::BDDD.Tools.ConfigurationDesigner.InterceptorElement interceptorElement)
        {
            base.BaseRemove(this.GetElementKey(interceptorElement));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public global::BDDD.Tools.ConfigurationDesigner.InterceptorElement GetItemAt(int index)
        {
            return ((global::BDDD.Tools.ConfigurationDesigner.InterceptorElement)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::BDDD.Tools.ConfigurationDesigner.InterceptorElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public global::BDDD.Tools.ConfigurationDesigner.InterceptorElement GetItemByKey(string name)
        {
            return ((global::BDDD.Tools.ConfigurationDesigner.InterceptorElement)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace BDDD.Tools.ConfigurationDesigner
{
    
    
    /// <summary>
    /// The InterceptorElement Configuration Element.
    /// </summary>
    public partial class InterceptorElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BDDD.Tools.ConfigurationDesigner.InterceptorElement.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::BDDD.Tools.ConfigurationDesigner.InterceptorElement.NamePropertyName]));
            }
            set
            {
                base[global::BDDD.Tools.ConfigurationDesigner.InterceptorElement.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region Type Property
        /// <summary>
        /// The XML name of the <see cref="Type"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string TypePropertyName = "type";
        
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Type.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BDDD.Tools.ConfigurationDesigner.InterceptorElement.TypePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Type
        {
            get
            {
                return ((string)(base[global::BDDD.Tools.ConfigurationDesigner.InterceptorElement.TypePropertyName]));
            }
            set
            {
                base[global::BDDD.Tools.ConfigurationDesigner.InterceptorElement.TypePropertyName] = value;
            }
        }
        #endregion
    }
}
