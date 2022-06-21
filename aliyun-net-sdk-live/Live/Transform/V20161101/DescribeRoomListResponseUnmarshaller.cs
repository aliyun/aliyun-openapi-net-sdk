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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeRoomListResponseUnmarshaller
    {
        public static DescribeRoomListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRoomListResponse describeRoomListResponse = new DescribeRoomListResponse();

			describeRoomListResponse.HttpResponse = _ctx.HttpResponse;
			describeRoomListResponse.RequestId = _ctx.StringValue("DescribeRoomList.RequestId");
			describeRoomListResponse.TotalNum = _ctx.IntegerValue("DescribeRoomList.TotalNum");
			describeRoomListResponse.TotalPage = _ctx.IntegerValue("DescribeRoomList.TotalPage");

			List<DescribeRoomListResponse.DescribeRoomList_Room> describeRoomListResponse_roomList = new List<DescribeRoomListResponse.DescribeRoomList_Room>();
			for (int i = 0; i < _ctx.Length("DescribeRoomList.RoomList.Length"); i++) {
				DescribeRoomListResponse.DescribeRoomList_Room room = new DescribeRoomListResponse.DescribeRoomList_Room();
				room.RoomId = _ctx.StringValue("DescribeRoomList.RoomList["+ i +"].RoomId");
				room.AnchorId = _ctx.StringValue("DescribeRoomList.RoomList["+ i +"].AnchorId");
				room.RoomStatus = _ctx.IntegerValue("DescribeRoomList.RoomList["+ i +"].RoomStatus");
				room.ForbidStream = _ctx.StringValue("DescribeRoomList.RoomList["+ i +"].ForbidStream");
				room.CreateTime = _ctx.StringValue("DescribeRoomList.RoomList["+ i +"].CreateTime");

				describeRoomListResponse_roomList.Add(room);
			}
			describeRoomListResponse.RoomList = describeRoomListResponse_roomList;
        
			return describeRoomListResponse;
        }
    }
}
