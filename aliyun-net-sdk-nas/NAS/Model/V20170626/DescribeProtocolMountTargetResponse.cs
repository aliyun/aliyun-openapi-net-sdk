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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeProtocolMountTargetResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeProtocolMountTarget_ProtocolMountTarget> protocolMountTargets;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<DescribeProtocolMountTarget_ProtocolMountTarget> ProtocolMountTargets
		{
			get
			{
				return protocolMountTargets;
			}
			set	
			{
				protocolMountTargets = value;
			}
		}

		public class DescribeProtocolMountTarget_ProtocolMountTarget
		{

			private string exportId;

			private string protocolMountTargetDomain;

			private string protocolType;

			private string vpcId;

			private string vSwitchId;

			private string fsetId;

			private string path;

			private string accessGroupName;

			private string createTime;

			private string status;

			private string protocolServiceId;

			private string description;

			public string ExportId
			{
				get
				{
					return exportId;
				}
				set	
				{
					exportId = value;
				}
			}

			public string ProtocolMountTargetDomain
			{
				get
				{
					return protocolMountTargetDomain;
				}
				set	
				{
					protocolMountTargetDomain = value;
				}
			}

			public string ProtocolType
			{
				get
				{
					return protocolType;
				}
				set	
				{
					protocolType = value;
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

			public string FsetId
			{
				get
				{
					return fsetId;
				}
				set	
				{
					fsetId = value;
				}
			}

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string AccessGroupName
			{
				get
				{
					return accessGroupName;
				}
				set	
				{
					accessGroupName = value;
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

			public string ProtocolServiceId
			{
				get
				{
					return protocolServiceId;
				}
				set	
				{
					protocolServiceId = value;
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
		}
	}
}
