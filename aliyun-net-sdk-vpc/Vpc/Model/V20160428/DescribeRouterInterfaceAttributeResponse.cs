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
	public class DescribeRouterInterfaceAttributeResponse : AcsResponse
	{

		private string reservationActiveTime;

		private string healthCheckTargetIp;

		private string status;

		private string creationTime;

		private string reservationOrderType;

		private string oppositeInterfaceId;

		private string spec;

		private string chargeType;

		private string routerInterfaceId;

		private string message;

		private int? hcThreshold;

		private string oppositeRouterType;

		private string gmtModified;

		private string vpcInstanceId;

		private string oppositeInterfaceOwnerId;

		private string oppositeVpcInstanceId;

		private string reservationInternetChargeType;

		private bool? crossBorder;

		private string requestId;

		private int? bandwidth;

		private string description;

		private int? hcRate;

		private string reservationBandwidth;

		private string code;

		private string name;

		private string oppositeRouterId;

		private string oppositeInterfaceSpec;

		private string routerId;

		private bool? success;

		private string oppositeInterfaceBusinessStatus;

		private string connectedTime;

		private string healthCheckSourceIp;

		private string oppositeInterfaceStatus;

		private string endTime;

		private string oppositeRegionId;

		private string oppositeAccessPointId;

		private string businessStatus;

		private string healthCheckStatus;

		private int? oppositeBandwidth;

		private string routerType;

		private string role;

		private string hasReservationData;

		private string accessPointId;

		public string ReservationActiveTime
		{
			get
			{
				return reservationActiveTime;
			}
			set	
			{
				reservationActiveTime = value;
			}
		}

		public string HealthCheckTargetIp
		{
			get
			{
				return healthCheckTargetIp;
			}
			set	
			{
				healthCheckTargetIp = value;
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

		public string CreationTime
		{
			get
			{
				return creationTime;
			}
			set	
			{
				creationTime = value;
			}
		}

		public string ReservationOrderType
		{
			get
			{
				return reservationOrderType;
			}
			set	
			{
				reservationOrderType = value;
			}
		}

		public string OppositeInterfaceId
		{
			get
			{
				return oppositeInterfaceId;
			}
			set	
			{
				oppositeInterfaceId = value;
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

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
			}
		}

		public string RouterInterfaceId
		{
			get
			{
				return routerInterfaceId;
			}
			set	
			{
				routerInterfaceId = value;
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

		public int? HcThreshold
		{
			get
			{
				return hcThreshold;
			}
			set	
			{
				hcThreshold = value;
			}
		}

		public string OppositeRouterType
		{
			get
			{
				return oppositeRouterType;
			}
			set	
			{
				oppositeRouterType = value;
			}
		}

		public string GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
			}
		}

		public string VpcInstanceId
		{
			get
			{
				return vpcInstanceId;
			}
			set	
			{
				vpcInstanceId = value;
			}
		}

		public string OppositeInterfaceOwnerId
		{
			get
			{
				return oppositeInterfaceOwnerId;
			}
			set	
			{
				oppositeInterfaceOwnerId = value;
			}
		}

		public string OppositeVpcInstanceId
		{
			get
			{
				return oppositeVpcInstanceId;
			}
			set	
			{
				oppositeVpcInstanceId = value;
			}
		}

		public string ReservationInternetChargeType
		{
			get
			{
				return reservationInternetChargeType;
			}
			set	
			{
				reservationInternetChargeType = value;
			}
		}

		public bool? CrossBorder
		{
			get
			{
				return crossBorder;
			}
			set	
			{
				crossBorder = value;
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

		public int? HcRate
		{
			get
			{
				return hcRate;
			}
			set	
			{
				hcRate = value;
			}
		}

		public string ReservationBandwidth
		{
			get
			{
				return reservationBandwidth;
			}
			set	
			{
				reservationBandwidth = value;
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

		public string OppositeRouterId
		{
			get
			{
				return oppositeRouterId;
			}
			set	
			{
				oppositeRouterId = value;
			}
		}

		public string OppositeInterfaceSpec
		{
			get
			{
				return oppositeInterfaceSpec;
			}
			set	
			{
				oppositeInterfaceSpec = value;
			}
		}

		public string RouterId
		{
			get
			{
				return routerId;
			}
			set	
			{
				routerId = value;
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

		public string OppositeInterfaceBusinessStatus
		{
			get
			{
				return oppositeInterfaceBusinessStatus;
			}
			set	
			{
				oppositeInterfaceBusinessStatus = value;
			}
		}

		public string ConnectedTime
		{
			get
			{
				return connectedTime;
			}
			set	
			{
				connectedTime = value;
			}
		}

		public string HealthCheckSourceIp
		{
			get
			{
				return healthCheckSourceIp;
			}
			set	
			{
				healthCheckSourceIp = value;
			}
		}

		public string OppositeInterfaceStatus
		{
			get
			{
				return oppositeInterfaceStatus;
			}
			set	
			{
				oppositeInterfaceStatus = value;
			}
		}

		public string EndTime
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

		public string OppositeRegionId
		{
			get
			{
				return oppositeRegionId;
			}
			set	
			{
				oppositeRegionId = value;
			}
		}

		public string OppositeAccessPointId
		{
			get
			{
				return oppositeAccessPointId;
			}
			set	
			{
				oppositeAccessPointId = value;
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

		public string HealthCheckStatus
		{
			get
			{
				return healthCheckStatus;
			}
			set	
			{
				healthCheckStatus = value;
			}
		}

		public int? OppositeBandwidth
		{
			get
			{
				return oppositeBandwidth;
			}
			set	
			{
				oppositeBandwidth = value;
			}
		}

		public string RouterType
		{
			get
			{
				return routerType;
			}
			set	
			{
				routerType = value;
			}
		}

		public string Role
		{
			get
			{
				return role;
			}
			set	
			{
				role = value;
			}
		}

		public string HasReservationData
		{
			get
			{
				return hasReservationData;
			}
			set	
			{
				hasReservationData = value;
			}
		}

		public string AccessPointId
		{
			get
			{
				return accessPointId;
			}
			set	
			{
				accessPointId = value;
			}
		}
	}
}
