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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeRoomListResponse : AcsResponse
	{

		private string requestId;

		private int? totalNum;

		private int? totalPage;

		private List<DescribeRoomList_Room> roomList;

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

		public List<DescribeRoomList_Room> RoomList
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

		public class DescribeRoomList_Room
		{

			private string roomId;

			private string anchorId;

			private int? roomStatus;

			private string createTime;

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

			public int? RoomStatus
			{
				get
				{
					return roomStatus;
				}
				set	
				{
					roomStatus = value;
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
		}
	}
}