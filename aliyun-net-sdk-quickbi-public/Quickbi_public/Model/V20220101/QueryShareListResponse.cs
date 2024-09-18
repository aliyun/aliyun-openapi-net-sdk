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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryShareListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<QueryShareList_Data> result;

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

		public List<QueryShareList_Data> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryShareList_Data
		{

			private int? authPoint;

			private long? expireDate;

			private string reportId;

			private string shareId;

			private string shareToId;

			private string shareToName;

			private int? shareToType;

			private string shareType;

			public int? AuthPoint
			{
				get
				{
					return authPoint;
				}
				set	
				{
					authPoint = value;
				}
			}

			public long? ExpireDate
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

			public string ReportId
			{
				get
				{
					return reportId;
				}
				set	
				{
					reportId = value;
				}
			}

			public string ShareId
			{
				get
				{
					return shareId;
				}
				set	
				{
					shareId = value;
				}
			}

			public string ShareToId
			{
				get
				{
					return shareToId;
				}
				set	
				{
					shareToId = value;
				}
			}

			public string ShareToName
			{
				get
				{
					return shareToName;
				}
				set	
				{
					shareToName = value;
				}
			}

			public int? ShareToType
			{
				get
				{
					return shareToType;
				}
				set	
				{
					shareToType = value;
				}
			}

			public string ShareType
			{
				get
				{
					return shareType;
				}
				set	
				{
					shareType = value;
				}
			}
		}
	}
}
