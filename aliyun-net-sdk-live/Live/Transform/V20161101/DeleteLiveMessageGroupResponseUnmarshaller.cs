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
    public class DeleteLiveMessageGroupResponseUnmarshaller
    {
        public static DeleteLiveMessageGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteLiveMessageGroupResponse deleteLiveMessageGroupResponse = new DeleteLiveMessageGroupResponse();

			deleteLiveMessageGroupResponse.HttpResponse = _ctx.HttpResponse;
			deleteLiveMessageGroupResponse.RequestId = _ctx.StringValue("DeleteLiveMessageGroup.RequestId");
			deleteLiveMessageGroupResponse.GroupId = _ctx.StringValue("DeleteLiveMessageGroup.GroupId");
        
			return deleteLiveMessageGroupResponse;
        }
    }
}
