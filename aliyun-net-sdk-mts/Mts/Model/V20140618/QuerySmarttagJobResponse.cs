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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QuerySmarttagJobResponse : AcsResponse
	{

		private string jobStatus;

		private string requestId;

		private string userData;

		private List<QuerySmarttagJob_Result> results;

		public string JobStatus
		{
			get
			{
				return jobStatus;
			}
			set	
			{
				jobStatus = value;
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

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
			}
		}

		public List<QuerySmarttagJob_Result> Results
		{
			get
			{
				return results;
			}
			set	
			{
				results = value;
			}
		}

		public class QuerySmarttagJob_Result
		{

			private string type;

			private string data;

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

			public string Data
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
		}
	}
}
