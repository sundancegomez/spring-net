#region License

/*
 * Copyright � 2002-2005 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

#region Imports

using System;

#endregion

namespace Spring.Objects.Factory
{
	/// <summary>
	/// Sub-interface implemented by object factories that can be part
	/// of a hierarchy.
	/// </summary>
	/// <author>Rod Johnson</author>
	/// <author>Rick Evans (.NET)</author>
	public interface IHierarchicalObjectFactory : IObjectFactory
	{
		/// <summary>
		/// Return the parent object factory, or <see langword="null"/>
		/// if this factory does not have a parent.
		/// </summary>
		/// <value>
		/// The parent object factory, or <see langword="null"/>
		/// if this factory does not have a parent.
		/// </value>
		IObjectFactory ParentObjectFactory { get; }
	}
}