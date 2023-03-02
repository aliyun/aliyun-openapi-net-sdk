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

namespace Aliyun.Acs.lto.Model.V20210707
{
	public class ListEdgeDeviceGroupResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private ListEdgeDeviceGroup_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public ListEdgeDeviceGroup_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListEdgeDeviceGroup_Data
		{

			private int? num;

			private int? total;

			private int? size;

			private List<ListEdgeDeviceGroup_MemberInfo> pageData;

			public int? Num
			{
				get
				{
					return num;
				}
				set	
				{
					num = value;
				}
			}

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public int? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public List<ListEdgeDeviceGroup_MemberInfo> PageData
			{
				get
				{
					return pageData;
				}
				set	
				{
					pageData = value;
				}
			}

			public class ListEdgeDeviceGroup_MemberInfo
			{

				private string status;

				private bool? currentUser;

				private string deviceGroupId;

				private string productKey;

				private string memberName;

				private string remark;

				private string name;

				private long? deviceCount;

				private int? authorizedCount;

				private string edgeName;

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

				public bool? CurrentUser
				{
					get
					{
						return currentUser;
					}
					set	
					{
						currentUser = value;
					}
				}

				public string DeviceGroupId
				{
					get
					{
						return deviceGroupId;
					}
					set	
					{
						deviceGroupId = value;
					}
				}

				public string ProductKey
				{
					get
					{
						return productKey;
					}
					set	
					{
						productKey = value;
					}
				}

				public string MemberName
				{
					get
					{
						return memberName;
					}
					set	
					{
						memberName = value;
					}
				}

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
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

				public long? DeviceCount
				{
					get
					{
						return deviceCount;
					}
					set	
					{
						deviceCount = value;
					}
				}

				public int? AuthorizedCount
				{
					get
					{
						return authorizedCount;
					}
					set	
					{
						authorizedCount = value;
					}
				}

				public string EdgeName
				{
					get
					{
						return edgeName;
					}
					set	
					{
						edgeName = value;
					}
				}
			}
		}
	}
}
