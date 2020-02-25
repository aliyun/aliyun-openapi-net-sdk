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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListDatabaseUserPermssionsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private long? totalCount;

		private List<ListDatabaseUserPermssions_UserPermission> userPermissions;

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

			private string userId;

			private string userNickName;

			private string dsType;

			private string dbId;

			private bool? logic;

			private string schemaName;

			private string searchName;

			private string instanceId;

			private string envType;

			private string alias;

			private string dbType;

			private string tableName;

			private string tableId;

			private string columnName;

			private List<ListDatabaseUserPermssions_PermDetail> permDetails;

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

				private string permType;

				private string expireDate;

				private string createDate;

				private string originFrom;

				private string userAccessId;

				private string extraData;

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
