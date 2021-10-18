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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeVirtualBorderRoutersForPhysicalConnectionResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType> virtualBorderRouterForPhysicalConnectionSet;

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

		public List<DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType> VirtualBorderRouterForPhysicalConnectionSet
		{
			get
			{
				return virtualBorderRouterForPhysicalConnectionSet;
			}
			set	
			{
				virtualBorderRouterForPhysicalConnectionSet = value;
			}
		}

		public class DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType
		{

			private string creationTime;

			private string circuitCode;

			private string recoveryTime;

			private string terminationTime;

			private string activationTime;

			private long? vbrOwnerUid;

			private string vbrId;

			private int? vlanId;

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

			public string RecoveryTime
			{
				get
				{
					return recoveryTime;
				}
				set	
				{
					recoveryTime = value;
				}
			}

			public string TerminationTime
			{
				get
				{
					return terminationTime;
				}
				set	
				{
					terminationTime = value;
				}
			}

			public string ActivationTime
			{
				get
				{
					return activationTime;
				}
				set	
				{
					activationTime = value;
				}
			}

			public long? VbrOwnerUid
			{
				get
				{
					return vbrOwnerUid;
				}
				set	
				{
					vbrOwnerUid = value;
				}
			}

			public string VbrId
			{
				get
				{
					return vbrId;
				}
				set	
				{
					vbrId = value;
				}
			}

			public int? VlanId
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
		}
	}
}
