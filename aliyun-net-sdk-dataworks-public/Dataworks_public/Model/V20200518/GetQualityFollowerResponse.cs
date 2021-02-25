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
	public class GetQualityFollowerResponse : AcsResponse
	{

		private string errorCode;

		private bool? success;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private List<GetQualityFollower_Follower> data;

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

		public List<GetQualityFollower_Follower> Data
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

		public class GetQualityFollower_Follower
		{

			private string projectName;

			private string tableName;

			private long? id;

			private string entityId;

			private string follower;

			private int? alarmMode;

			private string followerAccountName;

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

			public string EntityId
			{
				get
				{
					return entityId;
				}
				set	
				{
					entityId = value;
				}
			}

			public string Follower
			{
				get
				{
					return follower;
				}
				set	
				{
					follower = value;
				}
			}

			public int? AlarmMode
			{
				get
				{
					return alarmMode;
				}
				set	
				{
					alarmMode = value;
				}
			}

			public string FollowerAccountName
			{
				get
				{
					return followerAccountName;
				}
				set	
				{
					followerAccountName = value;
				}
			}
		}
	}
}
