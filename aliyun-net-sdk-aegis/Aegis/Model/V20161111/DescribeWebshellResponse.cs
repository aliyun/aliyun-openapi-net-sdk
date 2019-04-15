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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeWebshellResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeWebshell_WebshellListItem> webshellList;

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

		public List<DescribeWebshell_WebshellListItem> WebshellList
		{
			get
			{
				return webshellList;
			}
			set	
			{
				webshellList = value;
			}
		}

		public class DescribeWebshell_WebshellListItem
		{

			private string os;

			private string instanceName;

			private long? groupId;

			private string ip;

			private string uuid;

			private string foundTime;

			private string instanceId;

			private string trojanType;

			private string firstFoundTime;

			private long? trojanSize;

			private string domain;

			private string trojanPath;

			private string region;

			private int? status;

			public string Os
			{
				get
				{
					return os;
				}
				set	
				{
					os = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public long? GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string FoundTime
			{
				get
				{
					return foundTime;
				}
				set	
				{
					foundTime = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string TrojanType
			{
				get
				{
					return trojanType;
				}
				set	
				{
					trojanType = value;
				}
			}

			public string FirstFoundTime
			{
				get
				{
					return firstFoundTime;
				}
				set	
				{
					firstFoundTime = value;
				}
			}

			public long? TrojanSize
			{
				get
				{
					return trojanSize;
				}
				set	
				{
					trojanSize = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string TrojanPath
			{
				get
				{
					return trojanPath;
				}
				set	
				{
					trojanPath = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
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
		}
	}
}
