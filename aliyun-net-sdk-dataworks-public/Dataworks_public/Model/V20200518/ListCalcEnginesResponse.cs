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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListCalcEnginesResponse : AcsResponse
	{

		private int? httpStatusCode;

		private bool? success;

		private string requestId;

		private ListCalcEngines_Data data;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public ListCalcEngines_Data Data
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

		public class ListCalcEngines_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListCalcEngines_CalcEnginesItem> calcEngines;

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

			public List<ListCalcEngines_CalcEnginesItem> CalcEngines
			{
				get
				{
					return calcEngines;
				}
				set	
				{
					calcEngines = value;
				}
			}

			public class ListCalcEngines_CalcEnginesItem
			{

				private string calcEngineType;

				private string gmtCreate;

				private string dwRegion;

				private bool? isDefault;

				private int? bindingProjectId;

				private string envType;

				private long? tenantId;

				private string name;

				private string bindingProjectName;

				private string region;

				private int? engineId;

				private string engineInfo;

				private string taskAuthType;

				public string CalcEngineType
				{
					get
					{
						return calcEngineType;
					}
					set	
					{
						calcEngineType = value;
					}
				}

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string DwRegion
				{
					get
					{
						return dwRegion;
					}
					set	
					{
						dwRegion = value;
					}
				}

				public bool? IsDefault
				{
					get
					{
						return isDefault;
					}
					set	
					{
						isDefault = value;
					}
				}

				public int? BindingProjectId
				{
					get
					{
						return bindingProjectId;
					}
					set	
					{
						bindingProjectId = value;
					}
				}

				public string EnvType
				{
					get
					{
						return envType;
					}
					set	
					{
						envType = value;
					}
				}

				public long? TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
					}
				}

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

				public string BindingProjectName
				{
					get
					{
						return bindingProjectName;
					}
					set	
					{
						bindingProjectName = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public int? EngineId
				{
					get
					{
						return engineId;
					}
					set	
					{
						engineId = value;
					}
				}

				public string EngineInfo
				{
					get
					{
						return engineInfo;
					}
					set	
					{
						engineInfo = value;
					}
				}

				public string TaskAuthType
				{
					get
					{
						return taskAuthType;
					}
					set	
					{
						taskAuthType = value;
					}
				}
			}
		}
	}
}
