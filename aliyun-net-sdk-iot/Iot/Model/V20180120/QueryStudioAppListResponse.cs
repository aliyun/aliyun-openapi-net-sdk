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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryStudioAppListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryStudioAppList_Data data;

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

		public QueryStudioAppList_Data Data
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

		public class QueryStudioAppList_Data
		{

			private int? pageSize;

			private int? pageNo;

			private int? total;

			private int? totalPage;

			private List<QueryStudioAppList_AppInfo> list;

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

			public int? PageNo
			{
				get
				{
					return pageNo;
				}
				set	
				{
					pageNo = value;
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

			public int? TotalPage
			{
				get
				{
					return totalPage;
				}
				set	
				{
					totalPage = value;
				}
			}

			public List<QueryStudioAppList_AppInfo> List
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

			public class QueryStudioAppList_AppInfo
			{

				private string name;

				private string appId;

				private string appKey;

				private string appSecret;

				private string projectId;

				private string type;

				private string description;

				private string gmtCreate;

				private string gmtModified;

				private string gmtRelease;

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

				public string AppId
				{
					get
					{
						return appId;
					}
					set	
					{
						appId = value;
					}
				}

				public string AppKey
				{
					get
					{
						return appKey;
					}
					set	
					{
						appKey = value;
					}
				}

				public string AppSecret
				{
					get
					{
						return appSecret;
					}
					set	
					{
						appSecret = value;
					}
				}

				public string ProjectId
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

				public string GmtRelease
				{
					get
					{
						return gmtRelease;
					}
					set	
					{
						gmtRelease = value;
					}
				}
			}
		}
	}
}
