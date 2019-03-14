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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListClusterTagResponse : AcsResponse
	{

		private string requestId;

		private List<ListClusterTag_ClusterTag> clusterTagList;

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

		public List<ListClusterTag_ClusterTag> ClusterTagList
		{
			get
			{
				return clusterTagList;
			}
			set	
			{
				clusterTagList = value;
			}
		}

		public class ListClusterTag_ClusterTag
		{

			private string clusterId;

			private List<ListClusterTag_TagInfo> tagInfoList;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public List<ListClusterTag_TagInfo> TagInfoList
			{
				get
				{
					return tagInfoList;
				}
				set	
				{
					tagInfoList = value;
				}
			}

			public class ListClusterTag_TagInfo
			{

				private string tagType;

				private string tagValue;

				private string tagKey;

				public string TagType
				{
					get
					{
						return tagType;
					}
					set	
					{
						tagType = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}
			}
		}
	}
}
