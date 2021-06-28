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

namespace Aliyun.Acs.ivision.Model.V20190308
{
	public class ListMyAlgorithmResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private ListMyAlgorithm_Data data;

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

		public string Code
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

		public ListMyAlgorithm_Data Data
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

		public class ListMyAlgorithm_Data
		{

			private int? pageSize;

			private int? pageNumber;

			private int? totalCount;

			private List<ListMyAlgorithm_AlgorithmListItem> algorithmList;

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

			public int? TotalCount
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

			public List<ListMyAlgorithm_AlgorithmListItem> AlgorithmList
			{
				get
				{
					return algorithmList;
				}
				set	
				{
					algorithmList = value;
				}
			}

			public class ListMyAlgorithm_AlgorithmListItem
			{

				private string algorithmName;

				private string deployRegion;

				private int? currentMonthCount;

				private string algorithmCode;

				private string apiDocUrl;

				private int? yesterdayCount;

				private int? algorithmOrder;

				public string AlgorithmName
				{
					get
					{
						return algorithmName;
					}
					set	
					{
						algorithmName = value;
					}
				}

				public string DeployRegion
				{
					get
					{
						return deployRegion;
					}
					set	
					{
						deployRegion = value;
					}
				}

				public int? CurrentMonthCount
				{
					get
					{
						return currentMonthCount;
					}
					set	
					{
						currentMonthCount = value;
					}
				}

				public string AlgorithmCode
				{
					get
					{
						return algorithmCode;
					}
					set	
					{
						algorithmCode = value;
					}
				}

				public string ApiDocUrl
				{
					get
					{
						return apiDocUrl;
					}
					set	
					{
						apiDocUrl = value;
					}
				}

				public int? YesterdayCount
				{
					get
					{
						return yesterdayCount;
					}
					set	
					{
						yesterdayCount = value;
					}
				}

				public int? AlgorithmOrder
				{
					get
					{
						return algorithmOrder;
					}
					set	
					{
						algorithmOrder = value;
					}
				}
			}
		}
	}
}
