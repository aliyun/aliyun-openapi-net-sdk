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
	public class DescribeVpnAttachmentsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeVpnAttachments_VpnAttachment> vpnAttachments;

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

		public List<DescribeVpnAttachments_VpnAttachment> VpnAttachments
		{
			get
			{
				return vpnAttachments;
			}
			set	
			{
				vpnAttachments = value;
			}
		}

		public class DescribeVpnAttachments_VpnAttachment
		{

			private string instanceId;

			private string name;

			private string description;

			private string attachType;

			private string transitRouterId;

			private string transitRouterName;

			private bool? crossAccountAuthorized;

			private List<DescribeVpnAttachments_Tag> tags;

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

			public string AttachType
			{
				get
				{
					return attachType;
				}
				set	
				{
					attachType = value;
				}
			}

			public string TransitRouterId
			{
				get
				{
					return transitRouterId;
				}
				set	
				{
					transitRouterId = value;
				}
			}

			public string TransitRouterName
			{
				get
				{
					return transitRouterName;
				}
				set	
				{
					transitRouterName = value;
				}
			}

			public bool? CrossAccountAuthorized
			{
				get
				{
					return crossAccountAuthorized;
				}
				set	
				{
					crossAccountAuthorized = value;
				}
			}

			public List<DescribeVpnAttachments_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class DescribeVpnAttachments_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
