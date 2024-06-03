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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class GetNodeInfoForPodResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetNodeInfoForPod_Content content;

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

		public GetNodeInfoForPod_Content Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class GetNodeInfoForPod_Content
		{

			private string regionId;

			private string zoneId;

			private string clusterId;

			private string vpcId;

			private string nodeId;

			private int? leniQuota;

			private int? lniSipQuota;

			private int? leniSipQuota;

			private int? hdeniQuota;

			private List<string> vSwitches;

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

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
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

			public string NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public int? LeniQuota
			{
				get
				{
					return leniQuota;
				}
				set	
				{
					leniQuota = value;
				}
			}

			public int? LniSipQuota
			{
				get
				{
					return lniSipQuota;
				}
				set	
				{
					lniSipQuota = value;
				}
			}

			public int? LeniSipQuota
			{
				get
				{
					return leniSipQuota;
				}
				set	
				{
					leniSipQuota = value;
				}
			}

			public int? HdeniQuota
			{
				get
				{
					return hdeniQuota;
				}
				set	
				{
					hdeniQuota = value;
				}
			}

			public List<string> VSwitches
			{
				get
				{
					return vSwitches;
				}
				set	
				{
					vSwitches = value;
				}
			}
		}
	}
}
