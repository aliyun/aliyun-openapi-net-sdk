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
	public class ListDatabaseUserPermssionsResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListDatabaseUserPermssions_UserPermission> userPermissions;

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "UserPermissions")]
		public List<ListDatabaseUserPermssions_UserPermission> UserPermissions
		{
			get
			{
				return userPermissions;
			}
			set	
			{
				userPermissions = value;
			}
		}

		public class ListDatabaseUserPermssions_UserPermission
		{

			private string dbId;

			private string tableName;

			private string userId;

			private string schemaName;

			private bool? logic;

			private string userNickName;

			private string instanceId;

			private string envType;

			private string columnName;

			private string dbType;

			private string dsType;

			private string tableId;

			private string searchName;

			private string alias;

			private List<ListDatabaseUserPermssions_PermDetail> permDetails;

			[JsonProperty(PropertyName = "DbId")]
			public string DbId
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

			[JsonProperty(PropertyName = "UserId")]
			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			[JsonProperty(PropertyName = "SchemaName")]
			public string SchemaName
			{
				get
				{
					return schemaName;
				}
				set	
				{
					schemaName = value;
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

			[JsonProperty(PropertyName = "UserNickName")]
			public string UserNickName
			{
				get
				{
					return userNickName;
				}
				set	
				{
					userNickName = value;
				}
			}

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

			[JsonProperty(PropertyName = "DsType")]
			public string DsType
			{
				get
				{
					return dsType;
				}
				set	
				{
					dsType = value;
				}
			}

			[JsonProperty(PropertyName = "TableId")]
			public string TableId
			{
				get
				{
					return tableId;
				}
				set	
				{
					tableId = value;
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

			[JsonProperty(PropertyName = "Alias")]
			public string Alias
			{
				get
				{
					return alias;
				}
				set	
				{
					alias = value;
				}
			}

			[JsonProperty(PropertyName = "PermDetails")]
			public List<ListDatabaseUserPermssions_PermDetail> PermDetails
			{
				get
				{
					return permDetails;
				}
				set	
				{
					permDetails = value;
				}
			}

			public class ListDatabaseUserPermssions_PermDetail
			{

				private string originFrom;

				private string permType;

				private string expireDate;

				private string createDate;

				private string userAccessId;

				private string extraData;

				[JsonProperty(PropertyName = "OriginFrom")]
				public string OriginFrom
				{
					get
					{
						return originFrom;
					}
					set	
					{
						originFrom = value;
					}
				}

				[JsonProperty(PropertyName = "PermType")]
				public string PermType
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

				[JsonProperty(PropertyName = "ExpireDate")]
				public string ExpireDate
				{
					get
					{
						return expireDate;
					}
					set	
					{
						expireDate = value;
					}
				}

				[JsonProperty(PropertyName = "CreateDate")]
				public string CreateDate
				{
					get
					{
						return createDate;
					}
					set	
					{
						createDate = value;
					}
				}

				[JsonProperty(PropertyName = "UserAccessId")]
				public string UserAccessId
				{
					get
					{
						return userAccessId;
					}
					set	
					{
						userAccessId = value;
					}
				}

				[JsonProperty(PropertyName = "ExtraData")]
				public string ExtraData
				{
					get
					{
						return extraData;
					}
					set	
					{
						extraData = value;
					}
				}
			}
		}
	}
}
