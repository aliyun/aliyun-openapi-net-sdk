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

namespace Aliyun.Acs.Privatelink.Model.V20200415
{
	public class GetVpcEndpointAttributeResponse : AcsResponse
	{

		private string payer;

		private string requestId;

		private string endpointDomain;

		private bool? resourceOwner;

		private string createTime;

		private string endpointBusinessStatus;

		private string endpointDescription;

		private string serviceId;

		private string endpointStatus;

		private string endpointName;

		private string vpcId;

		private string serviceName;

		private string endpointId;

		private int? bandwidth;

		private string regionId;

		private string connectionStatus;

		private bool? zoneAffinityEnabled;

		public string Payer
		{
			get
			{
				return payer;
			}
			set	
			{
				payer = value;
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

		public bool? ResourceOwner
		{
			get
			{
				return resourceOwner;
			}
			set	
			{
				resourceOwner = value;
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

		public string EndpointDescription
		{
			get
			{
				return endpointDescription;
			}
			set	
			{
				endpointDescription = value;
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

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
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

		public int? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

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

		public bool? ZoneAffinityEnabled
		{
			get
			{
				return zoneAffinityEnabled;
			}
			set	
			{
				zoneAffinityEnabled = value;
			}
		}
	}
}
