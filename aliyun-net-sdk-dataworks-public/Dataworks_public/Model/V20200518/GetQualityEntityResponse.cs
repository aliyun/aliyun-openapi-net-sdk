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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetQualityEntityResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private string errorCode;

		private bool? success;

		private List<GetQualityEntity_EntityDto> data;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public List<GetQualityEntity_EntityDto> Data
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

		public class GetQualityEntity_EntityDto
		{

			private string relativeNode;

			private string onDutyAccountName;

			private int? task;

			private string tableName;

			private string followers;

			private string onDuty;

			private string matchExpression;

			private long? createTime;

			private string projectName;

			private bool? hasRelativeNode;

			private string envType;

			private int? entityLevel;

			private string modifyUser;

			private int? sql;

			private long? id;

			private long? modifyTime;

			public string RelativeNode
			{
				get
				{
					return relativeNode;
				}
				set	
				{
					relativeNode = value;
				}
			}

			public string OnDutyAccountName
			{
				get
				{
					return onDutyAccountName;
				}
				set	
				{
					onDutyAccountName = value;
				}
			}

			public int? Task
			{
				get
				{
					return task;
				}
				set	
				{
					task = value;
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

			public string Followers
			{
				get
				{
					return followers;
				}
				set	
				{
					followers = value;
				}
			}

			public string OnDuty
			{
				get
				{
					return onDuty;
				}
				set	
				{
					onDuty = value;
				}
			}

			public string MatchExpression
			{
				get
				{
					return matchExpression;
				}
				set	
				{
					matchExpression = value;
				}
			}

			public long? CreateTime
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

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public bool? HasRelativeNode
			{
				get
				{
					return hasRelativeNode;
				}
				set	
				{
					hasRelativeNode = value;
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

			public int? EntityLevel
			{
				get
				{
					return entityLevel;
				}
				set	
				{
					entityLevel = value;
				}
			}

			public string ModifyUser
			{
				get
				{
					return modifyUser;
				}
				set	
				{
					modifyUser = value;
				}
			}

			public int? Sql
			{
				get
				{
					return sql;
				}
				set	
				{
					sql = value;
				}
			}

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

			public long? ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}
		}
	}
}
