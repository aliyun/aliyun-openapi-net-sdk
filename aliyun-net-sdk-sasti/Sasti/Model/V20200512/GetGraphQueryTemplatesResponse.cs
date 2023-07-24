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

namespace Aliyun.Acs.Sasti.Model.V20200512
{
	public class GetGraphQueryTemplatesResponse : AcsResponse
	{

		private string requestId;

		private List<GetGraphQueryTemplates_DataItem> data;

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

		public List<GetGraphQueryTemplates_DataItem> Data
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

		public class GetGraphQueryTemplates_DataItem
		{

			private long? id;

			private string gmtCreate;

			private string gmtModified;

			private string scenario;

			private string gremlinTemplate;

			private string lastModifier;

			private int? status;

			private string scenarioDesc;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Scenario
			{
				get
				{
					return scenario;
				}
				set	
				{
					scenario = value;
				}
			}

			public string GremlinTemplate
			{
				get
				{
					return gremlinTemplate;
				}
				set	
				{
					gremlinTemplate = value;
				}
			}

			public string LastModifier
			{
				get
				{
					return lastModifier;
				}
				set	
				{
					lastModifier = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string ScenarioDesc
			{
				get
				{
					return scenarioDesc;
				}
				set	
				{
					scenarioDesc = value;
				}
			}
		}
	}
}
