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
	public class QueryTicketInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryTicketInfo_Result result;

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

		public QueryTicketInfo_Result Result
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

		public class QueryTicketInfo_Result
		{

			private string accessTicket;

			private string cmptId;

			private string globalParam;

			private string invalidTime;

			private int? maxTicketNum;

			private string organizationId;

			private string registerTime;

			private int? usedTicketNum;

			private string userId;

			private string watermarkParam;

			private string worksId;

			public string AccessTicket
			{
				get
				{
					return accessTicket;
				}
				set	
				{
					accessTicket = value;
				}
			}

			public string CmptId
			{
				get
				{
					return cmptId;
				}
				set	
				{
					cmptId = value;
				}
			}

			public string GlobalParam
			{
				get
				{
					return globalParam;
				}
				set	
				{
					globalParam = value;
				}
			}

			public string InvalidTime
			{
				get
				{
					return invalidTime;
				}
				set	
				{
					invalidTime = value;
				}
			}

			public int? MaxTicketNum
			{
				get
				{
					return maxTicketNum;
				}
				set	
				{
					maxTicketNum = value;
				}
			}

			public string OrganizationId
			{
				get
				{
					return organizationId;
				}
				set	
				{
					organizationId = value;
				}
			}

			public string RegisterTime
			{
				get
				{
					return registerTime;
				}
				set	
				{
					registerTime = value;
				}
			}

			public int? UsedTicketNum
			{
				get
				{
					return usedTicketNum;
				}
				set	
				{
					usedTicketNum = value;
				}
			}

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

			public string WatermarkParam
			{
				get
				{
					return watermarkParam;
				}
				set	
				{
					watermarkParam = value;
				}
			}

			public string WorksId
			{
				get
				{
					return worksId;
				}
				set	
				{
					worksId = value;
				}
			}
		}
	}
}
