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

namespace Aliyun.Acs.ResourceSharing.Model.V20200110
{
	public class ListSharedTargetsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private List<ListSharedTargets_SharedTarget> sharedTargets;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public List<ListSharedTargets_SharedTarget> SharedTargets
		{
			get
			{
				return sharedTargets;
			}
			set	
			{
				sharedTargets = value;
			}
		}

		public class ListSharedTargets_SharedTarget
		{

			private string targetId;

			private string updateTime;

			private string createTime;

			private string resourceShareId;

			private bool? external;

			private string targetProperty;

			public string TargetId
			{
				get
				{
					return targetId;
				}
				set	
				{
					targetId = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ResourceShareId
			{
				get
				{
					return resourceShareId;
				}
				set	
				{
					resourceShareId = value;
				}
			}

			public bool? External
			{
				get
				{
					return external;
				}
				set	
				{
					external = value;
				}
			}

			public string TargetProperty
			{
				get
				{
					return targetProperty;
				}
				set	
				{
					targetProperty = value;
				}
			}
		}
	}
}
