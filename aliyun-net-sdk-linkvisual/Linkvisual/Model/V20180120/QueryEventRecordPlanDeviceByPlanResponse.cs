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

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
	public class QueryEventRecordPlanDeviceByPlanResponse : AcsResponse
	{

		private string code;

		private string requestId;

		private string errorMessage;

		private bool? success;

		private QueryEventRecordPlanDeviceByPlan_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public QueryEventRecordPlanDeviceByPlan_Data Data
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

		public class QueryEventRecordPlanDeviceByPlan_Data
		{

			private int? pageSize;

			private int? total;

			private int? pageCount;

			private int? page;

			private List<QueryEventRecordPlanDeviceByPlan_ListItem> list;

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

			public int? PageCount
			{
				get
				{
					return pageCount;
				}
				set	
				{
					pageCount = value;
				}
			}

			public int? Page
			{
				get
				{
					return page;
				}
				set	
				{
					page = value;
				}
			}

			public List<QueryEventRecordPlanDeviceByPlan_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QueryEventRecordPlanDeviceByPlan_ListItem
			{

				private int? streamType;

				private string iotId;

				public int? StreamType
				{
					get
					{
						return streamType;
					}
					set	
					{
						streamType = value;
					}
				}

				public string IotId
				{
					get
					{
						return iotId;
					}
					set	
					{
						iotId = value;
					}
				}
			}
		}
	}
}
