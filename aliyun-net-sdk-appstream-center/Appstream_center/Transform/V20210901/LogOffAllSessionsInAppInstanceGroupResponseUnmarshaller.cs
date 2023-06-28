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
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class LogOffAllSessionsInAppInstanceGroupResponseUnmarshaller
    {
        public static LogOffAllSessionsInAppInstanceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			LogOffAllSessionsInAppInstanceGroupResponse logOffAllSessionsInAppInstanceGroupResponse = new LogOffAllSessionsInAppInstanceGroupResponse();

			logOffAllSessionsInAppInstanceGroupResponse.HttpResponse = _ctx.HttpResponse;
			logOffAllSessionsInAppInstanceGroupResponse.Code = _ctx.StringValue("LogOffAllSessionsInAppInstanceGroup.Code");
			logOffAllSessionsInAppInstanceGroupResponse.Message = _ctx.StringValue("LogOffAllSessionsInAppInstanceGroup.Message");
			logOffAllSessionsInAppInstanceGroupResponse.RequestId = _ctx.StringValue("LogOffAllSessionsInAppInstanceGroup.RequestId");
        
			return logOffAllSessionsInAppInstanceGroupResponse;
        }
    }
}
