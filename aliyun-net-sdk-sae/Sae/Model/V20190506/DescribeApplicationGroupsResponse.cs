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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeApplicationGroupsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string traceId;

		private string requestId;

		private bool? success;

		private string errorCode;

		private List<DescribeApplicationGroups_ApplicationGroup> data;

		public string Code
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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public List<DescribeApplicationGroups_ApplicationGroup> Data
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

		public class DescribeApplicationGroups_ApplicationGroup
		{

			private string groupId;

			private string groupName;

			private int? groupType;

			private string packageType;

			private string packageVersion;

			private string imageUrl;

			private string packageUrl;

			private string jdk;

			private string webContainer;

			private string edasContainerVersion;

			private int? replicas;

			private int? runningInstances;

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

			public int? GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}

			public string PackageType
			{
				get
				{
					return packageType;
				}
				set	
				{
					packageType = value;
				}
			}

			public string PackageVersion
			{
				get
				{
					return packageVersion;
				}
				set	
				{
					packageVersion = value;
				}
			}

			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
				}
			}

			public string PackageUrl
			{
				get
				{
					return packageUrl;
				}
				set	
				{
					packageUrl = value;
				}
			}

			public string Jdk
			{
				get
				{
					return jdk;
				}
				set	
				{
					jdk = value;
				}
			}

			public string WebContainer
			{
				get
				{
					return webContainer;
				}
				set	
				{
					webContainer = value;
				}
			}

			public string EdasContainerVersion
			{
				get
				{
					return edasContainerVersion;
				}
				set	
				{
					edasContainerVersion = value;
				}
			}

			public int? Replicas
			{
				get
				{
					return replicas;
				}
				set	
				{
					replicas = value;
				}
			}

			public int? RunningInstances
			{
				get
				{
					return runningInstances;
				}
				set	
				{
					runningInstances = value;
				}
			}
		}
	}
}
