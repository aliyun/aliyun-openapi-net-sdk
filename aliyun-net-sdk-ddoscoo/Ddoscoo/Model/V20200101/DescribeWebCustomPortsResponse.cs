/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeWebCustomPortsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeWebCustomPorts_WebCustomPort> webCustomPorts;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeWebCustomPorts_WebCustomPort> WebCustomPorts
		{
			get
			{
				return webCustomPorts;
			}
			set	
			{
				webCustomPorts = value;
			}
		}

		public class DescribeWebCustomPorts_WebCustomPort
		{

			private string proxyType;

			private List<string> proxyPorts;

			public string ProxyType
			{
				get
				{
					return proxyType;
				}
				set	
				{
					proxyType = value;
				}
			}

			public List<string> ProxyPorts
			{
				get
				{
					return proxyPorts;
				}
				set	
				{
					proxyPorts = value;
				}
			}
		}
	}
}
