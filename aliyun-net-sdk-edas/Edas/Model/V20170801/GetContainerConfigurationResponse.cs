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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetContainerConfigurationResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetContainerConfiguration_ContainerConfiguration containerConfiguration;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public GetContainerConfiguration_ContainerConfiguration ContainerConfiguration
		{
			get
			{
				return containerConfiguration;
			}
			set	
			{
				containerConfiguration = value;
			}
		}

		public class GetContainerConfiguration_ContainerConfiguration
		{

			private string contextPath;

			private int? httpPort;

			private int? maxThreads;

			private string uRIEncoding;

			private bool? useBodyEncoding;

			public string ContextPath
			{
				get
				{
					return contextPath;
				}
				set	
				{
					contextPath = value;
				}
			}

			public int? HttpPort
			{
				get
				{
					return httpPort;
				}
				set	
				{
					httpPort = value;
				}
			}

			public int? MaxThreads
			{
				get
				{
					return maxThreads;
				}
				set	
				{
					maxThreads = value;
				}
			}

			public string URIEncoding
			{
				get
				{
					return uRIEncoding;
				}
				set	
				{
					uRIEncoding = value;
				}
			}

			public bool? UseBodyEncoding
			{
				get
				{
					return useBodyEncoding;
				}
				set	
				{
					useBodyEncoding = value;
				}
			}
		}
	}
}
