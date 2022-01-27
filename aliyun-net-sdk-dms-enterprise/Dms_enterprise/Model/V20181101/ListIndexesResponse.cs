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
	public class ListIndexesResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListIndexes_Index> indexList;

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

		[JsonProperty(PropertyName = "IndexList")]
		public List<ListIndexes_Index> IndexList
		{
			get
			{
				return indexList;
			}
			set	
			{
				indexList = value;
			}
		}

		public class ListIndexes_Index
		{

			private string indexName;

			private string indexType;

			private string tableId;

			private string indexId;

			private string indexComment;

			[JsonProperty(PropertyName = "IndexName")]
			public string IndexName
			{
				get
				{
					return indexName;
				}
				set	
				{
					indexName = value;
				}
			}

			[JsonProperty(PropertyName = "IndexType")]
			public string IndexType
			{
				get
				{
					return indexType;
				}
				set	
				{
					indexType = value;
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

			[JsonProperty(PropertyName = "IndexId")]
			public string IndexId
			{
				get
				{
					return indexId;
				}
				set	
				{
					indexId = value;
				}
			}

			[JsonProperty(PropertyName = "IndexComment")]
			public string IndexComment
			{
				get
				{
					return indexComment;
				}
				set	
				{
					indexComment = value;
				}
			}
		}
	}
}
