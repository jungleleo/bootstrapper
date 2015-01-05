//-------------------------------------------------------------------------------
// <copyright file="ISyntaxBuilder.cs" company="Appccelerate">
//   Copyright (c) 2008-2015
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.Bootstrapper.Syntax
{
    /// <summary>
    /// Defines the interface for a syntax builder..
    /// </summary>
    /// <typeparam name="TExtension">The extension.</typeparam>
    public interface ISyntaxBuilder<TExtension> : IBeginSyntax<TExtension>
        where TExtension : IExtension
    {
    }

    /// <summary>
    /// Defines the interface for a syntax builder without context
    /// </summary>
    /// <typeparam name="TExtension">The type of the extension.</typeparam>
    public interface ISyntaxBuilderWithoutContext<TExtension> : ISyntaxBuilder<TExtension>, IWithBehavior<TExtension>, IEndWithBehavior<TExtension>
        where TExtension : IExtension
    {
    }

    /// <summary>
    /// Defines the interface for a syntax builder with context.
    /// </summary>
    /// <typeparam name="TExtension">The type of the extension.</typeparam>
    /// <typeparam name="TContext">The type of the context.</typeparam>
    public interface ISyntaxBuilderWithContext<TExtension, TContext> : IWithBehaviorOnContext<TExtension, TContext>, IEndWithBehavior<TExtension>
        where TExtension : IExtension
    {
    }
}