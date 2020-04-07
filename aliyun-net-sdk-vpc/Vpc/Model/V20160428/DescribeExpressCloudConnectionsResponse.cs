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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeExpressCloudConnectionsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeExpressCloudConnections_ExpressCloudConnectionType> expressCloudConnectionSet;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeExpressCloudConnections_ExpressCloudConnectionType> ExpressCloudConnectionSet
		{
			get
			{
				return expressCloudConnectionSet;
			}
			set	
			{
				expressCloudConnectionSet = value;
			}
		}

		public class DescribeExpressCloudConnections_ExpressCloudConnectionType
		{

			private string instanceId;

			private string status;

			private string name;

			private string description;

			private string gmtCreate;

			private string gmtModify;

			private string peerCity;

			private string peerLocation;

			private string portType;

			private int? bandwidth;

			private int? distance;

			private string redundantEccId;

			private string circuitCode;

			private string isp;

			private string type;

			private string idcSP;

			private string businessStatus;

			private string hasReservationData;

			private string reservationBandwidth;

			private string reservationInternetChargeType;

			private string reservationActiveTime;

			private string reservationOrderType;

			private string applicationType;

			private string applicationId;

			private string applicationStatus;

			private string applicationBandwidth;

			private string endTime;

			private string chargeType;

			private string contactTel;

			private string contactMail;

			private string iDCardNo;

			private string estimatedTime;

			private string bgpAs;

			private string peIp;

			private string ceIp;

			private string constructionPeriod;

			private List<DescribeExpressCloudConnections_VirtualBorderRouterModel> virtualBorderRouterModels;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModify
			{
				get
				{
					return gmtModify;
				}
				set	
				{
					gmtModify = value;
				}
			}

			public string PeerCity
			{
				get
				{
					return peerCity;
				}
				set	
				{
					peerCity = value;
				}
			}

			public string PeerLocation
			{
				get
				{
					return peerLocation;
				}
				set	
				{
					peerLocation = value;
				}
			}

			public string PortType
			{
				get
				{
					return portType;
				}
				set	
				{
					portType = value;
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

			public int? Distance
			{
				get
				{
					return distance;
				}
				set	
				{
					distance = value;
				}
			}

			public string RedundantEccId
			{
				get
				{
					return redundantEccId;
				}
				set	
				{
					redundantEccId = value;
				}
			}

			public string CircuitCode
			{
				get
				{
					return circuitCode;
				}
				set	
				{
					circuitCode = value;
				}
			}

			public string Isp
			{
				get
				{
					return isp;
				}
				set	
				{
					isp = value;
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

			public string IdcSP
			{
				get
				{
					return idcSP;
				}
				set	
				{
					idcSP = value;
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

			public string ApplicationType
			{
				get
				{
					return applicationType;
				}
				set	
				{
					applicationType = value;
				}
			}

			public string ApplicationId
			{
				get
				{
					return applicationId;
				}
				set	
				{
					applicationId = value;
				}
			}

			public string ApplicationStatus
			{
				get
				{
					return applicationStatus;
				}
				set	
				{
					applicationStatus = value;
				}
			}

			public string ApplicationBandwidth
			{
				get
				{
					return applicationBandwidth;
				}
				set	
				{
					applicationBandwidth = value;
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

			public string ContactTel
			{
				get
				{
					return contactTel;
				}
				set	
				{
					contactTel = value;
				}
			}

			public string ContactMail
			{
				get
				{
					return contactMail;
				}
				set	
				{
					contactMail = value;
				}
			}

			public string IDCardNo
			{
				get
				{
					return iDCardNo;
				}
				set	
				{
					iDCardNo = value;
				}
			}

			public string EstimatedTime
			{
				get
				{
					return estimatedTime;
				}
				set	
				{
					estimatedTime = value;
				}
			}

			public string BgpAs
			{
				get
				{
					return bgpAs;
				}
				set	
				{
					bgpAs = value;
				}
			}

			public string PeIp
			{
				get
				{
					return peIp;
				}
				set	
				{
					peIp = value;
				}
			}

			public string CeIp
			{
				get
				{
					return ceIp;
				}
				set	
				{
					ceIp = value;
				}
			}

			public string ConstructionPeriod
			{
				get
				{
					return constructionPeriod;
				}
				set	
				{
					constructionPeriod = value;
				}
			}

			public List<DescribeExpressCloudConnections_VirtualBorderRouterModel> VirtualBorderRouterModels
			{
				get
				{
					return virtualBorderRouterModels;
				}
				set	
				{
					virtualBorderRouterModels = value;
				}
			}

			public class DescribeExpressCloudConnections_VirtualBorderRouterModel
			{

				private string instanceId;

				private string accessPointId;

				private string physicalConnectionId;

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
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

				public string PhysicalConnectionId
				{
					get
					{
						return physicalConnectionId;
					}
					set	
					{
						physicalConnectionId = value;
					}
				}
			}
		}
	}
}
