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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class QuerySupplementInfoListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string message;

		private List<QuerySupplementInfoList_DataItem> data;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public List<QuerySupplementInfoList_DataItem> Data
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

		public class QuerySupplementInfoList_DataItem
		{

			private string bizId;

			private string supplementId;

			private string supplementReason;

			private long? receiveTimestamp;

			private string supplementFields;

			private string supplementType;

			private string supplementFileUrl;

			private string additionalReason;

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string SupplementId
			{
				get
				{
					return supplementId;
				}
				set	
				{
					supplementId = value;
				}
			}

			public string SupplementReason
			{
				get
				{
					return supplementReason;
				}
				set	
				{
					supplementReason = value;
				}
			}

			public long? ReceiveTimestamp
			{
				get
				{
					return receiveTimestamp;
				}
				set	
				{
					receiveTimestamp = value;
				}
			}

			public string SupplementFields
			{
				get
				{
					return supplementFields;
				}
				set	
				{
					supplementFields = value;
				}
			}

			public string SupplementType
			{
				get
				{
					return supplementType;
				}
				set	
				{
					supplementType = value;
				}
			}

			public string SupplementFileUrl
			{
				get
				{
					return supplementFileUrl;
				}
				set	
				{
					supplementFileUrl = value;
				}
			}

			public string AdditionalReason
			{
				get
				{
					return additionalReason;
				}
				set	
				{
					additionalReason = value;
				}
			}
		}
	}
}
