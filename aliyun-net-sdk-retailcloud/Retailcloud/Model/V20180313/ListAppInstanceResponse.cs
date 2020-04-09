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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class ListAppInstanceResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private int? pageSize;

		private int? pageNumber;

		private long? totalCount;

		private string errMsg;

		private List<ListAppInstance_AppInstanceDetail> data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
			}
		}

		public List<ListAppInstance_AppInstanceDetail> Data
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

		public class ListAppInstance_AppInstanceDetail
		{

			private string appInstanceId;

			private string createTime;

			private string spec;

			private int? restartCount;

			private string hostIp;

			private string podIp;

			private string health;

			private string requests;

			private string limits;

			public string AppInstanceId
			{
				get
				{
					return appInstanceId;
				}
				set	
				{
					appInstanceId = value;
				}
			}

			public string CreateTime
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

			public string Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
				}
			}

			public int? RestartCount
			{
				get
				{
					return restartCount;
				}
				set	
				{
					restartCount = value;
				}
			}

			public string HostIp
			{
				get
				{
					return hostIp;
				}
				set	
				{
					hostIp = value;
				}
			}

			public string PodIp
			{
				get
				{
					return podIp;
				}
				set	
				{
					podIp = value;
				}
			}

			public string Health
			{
				get
				{
					return health;
				}
				set	
				{
					health = value;
				}
			}

			public string Requests
			{
				get
				{
					return requests;
				}
				set	
				{
					requests = value;
				}
			}

			public string Limits
			{
				get
				{
					return limits;
				}
				set	
				{
					limits = value;
				}
			}
		}
	}
}
