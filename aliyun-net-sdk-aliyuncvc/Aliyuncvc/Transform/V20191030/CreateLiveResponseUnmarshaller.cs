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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class CreateLiveResponseUnmarshaller
    {
        public static CreateLiveResponse Unmarshall(UnmarshallerContext context)
        {
			CreateLiveResponse createLiveResponse = new CreateLiveResponse();

			createLiveResponse.HttpResponse = context.HttpResponse;
			createLiveResponse.ErrorCode = context.IntegerValue("CreateLive.ErrorCode");
			createLiveResponse.Message = context.StringValue("CreateLive.Message");
			createLiveResponse.Success = context.BooleanValue("CreateLive.Success");
			createLiveResponse.RequestId = context.StringValue("CreateLive.RequestId");

			CreateLiveResponse.CreateLive_LiveInfo liveInfo = new CreateLiveResponse.CreateLive_LiveInfo();
			liveInfo.LiveUUID = context.StringValue("CreateLive.LiveInfo.LiveUUID");
			liveInfo.StreamUUID = context.StringValue("CreateLive.LiveInfo.StreamUUID");
			createLiveResponse.LiveInfo = liveInfo;
        
			return createLiveResponse;
        }
    }
}
