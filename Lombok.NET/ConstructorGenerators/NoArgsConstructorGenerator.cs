﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Lombok.NET.ConstructorGenerators;

/// <summary>
/// Generator which generates an empty constructor. No parameters, no body.
/// </summary>
[Generator]
public sealed class NoArgsConstructorGenerator : BaseConstructorGenerator
{
	/// <summary>
	/// Gets the to-be-generated constructor's parameters as well as its body.
	/// </summary>
	/// <returns>The constructor's parameters and its body.</returns>
	protected override (ParameterListSyntax constructorParameters, BlockSyntax constructorBody) GetConstructorParts(TypeDeclarationSyntax t, AttributeData a)
	{
		return (SyntaxFactory.ParameterList(), SyntaxFactory.Block());
	}

	/// <summary>
	/// The name (as used in user code) of the attribute this generator targets.
	/// </summary>
	protected override string AttributeName { get; } = typeof(NoArgsConstructorAttribute).FullName;
}