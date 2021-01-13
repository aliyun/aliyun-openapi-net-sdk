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
    public class DescribeBoardsResponseUnmarshaller
    {
        public static DescribeBoardsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBoardsResponse describeBoardsResponse = new DescribeBoardsResponse();

			describeBoardsResponse.HttpResponse = _ctx.HttpResponse;
			describeBoardsResponse.RequestId = _ctx.StringValue("DescribeBoards.RequestId");

			List<DescribeBoardsResponse.DescribeBoards__Event> describeBoardsResponse_boards = new List<DescribeBoardsResponse.DescribeBoards__Event>();
			for (int i = 0; i < _ctx.Length("DescribeBoards.Boards.Length"); i++) {
				DescribeBoardsResponse.DescribeBoards__Event _event = new DescribeBoardsResponse.DescribeBoards__Event();
				_event.BoardId = _ctx.StringValue("DescribeBoards.Boards["+ i +"].BoardId");
				_event.Topic = _ctx.StringValue("DescribeBoards.Boards["+ i +"].Topic");
				_event.State = _ctx.IntegerValue("DescribeBoards.Boards["+ i +"].State");
				_event.UserId = _ctx.StringValue("DescribeBoards.Boards["+ i +"].UserId");

				describeBoardsResponse_boards.Add(_event);
			}
			describeBoardsResponse.Boards = describeBoardsResponse_boards;
        
			return describeBoardsResponse;
        }
    }
}
