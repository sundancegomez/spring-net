#region License

/*
 * Copyright � 2002-2006 the original author or authors.
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

using NMS;

namespace Spring.Messaging.Nms
{
    /// <summary> Callback for executing any number of operations on a provided
    /// ISession
    /// </summary>
    /// <remarks>
    /// <p>To be used with the NmsTemplate.Execute(ISessionCallback)}
    /// method, often implemented as an anonymous inner class.</p>
    /// </remarks>
    /// <author>Mark Pollack</author>
    /// <seealso cref="NmsTemplate.Execute(ISessionCallback,bool)">
    /// </seealso>
    public interface ISessionCallback
    {
        /// <summary> Execute any number of operations against the supplied NMS
        /// ISession, possibly returning a result.
        /// </summary>
        /// <param name="session">the NMS <code>ISession</code>
        /// </param>
        /// <returns> a result object from working with the <code>ISession</code>, if any (so can be <code>null</code>) 
        /// </returns>
        /// <throws>NMSException if there is any problem </throws>
        object DoInNms(ISession session);
    }
}