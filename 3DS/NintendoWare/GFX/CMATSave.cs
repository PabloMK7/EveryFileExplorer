using LibEveryFileExplorer.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DS.NintendoWare.GFX
{
    class CMATSave
    {
        CMAT.NintendoWareIntermediateFile Data;

        private CMAT.NintendoWareIntermediateFileGraphicsContentCtrEditData GenEditData()
        {
            CMAT.NintendoWareIntermediateFileGraphicsContentCtrEditData ret = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrEditData();
            ret.MetaData = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaData();
            ret.MetaData.Key = "MetaData";
            ret.MetaData.Create = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataCreate();
            ret.MetaData.Create.Date = DateTime.Now;
            ret.MetaData.Create.ToolDescriptions = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataCreateToolDescriptions();
            ret.MetaData.Create.ToolDescriptions.Name = "Every File Explorer";
            ret.MetaData.Create.ToolDescriptions.Version = "1.0";
            ret.MetaData.Modify = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataModify();
            ret.MetaData.Modify.Date = DateTime.Now;
            ret.MetaData.Modify.ToolDescriptions = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrEditDataMetaDataModifyToolDescriptions();
            ret.MetaData.Modify.ToolDescriptions.Name = "Every File Explorer";
            ret.MetaData.Modify.ToolDescriptions.Version = "1.0";
            return ret;
        }

        private CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler GenFragmentTableSampler(CMDL.MTOB.FragmentShader.FragmentLightingTableCtr.LightingLookupTableCtr table)
        {
            CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler ret = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableSampler();
            ret.IsAbs = false; // Always false? I guess the value from the LUT is actually used.
            if (table != null)
            {
                ret.ReferenceLookupTableCtr = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableReferenceLookupTableCtr();
                ret.Input = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.FragmentLightingTableCtr.LightingLookupTableCtr.InputCommandType), table.InputCommand);
                ret.Scale = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.FragmentLightingTableCtr.LightingLookupTableCtr.ScaleCommandType), table.ScaleCommand);
                ret.ReferenceLookupTableCtr.TableName = table.Sampler.TableName;
                ret.ReferenceLookupTableCtr.LookupTableSetContentReferenceCtr = String.Format("LookupTableSetContents[\"{0}\"]@file:{0}.clts", table.Sampler.BinaryPath);
            }
            else
            {
                ret.NullLookupTableCtr = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTableNullLookupTableCtr();
                ret.Input = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.FragmentLightingTableCtr.LightingLookupTableCtr.InputCommandType), 0);
                ret.Scale = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.FragmentLightingTableCtr.LightingLookupTableCtr.ScaleCommandType), 0);
            }
            return ret;
        }

        private CMAT.NintendoWareIntermediateFileGraphicsContentCtrColor GenColor(float r, float g, float b)
        {
            return new CMAT.NintendoWareIntermediateFileGraphicsContentCtrColor() { R = r, G = g, B = b, A = 1f };
        }
        private CMAT.NintendoWareIntermediateFileGraphicsContentCtrColor GenColor(float r, float g, float b, float a)
        {
            return new CMAT.NintendoWareIntermediateFileGraphicsContentCtrColor() { R = r, G = g, B = b, A = a };
        }
        private CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtr GenMaterialData(CMDL.MTOB mat)
        {
            CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtr data = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtr();
            data.EditData = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrEditData();
            data.EditData.MaterialCopySettingsMedaData = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrEditDataMaterialCopySettingsMedaData();
            data.EditData.MaterialCopySettingsMedaData.Key = "MaterialCopySettings";
            data.EditData.MaterialCopySettingsMedaData.MaterialCopyFilter = "All";

            data.Name = mat.Name;
            data.IsCompressible = false; // NOT IMPLEMENTED

            data.LightSetIndex = (byte)mat.LightSetIndex;
            data.FogIndex = (byte)mat.FogIndex;

            data.IsFragmentLightEnabled = mat.Flags.HasFlag(CMDL.MTOB.MaterialFlags.FragmentLightEnabled);
            data.IsVertexLightEnabled = mat.Flags.HasFlag(CMDL.MTOB.MaterialFlags.VertexLightEnabled);
            data.IsHemiSphereLightEnabled = mat.Flags.HasFlag(CMDL.MTOB.MaterialFlags.HemiSphereLightEnabled);
            data.IsHemiSphereOcclusionEnabled = mat.Flags.HasFlag(CMDL.MTOB.MaterialFlags.HemiSphereOcclusionEnabled);
            data.IsFogEnabled = mat.Flags.HasFlag(CMDL.MTOB.MaterialFlags.FogEnabled);
            
            string[] TextureCoordinateConfigOpts =
            {
                "Config0120",
                "Config0110",
                "Config0111",
                "Config0112",
                "Config0121",
                "Config0122",
            };
            data.TextureCoordinateConfig = TextureCoordinateConfigOpts[mat.TexCoordConfig];

            string[] TranslucencyKindOpts = {
                "Layer0",
                "Layer1",
                "Layer2",
                "Layer3"
            };
            data.TranslucencyKind = TranslucencyKindOpts[mat.TranslucencyKind];

            data.ShaderProgramDescriptionIndex = (sbyte)mat.ShaderProgramDescriptionIndex;
            data.ShaderBinaryKind = "Default"; // NOT IMPLEMENTED

            data.ShaderReference = null;

            data.MaterialColor = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrMaterialColor();
            data.MaterialColor.VertexColorScale = mat.MaterialColor.Ambient.W;
            data.MaterialColor.Emission = GenColor(
                mat.MaterialColor.Emission.X,
                mat.MaterialColor.Emission.Y,
                mat.MaterialColor.Emission.Z,
                0
            );
            data.MaterialColor.Ambient = GenColor(
                mat.MaterialColor.Ambient.X,
                mat.MaterialColor.Ambient.Y,
                mat.MaterialColor.Ambient.Z,
                1
            );
            data.MaterialColor.Diffuse = GenColor (
                mat.MaterialColor.Diffuse.X,
                mat.MaterialColor.Diffuse.Y,
                mat.MaterialColor.Diffuse.Z,
                mat.MaterialColor.Diffuse.W
            );
            data.MaterialColor.Specular0 = GenColor (
                mat.MaterialColor.Specular0.X,
                mat.MaterialColor.Specular0.Y,
                mat.MaterialColor.Specular0.Z,
                mat.MaterialColor.Specular0.W
            );
            data.MaterialColor.Specular1 = GenColor (
                mat.MaterialColor.Specular1.X,
                mat.MaterialColor.Specular1.Y,
                mat.MaterialColor.Specular1.Z,
                mat.MaterialColor.Specular1.W
            );
            data.MaterialColor.Constant0 = GenColor (
                mat.MaterialColor.Constant0.X,
                mat.MaterialColor.Constant0.Y,
                mat.MaterialColor.Constant0.Z,
                mat.MaterialColor.Constant0.W
            );
            data.MaterialColor.Constant1 = GenColor (
                mat.MaterialColor.Constant1.X,
                mat.MaterialColor.Constant1.Y,
                mat.MaterialColor.Constant1.Z,
                mat.MaterialColor.Constant1.W
            );
            data.MaterialColor.Constant2 = GenColor (
                mat.MaterialColor.Constant2.X,
                mat.MaterialColor.Constant2.Y,
                mat.MaterialColor.Constant2.Z,
                mat.MaterialColor.Constant2.W
            );
            data.MaterialColor.Constant3 = GenColor (
                mat.MaterialColor.Constant3.X,
                mat.MaterialColor.Constant3.Y,
                mat.MaterialColor.Constant3.Z,
                mat.MaterialColor.Constant3.W
            );
            data.MaterialColor.Constant4 = GenColor (
                mat.MaterialColor.Constant4.X,
                mat.MaterialColor.Constant4.Y,
                mat.MaterialColor.Constant4.Z,
                mat.MaterialColor.Constant4.W
            );
            data.MaterialColor.Constant5 = GenColor (
                mat.MaterialColor.Constant5.X,
                mat.MaterialColor.Constant5.Y,
                mat.MaterialColor.Constant5.Z,
                mat.MaterialColor.Constant5.W
            );

            data.Rasterization = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrRasterization();
            string[] CullingModeOpts = {
                "FrontFace",
                "BackFace",
                "Always",
                "Never"
            };
            data.Rasterization.CullingMode = CullingModeOpts[((uint)mat.Rasterization.CullingMode)];
            data.Rasterization.IsPolygonOffsetEnabled = mat.Rasterization.Flags.HasFlag(CMDL.MTOB.RasterizationCtr.RasterizationFlags.PolygonOffsetEnabled);
            data.Rasterization.PolygonOffsetUnit = mat.Rasterization.PolygonOffsetUnit;

            data.TextureCoordinators = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrTextureCoordinatorCtr[mat.TextureCoordiators.Length];
            string[] MappingMethodOpts = {
                "UvCoordinateMap",
                "CameraCubeEnvMap",
                "CameraSphereEnvMap",
                "ProjectionMap",
                ""
            };
            string[] MatrixModeOpts =
            {
                "DccMaya",
                "DccSoftimage",
                "Dcc3dsMax"
            };
            for (int i = 0; i < data.TextureCoordinators.Length; i++)
            {
                data.TextureCoordinators[i] = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrTextureCoordinatorCtr();
                data.TextureCoordinators[i].SourceCoordinate = (byte)mat.TextureCoordiators[i].SourceCoordinate;
                data.TextureCoordinators[i].MappingMethod = MappingMethodOpts[((uint)mat.TextureCoordiators[i].MappingMethod)];
                data.TextureCoordinators[i].ReferenceCamera = (sbyte)mat.TextureCoordiators[i].ReferenceCamera;
                data.TextureCoordinators[i].MatrixMode = MatrixModeOpts[(uint)mat.TextureCoordiators[i].MatrixMode];
                data.TextureCoordinators[i].ScaleS = mat.TextureCoordiators[i].Scale.X;
                data.TextureCoordinators[i].ScaleT = mat.TextureCoordiators[i].Scale.Y;
                data.TextureCoordinators[i].Rotate = mat.TextureCoordiators[i].Rotate;
                data.TextureCoordinators[i].TranslateS = mat.TextureCoordiators[i].Translate.X;
                data.TextureCoordinators[i].TranslateT = mat.TextureCoordiators[i].Translate.Y;
            }

            uint mapperSize = (mat.Tex0 != null ? 1u : 0u) + (mat.Tex1 != null ? 1u : 0u) + (mat.Tex2 != null ? 1u : 0u);
            data.TextureMappers = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtr[mapperSize];
            for (int i = 0; i < mapperSize; i++)
            {
                data.TextureMappers[i] = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtr();
                CMDL.MTOB.TexInfo curr = null;
                switch (i)
                {
                    case 0:
                        curr = mat.Tex0;
                        break;
                    case 1:
                        curr = mat.Tex1;
                        break;
                    case 2:
                        curr = mat.Tex2;
                        break;
                }
                if (curr.TextureObject != null) data.TextureMappers[i].TextureReference = "Textures[\"" + (curr.TextureObject as ReferenceTexture).LinkedTextureName + "\"]";
                data.TextureMappers[i].StandardTextureSamplerCtr = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrPixelBasedTextureMapperCtrStandardTextureSamplerCtr();
                data.TextureMappers[i].StandardTextureSamplerCtr.MinFilter = Enum.GetName(typeof(CMDL.MTOB.TexInfo.TextureMinFilter), curr.Sampler.MinFilter);
                
                CMDL.MTOB.TexInfo.TextureMagFilter magFilter = (CMDL.MTOB.TexInfo.TextureMagFilter)((curr.Unknown12 >> 1) & 1);
                CMDL.MTOB.TexInfo.TextureWrap wrapV = (CMDL.MTOB.TexInfo.TextureWrap)((curr.Unknown12 >> 8) & 3);
                CMDL.MTOB.TexInfo.TextureWrap wrapU = (CMDL.MTOB.TexInfo.TextureWrap)((curr.Unknown12 >> 12) & 3);
                byte minLod = (byte)((curr.Unknown13 >> 24) & 0xf);

                data.TextureMappers[i].StandardTextureSamplerCtr.MagFilter = Enum.GetName(typeof(CMDL.MTOB.TexInfo.TextureMagFilter), magFilter);
                data.TextureMappers[i].StandardTextureSamplerCtr.WrapS = Enum.GetName(typeof(CMDL.MTOB.TexInfo.TextureWrap), wrapU);
                data.TextureMappers[i].StandardTextureSamplerCtr.WrapT = Enum.GetName(typeof(CMDL.MTOB.TexInfo.TextureWrap), wrapV);
                data.TextureMappers[i].StandardTextureSamplerCtr.MinLod = minLod;
                data.TextureMappers[i].StandardTextureSamplerCtr.LodBias = (curr.Sampler as CMDL.MTOB.TexInfo.StandardTextureSamplerCtr).LodBias;
                Vector4 borderColor = (curr.Sampler as CMDL.MTOB.TexInfo.StandardTextureSamplerCtr).BorderColor;
                data.TextureMappers[i].StandardTextureSamplerCtr.BorderColor = GenColor(borderColor.X, borderColor.Y, borderColor.Z, borderColor.W);
            }

            data.FragmentShader = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShader();
            data.FragmentShader.LayerConfig = "ConfigurationType" + mat.FragShader.FragmentLighting.LayerConfig;
            data.FragmentShader.BufferColor = GenColor(mat.FragShader.BufferColor.X, mat.FragShader.BufferColor.Y, mat.FragShader.BufferColor.Z, mat.FragShader.BufferColor.W);
            data.FragmentShader.FragmentBump = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentBump();
            data.FragmentShader.FragmentBump.BumpTextureIndex = "Texture" + mat.FragShader.FragmentLighting.BumpTextureIndex;
            data.FragmentShader.FragmentBump.BumpMode = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.FragmentLightingCtr.FragmentLightingBumpMode), mat.FragShader.FragmentLighting.BumpMode);
            data.FragmentShader.FragmentBump.IsBumpRenormalize = mat.FragShader.FragmentLighting.IsBumpRenormalize;

            data.FragmentShader.FragmentLighting = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLighting();
            string[] FresnelConfigOpts =
            {
                "No",
                "Pri",
                "Sec",
                "PriSec"
            };
            data.FragmentShader.FragmentLighting.FresnelConfig = FresnelConfigOpts[mat.FragShader.FragmentLighting.FresnelConfig];
            data.FragmentShader.FragmentLighting.IsClampHighLight = mat.FragShader.FragmentLighting.Flags.HasFlag(CMDL.MTOB.FragmentShader.FragmentLightingCtr.FragmentLightingFlags.ClampHighLight);
            data.FragmentShader.FragmentLighting.IsDistribution0Enabled = mat.FragShader.FragmentLighting.Flags.HasFlag(CMDL.MTOB.FragmentShader.FragmentLightingCtr.FragmentLightingFlags.UseDistribution0);
            data.FragmentShader.FragmentLighting.IsDistribution1Enabled = mat.FragShader.FragmentLighting.Flags.HasFlag(CMDL.MTOB.FragmentShader.FragmentLightingCtr.FragmentLightingFlags.UseDistribution1);
            data.FragmentShader.FragmentLighting.IsGeometricFactor0Enabled = mat.FragShader.FragmentLighting.Flags.HasFlag(CMDL.MTOB.FragmentShader.FragmentLightingCtr.FragmentLightingFlags.UseGeometricFactor0);
            data.FragmentShader.FragmentLighting.IsGeometricFactor1Enabled = mat.FragShader.FragmentLighting.Flags.HasFlag(CMDL.MTOB.FragmentShader.FragmentLightingCtr.FragmentLightingFlags.UseGeometricFactor1);
            data.FragmentShader.FragmentLighting.IsReflectionEnabled = mat.FragShader.FragmentLighting.Flags.HasFlag(CMDL.MTOB.FragmentShader.FragmentLightingCtr.FragmentLightingFlags.UseReflection);
            data.FragmentShader.FragmentLightingTable = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderFragmentLightingTable();

            data.FragmentShader.FragmentLightingTable.ReflectanceRSampler = GenFragmentTableSampler(mat.FragShader.FragmentLightingTable.ReflectanceRSampler);
            data.FragmentShader.FragmentLightingTable.ReflectanceGSampler = GenFragmentTableSampler(mat.FragShader.FragmentLightingTable.ReflectanceGSampler);
            data.FragmentShader.FragmentLightingTable.ReflectanceBSampler = GenFragmentTableSampler(mat.FragShader.FragmentLightingTable.ReflectanceBSampler);

            data.FragmentShader.FragmentLightingTable.Distribution0Sampler = GenFragmentTableSampler(mat.FragShader.FragmentLightingTable.Distribution0Sampler);
            data.FragmentShader.FragmentLightingTable.Distribution1Sampler = GenFragmentTableSampler(mat.FragShader.FragmentLightingTable.Distribution1Sampler);

            data.FragmentShader.FragmentLightingTable.FresnelSampler = GenFragmentTableSampler(mat.FragShader.FragmentLightingTable.FresnelSampler);

            data.FragmentShader.TextureCombiners = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtr[6];
            for (int i = 0; i < 6; i++)
            {
                data.FragmentShader.TextureCombiners[i] = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtr();
                data.FragmentShader.TextureCombiners[i].CombineRgb = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Operation), mat.FragShader.TextureCombiners[i].OperationRGB);
                data.FragmentShader.TextureCombiners[i].CombineAlpha = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Operation), mat.FragShader.TextureCombiners[i].CombineAlpha);
                data.FragmentShader.TextureCombiners[i].ScaleRgb = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Scale), mat.FragShader.TextureCombiners[i].ScalationRGB);
                data.FragmentShader.TextureCombiners[i].ScaleAlpha = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Scale), mat.FragShader.TextureCombiners[i].ScalationA);
                data.FragmentShader.TextureCombiners[i].Constant = "Constant" + mat.FragShader.TextureCombiners[i].Constant;
                
                data.FragmentShader.TextureCombiners[i].SourceRgb = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrSourceRgb();
                CMDL.MTOB.FragmentShader.TextureCombinerCtr.Source[] rgbSource = mat.FragShader.TextureCombiners[i].SourcesRGB;
                data.FragmentShader.TextureCombiners[i].SourceRgb.Source0 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Source), rgbSource[0]);
                data.FragmentShader.TextureCombiners[i].SourceRgb.Source1 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Source), rgbSource[1]);
                data.FragmentShader.TextureCombiners[i].SourceRgb.Source2 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Source), rgbSource[2]);
                data.FragmentShader.TextureCombiners[i].OperandRgb = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrOperandRgb();
                CMDL.MTOB.FragmentShader.TextureCombinerCtr.OperandRGB[] rgbOperand = mat.FragShader.TextureCombiners[i].OperandsRGB;
                data.FragmentShader.TextureCombiners[i].OperandRgb.Operand0 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.OperandRGB), rgbOperand[0]);
                data.FragmentShader.TextureCombiners[i].OperandRgb.Operand1 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.OperandRGB), rgbOperand[1]);
                data.FragmentShader.TextureCombiners[i].OperandRgb.Operand2 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.OperandRGB), rgbOperand[2]);
                if (i > 1 && i < 5) data.FragmentShader.TextureCombiners[i - 1].BufferInputRgb = (((mat.FragShader.BufferCommand3 >> (8 + (i - 2))) & 1) != 0) ? "Previous" : "PreviousBuffer";

                data.FragmentShader.TextureCombiners[i].SourceAlpha = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrSourceAlpha();
                CMDL.MTOB.FragmentShader.TextureCombinerCtr.Source[] alphaSource = mat.FragShader.TextureCombiners[i].SourcesA;
                data.FragmentShader.TextureCombiners[i].SourceAlpha.Source0 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Source), alphaSource[0]);
                data.FragmentShader.TextureCombiners[i].SourceAlpha.Source1 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Source), alphaSource[1]);
                data.FragmentShader.TextureCombiners[i].SourceAlpha.Source2 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.Source), alphaSource[2]);
                data.FragmentShader.TextureCombiners[i].OperandAlpha = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderTextureCombinerCtrOperandAlpha();
                CMDL.MTOB.FragmentShader.TextureCombinerCtr.OperandAlpha[] alphaOperand = mat.FragShader.TextureCombiners[i].OperandsA;
                data.FragmentShader.TextureCombiners[i].OperandAlpha.Operand0 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.OperandAlpha), alphaOperand[0]);
                data.FragmentShader.TextureCombiners[i].OperandAlpha.Operand1 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.OperandAlpha), alphaOperand[1]);
                data.FragmentShader.TextureCombiners[i].OperandAlpha.Operand2 = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.TextureCombinerCtr.OperandAlpha), alphaOperand[2]);
                if (i > 1 && i < 5) data.FragmentShader.TextureCombiners[i - 1].BufferInputAlpha = (((mat.FragShader.BufferCommand3 >> (12 + (i - 2))) & 1) != 0) ? "Previous" : "PreviousBuffer";
            }
            data.FragmentShader.TextureCombiners[0].BufferInputRgb = "PreviousBuffer";
            data.FragmentShader.TextureCombiners[4].BufferInputRgb = "PreviousBuffer";
            data.FragmentShader.TextureCombiners[5].BufferInputRgb = "PreviousBuffer";
            data.FragmentShader.TextureCombiners[0].BufferInputAlpha = "PreviousBuffer";
            data.FragmentShader.TextureCombiners[4].BufferInputAlpha = "PreviousBuffer";
            data.FragmentShader.TextureCombiners[5].BufferInputAlpha = "PreviousBuffer";

            data.FragmentShader.AlphaTest = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentShaderAlphaTest();
            data.FragmentShader.AlphaTest.IsTestEnabled = mat.FragShader.AlphaTest.AlphaTestEnabled;
            data.FragmentShader.AlphaTest.TestFunction = Enum.GetName(typeof(CMDL.MTOB.FragmentShader.AlphaTestCtr.AlphaTestOperation), mat.FragShader.AlphaTest.TestFunction);
            data.FragmentShader.AlphaTest.TestReference = mat.FragShader.AlphaTest.TestReference;

            data.FragmentOperation = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperation();
            data.FragmentOperation.DepthOperation = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationDepthOperation();
            data.FragmentOperation.DepthOperation.IsTestEnabled = mat.FragmentOperation.DepthOperation.Flags.HasFlag(CMDL.MTOB.FragmentOperationCtr.DepthOperationCtr.DepthFlags.TestEnabled);
            data.FragmentOperation.DepthOperation.IsMaskEnabled = mat.FragmentOperation.DepthOperation.Flags.HasFlag(CMDL.MTOB.FragmentOperationCtr.DepthOperationCtr.DepthFlags.MaskEnabled);
            data.FragmentOperation.DepthOperation.TestFunction = Enum.GetName(typeof(CMDL.MTOB.FragmentOperationCtr.DepthOperationCtr.DepthTestOperation), mat.FragmentOperation.DepthOperation.Operation);

            data.FragmentOperation.BlendOperation = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperation();
            data.FragmentOperation.BlendOperation.Mode = Enum.GetName(typeof(CMDL.MTOB.FragmentOperationCtr.BlendOperationCtr.BlendModes), mat.FragmentOperation.BlendOperation.BlendMode);
            data.FragmentOperation.BlendOperation.LogicOperation = Enum.GetName(typeof(CMDL.MTOB.FragmentOperationCtr.BlendOperationCtr.LogicOperations), mat.FragmentOperation.BlendOperation.LogicOperation);

            data.FragmentOperation.BlendOperation.RgbParameter = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperationRgbParameter();
            data.FragmentOperation.BlendOperation.RgbParameter.BlendFunctionSource = Enum.GetName(typeof(CMDL.MTOB.FragmentOperationCtr.BlendOperationCtr.BlendFactor), mat.FragmentOperation.BlendOperation.ColorSource);
            data.FragmentOperation.BlendOperation.RgbParameter.BlendFunctionDestination = Enum.GetName(typeof(CMDL.MTOB.FragmentOperationCtr.BlendOperationCtr.BlendFactor), mat.FragmentOperation.BlendOperation.ColorDest);
            data.FragmentOperation.BlendOperation.RgbParameter.BlendEquation = Enum.GetName(typeof(CMDL.MTOB.FragmentOperationCtr.BlendOperationCtr.BlendEquations), mat.FragmentOperation.BlendOperation.BlendEquationColor);

            // Alpha blending settings unused?
            data.FragmentOperation.BlendOperation.AlphaParameter = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationBlendOperationAlphaParameter();
            data.FragmentOperation.BlendOperation.AlphaParameter.BlendFunctionSource = Enum.GetName(typeof(CMDL.MTOB.FragmentOperationCtr.BlendOperationCtr.BlendFactor), mat.FragmentOperation.BlendOperation.AlphaSource);
            data.FragmentOperation.BlendOperation.AlphaParameter.BlendFunctionDestination = Enum.GetName(typeof(CMDL.MTOB.FragmentOperationCtr.BlendOperationCtr.BlendFactor), mat.FragmentOperation.BlendOperation.AlphaDest);
            data.FragmentOperation.BlendOperation.AlphaParameter.BlendEquation = Enum.GetName(typeof(CMDL.MTOB.FragmentOperationCtr.BlendOperationCtr.BlendEquations), mat.FragmentOperation.BlendOperation.BlendEquationAlpha);

            data.FragmentOperation.BlendOperation.BlendColor = GenColor(
                mat.FragmentOperation.BlendOperation.BlendColor.X,
                mat.FragmentOperation.BlendOperation.BlendColor.Y,
                mat.FragmentOperation.BlendOperation.BlendColor.Z,
                mat.FragmentOperation.BlendOperation.BlendColor.W
            );

            // Stencil operation unused?
            data.FragmentOperation.StencilOperation = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterialsMaterialCtrFragmentOperationStencilOperation();
            data.FragmentOperation.StencilOperation.IsTestEnabled = false;
            data.FragmentOperation.StencilOperation.TestFunction = "Always";
            data.FragmentOperation.StencilOperation.TestReference = 0;
            data.FragmentOperation.StencilOperation.TestMask = 255;
            data.FragmentOperation.StencilOperation.FailOperation = "Keep";
            data.FragmentOperation.StencilOperation.ZFailOperation = "Keep";
            data.FragmentOperation.StencilOperation.PassOperation = "Keep";
            return data;
        }

        public CMATSave(CMDL.MTOB material)
        {
            Data = new CMAT.NintendoWareIntermediateFile();
            Data.GraphicsContentCtr = new CMAT.NintendoWareIntermediateFileGraphicsContentCtr();
            Data.GraphicsContentCtr.Version = "1.3.0";
            Data.GraphicsContentCtr.Namespace = "";
            Data.GraphicsContentCtr.EditData = GenEditData();
            Data.GraphicsContentCtr.Materials = new CMAT.NintendoWareIntermediateFileGraphicsContentCtrMaterials();
            Data.GraphicsContentCtr.Materials.MaterialCtr = GenMaterialData(material);

        }
        public void Serialize(string filename)
        {
            System.Xml.Serialization.XmlSerializer xmlSerialize = new System.Xml.Serialization.XmlSerializer(typeof(CMAT.NintendoWareIntermediateFile));
            System.IO.FileStream file = System.IO.File.Open(filename, System.IO.FileMode.Create);
            xmlSerialize.Serialize(file, Data);
            file.Close();
        }
    }
}
