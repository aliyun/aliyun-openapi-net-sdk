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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListSoftwaresResponse : AcsResponse
	{

		private string requestId;

		private List<ListSoftwares_SoftwareInfo> softwares;

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

		public List<ListSoftwares_SoftwareInfo> Softwares
		{
			get
			{
				return softwares;
			}
			set	
			{
				softwares = value;
			}
		}

		public class ListSoftwares_SoftwareInfo
		{

			private string ehpcVersion;

			private string osTag;

			private string schedulerType;

			private string schedulerVersion;

			private string accountType;

			private string accountVersion;

			private List<ListSoftwares_ApplicationInfo> applications;

			public string EhpcVersion
			{
				get
				{
					return ehpcVersion;
				}
				set	
				{
					ehpcVersion = value;
				}
			}

			public string OsTag
			{
				get
				{
					return osTag;
				}
				set	
				{
					osTag = value;
				}
			}

			public string SchedulerType
			{
				get
				{
					return schedulerType;
				}
				set	
				{
					schedulerType = value;
				}
			}

			public string SchedulerVersion
			{
				get
				{
					return schedulerVersion;
				}
				set	
				{
					schedulerVersion = value;
				}
			}

			public string AccountType
			{
				get
				{
					return accountType;
				}
				set	
				{
					accountType = value;
				}
			}

			public string AccountVersion
			{
				get
				{
					return accountVersion;
				}
				set	
				{
					accountVersion = value;
				}
			}

			public List<ListSoftwares_ApplicationInfo> Applications
			{
				get
				{
					return applications;
				}
				set	
				{
					applications = value;
				}
			}

			public class ListSoftwares_ApplicationInfo
			{

				private string tag;

				private string name;

				private string version;

				private bool? required;

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
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

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public bool? Required
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
			}
		}
	}
}