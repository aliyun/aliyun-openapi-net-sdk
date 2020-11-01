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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListDiagnoseReportResponse : AcsResponse
	{

		private string requestId;

		private List<ListDiagnoseReport_ResultItem> result;

		private ListDiagnoseReport_Headers headers;

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

		public List<ListDiagnoseReport_ResultItem> Result
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

		public ListDiagnoseReport_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListDiagnoseReport_ResultItem
		{

			private string reportId;

			private string instanceId;

			private string state;

			private string trigger;

			private string health;

			private long? createTime;

			private List<ListDiagnoseReport_DiagnoseItemsItem> diagnoseItems;

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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string Trigger
			{
				get
				{
					return trigger;
				}
				set	
				{
					trigger = value;
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

			public long? CreateTime
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

			public List<ListDiagnoseReport_DiagnoseItemsItem> DiagnoseItems
			{
				get
				{
					return diagnoseItems;
				}
				set	
				{
					diagnoseItems = value;
				}
			}

			public class ListDiagnoseReport_DiagnoseItemsItem
			{

				private string item;

				private string health;

				private ListDiagnoseReport_Detail detail;

				public string Item
				{
					get
					{
						return item;
					}
					set	
					{
						item = value;
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

				public ListDiagnoseReport_Detail Detail
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

				public class ListDiagnoseReport_Detail
				{

					private string name;

					private string desc;

					private string type;

					private string suggest;

					private string result;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public string Desc
					{
						get
						{
							return desc;
						}
						set	
						{
							desc = value;
						}
					}

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					public string Suggest
					{
						get
						{
							return suggest;
						}
						set	
						{
							suggest = value;
						}
					}

					public string Result
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
				}
			}
		}

		public class ListDiagnoseReport_Headers
		{

			private int? xTotalCount;

			public int? XTotalCount
			{
				get
				{
					return xTotalCount;
				}
				set	
				{
					xTotalCount = value;
				}
			}
		}
	}
}
