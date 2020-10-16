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

namespace Aliyun.Acs.dataworks_public.Model.V20180601
{
	public class ListHiveTableLineagesResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private ListHiveTableLineages_Data data;

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

		public ListHiveTableLineages_Data Data
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

		public class ListHiveTableLineages_Data
		{

			private int? upstreamNumber;

			private int? downstreamNumber;

			private List<ListHiveTableLineages_TableLineage> upstreamLineages;

			private List<ListHiveTableLineages_TableLineage> downstreamLineages;

			public int? UpstreamNumber
			{
				get
				{
					return upstreamNumber;
				}
				set	
				{
					upstreamNumber = value;
				}
			}

			public int? DownstreamNumber
			{
				get
				{
					return downstreamNumber;
				}
				set	
				{
					downstreamNumber = value;
				}
			}

			public List<ListHiveTableLineages_TableLineage> UpstreamLineages
			{
				get
				{
					return upstreamLineages;
				}
				set	
				{
					upstreamLineages = value;
				}
			}

			public List<ListHiveTableLineages_TableLineage> DownstreamLineages
			{
				get
				{
					return downstreamLineages;
				}
				set	
				{
					downstreamLineages = value;
				}
			}

			public class ListHiveTableLineages_TableLineage
			{

				private string modifiedTime;

				private string databaseName;

				private string engine;

				private string createTime;

				private string clusterId;

				private string source;

				private string tableName;

				private string jobId;

				private string queryText;

				public string ModifiedTime
				{
					get
					{
						return modifiedTime;
					}
					set	
					{
						modifiedTime = value;
					}
				}

				public string DatabaseName
				{
					get
					{
						return databaseName;
					}
					set	
					{
						databaseName = value;
					}
				}

				public string Engine
				{
					get
					{
						return engine;
					}
					set	
					{
						engine = value;
					}
				}

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public string ClusterId
				{
					get
					{
						return clusterId;
					}
					set	
					{
						clusterId = value;
					}
				}

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}

				public string TableName
				{
					get
					{
						return tableName;
					}
					set	
					{
						tableName = value;
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

				public string QueryText
				{
					get
					{
						return queryText;
					}
					set	
					{
						queryText = value;
					}
				}
			}
		}
	}
}
