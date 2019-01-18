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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class GroupFacesResponse : AcsResponse
	{

		private string requestId;

		private string setId;

		private int? hasMore;

		private List<GroupFaces_GroupsItem> groups;

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

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
			}
		}

		public int? HasMore
		{
			get
			{
				return hasMore;
			}
			set	
			{
				hasMore = value;
			}
		}

		public List<GroupFaces_GroupsItem> Groups
		{
			get
			{
				return groups;
			}
			set	
			{
				groups = value;
			}
		}

		public class GroupFaces_GroupsItem
		{

			private string faceId;

			private string groupId;

			private string unGroupReason;

			public string FaceId
			{
				get
				{
					return faceId;
				}
				set	
				{
					faceId = value;
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

			public string UnGroupReason
			{
				get
				{
					return unGroupReason;
				}
				set	
				{
					unGroupReason = value;
				}
			}
		}
	}
}