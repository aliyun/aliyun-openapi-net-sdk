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
    public class JoinBoardResponseUnmarshaller
    {
        public static JoinBoardResponse Unmarshall(UnmarshallerContext _ctx)
        {
			JoinBoardResponse joinBoardResponse = new JoinBoardResponse();

			joinBoardResponse.HttpResponse = _ctx.HttpResponse;
			joinBoardResponse.RequestId = _ctx.StringValue("JoinBoard.RequestId");
			joinBoardResponse.Token = _ctx.StringValue("JoinBoard.Token");
			joinBoardResponse.BoardId = _ctx.StringValue("JoinBoard.BoardId");
			joinBoardResponse.TopicId = _ctx.StringValue("JoinBoard.TopicId");
			joinBoardResponse.KeepaliveTopic = _ctx.StringValue("JoinBoard.KeepaliveTopic");
			joinBoardResponse.KeepaliveInterval = _ctx.IntegerValue("JoinBoard.KeepaliveInterval");
        
			return joinBoardResponse;
        }
    }
}
