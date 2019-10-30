﻿using System;

namespace SDL.GL.ImGui
{
	public unsafe static partial class GL
	{
		[Flags]
		public enum ClearBufferMask
		{
			DepthBufferBit = 0x00000100,
			AccumBufferBit = 0x00000200,
			StencilBufferBit = 0x00000400,
			ColorBufferBit = 0x00004000,
		}

		public enum EnableCap
		{
			LineSmooth = ((int)0x0B20),
			PolygonSmooth = ((int)0x0B41),
			CullFace = ((int)0x0B44),
			DepthTest = ((int)0x0B71),
			StencilTest = ((int)0x0B90),
			Dither = ((int)0x0BD0),
			Blend = ((int)0x0BE2),
			IndexLogicOp = ((int)0x0BF1),
			ColorLogicOp = ((int)0x0BF2),
			ScissorTest = ((int)0x0C11),
			AutoNormal = ((int)0x0D80),
			Map1Color4 = ((int)0x0D90),
			Map1Index = ((int)0x0D91),
			Map1Normal = ((int)0x0D92),
			Map1TextureCoord1 = ((int)0x0D93),
			Map1TextureCoord2 = ((int)0x0D94),
			Map1TextureCoord3 = ((int)0x0D95),
			Map1TextureCoord4 = ((int)0x0D96),
			Map1Vertex3 = ((int)0x0D97),
			Map1Vertex4 = ((int)0x0D98),
			Map2Color4 = ((int)0x0DB0),
			Map2Index = ((int)0x0DB1),
			Map2Normal = ((int)0x0DB2),
			Map2TextureCoord1 = ((int)0x0DB3),
			Map2TextureCoord2 = ((int)0x0DB4),
			Map2TextureCoord3 = ((int)0x0DB5),
			Map2TextureCoord4 = ((int)0x0DB6),
			Map2Vertex3 = ((int)0x0DB7),
			Map2Vertex4 = ((int)0x0DB8),
			Texture1D = ((int)0x0DE0),
			Texture2D = ((int)0x0DE1),
			PolygonOffsetPoint = ((int)0x2A01),
			PolygonOffsetLine = ((int)0x2A02),
			ClipPlane0 = ((int)0x3000),
			ClipPlane1 = ((int)0x3001),
			ClipPlane2 = ((int)0x3002),
			ClipPlane3 = ((int)0x3003),
			ClipPlane4 = ((int)0x3004),
			ClipPlane5 = ((int)0x3005),
			Convolution1D = ((int)0x8010),
			Convolution1DExt = ((int)0x8010),
			Convolution2D = ((int)0x8011),
			Convolution2DExt = ((int)0x8011),
			Separable2D = ((int)0x8012),
			Separable2DExt = ((int)0x8012),
			Histogram = ((int)0x8024),
			HistogramExt = ((int)0x8024),
			MinmaxExt = ((int)0x802E),
			PolygonOffsetFill = ((int)0x8037),
			RescaleNormalExt = ((int)0x803A),
			Texture3DExt = ((int)0x806F),
			VertexArray = ((int)0x8074),
			NormalArray = ((int)0x8075),
			ColorArray = ((int)0x8076),
			IndexArray = ((int)0x8077),
			TextureCoordArray = ((int)0x8078),
			EdgeFlagArray = ((int)0x8079),
			InterlaceSgix = ((int)0x8094),
			Multisample = ((int)0x809D),
			SampleAlphaToCoverage = ((int)0x809E),
			SampleAlphaToMaskSgis = ((int)0x809E),
			SampleAlphaToOne = ((int)0x809F),
			SampleAlphaToOneSgis = ((int)0x809F),
			SampleCoverage = ((int)0x80A0),
			SampleMaskSgis = ((int)0x80A0),
			TextureColorTableSgi = ((int)0x80BC),
			ColorTable = ((int)0x80D0),
			ColorTableSgi = ((int)0x80D0),
			PostConvolutionColorTable = ((int)0x80D1),
			PostConvolutionColorTableSgi = ((int)0x80D1),
			PostColorMatrixColorTable = ((int)0x80D2),
			PostColorMatrixColorTableSgi = ((int)0x80D2),
			Texture4DSgis = ((int)0x8134),
			PixelTexGenSgix = ((int)0x8139),
			SpriteSgix = ((int)0x8148),
			ReferencePlaneSgix = ((int)0x817D),
			IrInstrument1Sgix = ((int)0x817F),
			CalligraphicFragmentSgix = ((int)0x8183),
			FramezoomSgix = ((int)0x818B),
			FogOffsetSgix = ((int)0x8198),
			SharedTexturePaletteExt = ((int)0x81FB),
			AsyncHistogramSgix = ((int)0x832C),
			PixelTextureSgis = ((int)0x8353),
			AsyncTexImageSgix = ((int)0x835C),
			AsyncDrawPixelsSgix = ((int)0x835D),
			AsyncReadPixelsSgix = ((int)0x835E),
			FragmentLightingSgix = ((int)0x8400),
			FragmentColorMaterialSgix = ((int)0x8401),
			FragmentLight0Sgix = ((int)0x840C),
			FragmentLight1Sgix = ((int)0x840D),
			FragmentLight2Sgix = ((int)0x840E),
			FragmentLight3Sgix = ((int)0x840F),
			FragmentLight4Sgix = ((int)0x8410),
			FragmentLight5Sgix = ((int)0x8411),
			FragmentLight6Sgix = ((int)0x8412),
			FragmentLight7Sgix = ((int)0x8413),
			ColorSum = ((int)0x8458),
			SecondaryColorArray = ((int)0x845E),
			TextureCubeMap = ((int)0x8513),
			ProgramPointSize = ((int)0x8642),
			VertexProgramPointSize = ((int)0x8642),
			DepthClamp = ((int)0x864F),
			TextureCubeMapSeamless = ((int)0x884F),
			PointSprite = ((int)0x8861),
			RasterizerDiscard = ((int)0x8C89),
			FramebufferSrgb = ((int)0x8DB9),
			SampleMask = ((int)0x8E51),
			PrimitiveRestart = ((int)0x8F9D),
		}

		public enum BlendEquationMode : int
		{
			FuncAdd = ((int)0x8006),
			Min = ((int)0x8007),
			Max = ((int)0x8008),
			FuncSubtract = ((int)0x800A),
			FuncReverseSubtract = ((int)0x800B),
		}

		public enum BlendingFactorDest : int
		{
			Zero = ((int)0),
			SrcColor = ((int)0x0300),
			OneMinusSrcColor = ((int)0x0301),
			SrcAlpha = ((int)0x0302),
			OneMinusSrcAlpha = ((int)0x0303),
			DstAlpha = ((int)0x0304),
			OneMinusDstAlpha = ((int)0x0305),
			DstColor = ((int)0x0306),
			OneMinusDstColor = ((int)0x0307),
			ConstantColor = ((int)0x8001),
			ConstantColorExt = ((int)0x8001),
			OneMinusConstantColor = ((int)0x8002),
			OneMinusConstantColorExt = ((int)0x8002),
			ConstantAlpha = ((int)0x8003),
			ConstantAlphaExt = ((int)0x8003),
			OneMinusConstantAlpha = ((int)0x8004),
			OneMinusConstantAlphaExt = ((int)0x8004),
			One = ((int)1),
		}

		public enum BlendingFactorSrc : int
		{
			Zero = ((int)0),
			SrcAlpha = ((int)0x0302),
			OneMinusSrcAlpha = ((int)0x0303),
			DstAlpha = ((int)0x0304),
			OneMinusDstAlpha = ((int)0x0305),
			DstColor = ((int)0x0306),
			OneMinusDstColor = ((int)0x0307),
			SrcAlphaSaturate = ((int)0x0308),
			ConstantColor = ((int)0x8001),
			ConstantColorExt = ((int)0x8001),
			OneMinusConstantColor = ((int)0x8002),
			OneMinusConstantColorExt = ((int)0x8002),
			ConstantAlpha = ((int)0x8003),
			ConstantAlphaExt = ((int)0x8003),
			OneMinusConstantAlpha = ((int)0x8004),
			OneMinusConstantAlphaExt = ((int)0x8004),
			One = ((int)1),
		}

		public enum StringName : int
		{
			Vendor = ((int)0x1F00),
			Renderer = ((int)0x1F01),
			Version = ((int)0x1F02),
			Extensions = ((int)0x1F03),
			ShadingLanguageVersion = ((int)0x8B8C),
		}

		public enum ShaderParameter : int
		{
			ShaderType = ((int)0x8B4F),
			DeleteStatus = ((int)0x8B80),
			CompileStatus = ((int)0x8B81),
			InfoLogLength = ((int)0x8B84),
			ShaderSourceLength = ((int)0x8B88),
		}

		public enum ShaderType : int
		{
			FragmentShader = ((int)0x8B30),
			VertexShader = ((int)0x8B31),
			GeometryShader = ((int)0x8DD9),
			TessControlShader = ((int)0x8E88),
			TessEvaluationShader = ((int)0x8E87),
			ComputeShader = ((int)0x91B9)
		}

		public enum ProgramParameter : int
		{
			ActiveUniformBlockMaxNameLength = ((int)0x8A35),
			ActiveUniformBlocks = ((int)0x8A36),
			DeleteStatus = ((int)0x8B80),
			LinkStatus = ((int)0x8B82),
			ValidateStatus = ((int)0x8B83),
			InfoLogLength = ((int)0x8B84),
			AttachedShaders = ((int)0x8B85),
			ActiveUniforms = ((int)0x8B86),
			ActiveUniformMaxLength = ((int)0x8B87),
			ActiveAttributes = ((int)0x8B89),
			ActiveAttributeMaxLength = ((int)0x8B8A),
			TransformFeedbackVaryingMaxLength = ((int)0x8C76),
			TransformFeedbackBufferMode = ((int)0x8C7F),
			TransformFeedbackVaryings = ((int)0x8C83),
			GeometryVerticesOut = ((int)0x8DDA),
			GeometryInputType = ((int)0x8DDB),
			GeometryOutputType = ((int)0x8DDC),
		}

		public enum ActiveAttribType : int
		{
			Float = ((int)0x1406),
			FloatVec2 = ((int)0x8B50),
			FloatVec3 = ((int)0x8B51),
			FloatVec4 = ((int)0x8B52),
			FloatMat2 = ((int)0x8B5A),
			FloatMat3 = ((int)0x8B5B),
			FloatMat4 = ((int)0x8B5C),
		}

		public enum ActiveUniformType : int
		{
			Int = ((int)0x1404),
			Float = ((int)0x1406),
			FloatVec2 = ((int)0x8B50),
			FloatVec3 = ((int)0x8B51),
			FloatVec4 = ((int)0x8B52),
			IntVec2 = ((int)0x8B53),
			IntVec3 = ((int)0x8B54),
			IntVec4 = ((int)0x8B55),
			Bool = ((int)0x8B56),
			BoolVec2 = ((int)0x8B57),
			BoolVec3 = ((int)0x8B58),
			BoolVec4 = ((int)0x8B59),
			FloatMat2 = ((int)0x8B5A),
			FloatMat3 = ((int)0x8B5B),
			FloatMat4 = ((int)0x8B5C),
			Sampler1D = ((int)0x8B5D),
			Sampler2D = ((int)0x8B5E),
			Sampler3D = ((int)0x8B5F),
			SamplerCube = ((int)0x8B60),
			Sampler1DShadow = ((int)0x8B61),
			Sampler2DShadow = ((int)0x8B62),
			Sampler2DRect = ((int)0x8B63),
			Sampler2DRectShadow = ((int)0x8B64),
			FloatMat2x3 = ((int)0x8B65),
			FloatMat2x4 = ((int)0x8B66),
			FloatMat3x2 = ((int)0x8B67),
			FloatMat3x4 = ((int)0x8B68),
			FloatMat4x2 = ((int)0x8B69),
			FloatMat4x3 = ((int)0x8B6A),
			Sampler1DArray = ((int)0x8DC0),
			Sampler2DArray = ((int)0x8DC1),
			SamplerBuffer = ((int)0x8DC2),
			Sampler1DArrayShadow = ((int)0x8DC3),
			Sampler2DArrayShadow = ((int)0x8DC4),
			SamplerCubeShadow = ((int)0x8DC5),
			UnsignedIntVec2 = ((int)0x8DC6),
			UnsignedIntVec3 = ((int)0x8DC7),
			UnsignedIntVec4 = ((int)0x8DC8),
			IntSampler1D = ((int)0x8DC9),
			IntSampler2D = ((int)0x8DCA),
			IntSampler3D = ((int)0x8DCB),
			IntSamplerCube = ((int)0x8DCC),
			IntSampler2DRect = ((int)0x8DCD),
			IntSampler1DArray = ((int)0x8DCE),
			IntSampler2DArray = ((int)0x8DCF),
			IntSamplerBuffer = ((int)0x8DD0),
			UnsignedIntSampler1D = ((int)0x8DD1),
			UnsignedIntSampler2D = ((int)0x8DD2),
			UnsignedIntSampler3D = ((int)0x8DD3),
			UnsignedIntSamplerCube = ((int)0x8DD4),
			UnsignedIntSampler2DRect = ((int)0x8DD5),
			UnsignedIntSampler1DArray = ((int)0x8DD6),
			UnsignedIntSampler2DArray = ((int)0x8DD7),
			UnsignedIntSamplerBuffer = ((int)0x8DD8),
			Sampler2DMultisample = ((int)0x9108),
			IntSampler2DMultisample = ((int)0x9109),
			UnsignedIntSampler2DMultisample = ((int)0x910A),
			Sampler2DMultisampleArray = ((int)0x910B),
			IntSampler2DMultisampleArray = ((int)0x910C),
			UnsignedIntSampler2DMultisampleArray = ((int)0x910D),
		}

		public enum BufferTarget : int
		{
			ArrayBuffer = ((int)0x8892),
			ElementArrayBuffer = ((int)0x8893),
			PixelPackBuffer = ((int)0x88EB),
			PixelUnpackBuffer = ((int)0x88EC),
			UniformBuffer = ((int)0x8A11),
			TextureBuffer = ((int)0x8C2A),
			TransformFeedbackBuffer = ((int)0x8C8E),
			CopyReadBuffer = ((int)0x8F36),
			CopyWriteBuffer = ((int)0x8F37),
			DrawIndirectBuffer = ((int)0x8F3F),
			AtomicCounterBuffer = ((int)0x92C0),
			DispatchIndirectBuffer = ((int)0x90EE),
			QueryBuffer = ((int)0x9192),
			ShaderStorageBuffer = ((int)0x90D2),
		}

		public enum TextureTarget : int
		{
			Texture1D = ((int)0x0DE0),
			Texture2D = ((int)0x0DE1),
			Texture3D = ((int)0x806F),
			Texture1DArray = ((int)0x8C18),
			Texture2DArray = ((int)0x8C1A),
			TextureRectangle = ((int)0x84F5),
			TextureCubeMap = ((int)0x8513),
			TextureCubeMapPositiveX = ((int)0x8515),
			TextureCubeMapNegativeX = ((int)0x8516),
			TextureCubeMapPositiveY = ((int)0x8517),
			TextureCubeMapNegativeY = ((int)0x8518),
			TextureCubeMapPositiveZ = ((int)0x8519),
			TextureCubeMapNegativeZ = ((int)0x851A),
			TextureCubeMapArray = ((int)0x9009),
			Texture2DMultisample = ((int)0x9100),
			Texture2DMultisampleArray = ((int)0x9102)
		}

		public enum BeginMode : int
		{
			Points = ((int)0x0000),
			Lines = ((int)0x0001),
			LineLoop = ((int)0x0002),
			LineStrip = ((int)0x0003),
			Triangles = ((int)0x0004),
			TriangleStrip = ((int)0x0005),
			TriangleFan = ((int)0x0006),
			LinesAdjacency = ((int)0xA),
			LineStripAdjacency = ((int)0xB),
			TrianglesAdjacency = ((int)0xC),
			TriangleStripAdjacency = ((int)0xD),
			Patches = ((int)0xE),
			[Obsolete("OpenGL 4 Core does not support quads.")]
			Quads = ((int)0x0007),
			[Obsolete("OpenGL 4 Core does not support quads.")]
			QuadStrip = ((int)0x0008)
		}

		public enum DrawElementsType : int
		{
			UnsignedByte = ((int)0x1401),
			UnsignedShort = ((int)0x1403),
			UnsignedInt = ((int)0x1405),
		}

		public enum VertexAttribPointerType : int
		{
			Byte = ((int)0x1400),
			UnsignedByte = ((int)0x1401),
			Short = ((int)0x1402),
			UnsignedShort = ((int)0x1403),
			Int = ((int)0x1404),
			UnsignedInt = ((int)0x1405),
			Float = ((int)0x1406),
			Double = ((int)0x140A),
			HalfFloat = ((int)0x140B),
			UnsignedUInt2101010Reversed = ((int)0x8368),
			UnsignedInt2101010Reversed = ((int)0x8D9F),
			UnsignedUInt101111Reversed = ((int)0x8C3B)
		}

		public enum BufferUsageHint : int
		{
			StreamDraw = ((int)0x88E0),
			StreamRead = ((int)0x88E1),
			StreamCopy = ((int)0x88E2),
			StaticDraw = ((int)0x88E4),
			StaticRead = ((int)0x88E5),
			StaticCopy = ((int)0x88E6),
			DynamicDraw = ((int)0x88E8),
			DynamicRead = ((int)0x88E9),
			DynamicCopy = ((int)0x88EA),
		}

		public enum PixelFormat : int
		{
			ColorIndex = ((int)0x1900),
			StencilIndex = ((int)0x1901),
			DepthComponent = ((int)0x1902),
			Red = ((int)0x1903),
			Green = ((int)0x1904),
			Blue = ((int)0x1905),
			Alpha = ((int)0x1906),
			Rgb = ((int)0x1907),
			Rgba = ((int)0x1908),
			Luminance = ((int)0x1909),
			LuminanceAlpha = ((int)0x190A),
			AbgrExt = ((int)0x8000),
			CmykExt = ((int)0x800C),
			CmykaExt = ((int)0x800D),
			Bgr = ((int)0x80E0),
			Bgra = ((int)0x80E1),
			Ycrcb422Sgix = ((int)0x81BB),
			Ycrcb444Sgix = ((int)0x81BC),
			Rg = ((int)0x8227),
			RgInteger = ((int)0x8228),
			DepthStencil = ((int)0x84F9),
			RedInteger = ((int)0x8D94),
			GreenInteger = ((int)0x8D95),
			BlueInteger = ((int)0x8D96),
			AlphaInteger = ((int)0x8D97),
			RgbInteger = ((int)0x8D98),
			RgbaInteger = ((int)0x8D99),
			BgrInteger = ((int)0x8D9A),
			BgraInteger = ((int)0x8D9B),
		}

		public enum PixelInternalFormat : int
		{
			DepthComponent = ((int)0x1902),
			Alpha = ((int)0x1906),
			Rgb = ((int)0x1907),
			Rgba = ((int)0x1908),
			Luminance = ((int)0x1909),
			LuminanceAlpha = ((int)0x190A),
			R3G3B2 = ((int)0x2A10),
			Alpha4 = ((int)0x803B),
			Alpha8 = ((int)0x803C),
			Alpha12 = ((int)0x803D),
			Alpha16 = ((int)0x803E),
			Luminance4 = ((int)0x803F),
			Luminance8 = ((int)0x8040),
			Luminance12 = ((int)0x8041),
			Luminance16 = ((int)0x8042),
			Luminance4Alpha4 = ((int)0x8043),
			Luminance6Alpha2 = ((int)0x8044),
			Luminance8Alpha8 = ((int)0x8045),
			Luminance12Alpha4 = ((int)0x8046),
			Luminance12Alpha12 = ((int)0x8047),
			Luminance16Alpha16 = ((int)0x8048),
			Intensity = ((int)0x8049),
			Intensity4 = ((int)0x804A),
			Intensity8 = ((int)0x804B),
			Intensity12 = ((int)0x804C),
			Intensity16 = ((int)0x804D),
			Rgb2Ext = ((int)0x804E),
			Rgb4 = ((int)0x804F),
			Rgb5 = ((int)0x8050),
			Rgb8 = ((int)0x8051),
			Rgb10 = ((int)0x8052),
			Rgb12 = ((int)0x8053),
			Rgb16 = ((int)0x8054),
			Rgba2 = ((int)0x8055),
			Rgba4 = ((int)0x8056),
			Rgb5A1 = ((int)0x8057),
			Rgba8 = ((int)0x8058),
			Rgb10A2 = ((int)0x8059),
			Rgba12 = ((int)0x805A),
			Rgba16 = ((int)0x805B),
			DualAlpha4Sgis = ((int)0x8110),
			DualAlpha8Sgis = ((int)0x8111),
			DualAlpha12Sgis = ((int)0x8112),
			DualAlpha16Sgis = ((int)0x8113),
			DualLuminance4Sgis = ((int)0x8114),
			DualLuminance8Sgis = ((int)0x8115),
			DualLuminance12Sgis = ((int)0x8116),
			DualLuminance16Sgis = ((int)0x8117),
			DualIntensity4Sgis = ((int)0x8118),
			DualIntensity8Sgis = ((int)0x8119),
			DualIntensity12Sgis = ((int)0x811A),
			DualIntensity16Sgis = ((int)0x811B),
			DualLuminanceAlpha4Sgis = ((int)0x811C),
			DualLuminanceAlpha8Sgis = ((int)0x811D),
			QuadAlpha4Sgis = ((int)0x811E),
			QuadAlpha8Sgis = ((int)0x811F),
			QuadLuminance4Sgis = ((int)0x8120),
			QuadLuminance8Sgis = ((int)0x8121),
			QuadIntensity4Sgis = ((int)0x8122),
			QuadIntensity8Sgis = ((int)0x8123),
			DepthComponent16 = ((int)0x81a5),
			DepthComponent16Sgix = ((int)0x81A5),
			DepthComponent24 = ((int)0x81a6),
			DepthComponent24Sgix = ((int)0x81A6),
			DepthComponent32 = ((int)0x81a7),
			DepthComponent32Sgix = ((int)0x81A7),
			CompressedRed = ((int)0x8225),
			CompressedRg = ((int)0x8226),
			R8 = ((int)0x8229),
			R16 = ((int)0x822A),
			Rg8 = ((int)0x822B),
			Rg16 = ((int)0x822C),
			R16f = ((int)0x822D),
			R32f = ((int)0x822E),
			Rg16f = ((int)0x822F),
			Rg32f = ((int)0x8230),
			R8i = ((int)0x8231),
			R8ui = ((int)0x8232),
			R16i = ((int)0x8233),
			R16ui = ((int)0x8234),
			R32i = ((int)0x8235),
			R32ui = ((int)0x8236),
			Rg8i = ((int)0x8237),
			Rg8ui = ((int)0x8238),
			Rg16i = ((int)0x8239),
			Rg16ui = ((int)0x823A),
			Rg32i = ((int)0x823B),
			Rg32ui = ((int)0x823C),
			CompressedRgbS3tcDxt1Ext = ((int)0x83F0),
			CompressedRgbaS3tcDxt1Ext = ((int)0x83F1),
			CompressedRgbaS3tcDxt3Ext = ((int)0x83F2),
			CompressedRgbaS3tcDxt5Ext = ((int)0x83F3),
			CompressedAlpha = ((int)0x84E9),
			CompressedLuminance = ((int)0x84EA),
			CompressedLuminanceAlpha = ((int)0x84EB),
			CompressedIntensity = ((int)0x84EC),
			CompressedRgb = ((int)0x84ED),
			CompressedRgba = ((int)0x84EE),
			DepthStencil = ((int)0x84F9),
			Rgba32f = ((int)0x8814),
			Rgb32f = ((int)0x8815),
			Rgba16f = ((int)0x881A),
			Rgb16f = ((int)0x881B),
			Depth24Stencil8 = ((int)0x88F0),
			R11fG11fB10f = ((int)0x8C3A),
			Rgb9E5 = ((int)0x8C3D),
			Srgb = ((int)0x8C40),
			Srgb8 = ((int)0x8C41),
			SrgbAlpha = ((int)0x8C42),
			Srgb8Alpha8 = ((int)0x8C43),
			SluminanceAlpha = ((int)0x8C44),
			Sluminance8Alpha8 = ((int)0x8C45),
			Sluminance = ((int)0x8C46),
			Sluminance8 = ((int)0x8C47),
			CompressedSrgb = ((int)0x8C48),
			CompressedSrgbAlpha = ((int)0x8C49),
			CompressedSluminance = ((int)0x8C4A),
			CompressedSluminanceAlpha = ((int)0x8C4B),
			CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C),
			CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D),
			CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E),
			CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F),
			DepthComponent32f = ((int)0x8CAC),
			Depth32fStencil8 = ((int)0x8CAD),
			Rgba32ui = ((int)0x8D70),
			Rgb32ui = ((int)0x8D71),
			Rgba16ui = ((int)0x8D76),
			Rgb16ui = ((int)0x8D77),
			Rgba8ui = ((int)0x8D7C),
			Rgb8ui = ((int)0x8D7D),
			Rgba32i = ((int)0x8D82),
			Rgb32i = ((int)0x8D83),
			Rgba16i = ((int)0x8D88),
			Rgb16i = ((int)0x8D89),
			Rgba8i = ((int)0x8D8E),
			Rgb8i = ((int)0x8D8F),
			Float32UnsignedInt248Rev = ((int)0x8DAD),
			CompressedRedRgtc1 = ((int)0x8DBB),
			CompressedSignedRedRgtc1 = ((int)0x8DBC),
			CompressedRgRgtc2 = ((int)0x8DBD),
			CompressedSignedRgRgtc2 = ((int)0x8DBE),
			One = ((int)1),
			Two = ((int)2),
			Three = ((int)3),
			Four = ((int)4),
		}

		public enum PixelStoreParameter : int
		{
			UnpackSwapBytes = ((int)0x0CF0),
			UnpackLsbFirst = ((int)0x0CF1),
			UnpackRowLength = ((int)0x0CF2),
			UnpackSkipRows = ((int)0x0CF3),
			UnpackSkipPixels = ((int)0x0CF4),
			UnpackAlignment = ((int)0x0CF5),
			PackSwapBytes = ((int)0x0D00),
			PackLsbFirst = ((int)0x0D01),
			PackRowLength = ((int)0x0D02),
			PackSkipRows = ((int)0x0D03),
			PackSkipPixels = ((int)0x0D04),
			PackAlignment = ((int)0x0D05),
			PackSkipImages = ((int)0x806B),
			PackSkipImagesExt = ((int)0x806B),
			PackImageHeight = ((int)0x806C),
			PackImageHeightExt = ((int)0x806C),
			UnpackSkipImages = ((int)0x806D),
			UnpackSkipImagesExt = ((int)0x806D),
			UnpackImageHeight = ((int)0x806E),
			UnpackImageHeightExt = ((int)0x806E),
			PackSkipVolumesSgis = ((int)0x8130),
			PackImageDepthSgis = ((int)0x8131),
			UnpackSkipVolumesSgis = ((int)0x8132),
			UnpackImageDepthSgis = ((int)0x8133),
			PixelTileWidthSgix = ((int)0x8140),
			PixelTileHeightSgix = ((int)0x8141),
			PixelTileGridWidthSgix = ((int)0x8142),
			PixelTileGridHeightSgix = ((int)0x8143),
			PixelTileGridDepthSgix = ((int)0x8144),
			PixelTileCacheSizeSgix = ((int)0x8145),
			PackResampleSgix = ((int)0x842C),
			UnpackResampleSgix = ((int)0x842D),
			PackSubsampleRateSgix = ((int)0x85A0),
			UnpackSubsampleRateSgix = ((int)0x85A1),
		}

		public enum TextureParameterName : int
		{
			TextureBaseLevel = ((int)0x813C),
			TextureBorderColor = ((int)0x1004),
			TextureCompareMode = ((int)0x884C),
			TextureCompareFunc = ((int)0x884D),
			TextureLodBias = ((int)0x8501),
			TextureMagFilter = ((int)0x2800),
			TextureMaxLevel = ((int)0x813D),
			TextureMaxLod = ((int)0x813B),
			TextureMinFilter = ((int)0x2801),
			TextureMinLod = ((int)0x813A),
			TextureSwizzleR = ((int)0x8E42),
			TextureSwizzleG = ((int)0x8E43),
			TextureSwizzleB = ((int)0x8E44),
			TextureSwizzleA = ((int)0x8E45),
			TextureSwizzleRGBA = ((int)0x8E46),
			TextureWrapS = ((int)0x2802),
			TextureWrapT = ((int)0x2803),
			TextureWrapR = ((int)0x8072),
			MaxAnisotropyExt = ((int)0x84FE)
		}

		public enum TextureParameter : int
		{
			Nearest = ((int)0x2600),
			Linear = ((int)0x2601),
			NearestMipMapNearest = ((int)0x2700),
			LinearMipMapNearest = ((int)0x2701),
			NearestMipMapLinear = ((int)0x2702),
			LinearMipMapLinear = ((int)0x2703),
			ClampToEdge = ((int)0x812F),
			ClampToBorder = ((int)0x812D),
			MirrorClampToEdge = ((int)0x8743),
			MirroredRepeat = ((int)0x8370),
			Repeat = ((int)0x2901),
			Red = ((int)0x1903),
			Green = ((int)0x1904),
			Blue = ((int)0x1905),
			Alpha = ((int)0x1906),
			Zero = ((int)0),
			One = ((int)1),
			CompareRefToTexture = ((int)0x884E),
			None = ((int)0),
			StencilIndex = ((int)0x1901),
			DepthComponent = ((int)0x1902),
			MaxAnisotropyExt = ((int)0x84FE)
		}

		public enum PixelType : int
		{
			Byte = ((int)0x1400),
			UnsignedByte = ((int)0x1401),
			Short = ((int)0x1402),
			UnsignedShort = ((int)0x1403),
			Int = ((int)0x1404),
			UnsignedInt = ((int)0x1405),
			Float = ((int)0x1406),
			HalfFloat = ((int)0x140B),
			Bitmap = ((int)0x1A00),
			UnsignedByte332 = ((int)0x8032),
			UnsignedByte332Ext = ((int)0x8032),
			UnsignedShort4444 = ((int)0x8033),
			UnsignedShort4444Ext = ((int)0x8033),
			UnsignedShort5551 = ((int)0x8034),
			UnsignedShort5551Ext = ((int)0x8034),
			UnsignedInt8888 = ((int)0x8035),
			UnsignedInt8888Ext = ((int)0x8035),
			UnsignedInt1010102 = ((int)0x8036),
			UnsignedInt1010102Ext = ((int)0x8036),
			UnsignedByte233Reversed = ((int)0x8362),
			UnsignedShort565 = ((int)0x8363),
			UnsignedShort565Reversed = ((int)0x8364),
			UnsignedShort4444Reversed = ((int)0x8365),
			UnsignedShort1555Reversed = ((int)0x8366),
			UnsignedInt8888Reversed = ((int)0x8367),
			UnsignedInt2101010Reversed = ((int)0x8368),
			UnsignedInt248 = ((int)0x84FA),
			UnsignedInt10F11F11FRev = ((int)0x8C3B),
			UnsignedInt5999Rev = ((int)0x8C3E),
			Float32UnsignedInt248Rev = ((int)0x8DAD),
		}
	}
}
