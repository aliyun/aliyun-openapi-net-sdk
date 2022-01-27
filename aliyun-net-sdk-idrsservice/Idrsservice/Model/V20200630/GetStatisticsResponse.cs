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

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
	public class GetStatisticsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetStatistics_Data data;

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

		public GetStatistics_Data Data
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

		public class GetStatistics_Data
		{

			private List<GetStatistics_ItemsItem> items;

			public List<GetStatistics_ItemsItem> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class GetStatistics_ItemsItem
			{

				private long? clientCount;

				private long? cloudCount;

				private string departmentName;

				private string month;

				private List<GetStatistics_DetailItem> detail;

				public long? ClientCount
				{
					get
					{
						return clientCount;
					}
					set	
					{
						clientCount = value;
					}
				}

				public long? CloudCount
				{
					get
					{
						return cloudCount;
					}
					set	
					{
						cloudCount = value;
					}
				}

				public string DepartmentName
				{
					get
					{
						return departmentName;
					}
					set	
					{
						departmentName = value;
					}
				}

				public string Month
				{
					get
					{
						return month;
					}
					set	
					{
						month = value;
					}
				}

				public List<GetStatistics_DetailItem> Detail
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

				public class GetStatistics_DetailItem
				{

					private long? clientCount;

					private long? cloudCount;

					private string departmentId;

					private string departmentName;

					private int? month;

					public long? ClientCount
					{
						get
						{
							return clientCount;
						}
						set	
						{
							clientCount = value;
						}
					}

					public long? CloudCount
					{
						get
						{
							return cloudCount;
						}
						set	
						{
							cloudCount = value;
						}
					}

					public string DepartmentId
					{
						get
						{
							return departmentId;
						}
						set	
						{
							departmentId = value;
						}
					}

					public string DepartmentName
					{
						get
						{
							return departmentName;
						}
						set	
						{
							departmentName = value;
						}
					}

					public int? Month
					{
						get
						{
							return month;
						}
						set	
						{
							month = value;
						}
					}
				}
			}
		}
	}
}
