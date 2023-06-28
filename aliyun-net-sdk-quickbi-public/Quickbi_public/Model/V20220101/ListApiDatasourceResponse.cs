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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class ListApiDatasourceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListApiDatasource_Result result;

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

		public ListApiDatasource_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListApiDatasource_Result
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalNum;

			private List<ListApiDatasource_DataItem> data;

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
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

			public int? TotalNum
			{
				get
				{
					return totalNum;
				}
				set	
				{
					totalNum = value;
				}
			}

			public List<ListApiDatasource_DataItem> Data
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

			public class ListApiDatasource_DataItem
			{

				private string apiId;

				private string jobId;

				private string showName;

				private float? dataSize;

				private int? statusType;

				private string parameters;

				private string body;

				private string dateUpdateTime;

				private string gmtCreate;

				private string gmtModified;

				public string ApiId
				{
					get
					{
						return apiId;
					}
					set	
					{
						apiId = value;
					}
				}

				public string JobId
				{
					get
					{
						return jobId;
					}
					set	
					{
						jobId = value;
					}
				}

				public string ShowName
				{
					get
					{
						return showName;
					}
					set	
					{
						showName = value;
					}
				}

				public float? DataSize
				{
					get
					{
						return dataSize;
					}
					set	
					{
						dataSize = value;
					}
				}

				public int? StatusType
				{
					get
					{
						return statusType;
					}
					set	
					{
						statusType = value;
					}
				}

				public string Parameters
				{
					get
					{
						return parameters;
					}
					set	
					{
						parameters = value;
					}
				}

				public string Body
				{
					get
					{
						return body;
					}
					set	
					{
						body = value;
					}
				}

				public string DateUpdateTime
				{
					get
					{
						return dateUpdateTime;
					}
					set	
					{
						dateUpdateTime = value;
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
			}
		}
	}
}
