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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class CheckResourceResponse : AcsResponse
	{

		private string specifyCount;

		private List<Resource> resources;

		public string SpecifyCount
		{
			get
			{
				return specifyCount;
			}
			set	
			{
				specifyCount = value;
			}
		}

		public List<Resource> Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
			}
		}

		public class Resource{

			private string dBInstanceAvailable;

			private string engine;

			private string engineVersion;

			public string DBInstanceAvailable
			{
				get
				{
					return dBInstanceAvailable;
				}
				set	
				{
					dBInstanceAvailable = value;
				}
			}

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}
		}
	}
}