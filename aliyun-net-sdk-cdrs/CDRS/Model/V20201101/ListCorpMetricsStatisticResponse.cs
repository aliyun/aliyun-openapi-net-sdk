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

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class ListCorpMetricsStatisticResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private string message;

		private string requestId;

		private int? pageNumber;

		private string code;

		private string success;

		private List<ListCorpMetricsStatistic_DataItem> data;

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

		public string Success
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

		public List<ListCorpMetricsStatistic_DataItem> Data
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

		public class ListCorpMetricsStatistic_DataItem
		{

			private string corpId;

			private string personId;

			private string deviceGroupId;

			private string deviceId;

			private string userGroupId;

			private string tagMetrics;

			private string tagCode;

			private string tagValue;

			private string dateId;

			public string CorpId
			{
				get
				{
					return corpId;
				}
				set	
				{
					corpId = value;
				}
			}

			public string PersonId
			{
				get
				{
					return personId;
				}
				set	
				{
					personId = value;
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

			public string DeviceId
			{
				get
				{
					return deviceId;
				}
				set	
				{
					deviceId = value;
				}
			}

			public string UserGroupId
			{
				get
				{
					return userGroupId;
				}
				set	
				{
					userGroupId = value;
				}
			}

			public string TagMetrics
			{
				get
				{
					return tagMetrics;
				}
				set	
				{
					tagMetrics = value;
				}
			}

			public string TagCode
			{
				get
				{
					return tagCode;
				}
				set	
				{
					tagCode = value;
				}
			}

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}

			public string DateId
			{
				get
				{
					return dateId;
				}
				set	
				{
					dateId = value;
				}
			}
		}
	}
}
