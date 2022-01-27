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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListVpcEndpointsResponse : AcsResponse
	{

		private string requestId;

		private List<ListVpcEndpoints_ResultItem> result;

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

		public List<ListVpcEndpoints_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListVpcEndpoints_ResultItem
		{

			private string connectionStatus;

			private string createTime;

			private string endpointBusinessStatus;

			private string endpointId;

			private string endpointName;

			private string endpointStatus;

			private string serviceId;

			private string serviceName;

			private string endpointDomain;

			public string ConnectionStatus
			{
				get
				{
					return connectionStatus;
				}
				set	
				{
					connectionStatus = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string EndpointBusinessStatus
			{
				get
				{
					return endpointBusinessStatus;
				}
				set	
				{
					endpointBusinessStatus = value;
				}
			}

			public string EndpointId
			{
				get
				{
					return endpointId;
				}
				set	
				{
					endpointId = value;
				}
			}

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

			public string EndpointStatus
			{
				get
				{
					return endpointStatus;
				}
				set	
				{
					endpointStatus = value;
				}
			}

			public string ServiceId
			{
				get
				{
					return serviceId;
				}
				set	
				{
					serviceId = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string EndpointDomain
			{
				get
				{
					return endpointDomain;
				}
				set	
				{
					endpointDomain = value;
				}
			}
		}
	}
}
