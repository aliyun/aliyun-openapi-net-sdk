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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class ListInstanceServiceConfigurationsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageRecordCount;

		private long? totalRecordCount;

		private List<ListInstanceServiceConfigurations_Config> configureList;

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

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public long? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public List<ListInstanceServiceConfigurations_Config> ConfigureList
		{
			get
			{
				return configureList;
			}
			set	
			{
				configureList = value;
			}
		}

		public class ListInstanceServiceConfigurations_Config
		{

			private string configureName;

			private string defaultValue;

			private string runningValue;

			private string configureUnit;

			private string valueRange;

			private string needRestart;

			private string description;

			public string ConfigureName
			{
				get
				{
					return configureName;
				}
				set	
				{
					configureName = value;
				}
			}

			public string DefaultValue
			{
				get
				{
					return defaultValue;
				}
				set	
				{
					defaultValue = value;
				}
			}

			public string RunningValue
			{
				get
				{
					return runningValue;
				}
				set	
				{
					runningValue = value;
				}
			}

			public string ConfigureUnit
			{
				get
				{
					return configureUnit;
				}
				set	
				{
					configureUnit = value;
				}
			}

			public string ValueRange
			{
				get
				{
					return valueRange;
				}
				set	
				{
					valueRange = value;
				}
			}

			public string NeedRestart
			{
				get
				{
					return needRestart;
				}
				set	
				{
					needRestart = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}
	}
}
