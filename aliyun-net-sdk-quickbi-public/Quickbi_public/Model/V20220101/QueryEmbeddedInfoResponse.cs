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
	public class QueryEmbeddedInfoResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private QueryEmbeddedInfo_Result result;

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

		public QueryEmbeddedInfo_Result Result
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

		public class QueryEmbeddedInfo_Result
		{

			private int? embeddedCount;

			private int? maxCount;

			private QueryEmbeddedInfo_Detail detail;

			public int? EmbeddedCount
			{
				get
				{
					return embeddedCount;
				}
				set	
				{
					embeddedCount = value;
				}
			}

			public int? MaxCount
			{
				get
				{
					return maxCount;
				}
				set	
				{
					maxCount = value;
				}
			}

			public QueryEmbeddedInfo_Detail Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public class QueryEmbeddedInfo_Detail
			{

				private int? dashboardOfflineQuery;

				private int? page;

				private int? report;

				public int? DashboardOfflineQuery
				{
					get
					{
						return dashboardOfflineQuery;
					}
					set	
					{
						dashboardOfflineQuery = value;
					}
				}

				public int? Page
				{
					get
					{
						return page;
					}
					set	
					{
						page = value;
					}
				}

				public int? Report
				{
					get
					{
						return report;
					}
					set	
					{
						report = value;
					}
				}
			}
		}
	}
}
