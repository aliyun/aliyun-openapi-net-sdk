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

namespace Aliyun.Acs.EHPC.Model.V20170714
{
	public class ListPreferredEcsTypesResponse : AcsResponse
	{

		private string requestId;

		private List<ListPreferredEcsTypes_SeriesInfo> series;

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

		public List<ListPreferredEcsTypes_SeriesInfo> Series
		{
			get
			{
				return series;
			}
			set	
			{
				series = value;
			}
		}

		public class ListPreferredEcsTypes_SeriesInfo
		{

			private string seriesId;

			private string seriesName;

			private ListPreferredEcsTypes_Roles roles;

			public string SeriesId
			{
				get
				{
					return seriesId;
				}
				set	
				{
					seriesId = value;
				}
			}

			public string SeriesName
			{
				get
				{
					return seriesName;
				}
				set	
				{
					seriesName = value;
				}
			}

			public ListPreferredEcsTypes_Roles Roles
			{
				get
				{
					return roles;
				}
				set	
				{
					roles = value;
				}
			}

			public class ListPreferredEcsTypes_Roles
			{

				private List<string> manager;

				private List<string> compute;

				private List<string> login;

				public List<string> Manager
				{
					get
					{
						return manager;
					}
					set	
					{
						manager = value;
					}
				}

				public List<string> Compute
				{
					get
					{
						return compute;
					}
					set	
					{
						compute = value;
					}
				}

				public List<string> Login
				{
					get
					{
						return login;
					}
					set	
					{
						login = value;
					}
				}
			}
		}
	}
}