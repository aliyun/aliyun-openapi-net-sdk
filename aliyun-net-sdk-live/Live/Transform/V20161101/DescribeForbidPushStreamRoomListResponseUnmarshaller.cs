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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeForbidPushStreamRoomListResponseUnmarshaller
    {
        public static DescribeForbidPushStreamRoomListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeForbidPushStreamRoomListResponse describeForbidPushStreamRoomListResponse = new DescribeForbidPushStreamRoomListResponse();

			describeForbidPushStreamRoomListResponse.HttpResponse = context.HttpResponse;
			describeForbidPushStreamRoomListResponse.RequestId = context.StringValue("DescribeForbidPushStreamRoomList.RequestId");
			describeForbidPushStreamRoomListResponse.TotalNum = context.IntegerValue("DescribeForbidPushStreamRoomList.TotalNum");
			describeForbidPushStreamRoomListResponse.TotalPage = context.IntegerValue("DescribeForbidPushStreamRoomList.TotalPage");

			List<DescribeForbidPushStreamRoomListResponse.DescribeForbidPushStreamRoomList_Room> describeForbidPushStreamRoomListResponse_roomList = new List<DescribeForbidPushStreamRoomListResponse.DescribeForbidPushStreamRoomList_Room>();
			for (int i = 0; i < context.Length("DescribeForbidPushStreamRoomList.RoomList.Length"); i++) {
				DescribeForbidPushStreamRoomListResponse.DescribeForbidPushStreamRoomList_Room room = new DescribeForbidPushStreamRoomListResponse.DescribeForbidPushStreamRoomList_Room();
				room.RoomId = context.StringValue("DescribeForbidPushStreamRoomList.RoomList["+ i +"].RoomId");
				room.AnchorId = context.StringValue("DescribeForbidPushStreamRoomList.RoomList["+ i +"].AnchorId");
				room.OpStartTime = context.StringValue("DescribeForbidPushStreamRoomList.RoomList["+ i +"].OpStartTime");
				room.OpEndTime = context.StringValue("DescribeForbidPushStreamRoomList.RoomList["+ i +"].OpEndTime");

				describeForbidPushStreamRoomListResponse_roomList.Add(room);
			}
			describeForbidPushStreamRoomListResponse.RoomList = describeForbidPushStreamRoomListResponse_roomList;
        
			return describeForbidPushStreamRoomListResponse;
        }
    }
}