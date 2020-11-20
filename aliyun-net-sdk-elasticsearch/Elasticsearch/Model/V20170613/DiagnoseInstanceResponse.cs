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
	public class DiagnoseInstanceResponse : AcsResponse
	{

		private string requestId;

		private DiagnoseInstance_Result result;

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

		public DiagnoseInstance_Result Result
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

		public class DiagnoseInstance_Result
		{

			private string reportId;

			private string instanceId;

			private string state;

			private long? createTime;

			private List<DiagnoseInstance_DiagnoseItemsItem> diagnoseItems;

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

			public List<DiagnoseInstance_DiagnoseItemsItem> DiagnoseItems
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

			public class DiagnoseInstance_DiagnoseItemsItem
			{

				private string item;

				private string health;

				private DiagnoseInstance_Detail detail;

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

				public DiagnoseInstance_Detail Detail
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

				public class DiagnoseInstance_Detail
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
	}
}
