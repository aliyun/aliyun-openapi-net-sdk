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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class CreateLiveResponseUnmarshaller
    {
        public static CreateLiveResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateLiveResponse createLiveResponse = new CreateLiveResponse();

			createLiveResponse.HttpResponse = _ctx.HttpResponse;
			createLiveResponse.Code = _ctx.StringValue("CreateLive.Code");
			createLiveResponse.Message = _ctx.StringValue("CreateLive.Message");
			createLiveResponse.RequestId = _ctx.StringValue("CreateLive.RequestId");

			CreateLiveResponse.CreateLive_Data data = new CreateLiveResponse.CreateLive_Data();
			data.Channel = _ctx.StringValue("CreateLive.Data.Channel");
			data.Id = _ctx.StringValue("CreateLive.Data.Id");
			data.Name = _ctx.StringValue("CreateLive.Data.Name");
			createLiveResponse.Data = data;
        
			return createLiveResponse;
        }
    }
}
