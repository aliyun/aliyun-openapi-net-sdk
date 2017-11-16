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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeForwardTablesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeForwardTables_ForwardTable> forwardTables;

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

		public List<DescribeForwardTables_ForwardTable> ForwardTables
		{
			get
			{
				return forwardTables;
			}
			set	
			{
				forwardTables = value;
			}
		}

		public class DescribeForwardTables_ForwardTable
		{

			private string natGatewayId;

			private string forwardTableId;

			private string creationTime;

			private List<DescribeForwardTables_ForwardEntry> forwardEntrys;

			public string NatGatewayId
			{
				get
				{
					return natGatewayId;
				}
				set	
				{
					natGatewayId = value;
				}
			}

			public string ForwardTableId
			{
				get
				{
					return forwardTableId;
				}
				set	
				{
					forwardTableId = value;
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

			public List<DescribeForwardTables_ForwardEntry> ForwardEntrys
			{
				get
				{
					return forwardEntrys;
				}
				set	
				{
					forwardEntrys = value;
				}
			}

			public class DescribeForwardTables_ForwardEntry
			{

				private string forwardTableId;

				private string forwardEntryId;

				private string externalIp;

				private string externalPort;

				private string ipProtocol;

				private string internalIp;

				private string internalPort;

				private string status;

				public string ForwardTableId
				{
					get
					{
						return forwardTableId;
					}
					set	
					{
						forwardTableId = value;
					}
				}

				public string ForwardEntryId
				{
					get
					{
						return forwardEntryId;
					}
					set	
					{
						forwardEntryId = value;
					}
				}

				public string ExternalIp
				{
					get
					{
						return externalIp;
					}
					set	
					{
						externalIp = value;
					}
				}

				public string ExternalPort
				{
					get
					{
						return externalPort;
					}
					set	
					{
						externalPort = value;
					}
				}

				public string IpProtocol
				{
					get
					{
						return ipProtocol;
					}
					set	
					{
						ipProtocol = value;
					}
				}

				public string InternalIp
				{
					get
					{
						return internalIp;
					}
					set	
					{
						internalIp = value;
					}
				}

				public string InternalPort
				{
					get
					{
						return internalPort;
					}
					set	
					{
						internalPort = value;
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
			}
		}
	}
}