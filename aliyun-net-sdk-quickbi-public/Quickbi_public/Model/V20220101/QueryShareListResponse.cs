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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryShareListResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private List<QueryShareList_Data> result;

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

			private string shareId;

			private string shareToId;

			private int? authPoint;

			private long? expireDate;

			private int? shareToType;

			private string reportId;

			private string shareToName;

			private string shareType;

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
