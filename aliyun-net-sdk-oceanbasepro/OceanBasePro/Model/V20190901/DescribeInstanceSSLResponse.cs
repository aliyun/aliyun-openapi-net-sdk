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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeInstanceSSLResponse : AcsResponse
	{

		private string requestId;

		private DescribeInstanceSSL_InstanceSSL instanceSSL;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "InstanceSSL")]
		public DescribeInstanceSSL_InstanceSSL InstanceSSL
		{
			get
			{
				return instanceSSL;
			}
			set	
			{
				instanceSSL = value;
			}
		}

		public class DescribeInstanceSSL_InstanceSSL
		{

			private string instanceId;

			private string enableSSL;

			private string validPeriod;

			private string caUrl;

			private string status;

			private bool? forceSSLSupport;

			private string forceSSL;

			[JsonProperty(PropertyName = "InstanceId")]
			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "EnableSSL")]
			public string EnableSSL
			{
				get
				{
					return enableSSL;
				}
				set	
				{
					enableSSL = value;
				}
			}

			[JsonProperty(PropertyName = "ValidPeriod")]
			public string ValidPeriod
			{
				get
				{
					return validPeriod;
				}
				set	
				{
					validPeriod = value;
				}
			}

			[JsonProperty(PropertyName = "CaUrl")]
			public string CaUrl
			{
				get
				{
					return caUrl;
				}
				set	
				{
					caUrl = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			[JsonProperty(PropertyName = "ForceSSLSupport")]
			public bool? ForceSSLSupport
			{
				get
				{
					return forceSSLSupport;
				}
				set	
				{
					forceSSLSupport = value;
				}
			}

			[JsonProperty(PropertyName = "ForceSSL")]
			public string ForceSSL
			{
				get
				{
					return forceSSL;
				}
				set	
				{
					forceSSL = value;
				}
			}
		}
	}
}
