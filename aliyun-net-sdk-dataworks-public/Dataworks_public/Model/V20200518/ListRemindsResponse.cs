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
	public class ListRemindsResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private string errorCode;

		private bool? success;

		private ListReminds_Data data;

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

		public ListReminds_Data Data
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

		public class ListReminds_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListReminds_RemindsItem> reminds;

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

			public List<ListReminds_RemindsItem> Reminds
			{
				get
				{
					return reminds;
				}
				set	
				{
					reminds = value;
				}
			}

			public class ListReminds_RemindsItem
			{

				private string founder;

				private long? remindId;

				private string alertUnit;

				private string remindType;

				private string dndEnd;

				private string dndStart;

				private string remindUnit;

				private bool? useflag;

				private string remindName;

				private List<string> alertTargets;

				private List<string> nodeIds;

				private List<string> bizProcessIds;

				private List<string> projectIds;

				private List<string> baselineIds;

				private List<string> alertMethods;

				public string Founder
				{
					get
					{
						return founder;
					}
					set	
					{
						founder = value;
					}
				}

				public long? RemindId
				{
					get
					{
						return remindId;
					}
					set	
					{
						remindId = value;
					}
				}

				public string AlertUnit
				{
					get
					{
						return alertUnit;
					}
					set	
					{
						alertUnit = value;
					}
				}

				public string RemindType
				{
					get
					{
						return remindType;
					}
					set	
					{
						remindType = value;
					}
				}

				public string DndEnd
				{
					get
					{
						return dndEnd;
					}
					set	
					{
						dndEnd = value;
					}
				}

				public string DndStart
				{
					get
					{
						return dndStart;
					}
					set	
					{
						dndStart = value;
					}
				}

				public string RemindUnit
				{
					get
					{
						return remindUnit;
					}
					set	
					{
						remindUnit = value;
					}
				}

				public bool? Useflag
				{
					get
					{
						return useflag;
					}
					set	
					{
						useflag = value;
					}
				}

				public string RemindName
				{
					get
					{
						return remindName;
					}
					set	
					{
						remindName = value;
					}
				}

				public List<string> AlertTargets
				{
					get
					{
						return alertTargets;
					}
					set	
					{
						alertTargets = value;
					}
				}

				public List<string> NodeIds
				{
					get
					{
						return nodeIds;
					}
					set	
					{
						nodeIds = value;
					}
				}

				public List<string> BizProcessIds
				{
					get
					{
						return bizProcessIds;
					}
					set	
					{
						bizProcessIds = value;
					}
				}

				public List<string> ProjectIds
				{
					get
					{
						return projectIds;
					}
					set	
					{
						projectIds = value;
					}
				}

				public List<string> BaselineIds
				{
					get
					{
						return baselineIds;
					}
					set	
					{
						baselineIds = value;
					}
				}

				public List<string> AlertMethods
				{
					get
					{
						return alertMethods;
					}
					set	
					{
						alertMethods = value;
					}
				}
			}
		}
	}
}
