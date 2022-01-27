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
	public class GetPermApplyOrderDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetPermApplyOrderDetail_PermApplyOrderDetail permApplyOrderDetail;

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

		[JsonProperty(PropertyName = "PermApplyOrderDetail")]
		public GetPermApplyOrderDetail_PermApplyOrderDetail PermApplyOrderDetail
		{
			get
			{
				return permApplyOrderDetail;
			}
			set	
			{
				permApplyOrderDetail = value;
			}
		}

		public class GetPermApplyOrderDetail_PermApplyOrderDetail
		{

			private long? permType;

			private long? seconds;

			private string applyType;

			private List<GetPermApplyOrderDetail_Resource> resources;

			[JsonProperty(PropertyName = "PermType")]
			public long? PermType
			{
				get
				{
					return permType;
				}
				set	
				{
					permType = value;
				}
			}

			[JsonProperty(PropertyName = "Seconds")]
			public long? Seconds
			{
				get
				{
					return seconds;
				}
				set	
				{
					seconds = value;
				}
			}

			[JsonProperty(PropertyName = "ApplyType")]
			public string ApplyType
			{
				get
				{
					return applyType;
				}
				set	
				{
					applyType = value;
				}
			}

			[JsonProperty(PropertyName = "Resources")]
			public List<GetPermApplyOrderDetail_Resource> Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}

			public class GetPermApplyOrderDetail_Resource
			{

				private GetPermApplyOrderDetail_DatabaseInfo databaseInfo;

				private GetPermApplyOrderDetail_TableInfo tableInfo;

				private GetPermApplyOrderDetail_ColumnInfo columnInfo;

				private GetPermApplyOrderDetail_InstanceInfo instanceInfo;

				[JsonProperty(PropertyName = "DatabaseInfo")]
				public GetPermApplyOrderDetail_DatabaseInfo DatabaseInfo
				{
					get
					{
						return databaseInfo;
					}
					set	
					{
						databaseInfo = value;
					}
				}

				[JsonProperty(PropertyName = "TableInfo")]
				public GetPermApplyOrderDetail_TableInfo TableInfo
				{
					get
					{
						return tableInfo;
					}
					set	
					{
						tableInfo = value;
					}
				}

				[JsonProperty(PropertyName = "ColumnInfo")]
				public GetPermApplyOrderDetail_ColumnInfo ColumnInfo
				{
					get
					{
						return columnInfo;
					}
					set	
					{
						columnInfo = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceInfo")]
				public GetPermApplyOrderDetail_InstanceInfo InstanceInfo
				{
					get
					{
						return instanceInfo;
					}
					set	
					{
						instanceInfo = value;
					}
				}

				public class GetPermApplyOrderDetail_DatabaseInfo
				{

					private long? dbId;

					private bool? logic;

					private string dbType;

					private string searchName;

					private string envType;

					private List<string> ownerIds;

					private List<string> ownerNickNames;

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

					[JsonProperty(PropertyName = "OwnerIds")]
					public List<string> OwnerIds
					{
						get
						{
							return ownerIds;
						}
						set	
						{
							ownerIds = value;
						}
					}

					[JsonProperty(PropertyName = "OwnerNickNames")]
					public List<string> OwnerNickNames
					{
						get
						{
							return ownerNickNames;
						}
						set	
						{
							ownerNickNames = value;
						}
					}
				}

				public class GetPermApplyOrderDetail_TableInfo
				{

					private string tableName;

					[JsonProperty(PropertyName = "TableName")]
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
				}

				public class GetPermApplyOrderDetail_ColumnInfo
				{

					private string tableName;

					private string columnName;

					[JsonProperty(PropertyName = "TableName")]
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

					[JsonProperty(PropertyName = "ColumnName")]
					public string ColumnName
					{
						get
						{
							return columnName;
						}
						set	
						{
							columnName = value;
						}
					}
				}

				public class GetPermApplyOrderDetail_InstanceInfo
				{

					private string instanceId;

					private string searchName;

					private string dbType;

					private string envType;

					private string host;

					private long? port;

					private long? dbaId;

					private string dbaNickName;

					private List<string> ownerIds1;

					private List<string> ownerNickName;

					[JsonProperty(PropertyName = "InstanceId")]
					public string InstanceId
					{
						get
						{
							return instanceId;
						}
						set	
						{
							instanceId = value;
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

					[JsonProperty(PropertyName = "Host")]
					public string Host
					{
						get
						{
							return host;
						}
						set	
						{
							host = value;
						}
					}

					[JsonProperty(PropertyName = "Port")]
					public long? Port
					{
						get
						{
							return port;
						}
						set	
						{
							port = value;
						}
					}

					[JsonProperty(PropertyName = "DbaId")]
					public long? DbaId
					{
						get
						{
							return dbaId;
						}
						set	
						{
							dbaId = value;
						}
					}

					[JsonProperty(PropertyName = "DbaNickName")]
					public string DbaNickName
					{
						get
						{
							return dbaNickName;
						}
						set	
						{
							dbaNickName = value;
						}
					}

					[JsonProperty(PropertyName = "OwnerIds1")]
					public List<string> OwnerIds1
					{
						get
						{
							return ownerIds1;
						}
						set	
						{
							ownerIds1 = value;
						}
					}

					[JsonProperty(PropertyName = "OwnerNickName")]
					public List<string> OwnerNickName
					{
						get
						{
							return ownerNickName;
						}
						set	
						{
							ownerNickName = value;
						}
					}
				}
			}
		}
	}
}
