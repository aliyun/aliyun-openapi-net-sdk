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
	public class ListDataCorrectPreCheckSQLResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private List<ListDataCorrectPreCheckSQL_PreCheckSQL> preCheckSQLList;

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

		[JsonProperty(PropertyName = "PreCheckSQLList")]
		public List<ListDataCorrectPreCheckSQL_PreCheckSQL> PreCheckSQLList
		{
			get
			{
				return preCheckSQLList;
			}
			set	
			{
				preCheckSQLList = value;
			}
		}

		public class ListDataCorrectPreCheckSQL_PreCheckSQL
		{

			private string checkSQL;

			private long? affectRows;

			private long? dbId;

			private string sQLReviewQueryKey;

			private string sqlReviewStatus;

			private string sqlType;

			private string tableNames;

			[JsonProperty(PropertyName = "CheckSQL")]
			public string CheckSQL
			{
				get
				{
					return checkSQL;
				}
				set	
				{
					checkSQL = value;
				}
			}

			[JsonProperty(PropertyName = "AffectRows")]
			public long? AffectRows
			{
				get
				{
					return affectRows;
				}
				set	
				{
					affectRows = value;
				}
			}

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

			[JsonProperty(PropertyName = "SQLReviewQueryKey")]
			public string SQLReviewQueryKey
			{
				get
				{
					return sQLReviewQueryKey;
				}
				set	
				{
					sQLReviewQueryKey = value;
				}
			}

			[JsonProperty(PropertyName = "SqlReviewStatus")]
			public string SqlReviewStatus
			{
				get
				{
					return sqlReviewStatus;
				}
				set	
				{
					sqlReviewStatus = value;
				}
			}

			[JsonProperty(PropertyName = "SqlType")]
			public string SqlType
			{
				get
				{
					return sqlType;
				}
				set	
				{
					sqlType = value;
				}
			}

			[JsonProperty(PropertyName = "TableNames")]
			public string TableNames
			{
				get
				{
					return tableNames;
				}
				set	
				{
					tableNames = value;
				}
			}
		}
	}
}
