using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DS.NintendoWare.GFX
{
    public class CMAT
    {

        // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class NintendoWareIntermediateFile
        {

            private NintendoWareIntermediateFileGraphicsContentCtr graphicsContentCtrField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtr GraphicsContentCtr
            {
                get
                {
                    return this.graphicsContentCtrField;
                }
                set
                {
                    this.graphicsContentCtrField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtr
        {

            private NintendoWareIntermediateFileGraphicsContentCtrEditData editDataField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterials materialsField;

            private string versionField;

            private string namespaceField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrEditData EditData
            {
                get
                {
                    return this.editDataField;
                }
                set
                {
                    this.editDataField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterials Materials
            {
                get
                {
                    return this.materialsField;
                }
                set
                {
                    this.materialsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Namespace
            {
                get
                {
                    return this.namespaceField;
                }
                set
                {
                    this.namespaceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrEditData
        {

            private NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaData metaDataField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaData MetaData
            {
                get
                {
                    return this.metaDataField;
                }
                set
                {
                    this.metaDataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaData
        {

            private string keyField;

            private NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataCreate createField;

            private NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataModify modifyField;

            /// <remarks/>
            public string Key
            {
                get
                {
                    return this.keyField;
                }
                set
                {
                    this.keyField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataCreate Create
            {
                get
                {
                    return this.createField;
                }
                set
                {
                    this.createField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataModify Modify
            {
                get
                {
                    return this.modifyField;
                }
                set
                {
                    this.modifyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataCreate
        {

            private NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataCreateToolDescriptions toolDescriptionsField;

            private System.DateTime dateField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataCreateToolDescriptions ToolDescriptions
            {
                get
                {
                    return this.toolDescriptionsField;
                }
                set
                {
                    this.toolDescriptionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataCreateToolDescriptions
        {

            private string nameField;

            private string versionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataModify
        {

            private NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataModifyToolDescriptions toolDescriptionsField;

            private System.DateTime dateField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataModifyToolDescriptions ToolDescriptions
            {
                get
                {
                    return this.toolDescriptionsField;
                }
                set
                {
                    this.toolDescriptionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataModifyToolDescriptions
        {

            private string nameField;

            private string versionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterials
        {

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtr materialCtrField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtr MaterialCtr
            {
                get
                {
                    return this.materialCtrField;
                }
                set
                {
                    this.materialCtrField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtr
        {

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrEditData editDataField;

            private object shaderReferenceField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrMaterialColor materialColorField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrRasterization rasterizationField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrTextureCoordinatorCtr[] textureCoordinatorsField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtr[] textureMappersField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShader fragmentShaderField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperation fragmentOperationField;

            private string nameField;

            private bool isCompressibleField;

            private byte lightSetIndexField;

            private byte fogIndexField;

            private bool isFragmentLightEnabledField;

            private bool isVertexLightEnabledField;

            private bool isHemiSphereLightEnabledField;

            private bool isHemiSphereOcclusionEnabledField;

            private bool isFogEnabledField;

            private string textureCoordinateConfigField;

            private string translucencyKindField;

            private sbyte shaderProgramDescriptionIndexField;

            private string shaderBinaryKindField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrEditData EditData
            {
                get
                {
                    return this.editDataField;
                }
                set
                {
                    this.editDataField = value;
                }
            }

            /// <remarks/>
            public object ShaderReference
            {
                get
                {
                    return this.shaderReferenceField;
                }
                set
                {
                    this.shaderReferenceField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrMaterialColor MaterialColor
            {
                get
                {
                    return this.materialColorField;
                }
                set
                {
                    this.materialColorField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrRasterization Rasterization
            {
                get
                {
                    return this.rasterizationField;
                }
                set
                {
                    this.rasterizationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("TextureCoordinatorCtr", IsNullable = false)]
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrTextureCoordinatorCtr[] TextureCoordinators
            {
                get
                {
                    return this.textureCoordinatorsField;
                }
                set
                {
                    this.textureCoordinatorsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("PixelBasedTextureMapperCtr", IsNullable = false)]
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtr[] TextureMappers
            {
                get
                {
                    return this.textureMappersField;
                }
                set
                {
                    this.textureMappersField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShader FragmentShader
            {
                get
                {
                    return this.fragmentShaderField;
                }
                set
                {
                    this.fragmentShaderField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperation FragmentOperation
            {
                get
                {
                    return this.fragmentOperationField;
                }
                set
                {
                    this.fragmentOperationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsCompressible
            {
                get
                {
                    return this.isCompressibleField;
                }
                set
                {
                    this.isCompressibleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte LightSetIndex
            {
                get
                {
                    return this.lightSetIndexField;
                }
                set
                {
                    this.lightSetIndexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte FogIndex
            {
                get
                {
                    return this.fogIndexField;
                }
                set
                {
                    this.fogIndexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsFragmentLightEnabled
            {
                get
                {
                    return this.isFragmentLightEnabledField;
                }
                set
                {
                    this.isFragmentLightEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsVertexLightEnabled
            {
                get
                {
                    return this.isVertexLightEnabledField;
                }
                set
                {
                    this.isVertexLightEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsHemiSphereLightEnabled
            {
                get
                {
                    return this.isHemiSphereLightEnabledField;
                }
                set
                {
                    this.isHemiSphereLightEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsHemiSphereOcclusionEnabled
            {
                get
                {
                    return this.isHemiSphereOcclusionEnabledField;
                }
                set
                {
                    this.isHemiSphereOcclusionEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsFogEnabled
            {
                get
                {
                    return this.isFogEnabledField;
                }
                set
                {
                    this.isFogEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TextureCoordinateConfig
            {
                get
                {
                    return this.textureCoordinateConfigField;
                }
                set
                {
                    this.textureCoordinateConfigField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TranslucencyKind
            {
                get
                {
                    return this.translucencyKindField;
                }
                set
                {
                    this.translucencyKindField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte ShaderProgramDescriptionIndex
            {
                get
                {
                    return this.shaderProgramDescriptionIndexField;
                }
                set
                {
                    this.shaderProgramDescriptionIndexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ShaderBinaryKind
            {
                get
                {
                    return this.shaderBinaryKindField;
                }
                set
                {
                    this.shaderBinaryKindField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrEditData
        {

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrEditDataMaterialCopySettingsMedaData materialCopySettingsMedaDataField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrEditDataMaterialCopySettingsMedaData MaterialCopySettingsMedaData
            {
                get
                {
                    return this.materialCopySettingsMedaDataField;
                }
                set
                {
                    this.materialCopySettingsMedaDataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrEditDataMaterialCopySettingsMedaData
        {

            private string keyField;

            private string materialCopyFilterField;

            /// <remarks/>
            public string Key
            {
                get
                {
                    return this.keyField;
                }
                set
                {
                    this.keyField = value;
                }
            }

            /// <remarks/>
            public string MaterialCopyFilter
            {
                get
                {
                    return this.materialCopyFilterField;
                }
                set
                {
                    this.materialCopyFilterField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrMaterialColor
        {

            private NintendoWareIntermediateFileGraphicsContentCtrColor emissionField;

            private NintendoWareIntermediateFileGraphicsContentCtrColor ambientField;

            private NintendoWareIntermediateFileGraphicsContentCtrColor diffuseField;

            private NintendoWareIntermediateFileGraphicsContentCtrColor specular0Field;

            private NintendoWareIntermediateFileGraphicsContentCtrColor specular1Field;

            private NintendoWareIntermediateFileGraphicsContentCtrColor constant0Field;

            private NintendoWareIntermediateFileGraphicsContentCtrColor constant1Field;

            private NintendoWareIntermediateFileGraphicsContentCtrColor constant2Field;

            private NintendoWareIntermediateFileGraphicsContentCtrColor constant3Field;

            private NintendoWareIntermediateFileGraphicsContentCtrColor constant4Field;

            private NintendoWareIntermediateFileGraphicsContentCtrColor constant5Field;

            private float vertexColorScaleField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Emission
            {
                get
                {
                    return this.emissionField;
                }
                set
                {
                    this.emissionField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Ambient
            {
                get
                {
                    return this.ambientField;
                }
                set
                {
                    this.ambientField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Diffuse
            {
                get
                {
                    return this.diffuseField;
                }
                set
                {
                    this.diffuseField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Specular0
            {
                get
                {
                    return this.specular0Field;
                }
                set
                {
                    this.specular0Field = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Specular1
            {
                get
                {
                    return this.specular1Field;
                }
                set
                {
                    this.specular1Field = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Constant0
            {
                get
                {
                    return this.constant0Field;
                }
                set
                {
                    this.constant0Field = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Constant1
            {
                get
                {
                    return this.constant1Field;
                }
                set
                {
                    this.constant1Field = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Constant2
            {
                get
                {
                    return this.constant2Field;
                }
                set
                {
                    this.constant2Field = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Constant3
            {
                get
                {
                    return this.constant3Field;
                }
                set
                {
                    this.constant3Field = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Constant4
            {
                get
                {
                    return this.constant4Field;
                }
                set
                {
                    this.constant4Field = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor Constant5
            {
                get
                {
                    return this.constant5Field;
                }
                set
                {
                    this.constant5Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float VertexColorScale
            {
                get
                {
                    return this.vertexColorScaleField;
                }
                set
                {
                    this.vertexColorScaleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrColor
        {

            private float rField;

            private float gField;

            private float bField;

            private float aField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float R
            {
                get
                {
                    return this.rField;
                }
                set
                {
                    this.rField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float G
            {
                get
                {
                    return this.gField;
                }
                set
                {
                    this.gField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float B
            {
                get
                {
                    return this.bField;
                }
                set
                {
                    this.bField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float A
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrRasterization
        {

            private string cullingModeField;

            private bool isPolygonOffsetEnabledField;

            private float polygonOffsetUnitField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CullingMode
            {
                get
                {
                    return this.cullingModeField;
                }
                set
                {
                    this.cullingModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsPolygonOffsetEnabled
            {
                get
                {
                    return this.isPolygonOffsetEnabledField;
                }
                set
                {
                    this.isPolygonOffsetEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float PolygonOffsetUnit
            {
                get
                {
                    return this.polygonOffsetUnitField;
                }
                set
                {
                    this.polygonOffsetUnitField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrTextureCoordinatorCtr
        {

            private byte sourceCoordinateField;

            private string mappingMethodField;

            private sbyte referenceCameraField;

            private string matrixModeField;

            private float scaleSField;

            private float scaleTField;

            private float rotateField;

            private float translateSField;

            private float translateTField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte SourceCoordinate
            {
                get
                {
                    return this.sourceCoordinateField;
                }
                set
                {
                    this.sourceCoordinateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MappingMethod
            {
                get
                {
                    return this.mappingMethodField;
                }
                set
                {
                    this.mappingMethodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte ReferenceCamera
            {
                get
                {
                    return this.referenceCameraField;
                }
                set
                {
                    this.referenceCameraField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MatrixMode
            {
                get
                {
                    return this.matrixModeField;
                }
                set
                {
                    this.matrixModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float ScaleS
            {
                get
                {
                    return this.scaleSField;
                }
                set
                {
                    this.scaleSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float ScaleT
            {
                get
                {
                    return this.scaleTField;
                }
                set
                {
                    this.scaleTField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float Rotate
            {
                get
                {
                    return this.rotateField;
                }
                set
                {
                    this.rotateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float TranslateS
            {
                get
                {
                    return this.translateSField;
                }
                set
                {
                    this.translateSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float TranslateT
            {
                get
                {
                    return this.translateTField;
                }
                set
                {
                    this.translateTField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtr
        {

            private string textureReferenceField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtrStandardTextureSamplerCtr standardTextureSamplerCtrField;

            /// <remarks/>
            public string TextureReference
            {
                get
                {
                    return this.textureReferenceField;
                }
                set
                {
                    this.textureReferenceField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtrStandardTextureSamplerCtr StandardTextureSamplerCtr
            {
                get
                {
                    return this.standardTextureSamplerCtrField;
                }
                set
                {
                    this.standardTextureSamplerCtrField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtrStandardTextureSamplerCtr
        {

            private NintendoWareIntermediateFileGraphicsContentCtrColor borderColorField;

            private string minFilterField;

            private string magFilterField;

            private string wrapSField;

            private string wrapTField;

            private byte minLodField;

            private float lodBiasField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor BorderColor
            {
                get
                {
                    return this.borderColorField;
                }
                set
                {
                    this.borderColorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MinFilter
            {
                get
                {
                    return this.minFilterField;
                }
                set
                {
                    this.minFilterField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MagFilter
            {
                get
                {
                    return this.magFilterField;
                }
                set
                {
                    this.magFilterField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string WrapS
            {
                get
                {
                    return this.wrapSField;
                }
                set
                {
                    this.wrapSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string WrapT
            {
                get
                {
                    return this.wrapTField;
                }
                set
                {
                    this.wrapTField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte MinLod
            {
                get
                {
                    return this.minLodField;
                }
                set
                {
                    this.minLodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float LodBias
            {
                get
                {
                    return this.lodBiasField;
                }
                set
                {
                    this.lodBiasField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtrStandardTextureSamplerCtrBorderColor
        {

            private byte rField;

            private byte gField;

            private decimal bField;

            private byte aField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte R
            {
                get
                {
                    return this.rField;
                }
                set
                {
                    this.rField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte G
            {
                get
                {
                    return this.gField;
                }
                set
                {
                    this.gField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal B
            {
                get
                {
                    return this.bField;
                }
                set
                {
                    this.bField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte A
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShader
        {

            private NintendoWareIntermediateFileGraphicsContentCtrColor bufferColorField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentBump fragmentBumpField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLighting fragmentLightingField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTable fragmentLightingTableField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtr[] textureCombinersField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderAlphaTest alphaTestField;

            private string layerConfigField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor BufferColor
            {
                get
                {
                    return this.bufferColorField;
                }
                set
                {
                    this.bufferColorField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentBump FragmentBump
            {
                get
                {
                    return this.fragmentBumpField;
                }
                set
                {
                    this.fragmentBumpField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLighting FragmentLighting
            {
                get
                {
                    return this.fragmentLightingField;
                }
                set
                {
                    this.fragmentLightingField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTable FragmentLightingTable
            {
                get
                {
                    return this.fragmentLightingTableField;
                }
                set
                {
                    this.fragmentLightingTableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("TextureCombinerCtr", IsNullable = false)]
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtr[] TextureCombiners
            {
                get
                {
                    return this.textureCombinersField;
                }
                set
                {
                    this.textureCombinersField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderAlphaTest AlphaTest
            {
                get
                {
                    return this.alphaTestField;
                }
                set
                {
                    this.alphaTestField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string LayerConfig
            {
                get
                {
                    return this.layerConfigField;
                }
                set
                {
                    this.layerConfigField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderBufferColor
        {

            private decimal rField;

            private byte gField;

            private byte bField;

            private byte aField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal R
            {
                get
                {
                    return this.rField;
                }
                set
                {
                    this.rField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte G
            {
                get
                {
                    return this.gField;
                }
                set
                {
                    this.gField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte B
            {
                get
                {
                    return this.bField;
                }
                set
                {
                    this.bField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte A
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentBump
        {

            private string bumpTextureIndexField;

            private string bumpModeField;

            private bool isBumpRenormalizeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BumpTextureIndex
            {
                get
                {
                    return this.bumpTextureIndexField;
                }
                set
                {
                    this.bumpTextureIndexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BumpMode
            {
                get
                {
                    return this.bumpModeField;
                }
                set
                {
                    this.bumpModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsBumpRenormalize
            {
                get
                {
                    return this.isBumpRenormalizeField;
                }
                set
                {
                    this.isBumpRenormalizeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLighting
        {

            private string fresnelConfigField;

            private bool isClampHighLightField;

            private bool isDistribution0EnabledField;

            private bool isDistribution1EnabledField;

            private bool isGeometricFactor0EnabledField;

            private bool isGeometricFactor1EnabledField;

            private bool isReflectionEnabledField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FresnelConfig
            {
                get
                {
                    return this.fresnelConfigField;
                }
                set
                {
                    this.fresnelConfigField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsClampHighLight
            {
                get
                {
                    return this.isClampHighLightField;
                }
                set
                {
                    this.isClampHighLightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsDistribution0Enabled
            {
                get
                {
                    return this.isDistribution0EnabledField;
                }
                set
                {
                    this.isDistribution0EnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsDistribution1Enabled
            {
                get
                {
                    return this.isDistribution1EnabledField;
                }
                set
                {
                    this.isDistribution1EnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsGeometricFactor0Enabled
            {
                get
                {
                    return this.isGeometricFactor0EnabledField;
                }
                set
                {
                    this.isGeometricFactor0EnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsGeometricFactor1Enabled
            {
                get
                {
                    return this.isGeometricFactor1EnabledField;
                }
                set
                {
                    this.isGeometricFactor1EnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsReflectionEnabled
            {
                get
                {
                    return this.isReflectionEnabledField;
                }
                set
                {
                    this.isReflectionEnabledField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTable
        {

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler reflectanceRSamplerField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler reflectanceGSamplerField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler reflectanceBSamplerField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler distribution0SamplerField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler distribution1SamplerField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler fresnelSamplerField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler ReflectanceRSampler
            {
                get
                {
                    return this.reflectanceRSamplerField;
                }
                set
                {
                    this.reflectanceRSamplerField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler ReflectanceGSampler
            {
                get
                {
                    return this.reflectanceGSamplerField;
                }
                set
                {
                    this.reflectanceGSamplerField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler ReflectanceBSampler
            {
                get
                {
                    return this.reflectanceBSamplerField;
                }
                set
                {
                    this.reflectanceBSamplerField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler Distribution0Sampler
            {
                get
                {
                    return this.distribution0SamplerField;
                }
                set
                {
                    this.distribution0SamplerField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler Distribution1Sampler
            {
                get
                {
                    return this.distribution1SamplerField;
                }
                set
                {
                    this.distribution1SamplerField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler FresnelSampler
            {
                get
                {
                    return this.fresnelSamplerField;
                }
                set
                {
                    this.fresnelSamplerField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler
        {
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableReferenceLookupTableCtr referenceLookupTableCtrField;

            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableNullLookupTableCtr nullLookupTableCtrField;

            private bool isAbsField;

            private string inputField;

            private string scaleField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableReferenceLookupTableCtr ReferenceLookupTableCtr
            {
                get
                {
                    return this.referenceLookupTableCtrField;
                }
                set
                {
                    this.referenceLookupTableCtrField = value;
                }
            }

            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableNullLookupTableCtr NullLookupTableCtr
            {
                get
                {
                    return this.nullLookupTableCtrField;
                }
                set
                {
                    this.nullLookupTableCtrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsAbs
            {
                get
                {
                    return this.isAbsField;
                }
                set
                {
                    this.isAbsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Input
            {
                get
                {
                    return this.inputField;
                }
                set
                {
                    this.inputField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Scale
            {
                get
                {
                    return this.scaleField;
                }
                set
                {
                    this.scaleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableNullLookupTableCtr
        {
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableReferenceLookupTableCtr
        {

            private string lookupTableSetContentReferenceCtrField;

            private string tableNameField;

            /// <remarks/>
            public string LookupTableSetContentReferenceCtr
            {
                get
                {
                    return this.lookupTableSetContentReferenceCtrField;
                }
                set
                {
                    this.lookupTableSetContentReferenceCtrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }
        }
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtr
        {

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrSourceRgb sourceRgbField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrOperandRgb operandRgbField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrSourceAlpha sourceAlphaField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrOperandAlpha operandAlphaField;

            private string combineRgbField;

            private string combineAlphaField;

            private string scaleRgbField;

            private string scaleAlphaField;

            private string constantField;

            private string bufferInputRgbField;

            private string bufferInputAlphaField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrSourceRgb SourceRgb
            {
                get
                {
                    return this.sourceRgbField;
                }
                set
                {
                    this.sourceRgbField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrOperandRgb OperandRgb
            {
                get
                {
                    return this.operandRgbField;
                }
                set
                {
                    this.operandRgbField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrSourceAlpha SourceAlpha
            {
                get
                {
                    return this.sourceAlphaField;
                }
                set
                {
                    this.sourceAlphaField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrOperandAlpha OperandAlpha
            {
                get
                {
                    return this.operandAlphaField;
                }
                set
                {
                    this.operandAlphaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CombineRgb
            {
                get
                {
                    return this.combineRgbField;
                }
                set
                {
                    this.combineRgbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CombineAlpha
            {
                get
                {
                    return this.combineAlphaField;
                }
                set
                {
                    this.combineAlphaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ScaleRgb
            {
                get
                {
                    return this.scaleRgbField;
                }
                set
                {
                    this.scaleRgbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ScaleAlpha
            {
                get
                {
                    return this.scaleAlphaField;
                }
                set
                {
                    this.scaleAlphaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Constant
            {
                get
                {
                    return this.constantField;
                }
                set
                {
                    this.constantField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BufferInputRgb
            {
                get
                {
                    return this.bufferInputRgbField;
                }
                set
                {
                    this.bufferInputRgbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BufferInputAlpha
            {
                get
                {
                    return this.bufferInputAlphaField;
                }
                set
                {
                    this.bufferInputAlphaField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrSourceRgb
        {

            private string source0Field;

            private string source1Field;

            private string source2Field;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Source0
            {
                get
                {
                    return this.source0Field;
                }
                set
                {
                    this.source0Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Source1
            {
                get
                {
                    return this.source1Field;
                }
                set
                {
                    this.source1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Source2
            {
                get
                {
                    return this.source2Field;
                }
                set
                {
                    this.source2Field = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrOperandRgb
        {

            private string operand0Field;

            private string operand1Field;

            private string operand2Field;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Operand0
            {
                get
                {
                    return this.operand0Field;
                }
                set
                {
                    this.operand0Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Operand1
            {
                get
                {
                    return this.operand1Field;
                }
                set
                {
                    this.operand1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Operand2
            {
                get
                {
                    return this.operand2Field;
                }
                set
                {
                    this.operand2Field = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrSourceAlpha
        {

            private string source0Field;

            private string source1Field;

            private string source2Field;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Source0
            {
                get
                {
                    return this.source0Field;
                }
                set
                {
                    this.source0Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Source1
            {
                get
                {
                    return this.source1Field;
                }
                set
                {
                    this.source1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Source2
            {
                get
                {
                    return this.source2Field;
                }
                set
                {
                    this.source2Field = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrOperandAlpha
        {

            private string operand0Field;

            private string operand1Field;

            private string operand2Field;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Operand0
            {
                get
                {
                    return this.operand0Field;
                }
                set
                {
                    this.operand0Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Operand1
            {
                get
                {
                    return this.operand1Field;
                }
                set
                {
                    this.operand1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Operand2
            {
                get
                {
                    return this.operand2Field;
                }
                set
                {
                    this.operand2Field = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderAlphaTest
        {

            private bool isTestEnabledField;

            private string testFunctionField;

            private float testReferenceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsTestEnabled
            {
                get
                {
                    return this.isTestEnabledField;
                }
                set
                {
                    this.isTestEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TestFunction
            {
                get
                {
                    return this.testFunctionField;
                }
                set
                {
                    this.testFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float TestReference
            {
                get
                {
                    return this.testReferenceField;
                }
                set
                {
                    this.testReferenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperation
        {

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationDepthOperation depthOperationField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperation blendOperationField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationStencilOperation stencilOperationField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationDepthOperation DepthOperation
            {
                get
                {
                    return this.depthOperationField;
                }
                set
                {
                    this.depthOperationField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperation BlendOperation
            {
                get
                {
                    return this.blendOperationField;
                }
                set
                {
                    this.blendOperationField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationStencilOperation StencilOperation
            {
                get
                {
                    return this.stencilOperationField;
                }
                set
                {
                    this.stencilOperationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationDepthOperation
        {

            private bool isTestEnabledField;

            private string testFunctionField;

            private bool isMaskEnabledField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsTestEnabled
            {
                get
                {
                    return this.isTestEnabledField;
                }
                set
                {
                    this.isTestEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TestFunction
            {
                get
                {
                    return this.testFunctionField;
                }
                set
                {
                    this.testFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsMaskEnabled
            {
                get
                {
                    return this.isMaskEnabledField;
                }
                set
                {
                    this.isMaskEnabledField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperation
        {

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperationRgbParameter rgbParameterField;

            private NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperationAlphaParameter alphaParameterField;

            private NintendoWareIntermediateFileGraphicsContentCtrColor blendColorField;

            private string modeField;

            private string logicOperationField;

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperationRgbParameter RgbParameter
            {
                get
                {
                    return this.rgbParameterField;
                }
                set
                {
                    this.rgbParameterField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperationAlphaParameter AlphaParameter
            {
                get
                {
                    return this.alphaParameterField;
                }
                set
                {
                    this.alphaParameterField = value;
                }
            }

            /// <remarks/>
            public NintendoWareIntermediateFileGraphicsContentCtrColor BlendColor
            {
                get
                {
                    return this.blendColorField;
                }
                set
                {
                    this.blendColorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Mode
            {
                get
                {
                    return this.modeField;
                }
                set
                {
                    this.modeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string LogicOperation
            {
                get
                {
                    return this.logicOperationField;
                }
                set
                {
                    this.logicOperationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperationRgbParameter
        {

            private string blendFunctionSourceField;

            private string blendFunctionDestinationField;

            private string blendEquationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BlendFunctionSource
            {
                get
                {
                    return this.blendFunctionSourceField;
                }
                set
                {
                    this.blendFunctionSourceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BlendFunctionDestination
            {
                get
                {
                    return this.blendFunctionDestinationField;
                }
                set
                {
                    this.blendFunctionDestinationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BlendEquation
            {
                get
                {
                    return this.blendEquationField;
                }
                set
                {
                    this.blendEquationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperationAlphaParameter
        {

            private string blendFunctionSourceField;

            private string blendFunctionDestinationField;

            private string blendEquationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BlendFunctionSource
            {
                get
                {
                    return this.blendFunctionSourceField;
                }
                set
                {
                    this.blendFunctionSourceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BlendFunctionDestination
            {
                get
                {
                    return this.blendFunctionDestinationField;
                }
                set
                {
                    this.blendFunctionDestinationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BlendEquation
            {
                get
                {
                    return this.blendEquationField;
                }
                set
                {
                    this.blendEquationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperationBlendColor
        {

            private byte rField;

            private decimal gField;

            private byte bField;

            private byte aField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte R
            {
                get
                {
                    return this.rField;
                }
                set
                {
                    this.rField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal G
            {
                get
                {
                    return this.gField;
                }
                set
                {
                    this.gField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte B
            {
                get
                {
                    return this.bField;
                }
                set
                {
                    this.bField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte A
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationStencilOperation
        {

            private bool isTestEnabledField;

            private string testFunctionField;

            private byte testReferenceField;

            private byte testMaskField;

            private string failOperationField;

            private string zFailOperationField;

            private string passOperationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool IsTestEnabled
            {
                get
                {
                    return this.isTestEnabledField;
                }
                set
                {
                    this.isTestEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string TestFunction
            {
                get
                {
                    return this.testFunctionField;
                }
                set
                {
                    this.testFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte TestReference
            {
                get
                {
                    return this.testReferenceField;
                }
                set
                {
                    this.testReferenceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte TestMask
            {
                get
                {
                    return this.testMaskField;
                }
                set
                {
                    this.testMaskField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FailOperation
            {
                get
                {
                    return this.failOperationField;
                }
                set
                {
                    this.failOperationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ZFailOperation
            {
                get
                {
                    return this.zFailOperationField;
                }
                set
                {
                    this.zFailOperationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string PassOperation
            {
                get
                {
                    return this.passOperationField;
                }
                set
                {
                    this.passOperationField = value;
                }
            }
        }
    }
}
