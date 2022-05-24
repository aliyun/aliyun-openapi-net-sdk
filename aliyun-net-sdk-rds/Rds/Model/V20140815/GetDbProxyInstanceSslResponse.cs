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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class GetDbProxyInstanceSslResponse : AcsResponse
	{

		private string requestId;

		private List<GetDbProxyInstanceSsl_DbProxyCertListItemsItem> dbProxyCertListItems;

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

		[JsonProperty(PropertyName = "DbProxyCertListItems")]
		public List<GetDbProxyInstanceSsl_DbProxyCertListItemsItem> DbProxyCertListItems
		{
			get
			{
				return dbProxyCertListItems;
			}
			set	
			{
				dbProxyCertListItems = value;
			}
		}

		public class GetDbProxyInstanceSsl_DbProxyCertListItemsItem
		{

			private string dbInstanceName;

			private string endpointName;

			private string endpointType;

			private string sslExpiredTime;

			private string certCommonName;

			[JsonProperty(PropertyName = "DbInstanceName")]
			public string DbInstanceName
			{
				get
				{
					return dbInstanceName;
				}
				set	
				{
					dbInstanceName = value;
				}
			}

			[JsonProperty(PropertyName = "EndpointName")]
			public string EndpointName
			{
				get
				{
					return endpointName;
				}
				set	
				{
					endpointName = value;
				}
			}

			[JsonProperty(PropertyName = "EndpointType")]
			public string EndpointType
			{
				get
				{
					return endpointType;
				}
				set	
				{
					endpointType = value;
				}
			}

			[JsonProperty(PropertyName = "SslExpiredTime")]
			public string SslExpiredTime
			{
				get
				{
					return sslExpiredTime;
				}
				set	
				{
					sslExpiredTime = value;
				}
			}

			[JsonProperty(PropertyName = "CertCommonName")]
			public string CertCommonName
			{
				get
				{
					return certCommonName;
				}
				set	
				{
					certCommonName = value;
				}
			}
		}
	}
}
