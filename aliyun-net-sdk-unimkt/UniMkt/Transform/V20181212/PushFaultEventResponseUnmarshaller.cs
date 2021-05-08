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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class PushFaultEventResponseUnmarshaller
    {
        public static PushFaultEventResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PushFaultEventResponse pushFaultEventResponse = new PushFaultEventResponse();

			pushFaultEventResponse.HttpResponse = _ctx.HttpResponse;
			pushFaultEventResponse.Status = _ctx.BooleanValue("PushFaultEvent.Status");
			pushFaultEventResponse.Msg = _ctx.StringValue("PushFaultEvent.Msg");
			pushFaultEventResponse.Data = _ctx.StringValue("PushFaultEvent.Data");
			pushFaultEventResponse.ErrorCode = _ctx.StringValue("PushFaultEvent.ErrorCode");
			pushFaultEventResponse.RequestId = _ctx.StringValue("PushFaultEvent.RequestId");
        
			return pushFaultEventResponse;
        }
    }
}
