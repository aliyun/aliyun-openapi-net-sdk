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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class ListDisposeStrategyResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private ListDisposeStrategy_Data data;

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

		public int? Code
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

		public ListDisposeStrategy_Data Data
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

		public class ListDisposeStrategy_Data
		{

			private List<ListDisposeStrategy_ResponseDataItem> responseData;

			private ListDisposeStrategy_PageInfo pageInfo;

			public List<ListDisposeStrategy_ResponseDataItem> ResponseData
			{
				get
				{
					return responseData;
				}
				set	
				{
					responseData = value;
				}
			}

			public ListDisposeStrategy_PageInfo PageInfo
			{
				get
				{
					return pageInfo;
				}
				set	
				{
					pageInfo = value;
				}
			}

			public class ListDisposeStrategy_ResponseDataItem
			{

				private long? id;

				private string gmtCreate;

				private string gmtModified;

				private long? aliuid;

				private long? subAliuid;

				private string incidentName;

				private string incidentUuid;

				private string alertUuid;

				private string sophonTaskId;

				private string playbookName;

				private string playbookUuid;

				private string playbookType;

				private long? entityId;

				private string entityType;

				private string taskParam;

				private string errorMessage;

				private string finishTime;

				private int? effectiveStatus;

				private int? status;

				private List<string> scope;

				private List<string> entity;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string GmtCreate
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

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public long? Aliuid
				{
					get
					{
						return aliuid;
					}
					set	
					{
						aliuid = value;
					}
				}

				public long? SubAliuid
				{
					get
					{
						return subAliuid;
					}
					set	
					{
						subAliuid = value;
					}
				}

				public string IncidentName
				{
					get
					{
						return incidentName;
					}
					set	
					{
						incidentName = value;
					}
				}

				public string IncidentUuid
				{
					get
					{
						return incidentUuid;
					}
					set	
					{
						incidentUuid = value;
					}
				}

				public string AlertUuid
				{
					get
					{
						return alertUuid;
					}
					set	
					{
						alertUuid = value;
					}
				}

				public string SophonTaskId
				{
					get
					{
						return sophonTaskId;
					}
					set	
					{
						sophonTaskId = value;
					}
				}

				public string PlaybookName
				{
					get
					{
						return playbookName;
					}
					set	
					{
						playbookName = value;
					}
				}

				public string PlaybookUuid
				{
					get
					{
						return playbookUuid;
					}
					set	
					{
						playbookUuid = value;
					}
				}

				public string PlaybookType
				{
					get
					{
						return playbookType;
					}
					set	
					{
						playbookType = value;
					}
				}

				public long? EntityId
				{
					get
					{
						return entityId;
					}
					set	
					{
						entityId = value;
					}
				}

				public string EntityType
				{
					get
					{
						return entityType;
					}
					set	
					{
						entityType = value;
					}
				}

				public string TaskParam
				{
					get
					{
						return taskParam;
					}
					set	
					{
						taskParam = value;
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

				public string FinishTime
				{
					get
					{
						return finishTime;
					}
					set	
					{
						finishTime = value;
					}
				}

				public int? EffectiveStatus
				{
					get
					{
						return effectiveStatus;
					}
					set	
					{
						effectiveStatus = value;
					}
				}

				public int? Status
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

				public List<string> Scope
				{
					get
					{
						return scope;
					}
					set	
					{
						scope = value;
					}
				}

				public List<string> Entity
				{
					get
					{
						return entity;
					}
					set	
					{
						entity = value;
					}
				}
			}

			public class ListDisposeStrategy_PageInfo
			{

				private int? currentPage;

				private int? pageSize;

				private long? totalCount;

				public int? CurrentPage
				{
					get
					{
						return currentPage;
					}
					set	
					{
						currentPage = value;
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

				public long? TotalCount
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
			}
		}
	}
}
