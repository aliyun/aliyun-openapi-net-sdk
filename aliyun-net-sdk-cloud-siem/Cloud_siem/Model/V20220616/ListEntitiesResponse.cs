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
	public class ListEntitiesResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private ListEntities_Data data;

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

		public ListEntities_Data Data
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

		public class ListEntities_Data
		{

			private List<ListEntities_ResponseDataItem> responseData;

			private ListEntities_PageInfo pageInfo;

			public List<ListEntities_ResponseDataItem> ResponseData
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

			public ListEntities_PageInfo PageInfo
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

			public class ListEntities_ResponseDataItem
			{

				private long? id;

				private string gmtCreate;

				private string gmtModified;

				private long? aliuid;

				private string incidentUuid;

				private string alertUuid;

				private int? alertNum;

				private int? eventNum;

				private string cloudCode;

				private string entityType;

				private string entityName;

				private string entityInfo;

				private long? subUserId;

				private string entityId;

				private string entityUuid;

				private string malwareType;

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

				public int? AlertNum
				{
					get
					{
						return alertNum;
					}
					set	
					{
						alertNum = value;
					}
				}

				public int? EventNum
				{
					get
					{
						return eventNum;
					}
					set	
					{
						eventNum = value;
					}
				}

				public string CloudCode
				{
					get
					{
						return cloudCode;
					}
					set	
					{
						cloudCode = value;
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

				public string EntityName
				{
					get
					{
						return entityName;
					}
					set	
					{
						entityName = value;
					}
				}

				public string EntityInfo
				{
					get
					{
						return entityInfo;
					}
					set	
					{
						entityInfo = value;
					}
				}

				public long? SubUserId
				{
					get
					{
						return subUserId;
					}
					set	
					{
						subUserId = value;
					}
				}

				public string EntityId
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

				public string EntityUuid
				{
					get
					{
						return entityUuid;
					}
					set	
					{
						entityUuid = value;
					}
				}

				public string MalwareType
				{
					get
					{
						return malwareType;
					}
					set	
					{
						malwareType = value;
					}
				}
			}

			public class ListEntities_PageInfo
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
