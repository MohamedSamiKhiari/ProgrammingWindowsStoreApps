﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace StreetFoo.Client.UI
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(type, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(typeName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[14];
            _typeNameTable[0] = "StreetFoo.Client.UI.BooleanNegationConverter";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "StreetFoo.Client.UI.BooleanToVisibilityConverter";
            _typeNameTable[3] = "StreetFoo.Client.UI.StreetFooPage";
            _typeNameTable[4] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[5] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[6] = "StreetFoo.Client.UI.LogonPage";
            _typeNameTable[7] = "StreetFoo.Client.UI.RegisterPage";
            _typeNameTable[8] = "StreetFoo.Client.UI.MyGridView";
            _typeNameTable[9] = "Windows.UI.Xaml.Controls.GridView";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.ItemsControl";
            _typeNameTable[11] = "System.Windows.Input.ICommand";
            _typeNameTable[12] = "Boolean";
            _typeNameTable[13] = "StreetFoo.Client.UI.ReportsPage";

            _typeTable = new global::System.Type[14];
            _typeTable[0] = typeof(global::StreetFoo.Client.UI.BooleanNegationConverter);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::StreetFoo.Client.UI.BooleanToVisibilityConverter);
            _typeTable[3] = typeof(global::StreetFoo.Client.UI.StreetFooPage);
            _typeTable[4] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[5] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[6] = typeof(global::StreetFoo.Client.UI.LogonPage);
            _typeTable[7] = typeof(global::StreetFoo.Client.UI.RegisterPage);
            _typeTable[8] = typeof(global::StreetFoo.Client.UI.MyGridView);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.Controls.GridView);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.ItemsControl);
            _typeTable[11] = typeof(global::System.Windows.Input.ICommand);
            _typeTable[12] = typeof(global::System.Boolean);
            _typeTable[13] = typeof(global::StreetFoo.Client.UI.ReportsPage);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_BooleanNegationConverter() { return new global::StreetFoo.Client.UI.BooleanNegationConverter(); }

        private object Activate_2_BooleanToVisibilityConverter() { return new global::StreetFoo.Client.UI.BooleanToVisibilityConverter(); }

        private object Activate_3_StreetFooPage() { return new global::StreetFoo.Client.UI.StreetFooPage(); }

        private object Activate_6_LogonPage() { return new global::StreetFoo.Client.UI.LogonPage(); }

        private object Activate_7_RegisterPage() { return new global::StreetFoo.Client.UI.RegisterPage(); }

        private object Activate_8_MyGridView() { return new global::StreetFoo.Client.UI.MyGridView(); }

        private object Activate_13_ReportsPage() { return new global::StreetFoo.Client.UI.ReportsPage(); }


        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  StreetFoo.Client.UI.BooleanNegationConverter
                userType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_BooleanNegationConverter;
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  StreetFoo.Client.UI.BooleanToVisibilityConverter
                userType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_2_BooleanToVisibilityConverter;
                xamlType = userType;
                break;

            case 3:   //  StreetFoo.Client.UI.StreetFooPage
                userType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_StreetFooPage;
                xamlType = userType;
                break;

            case 4:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  StreetFoo.Client.UI.LogonPage
                userType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("StreetFoo.Client.UI.StreetFooPage"));
                userType.Activator = Activate_6_LogonPage;
                xamlType = userType;
                break;

            case 7:   //  StreetFoo.Client.UI.RegisterPage
                userType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("StreetFoo.Client.UI.StreetFooPage"));
                userType.Activator = Activate_7_RegisterPage;
                xamlType = userType;
                break;

            case 8:   //  StreetFoo.Client.UI.MyGridView
                userType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.GridView"));
                userType.Activator = Activate_8_MyGridView;
                userType.AddMemberName("SelectionCommand");
                userType.AddMemberName("OpenAppBarsOnRightClick");
                userType.AddMemberName("OpenAppBarsOnMultipleSelection");
                xamlType = userType;
                break;

            case 9:   //  Windows.UI.Xaml.Controls.GridView
                xamlType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  Windows.UI.Xaml.Controls.ItemsControl
                xamlType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  System.Windows.Input.ICommand
                userType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType(this, typeName, type, null);
                xamlType = userType;
                break;

            case 12:   //  Boolean
                xamlType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 13:   //  StreetFoo.Client.UI.ReportsPage
                userType = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("StreetFoo.Client.UI.StreetFooPage"));
                userType.Activator = Activate_13_ReportsPage;
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_MyGridView_SelectionCommand(object instance)
        {
            var that = (global::StreetFoo.Client.UI.MyGridView)instance;
            return that.SelectionCommand;
        }
        private void set_0_MyGridView_SelectionCommand(object instance, object Value)
        {
            var that = (global::StreetFoo.Client.UI.MyGridView)instance;
            that.SelectionCommand = (global::System.Windows.Input.ICommand)Value;
        }
        private object get_1_MyGridView_OpenAppBarsOnRightClick(object instance)
        {
            var that = (global::StreetFoo.Client.UI.MyGridView)instance;
            return that.OpenAppBarsOnRightClick;
        }
        private void set_1_MyGridView_OpenAppBarsOnRightClick(object instance, object Value)
        {
            var that = (global::StreetFoo.Client.UI.MyGridView)instance;
            that.OpenAppBarsOnRightClick = (global::System.Boolean)Value;
        }
        private object get_2_MyGridView_OpenAppBarsOnMultipleSelection(object instance)
        {
            var that = (global::StreetFoo.Client.UI.MyGridView)instance;
            return that.OpenAppBarsOnMultipleSelection;
        }
        private void set_2_MyGridView_OpenAppBarsOnMultipleSelection(object instance, object Value)
        {
            var that = (global::StreetFoo.Client.UI.MyGridView)instance;
            that.OpenAppBarsOnMultipleSelection = (global::System.Boolean)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlMember xamlMember = null;
            global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "StreetFoo.Client.UI.MyGridView.SelectionCommand":
                userType = (global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("StreetFoo.Client.UI.MyGridView");
                xamlMember = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlMember(this, "SelectionCommand", "System.Windows.Input.ICommand");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_MyGridView_SelectionCommand;
                xamlMember.Setter = set_0_MyGridView_SelectionCommand;
                break;
            case "StreetFoo.Client.UI.MyGridView.OpenAppBarsOnRightClick":
                userType = (global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("StreetFoo.Client.UI.MyGridView");
                xamlMember = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlMember(this, "OpenAppBarsOnRightClick", "Boolean");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_MyGridView_OpenAppBarsOnRightClick;
                xamlMember.Setter = set_1_MyGridView_OpenAppBarsOnRightClick;
                break;
            case "StreetFoo.Client.UI.MyGridView.OpenAppBarsOnMultipleSelection":
                userType = (global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("StreetFoo.Client.UI.MyGridView");
                xamlMember = new global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlMember(this, "OpenAppBarsOnMultipleSelection", "Boolean");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_2_MyGridView_OpenAppBarsOnMultipleSelection;
                xamlMember.Setter = set_2_MyGridView_OpenAppBarsOnMultipleSelection;
                break;
            }
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlSystemBaseType
    {
        global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::StreetFoo.Client.UI.StreetFoo_Client_UI_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


