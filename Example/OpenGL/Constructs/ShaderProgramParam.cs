﻿using System;
using System.Diagnostics;
using System.Numerics;

namespace SDL.GL.ImGui
{
	public enum ParamType
	{
		Uniform,
		Attribute
	}

	public class ShaderProgramParam
	{
		/// <summary>
		/// Specifies the C# equivalent of the GLSL data type.
		/// </summary>
		public Type Type;

		/// <summary>
		/// Specifies the location of the parameter in the OpenGL program.
		/// </summary>
		public int Location;

		/// <summary>
		/// Specifies the OpenGL program ID.
		/// </summary>
		public uint Program;

		/// <summary>
		/// Specifies the parameter type (either attribute or uniform).
		/// </summary>
		public ParamType ParamType;

		/// <summary>
		/// Specifies the case-sensitive name of the parameter.
		/// </summary>
		public string Name;

		public uint ProgramId;

		public ShaderProgramParam(Type type, ParamType paramType, string name)
		{
			Type = type;
			ParamType = paramType;
			Name = name;
		}

		public ShaderProgramParam(Type type, ParamType paramType, string name, uint program, int location) : this(type, paramType, name)
		{
			ProgramId = Program;
			Location = location;
		}

		/// <summary>
		/// Gets the location of the parameter in a compiled OpenGL program.
		/// </summary>
		/// <param name="Program">Specifies the shader program that contains this parameter.</param>
		public void GetLocation(ShaderProgram Program)
		{
			Program.Use();
			if (ProgramId == 0)
			{
				ProgramId = Program.ProgramID;
				Location = (ParamType == ParamType.Uniform ? Program.GetUniformLocation(Name) : Program.GetAttributeLocation(Name));
			}
		}

		public void SetValue(bool param)
		{
			EnsureType<bool>();
			GL.glUniform1i(Location, (param) ? 1 : 0);
		}

		public void SetValue(int param)
		{
			EnsureType<int>();
			GL.glUniform1i(Location, param);
		}

		public void SetValue(float param)
		{
			EnsureType<float>();
			GL.glUniform1f(Location, param);
		}

		public void SetValue(Vector2 param)
		{
			EnsureType<Vector2>();
			GL.glUniform2f(Location, param.X, param.Y);
		}

		public void SetValue(Vector3 param)
		{
			EnsureType<Vector3>();
			GL.glUniform3f(Location, param.X, param.Y, param.Z);
		}

		public void SetValue(Vector4 param)
		{
			EnsureType<Vector4>();
			GL.glUniform4f(Location, param.X, param.Y, param.Z, param.W);
		}

		public void SetValue(Matrix4x4 param)
		{
			EnsureType<Matrix4x4>();
			GL.UniformMatrix4fv(Location, param);
		}

		public void SetValue(float[] param)
		{
			if (param.Length == 16)
			{
				EnsureType<Matrix4x4>();
				GL.glUniformMatrix4fv(Location, 1, false, param);
			}
			else if (param.Length == 9)
			{
				EnsureType<Exception>();
				GL.glUniformMatrix3fv(Location, 1, false, param);
			}
			else if (param.Length == 4)
			{
				EnsureType<Vector4>();
				GL.glUniform4f(Location, param[0], param[1], param[2], param[3]);
			}
			else if (param.Length == 3)
			{
				EnsureType<Vector3>();
				GL.glUniform3f(Location, param[0], param[1], param[2]);
			}
			else if (param.Length == 2)
			{
				EnsureType<Vector2>();
				GL.glUniform2f(Location, param[0], param[1]);
			}
			else if (param.Length == 1)
			{
				EnsureType<float>();
				GL.glUniform1f(Location, param[0]);
			}
			else
			{
				throw new ArgumentException("param was an unexpected length.", nameof(param));
			}
		}

		[Conditional("DEBUG")]
		void EnsureType<T>() => Debug.Assert(Type == typeof(T), $"SetValue({Type}) was called with a {typeof(T).Name}");
	}
}
