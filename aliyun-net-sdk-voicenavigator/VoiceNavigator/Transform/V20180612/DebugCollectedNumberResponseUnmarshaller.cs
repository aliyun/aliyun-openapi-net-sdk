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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class DebugCollectedNumberResponseUnmarshaller
    {
        public static DebugCollectedNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DebugCollectedNumberResponse debugCollectedNumberResponse = new DebugCollectedNumberResponse();

			debugCollectedNumberResponse.HttpResponse = _ctx.HttpResponse;
			debugCollectedNumberResponse.RequestId = _ctx.StringValue("DebugCollectedNumber.RequestId");
			debugCollectedNumberResponse.TextResponse = _ctx.StringValue("DebugCollectedNumber.TextResponse");
			debugCollectedNumberResponse.Interruptible = _ctx.BooleanValue("DebugCollectedNumber.Interruptible");
			debugCollectedNumberResponse.Action = _ctx.StringValue("DebugCollectedNumber.Action");
			debugCollectedNumberResponse.ActionParams = _ctx.StringValue("DebugCollectedNumber.ActionParams");
        
			return debugCollectedNumberResponse;
        }
    }
}
