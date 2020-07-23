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

namespace Aliyun.Acs.cloudgame.Model.V20200429
{
	public class ListProjectsResponse : AcsResponse
	{

		private int? count;

		private int? currentPage;

		private int? pageSize;

		private string requestId;

		private List<ListProjects_DataListItem> dataList;

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<ListProjects_DataListItem> DataList
		{
			get
			{
				return dataList;
			}
			set	
			{
				dataList = value;
			}
		}

		public class ListProjects_DataListItem
		{

			private string standardCodeRate;

			private string highDefinitionResolution;

			private string highDefinitionCodeRate;

			private string standardResolution;

			private string projectId;

			private int? concurrencyLimitNumber;

			private string highestCodeRate;

			private string projectName;

			private string highestResolution;

			public string StandardCodeRate
			{
				get
				{
					return standardCodeRate;
				}
				set	
				{
					standardCodeRate = value;
				}
			}

			public string HighDefinitionResolution
			{
				get
				{
					return highDefinitionResolution;
				}
				set	
				{
					highDefinitionResolution = value;
				}
			}

			public string HighDefinitionCodeRate
			{
				get
				{
					return highDefinitionCodeRate;
				}
				set	
				{
					highDefinitionCodeRate = value;
				}
			}

			public string StandardResolution
			{
				get
				{
					return standardResolution;
				}
				set	
				{
					standardResolution = value;
				}
			}

			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public int? ConcurrencyLimitNumber
			{
				get
				{
					return concurrencyLimitNumber;
				}
				set	
				{
					concurrencyLimitNumber = value;
				}
			}

			public string HighestCodeRate
			{
				get
				{
					return highestCodeRate;
				}
				set	
				{
					highestCodeRate = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public string HighestResolution
			{
				get
				{
					return highestResolution;
				}
				set	
				{
					highestResolution = value;
				}
			}
		}
	}
}
