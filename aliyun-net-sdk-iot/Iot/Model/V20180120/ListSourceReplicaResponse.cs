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
	public class ListSourceReplicaResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private ListSourceReplica_Data data;

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

		public ListSourceReplica_Data Data
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

		public class ListSourceReplica_Data
		{

			private long? total;

			private long? totalPage;

			private int? pageSize;

			private int? pageNo;

			private List<ListSourceReplica_DataListItem> dataList;

			public long? Total
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

			public long? TotalPage
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

			public List<ListSourceReplica_DataListItem> DataList
			{
				get
				{
					return dataList;
				}
				set	
				{
					dataList = value;
				}
			}

			public class ListSourceReplica_DataListItem
			{

				private string replicaUid;

				private string name;

				private string code;

				private string sourceUid;

				private string tableUid;

				private string sourceType;

				private int? timeCycle;

				private string timeUnit;

				private int? region;

				private long? beginLatest;

				private long? endLatest;

				private string extraProperty;

				private int? status;

				private long? storageSize;

				private long? productCreateTime;

				private int? nodeType;

				private bool? needTips;

				private string longJobUid;

				private string desc;

				private long? gmtCreate;

				public string ReplicaUid
				{
					get
					{
						return replicaUid;
					}
					set	
					{
						replicaUid = value;
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

				public string SourceUid
				{
					get
					{
						return sourceUid;
					}
					set	
					{
						sourceUid = value;
					}
				}

				public string TableUid
				{
					get
					{
						return tableUid;
					}
					set	
					{
						tableUid = value;
					}
				}

				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}

				public int? TimeCycle
				{
					get
					{
						return timeCycle;
					}
					set	
					{
						timeCycle = value;
					}
				}

				public string TimeUnit
				{
					get
					{
						return timeUnit;
					}
					set	
					{
						timeUnit = value;
					}
				}

				public int? Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public long? BeginLatest
				{
					get
					{
						return beginLatest;
					}
					set	
					{
						beginLatest = value;
					}
				}

				public long? EndLatest
				{
					get
					{
						return endLatest;
					}
					set	
					{
						endLatest = value;
					}
				}

				public string ExtraProperty
				{
					get
					{
						return extraProperty;
					}
					set	
					{
						extraProperty = value;
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

				public long? StorageSize
				{
					get
					{
						return storageSize;
					}
					set	
					{
						storageSize = value;
					}
				}

				public long? ProductCreateTime
				{
					get
					{
						return productCreateTime;
					}
					set	
					{
						productCreateTime = value;
					}
				}

				public int? NodeType
				{
					get
					{
						return nodeType;
					}
					set	
					{
						nodeType = value;
					}
				}

				public bool? NeedTips
				{
					get
					{
						return needTips;
					}
					set	
					{
						needTips = value;
					}
				}

				public string LongJobUid
				{
					get
					{
						return longJobUid;
					}
					set	
					{
						longJobUid = value;
					}
				}

				public string Desc
				{
					get
					{
						return desc;
					}
					set	
					{
						desc = value;
					}
				}

				public long? GmtCreate
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
			}
		}
	}
}
