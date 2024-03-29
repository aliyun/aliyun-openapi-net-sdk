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
	public class ModifyVpnGatewayAttributeResponse : AcsResponse
	{

		private string vpcId;

		private string status;

		private string internetIp;

		private string spec;

		private long? createTime;

		private bool? autoPropagate;

		private string vpnGatewayId;

		private string intranetIp;

		private long? endTime;

		private string vSwitchId;

		private string requestId;

		private string description;

		private bool? enableBgp;

		private string businessStatus;

		private string name;

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

		public string InternetIp
		{
			get
			{
				return internetIp;
			}
			set	
			{
				internetIp = value;
			}
		}

		public string Spec
		{
			get
			{
				return spec;
			}
			set	
			{
				spec = value;
			}
		}

		public long? CreateTime
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

		public bool? AutoPropagate
		{
			get
			{
				return autoPropagate;
			}
			set	
			{
				autoPropagate = value;
			}
		}

		public string VpnGatewayId
		{
			get
			{
				return vpnGatewayId;
			}
			set	
			{
				vpnGatewayId = value;
			}
		}

		public string IntranetIp
		{
			get
			{
				return intranetIp;
			}
			set	
			{
				intranetIp = value;
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public bool? EnableBgp
		{
			get
			{
				return enableBgp;
			}
			set	
			{
				enableBgp = value;
			}
		}

		public string BusinessStatus
		{
			get
			{
				return businessStatus;
			}
			set	
			{
				businessStatus = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}
	}
}
