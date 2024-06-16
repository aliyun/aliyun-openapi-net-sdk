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
	public class DescribeDataSourceInstanceResponse : AcsResponse
	{

		private string requestId;

		private DescribeDataSourceInstance_Data data;

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

		public DescribeDataSourceInstance_Data Data
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

		public class DescribeDataSourceInstance_Data
		{

			private string dataSourceInstanceId;

			private string accountId;

			private string cloudCode;

			private List<DescribeDataSourceInstance_DataSourceInstanceParam> dataSourceInstanceParams;

			public string DataSourceInstanceId
			{
				get
				{
					return dataSourceInstanceId;
				}
				set	
				{
					dataSourceInstanceId = value;
				}
			}

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
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

			public List<DescribeDataSourceInstance_DataSourceInstanceParam> DataSourceInstanceParams
			{
				get
				{
					return dataSourceInstanceParams;
				}
				set	
				{
					dataSourceInstanceParams = value;
				}
			}

			public class DescribeDataSourceInstance_DataSourceInstanceParam
			{

				private string paraCode;

				private string paraValue;

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

				public string ParaValue
				{
					get
					{
						return paraValue;
					}
					set	
					{
						paraValue = value;
					}
				}
			}
		}
	}
}
