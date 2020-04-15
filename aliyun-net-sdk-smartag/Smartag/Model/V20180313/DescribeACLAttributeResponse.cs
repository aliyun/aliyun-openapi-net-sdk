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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeACLAttributeResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeACLAttribute_Acr> acrs;

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

		public List<DescribeACLAttribute_Acr> Acrs
		{
			get
			{
				return acrs;
			}
			set	
			{
				acrs = value;
			}
		}

		public class DescribeACLAttribute_Acr
		{

			private string acrId;

			private string description;

			private string direction;

			private string sourceCidr;

			private string destCidr;

			private string ipProtocol;

			private string sourcePortRange;

			private string destPortRange;

			private string policy;

			private int? priority;

			private long? gmtCreate;

			private string aclId;

			private string type;

			private string name;

			public string AcrId
			{
				get
				{
					return acrId;
				}
				set	
				{
					acrId = value;
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

			public string Direction
			{
				get
				{
					return direction;
				}
				set	
				{
					direction = value;
				}
			}

			public string SourceCidr
			{
				get
				{
					return sourceCidr;
				}
				set	
				{
					sourceCidr = value;
				}
			}

			public string DestCidr
			{
				get
				{
					return destCidr;
				}
				set	
				{
					destCidr = value;
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

			public string SourcePortRange
			{
				get
				{
					return sourcePortRange;
				}
				set	
				{
					sourcePortRange = value;
				}
			}

			public string DestPortRange
			{
				get
				{
					return destPortRange;
				}
				set	
				{
					destPortRange = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public long? GmtCreate
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

			public string AclId
			{
				get
				{
					return aclId;
				}
				set	
				{
					aclId = value;
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
}
