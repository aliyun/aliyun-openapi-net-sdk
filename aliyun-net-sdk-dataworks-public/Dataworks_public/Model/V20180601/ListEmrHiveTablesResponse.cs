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
	public class ListEmrHiveTablesResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private ListEmrHiveTables_Data data;

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

		public ListEmrHiveTables_Data Data
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

		public class ListEmrHiveTables_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListEmrHiveTables_HiveTables> pagedData;

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

			public List<ListEmrHiveTables_HiveTables> PagedData
			{
				get
				{
					return pagedData;
				}
				set	
				{
					pagedData = value;
				}
			}

			public class ListEmrHiveTables_HiveTables
			{

				private string clusterBizId;

				private string tableName;

				private string tableType;

				private string owner;

				private string ownerType;

				private bool? isTemporary;

				private string serializationLib;

				private string inputFormat;

				private string outputFormat;

				private string location;

				private string lastAccessTime;

				private string gmtCreate;

				private string gmtModified;

				private string tableComment;

				private string tableParameters;

				private string partitionKeys;

				private bool? isCompressed;

				private string clusterBizName;

				private string databaseName;

				private string ownerId;

				private string lastModifyTime;

				private string tableDesc;

				public string ClusterBizId
				{
					get
					{
						return clusterBizId;
					}
					set	
					{
						clusterBizId = value;
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

				public string TableType
				{
					get
					{
						return tableType;
					}
					set	
					{
						tableType = value;
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

				public string OwnerType
				{
					get
					{
						return ownerType;
					}
					set	
					{
						ownerType = value;
					}
				}

				public bool? IsTemporary
				{
					get
					{
						return isTemporary;
					}
					set	
					{
						isTemporary = value;
					}
				}

				public string SerializationLib
				{
					get
					{
						return serializationLib;
					}
					set	
					{
						serializationLib = value;
					}
				}

				public string InputFormat
				{
					get
					{
						return inputFormat;
					}
					set	
					{
						inputFormat = value;
					}
				}

				public string OutputFormat
				{
					get
					{
						return outputFormat;
					}
					set	
					{
						outputFormat = value;
					}
				}

				public string Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public string LastAccessTime
				{
					get
					{
						return lastAccessTime;
					}
					set	
					{
						lastAccessTime = value;
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

				public string TableComment
				{
					get
					{
						return tableComment;
					}
					set	
					{
						tableComment = value;
					}
				}

				public string TableParameters
				{
					get
					{
						return tableParameters;
					}
					set	
					{
						tableParameters = value;
					}
				}

				public string PartitionKeys
				{
					get
					{
						return partitionKeys;
					}
					set	
					{
						partitionKeys = value;
					}
				}

				public bool? IsCompressed
				{
					get
					{
						return isCompressed;
					}
					set	
					{
						isCompressed = value;
					}
				}

				public string ClusterBizName
				{
					get
					{
						return clusterBizName;
					}
					set	
					{
						clusterBizName = value;
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

				public string OwnerId
				{
					get
					{
						return ownerId;
					}
					set	
					{
						ownerId = value;
					}
				}

				public string LastModifyTime
				{
					get
					{
						return lastModifyTime;
					}
					set	
					{
						lastModifyTime = value;
					}
				}

				public string TableDesc
				{
					get
					{
						return tableDesc;
					}
					set	
					{
						tableDesc = value;
					}
				}
			}
		}
	}
}
