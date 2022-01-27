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
	public class GetMetaTableLineageResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private string errorCode;

		private GetMetaTableLineage_Data data;

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

		public GetMetaTableLineage_Data Data
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

		public class GetMetaTableLineage_Data
		{

			private string nextPrimaryKey;

			private bool? hasNext;

			private List<GetMetaTableLineage_DataEntityListItem> dataEntityList;

			public string NextPrimaryKey
			{
				get
				{
					return nextPrimaryKey;
				}
				set	
				{
					nextPrimaryKey = value;
				}
			}

			public bool? HasNext
			{
				get
				{
					return hasNext;
				}
				set	
				{
					hasNext = value;
				}
			}

			public List<GetMetaTableLineage_DataEntityListItem> DataEntityList
			{
				get
				{
					return dataEntityList;
				}
				set	
				{
					dataEntityList = value;
				}
			}

			public class GetMetaTableLineage_DataEntityListItem
			{

				private string tableName;

				private string tableGuid;

				private long? createTimestamp;

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

				public string TableGuid
				{
					get
					{
						return tableGuid;
					}
					set	
					{
						tableGuid = value;
					}
				}

				public long? CreateTimestamp
				{
					get
					{
						return createTimestamp;
					}
					set	
					{
						createTimestamp = value;
					}
				}
			}
		}
	}
}
