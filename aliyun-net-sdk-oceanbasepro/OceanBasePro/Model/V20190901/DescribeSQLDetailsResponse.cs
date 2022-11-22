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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeSQLDetailsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSQLDetails_Data> sQLDetails;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "SQLDetails")]
		public List<DescribeSQLDetails_Data> SQLDetails
		{
			get
			{
				return sQLDetails;
			}
			set	
			{
				sQLDetails = value;
			}
		}

		public class DescribeSQLDetails_Data
		{

			private string sQLText;

			private string dbName;

			private string userName;

			[JsonProperty(PropertyName = "SQLText")]
			public string SQLText
			{
				get
				{
					return sQLText;
				}
				set	
				{
					sQLText = value;
				}
			}

			[JsonProperty(PropertyName = "DbName")]
			public string DbName
			{
				get
				{
					return dbName;
				}
				set	
				{
					dbName = value;
				}
			}

			[JsonProperty(PropertyName = "UserName")]
			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}
		}
	}
}
