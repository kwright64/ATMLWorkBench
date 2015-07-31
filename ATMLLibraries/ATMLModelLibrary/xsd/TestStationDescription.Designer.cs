// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.0.0.285
//    <NameSpace>ATMLCommonLibrary.model.equipment</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><InitializeFields>Collections</InitializeFields><GenerateUnusedComplexTypes>True</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>True</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>True</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>Default</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>True</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>True</ExcludeImportedTypes><ExpandNesteadAttributeGroup>True</ExpandNesteadAttributeGroup><CleanupCode>True</CleanupCode><EnableXmlSerialization>True</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><GenerateShouldSerialize>True</GenerateShouldSerialize><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings>ATMLCommonLibrary.model.common</CustomUsings>
//  </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable
namespace ATMLModelLibrary.model.equipment
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using ATMLModelLibrary.model.common;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [Serializable]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="urn:IEEE-1671.6:2009.03:TestStationDescription")]
    [XmlRootAttribute("TestStationDescription", Namespace="urn:IEEE-1671.6:2009.03:TestStationDescription", IsNullable=false)]
    public partial class TestStationDescription11 : TestStationDescription
    {
        
        private string _uuid;
        
        private static XmlSerializer serializer;
        
        [XmlAttribute]
        public string uuid
        {
            get
            {
                return _uuid;
            }
            set
            {
                _uuid = value;
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof(TestStationDescription11));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current TestStationDescription11 object into an XML string
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try
            {
                memoryStream = new MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an TestStationDescription11 object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output TestStationDescription11 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out TestStationDescription11 obj, out Exception exception)
        {
            exception = null;
            obj = default(TestStationDescription11);
            try
            {
                obj = Deserialize(input);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string input, out TestStationDescription11 obj)
        {
            Exception exception;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static TestStationDescription11 Deserialize(string input)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(input);
                return ((TestStationDescription11)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static TestStationDescription11 Deserialize(Stream s)
        {
            return ((TestStationDescription11)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current TestStationDescription11 object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName)
        {
            StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize();
                FileInfo xmlFile = new FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an TestStationDescription11 object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TestStationDescription11 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out TestStationDescription11 obj, out Exception exception)
        {
            exception = null;
            obj = default(TestStationDescription11);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out TestStationDescription11 obj)
        {
            Exception exception;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public new static TestStationDescription11 LoadFromFile(string fileName)
        {
            FileStream file = null;
            StreamReader sr = null;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }

        public string GetAtmlFileDescription()
        {
            string description = string.Format("XML Representation of Test Station {0}", GetAtmlName());
            if (!string.IsNullOrEmpty(this.Description))
                description = this.Description;
            return description;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [Serializable]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:IEEE-1671.6:2009.03:TestStationDescription")]
    public partial class TestStationDescription : TestEquipment
    {
        
        private List<TestStationDescriptionInstrument> _instruments;
        
        private static XmlSerializer serializer;
        
        /// <summary>
        /// TestStationDescription class constructor
        /// </summary>
        public TestStationDescription()
        {
            _instruments = new List<TestStationDescriptionInstrument>();
        }
        
        /// <summary>
        /// This element is a list of all instruments in the test station.
        /// </summary>
        [XmlArrayAttribute(Order=0)]
        [XmlArrayItemAttribute("Instrument", IsNullable=false)]
        public List<TestStationDescriptionInstrument> Instruments
        {
            get
            {
                return _instruments;
            }
            set
            {
                _instruments = value;
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof(TestStationDescription));
                }
                return serializer;
            }
        }
        
        /// <summary>
        /// Test whether Instruments should be serialized
        /// </summary>
        public virtual bool ShouldSerializeInstruments()
        {
            return Instruments != null && Instruments.Count > 0;
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current TestStationDescription object into an XML string
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try
            {
                memoryStream = new MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an TestStationDescription object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output TestStationDescription object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out TestStationDescription obj, out Exception exception)
        {
            exception = null;
            obj = default(TestStationDescription);
            try
            {
                obj = Deserialize(input);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string input, out TestStationDescription obj)
        {
            Exception exception;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static TestStationDescription Deserialize(string input)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(input);
                return ((TestStationDescription)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static TestStationDescription Deserialize(Stream s)
        {
            return ((TestStationDescription)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current TestStationDescription object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName)
        {
            StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize();
                FileInfo xmlFile = new FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an TestStationDescription object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TestStationDescription object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out TestStationDescription obj, out Exception exception)
        {
            exception = null;
            obj = default(TestStationDescription);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out TestStationDescription obj)
        {
            Exception exception;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public new static TestStationDescription LoadFromFile(string fileName)
        {
            FileStream file = null;
            StreamReader sr = null;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [Serializable]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="urn:IEEE-1671.6:2009.03:TestStationDescription")]
    public partial class TestStationDescriptionInstrument : ItemDescriptionReference
    {
        
        private string _physicalLocation;
        
        private string _address;
        
        private string _id;
        
        private static XmlSerializer serializer;
        
        [XmlElementAttribute(Order=0)]
        public string PhysicalLocation
        {
            get
            {
                return _physicalLocation;
            }
            set
            {
                _physicalLocation = value;
            }
        }
        
        [XmlElementAttribute(Order=1)]
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        
        [XmlAttribute]
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof(TestStationDescriptionInstrument));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current TestStationDescriptionInstrument object into an XML string
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try
            {
                memoryStream = new MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an TestStationDescriptionInstrument object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output TestStationDescriptionInstrument object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out TestStationDescriptionInstrument obj, out Exception exception)
        {
            exception = null;
            obj = default(TestStationDescriptionInstrument);
            try
            {
                obj = Deserialize(input);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string input, out TestStationDescriptionInstrument obj)
        {
            Exception exception;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static TestStationDescriptionInstrument Deserialize(string input)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(input);
                return ((TestStationDescriptionInstrument)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static TestStationDescriptionInstrument Deserialize(Stream s)
        {
            return ((TestStationDescriptionInstrument)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current TestStationDescriptionInstrument object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName)
        {
            StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize();
                FileInfo xmlFile = new FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an TestStationDescriptionInstrument object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TestStationDescriptionInstrument object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out TestStationDescriptionInstrument obj, out Exception exception)
        {
            exception = null;
            obj = default(TestStationDescriptionInstrument);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out TestStationDescriptionInstrument obj)
        {
            Exception exception;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public new static TestStationDescriptionInstrument LoadFromFile(string fileName)
        {
            FileStream file = null;
            StreamReader sr = null;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
    }
}
#pragma warning restore
