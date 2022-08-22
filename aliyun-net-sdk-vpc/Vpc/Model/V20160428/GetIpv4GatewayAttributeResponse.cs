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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class GetIpv4GatewayAttributeResponse : AcsResponse
	{

		private string vpcId;

		private string status;

		private string ipv4GatewayId;

		private string requestId;

		private string ipv4GatewayDescription;

		private bool? enabled;

		private string ipv4GatewayRouteTableId;

		private string ipv4GatewayName;

		private string createTime;

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

		public string Ipv4GatewayId
		{
			get
			{
				return ipv4GatewayId;
			}
			set	
			{
				ipv4GatewayId = value;
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

		public string Ipv4GatewayDescription
		{
			get
			{
				return ipv4GatewayDescription;
			}
			set	
			{
				ipv4GatewayDescription = value;
			}
		}

		public bool? Enabled
		{
			get
			{
				return enabled;
			}
			set	
			{
				enabled = value;
			}
		}

		public string Ipv4GatewayRouteTableId
		{
			get
			{
				return ipv4GatewayRouteTableId;
			}
			set	
			{
				ipv4GatewayRouteTableId = value;
			}
		}

		public string Ipv4GatewayName
		{
			get
			{
				return ipv4GatewayName;
			}
			set	
			{
				ipv4GatewayName = value;
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
	}
}
