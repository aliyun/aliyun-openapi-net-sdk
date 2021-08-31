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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class DescribeAppInstanceListResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private List<DescribeAppInstanceList_Instance> instanceList;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public List<DescribeAppInstanceList_Instance> InstanceList
		{
			get
			{
				return instanceList;
			}
			set	
			{
				instanceList = value;
			}
		}

		public class DescribeAppInstanceList_Instance
		{

			private string appId;

			private string groupId;

			private string podRaw;

			private string groupName;

			private bool? canary;

			private string version;

			private string nodeName;

			private string nodeLabels;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string GroupId
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

			public string PodRaw
			{
				get
				{
					return podRaw;
				}
				set	
				{
					podRaw = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public bool? Canary
			{
				get
				{
					return canary;
				}
				set	
				{
					canary = value;
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

			public string NodeName
			{
				get
				{
					return nodeName;
				}
				set	
				{
					nodeName = value;
				}
			}

			public string NodeLabels
			{
				get
				{
					return nodeLabels;
				}
				set	
				{
					nodeLabels = value;
				}
			}
		}
	}
}
