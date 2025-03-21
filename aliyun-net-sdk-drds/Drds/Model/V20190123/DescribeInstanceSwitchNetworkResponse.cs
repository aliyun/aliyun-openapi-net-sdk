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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeInstanceSwitchNetworkResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private List<DescribeInstanceSwitchNetwork_VpcInfo> vpcInfos;

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public List<DescribeInstanceSwitchNetwork_VpcInfo> VpcInfos
		{
			get
			{
				return vpcInfos;
			}
			set	
			{
				vpcInfos = value;
			}
		}

		public class DescribeInstanceSwitchNetwork_VpcInfo
		{

			private string vpcId;

			private string vpcName;

			private string regionId;

			private List<DescribeInstanceSwitchNetwork_VswitchInfo> vswitchInfos;

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

			public string VpcName
			{
				get
				{
					return vpcName;
				}
				set	
				{
					vpcName = value;
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

			public List<DescribeInstanceSwitchNetwork_VswitchInfo> VswitchInfos
			{
				get
				{
					return vswitchInfos;
				}
				set	
				{
					vswitchInfos = value;
				}
			}

			public class DescribeInstanceSwitchNetwork_VswitchInfo
			{

				private string vpcId;

				private bool? drdsSupported;

				private string vswitchId;

				private string azoneId;

				private string vswitchName;

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

				public bool? DrdsSupported
				{
					get
					{
						return drdsSupported;
					}
					set	
					{
						drdsSupported = value;
					}
				}

				public string VswitchId
				{
					get
					{
						return vswitchId;
					}
					set	
					{
						vswitchId = value;
					}
				}

				public string AzoneId
				{
					get
					{
						return azoneId;
					}
					set	
					{
						azoneId = value;
					}
				}

				public string VswitchName
				{
					get
					{
						return vswitchName;
					}
					set	
					{
						vswitchName = value;
					}
				}
			}
		}
	}
}
