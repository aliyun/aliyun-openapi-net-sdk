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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeForbidPushStreamRoomListResponse : AcsResponse
	{

		private int? totalPage;

		private string requestId;

		private int? totalNum;

		private List<DescribeForbidPushStreamRoomList_Room> roomList;

		[JsonProperty(PropertyName = "TotalPage")]
		public int? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "TotalNum")]
		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		[JsonProperty(PropertyName = "RoomList")]
		public List<DescribeForbidPushStreamRoomList_Room> RoomList
		{
			get
			{
				return roomList;
			}
			set	
			{
				roomList = value;
			}
		}

		public class DescribeForbidPushStreamRoomList_Room
		{

			private string opEndTime;

			private string anchorId;

			private string opStartTime;

			private string roomId;

			[JsonProperty(PropertyName = "OpEndTime")]
			public string OpEndTime
			{
				get
				{
					return opEndTime;
				}
				set	
				{
					opEndTime = value;
				}
			}

			[JsonProperty(PropertyName = "AnchorId")]
			public string AnchorId
			{
				get
				{
					return anchorId;
				}
				set	
				{
					anchorId = value;
				}
			}

			[JsonProperty(PropertyName = "OpStartTime")]
			public string OpStartTime
			{
				get
				{
					return opStartTime;
				}
				set	
				{
					opStartTime = value;
				}
			}

			[JsonProperty(PropertyName = "RoomId")]
			public string RoomId
			{
				get
				{
					return roomId;
				}
				set	
				{
					roomId = value;
				}
			}
		}
	}
}
