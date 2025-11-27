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

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class ListLabelTablesResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private List<ListLabelTables_LabelTable> labelTables;

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

		public List<ListLabelTables_LabelTable> LabelTables
		{
			get
			{
				return labelTables;
			}
			set	
			{
				labelTables = value;
			}
		}

		public class ListLabelTables_LabelTable
		{

			private string labelTableId;

			private string projectId;

			private string projectName;

			private string datasourceId;

			private string name;

			private string datasourceName;

			private string owner;

			private string gmtCreateTime;

			private string gmtModifiedTime;

			public string LabelTableId
			{
				get
				{
					return labelTableId;
				}
				set	
				{
					labelTableId = value;
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

			public string DatasourceId
			{
				get
				{
					return datasourceId;
				}
				set	
				{
					datasourceId = value;
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

			public string DatasourceName
			{
				get
				{
					return datasourceName;
				}
				set	
				{
					datasourceName = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string GmtCreateTime
			{
				get
				{
					return gmtCreateTime;
				}
				set	
				{
					gmtCreateTime = value;
				}
			}

			public string GmtModifiedTime
			{
				get
				{
					return gmtModifiedTime;
				}
				set	
				{
					gmtModifiedTime = value;
				}
			}
		}
	}
}
