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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListBaselineConfigsResponse : AcsResponse
	{

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private ListBaselineConfigs_Data data;

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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public ListBaselineConfigs_Data Data
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

		public class ListBaselineConfigs_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListBaselineConfigs_BaselinesItem> baselines;

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

			public List<ListBaselineConfigs_BaselinesItem> Baselines
			{
				get
				{
					return baselines;
				}
				set	
				{
					baselines = value;
				}
			}

			public class ListBaselineConfigs_BaselinesItem
			{

				private long? baselineId;

				private int? priority;

				private string baselineName;

				private string owner;

				private long? projectId;

				private bool? useFlag;

				private string baselineType;

				private int? expHour;

				private int? expMinu;

				private int? slaHour;

				private int? slaMinu;

				private string hourExpDetail;

				private string hourSlaDetail;

				private bool? isDefault;

				public long? BaselineId
				{
					get
					{
						return baselineId;
					}
					set	
					{
						baselineId = value;
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

				public string BaselineName
				{
					get
					{
						return baselineName;
					}
					set	
					{
						baselineName = value;
					}
				}

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public bool? UseFlag
				{
					get
					{
						return useFlag;
					}
					set	
					{
						useFlag = value;
					}
				}

				public string BaselineType
				{
					get
					{
						return baselineType;
					}
					set	
					{
						baselineType = value;
					}
				}

				public int? ExpHour
				{
					get
					{
						return expHour;
					}
					set	
					{
						expHour = value;
					}
				}

				public int? ExpMinu
				{
					get
					{
						return expMinu;
					}
					set	
					{
						expMinu = value;
					}
				}

				public int? SlaHour
				{
					get
					{
						return slaHour;
					}
					set	
					{
						slaHour = value;
					}
				}

				public int? SlaMinu
				{
					get
					{
						return slaMinu;
					}
					set	
					{
						slaMinu = value;
					}
				}

				public string HourExpDetail
				{
					get
					{
						return hourExpDetail;
					}
					set	
					{
						hourExpDetail = value;
					}
				}

				public string HourSlaDetail
				{
					get
					{
						return hourSlaDetail;
					}
					set	
					{
						hourSlaDetail = value;
					}
				}

				public bool? IsDefault
				{
					get
					{
						return isDefault;
					}
					set	
					{
						isDefault = value;
					}
				}
			}
		}
	}
}
