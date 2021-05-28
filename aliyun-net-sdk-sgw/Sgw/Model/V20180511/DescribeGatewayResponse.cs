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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeGatewayResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private string gatewayId;

		private string storageBundleId;

		private string name;

		private string description;

		private string location;

		private string category;

		private string type;

		private string gatewayClass;

		private string model;

		private string serialNumber;

		private string status;

		private string ecsInstanceId;

		private string vpcId;

		private string vSwitchId;

		private string ip;

		private string innerIp;

		private long? createdTime;

		private long? activatedTime;

		private string taskId;

		private string gatewayVersion;

		private string buyURL;

		private string renewURL;

		private bool? isPostPaid;

		private bool? isReleaseAfterExpiration;

		private long? expiredTime;

		private int? expireStatus;

		private string commonBuyInstanceId;

		private int? publicNetworkBandwidth;

		private string gatewayType;

		private bool? elasticGateway;

		private int? maxThroughput;

		private int? capacity;

		private string dataLoadType;

		private int? dataLoadInterval;

		private string lastErrorKey;

		private string innerIpv6Ip;

		private List<string> elasticNodes;

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

		public string Code
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

		public string GatewayId
		{
			get
			{
				return gatewayId;
			}
			set	
			{
				gatewayId = value;
			}
		}

		public string StorageBundleId
		{
			get
			{
				return storageBundleId;
			}
			set	
			{
				storageBundleId = value;
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

		public string Location
		{
			get
			{
				return location;
			}
			set	
			{
				location = value;
			}
		}

		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public string GatewayClass
		{
			get
			{
				return gatewayClass;
			}
			set	
			{
				gatewayClass = value;
			}
		}

		public string Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public string SerialNumber
		{
			get
			{
				return serialNumber;
			}
			set	
			{
				serialNumber = value;
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

		public string EcsInstanceId
		{
			get
			{
				return ecsInstanceId;
			}
			set	
			{
				ecsInstanceId = value;
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

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
			}
		}

		public string InnerIp
		{
			get
			{
				return innerIp;
			}
			set	
			{
				innerIp = value;
			}
		}

		public long? CreatedTime
		{
			get
			{
				return createdTime;
			}
			set	
			{
				createdTime = value;
			}
		}

		public long? ActivatedTime
		{
			get
			{
				return activatedTime;
			}
			set	
			{
				activatedTime = value;
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
			}
		}

		public string GatewayVersion
		{
			get
			{
				return gatewayVersion;
			}
			set	
			{
				gatewayVersion = value;
			}
		}

		public string BuyURL
		{
			get
			{
				return buyURL;
			}
			set	
			{
				buyURL = value;
			}
		}

		public string RenewURL
		{
			get
			{
				return renewURL;
			}
			set	
			{
				renewURL = value;
			}
		}

		public bool? IsPostPaid
		{
			get
			{
				return isPostPaid;
			}
			set	
			{
				isPostPaid = value;
			}
		}

		public bool? IsReleaseAfterExpiration
		{
			get
			{
				return isReleaseAfterExpiration;
			}
			set	
			{
				isReleaseAfterExpiration = value;
			}
		}

		public long? ExpiredTime
		{
			get
			{
				return expiredTime;
			}
			set	
			{
				expiredTime = value;
			}
		}

		public int? ExpireStatus
		{
			get
			{
				return expireStatus;
			}
			set	
			{
				expireStatus = value;
			}
		}

		public string CommonBuyInstanceId
		{
			get
			{
				return commonBuyInstanceId;
			}
			set	
			{
				commonBuyInstanceId = value;
			}
		}

		public int? PublicNetworkBandwidth
		{
			get
			{
				return publicNetworkBandwidth;
			}
			set	
			{
				publicNetworkBandwidth = value;
			}
		}

		public string GatewayType
		{
			get
			{
				return gatewayType;
			}
			set	
			{
				gatewayType = value;
			}
		}

		public bool? ElasticGateway
		{
			get
			{
				return elasticGateway;
			}
			set	
			{
				elasticGateway = value;
			}
		}

		public int? MaxThroughput
		{
			get
			{
				return maxThroughput;
			}
			set	
			{
				maxThroughput = value;
			}
		}

		public int? Capacity
		{
			get
			{
				return capacity;
			}
			set	
			{
				capacity = value;
			}
		}

		public string DataLoadType
		{
			get
			{
				return dataLoadType;
			}
			set	
			{
				dataLoadType = value;
			}
		}

		public int? DataLoadInterval
		{
			get
			{
				return dataLoadInterval;
			}
			set	
			{
				dataLoadInterval = value;
			}
		}

		public string LastErrorKey
		{
			get
			{
				return lastErrorKey;
			}
			set	
			{
				lastErrorKey = value;
			}
		}

		public string InnerIpv6Ip
		{
			get
			{
				return innerIpv6Ip;
			}
			set	
			{
				innerIpv6Ip = value;
			}
		}

		public List<string> ElasticNodes
		{
			get
			{
				return elasticNodes;
			}
			set	
			{
				elasticNodes = value;
			}
		}
	}
}
