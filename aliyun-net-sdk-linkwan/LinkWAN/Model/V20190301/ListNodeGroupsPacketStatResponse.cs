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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class ListNodeGroupsPacketStatResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<ListNodeGroupsPacketStat_NodeGroupPacketStat> data;

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

		public List<ListNodeGroupsPacketStat_NodeGroupPacketStat> Data
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

		public class ListNodeGroupsPacketStat_NodeGroupPacketStat
		{

			private string nodeGroupId;

			private int? uplinkCount;

			private int? downlinkCount;

			public string NodeGroupId
			{
				get
				{
					return nodeGroupId;
				}
				set	
				{
					nodeGroupId = value;
				}
			}

			public int? UplinkCount
			{
				get
				{
					return uplinkCount;
				}
				set	
				{
					uplinkCount = value;
				}
			}

			public int? DownlinkCount
			{
				get
				{
					return downlinkCount;
				}
				set	
				{
					downlinkCount = value;
				}
			}
		}
	}
}
