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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetStructSyncOrderDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetStructSyncOrderDetail_StructSyncOrderDetail structSyncOrderDetail;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
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

		[JsonProperty(PropertyName = "StructSyncOrderDetail")]
		public GetStructSyncOrderDetail_StructSyncOrderDetail StructSyncOrderDetail
		{
			get
			{
				return structSyncOrderDetail;
			}
			set	
			{
				structSyncOrderDetail = value;
			}
		}

		public class GetStructSyncOrderDetail_StructSyncOrderDetail
		{

			private string sourceType;

			private string targetType;

			private bool? ignoreError;

			private List<GetStructSyncOrderDetail_TableInfo> tableInfoList;

			private GetStructSyncOrderDetail_SourceDatabaseInfo sourceDatabaseInfo;

			private GetStructSyncOrderDetail_TargetDatabaseInfo targetDatabaseInfo;

			private GetStructSyncOrderDetail_SourceVersionInfo sourceVersionInfo;

			private GetStructSyncOrderDetail_TargetVersionInfo targetVersionInfo;

			[JsonProperty(PropertyName = "SourceType")]
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

			[JsonProperty(PropertyName = "TargetType")]
			public string TargetType
			{
				get
				{
					return targetType;
				}
				set	
				{
					targetType = value;
				}
			}

			[JsonProperty(PropertyName = "IgnoreError")]
			public bool? IgnoreError
			{
				get
				{
					return ignoreError;
				}
				set	
				{
					ignoreError = value;
				}
			}

			[JsonProperty(PropertyName = "TableInfoList")]
			public List<GetStructSyncOrderDetail_TableInfo> TableInfoList
			{
				get
				{
					return tableInfoList;
				}
				set	
				{
					tableInfoList = value;
				}
			}

			[JsonProperty(PropertyName = "SourceDatabaseInfo")]
			public GetStructSyncOrderDetail_SourceDatabaseInfo SourceDatabaseInfo
			{
				get
				{
					return sourceDatabaseInfo;
				}
				set	
				{
					sourceDatabaseInfo = value;
				}
			}

			[JsonProperty(PropertyName = "TargetDatabaseInfo")]
			public GetStructSyncOrderDetail_TargetDatabaseInfo TargetDatabaseInfo
			{
				get
				{
					return targetDatabaseInfo;
				}
				set	
				{
					targetDatabaseInfo = value;
				}
			}

			[JsonProperty(PropertyName = "SourceVersionInfo")]
			public GetStructSyncOrderDetail_SourceVersionInfo SourceVersionInfo
			{
				get
				{
					return sourceVersionInfo;
				}
				set	
				{
					sourceVersionInfo = value;
				}
			}

			[JsonProperty(PropertyName = "TargetVersionInfo")]
			public GetStructSyncOrderDetail_TargetVersionInfo TargetVersionInfo
			{
				get
				{
					return targetVersionInfo;
				}
				set	
				{
					targetVersionInfo = value;
				}
			}

			public class GetStructSyncOrderDetail_TableInfo
			{

				private string sourceTableName;

				private string targetTableName;

				[JsonProperty(PropertyName = "SourceTableName")]
				public string SourceTableName
				{
					get
					{
						return sourceTableName;
					}
					set	
					{
						sourceTableName = value;
					}
				}

				[JsonProperty(PropertyName = "TargetTableName")]
				public string TargetTableName
				{
					get
					{
						return targetTableName;
					}
					set	
					{
						targetTableName = value;
					}
				}
			}

			public class GetStructSyncOrderDetail_SourceDatabaseInfo
			{

				private long? dbId;

				private string searchName;

				private string dbType;

				private string envType;

				private bool? logic;

				[JsonProperty(PropertyName = "DbId")]
				public long? DbId
				{
					get
					{
						return dbId;
					}
					set	
					{
						dbId = value;
					}
				}

				[JsonProperty(PropertyName = "SearchName")]
				public string SearchName
				{
					get
					{
						return searchName;
					}
					set	
					{
						searchName = value;
					}
				}

				[JsonProperty(PropertyName = "DbType")]
				public string DbType
				{
					get
					{
						return dbType;
					}
					set	
					{
						dbType = value;
					}
				}

				[JsonProperty(PropertyName = "EnvType")]
				public string EnvType
				{
					get
					{
						return envType;
					}
					set	
					{
						envType = value;
					}
				}

				[JsonProperty(PropertyName = "Logic")]
				public bool? Logic
				{
					get
					{
						return logic;
					}
					set	
					{
						logic = value;
					}
				}
			}

			public class GetStructSyncOrderDetail_TargetDatabaseInfo
			{

				private long? dbId;

				private string searchName;

				private string dbType;

				private string envType;

				private bool? logic;

				[JsonProperty(PropertyName = "DbId")]
				public long? DbId
				{
					get
					{
						return dbId;
					}
					set	
					{
						dbId = value;
					}
				}

				[JsonProperty(PropertyName = "SearchName")]
				public string SearchName
				{
					get
					{
						return searchName;
					}
					set	
					{
						searchName = value;
					}
				}

				[JsonProperty(PropertyName = "DbType")]
				public string DbType
				{
					get
					{
						return dbType;
					}
					set	
					{
						dbType = value;
					}
				}

				[JsonProperty(PropertyName = "EnvType")]
				public string EnvType
				{
					get
					{
						return envType;
					}
					set	
					{
						envType = value;
					}
				}

				[JsonProperty(PropertyName = "Logic")]
				public bool? Logic
				{
					get
					{
						return logic;
					}
					set	
					{
						logic = value;
					}
				}
			}

			public class GetStructSyncOrderDetail_SourceVersionInfo
			{

				private string versionId;

				[JsonProperty(PropertyName = "VersionId")]
				public string VersionId
				{
					get
					{
						return versionId;
					}
					set	
					{
						versionId = value;
					}
				}
			}

			public class GetStructSyncOrderDetail_TargetVersionInfo
			{

				private string versionId;

				[JsonProperty(PropertyName = "VersionId")]
				public string VersionId
				{
					get
					{
						return versionId;
					}
					set	
					{
						versionId = value;
					}
				}
			}
		}
	}
}
