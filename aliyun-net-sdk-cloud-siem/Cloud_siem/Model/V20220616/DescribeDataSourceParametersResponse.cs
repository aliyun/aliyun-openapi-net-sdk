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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeDataSourceParametersResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDataSourceParameters_DataItem> data;

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

		public List<DescribeDataSourceParameters_DataItem> Data
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

		public class DescribeDataSourceParameters_DataItem
		{

			private string dataSourceType;

			private int? paraLevel;

			private string paraCode;

			private string paraName;

			private string paraType;

			private int? required;

			private string formatCheck;

			private string title;

			private string hit;

			private string defaultValue;

			private bool? disabled;

			private int? canEditted;

			private string cloudCode;

			private List<DescribeDataSourceParameters_ParamValueItem> paramValue;

			public string DataSourceType
			{
				get
				{
					return dataSourceType;
				}
				set	
				{
					dataSourceType = value;
				}
			}

			public int? ParaLevel
			{
				get
				{
					return paraLevel;
				}
				set	
				{
					paraLevel = value;
				}
			}

			public string ParaCode
			{
				get
				{
					return paraCode;
				}
				set	
				{
					paraCode = value;
				}
			}

			public string ParaName
			{
				get
				{
					return paraName;
				}
				set	
				{
					paraName = value;
				}
			}

			public string ParaType
			{
				get
				{
					return paraType;
				}
				set	
				{
					paraType = value;
				}
			}

			public int? Required
			{
				get
				{
					return required;
				}
				set	
				{
					required = value;
				}
			}

			public string FormatCheck
			{
				get
				{
					return formatCheck;
				}
				set	
				{
					formatCheck = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string Hit
			{
				get
				{
					return hit;
				}
				set	
				{
					hit = value;
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

			public bool? Disabled
			{
				get
				{
					return disabled;
				}
				set	
				{
					disabled = value;
				}
			}

			public int? CanEditted
			{
				get
				{
					return canEditted;
				}
				set	
				{
					canEditted = value;
				}
			}

			public string CloudCode
			{
				get
				{
					return cloudCode;
				}
				set	
				{
					cloudCode = value;
				}
			}

			public List<DescribeDataSourceParameters_ParamValueItem> ParamValue
			{
				get
				{
					return paramValue;
				}
				set	
				{
					paramValue = value;
				}
			}

			public class DescribeDataSourceParameters_ParamValueItem
			{

				private string label;

				private string _value;

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
