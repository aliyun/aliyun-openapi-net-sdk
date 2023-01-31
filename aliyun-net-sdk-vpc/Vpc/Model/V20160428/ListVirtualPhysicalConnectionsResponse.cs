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
	public class ListVirtualPhysicalConnectionsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? totalCount;

		private int? count;

		private List<ListVirtualPhysicalConnections_VirtualPhysicalConnection> virtualPhysicalConnections;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<ListVirtualPhysicalConnections_VirtualPhysicalConnection> VirtualPhysicalConnections
		{
			get
			{
				return virtualPhysicalConnections;
			}
			set	
			{
				virtualPhysicalConnections = value;
			}
		}

		public class ListVirtualPhysicalConnections_VirtualPhysicalConnection
		{

			private string type;

			private string status;

			private string creationTime;

			private string adLocation;

			private string portNumber;

			private string spec;

			private string chargeType;

			private string description;

			private long? bandwidth;

			private string enabledTime;

			private string lineOperator;

			private string peerLocation;

			private string redundantPhysicalConnectionId;

			private string name;

			private string circuitCode;

			private string endTime;

			private string portType;

			private string businessStatus;

			private string loaStatus;

			private string accessPointId;

			private string physicalConnectionId;

			private string productType;

			private string parentPhysicalConnectionId;

			private string virtualPhysicalConnectionStatus;

			private string parentPhysicalConnectionAliUid;

			private string orderMode;

			private string aliUid;

			private string vlanId;

			private string expectSpec;

			private string resourceGroupId;

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

			public string AdLocation
			{
				get
				{
					return adLocation;
				}
				set	
				{
					adLocation = value;
				}
			}

			public string PortNumber
			{
				get
				{
					return portNumber;
				}
				set	
				{
					portNumber = value;
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

			public long? Bandwidth
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

			public string EnabledTime
			{
				get
				{
					return enabledTime;
				}
				set	
				{
					enabledTime = value;
				}
			}

			public string LineOperator
			{
				get
				{
					return lineOperator;
				}
				set	
				{
					lineOperator = value;
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

			public string RedundantPhysicalConnectionId
			{
				get
				{
					return redundantPhysicalConnectionId;
				}
				set	
				{
					redundantPhysicalConnectionId = value;
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

			public string LoaStatus
			{
				get
				{
					return loaStatus;
				}
				set	
				{
					loaStatus = value;
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

			public string ProductType
			{
				get
				{
					return productType;
				}
				set	
				{
					productType = value;
				}
			}

			public string ParentPhysicalConnectionId
			{
				get
				{
					return parentPhysicalConnectionId;
				}
				set	
				{
					parentPhysicalConnectionId = value;
				}
			}

			public string VirtualPhysicalConnectionStatus
			{
				get
				{
					return virtualPhysicalConnectionStatus;
				}
				set	
				{
					virtualPhysicalConnectionStatus = value;
				}
			}

			public string ParentPhysicalConnectionAliUid
			{
				get
				{
					return parentPhysicalConnectionAliUid;
				}
				set	
				{
					parentPhysicalConnectionAliUid = value;
				}
			}

			public string OrderMode
			{
				get
				{
					return orderMode;
				}
				set	
				{
					orderMode = value;
				}
			}

			public string AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string VlanId
			{
				get
				{
					return vlanId;
				}
				set	
				{
					vlanId = value;
				}
			}

			public string ExpectSpec
			{
				get
				{
					return expectSpec;
				}
				set	
				{
					expectSpec = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}
		}
	}
}
