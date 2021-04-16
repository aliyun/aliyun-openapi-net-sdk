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
	public class CreateVpcEndpointServiceResponse : AcsResponse
	{

		private string serviceBusinessStatus;

		private string requestId;

		private string serviceName;

		private string serviceDescription;

		private string serviceStatus;

		private string createTime;

		private bool? zoneAffinityEnabled;

		private string serviceDomain;

		private string serviceId;

		private bool? autoAcceptEnabled;

		public string ServiceBusinessStatus
		{
			get
			{
				return serviceBusinessStatus;
			}
			set	
			{
				serviceBusinessStatus = value;
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

		public string ServiceDescription
		{
			get
			{
				return serviceDescription;
			}
			set	
			{
				serviceDescription = value;
			}
		}

		public string ServiceStatus
		{
			get
			{
				return serviceStatus;
			}
			set	
			{
				serviceStatus = value;
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

		public string ServiceDomain
		{
			get
			{
				return serviceDomain;
			}
			set	
			{
				serviceDomain = value;
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

		public bool? AutoAcceptEnabled
		{
			get
			{
				return autoAcceptEnabled;
			}
			set	
			{
				autoAcceptEnabled = value;
			}
		}
	}
}
