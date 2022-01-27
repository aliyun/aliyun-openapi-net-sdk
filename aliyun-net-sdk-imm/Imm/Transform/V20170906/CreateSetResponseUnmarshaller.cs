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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class CreateSetResponseUnmarshaller
    {
        public static CreateSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSetResponse createSetResponse = new CreateSetResponse();

			createSetResponse.HttpResponse = _ctx.HttpResponse;
			createSetResponse.RequestId = _ctx.StringValue("CreateSet.RequestId");
			createSetResponse.SetId = _ctx.StringValue("CreateSet.SetId");
			createSetResponse.SetName = _ctx.StringValue("CreateSet.SetName");
			createSetResponse.CreateTime = _ctx.StringValue("CreateSet.CreateTime");
			createSetResponse.ModifyTime = _ctx.StringValue("CreateSet.ModifyTime");
			createSetResponse.FaceCount = _ctx.IntegerValue("CreateSet.FaceCount");
			createSetResponse.ImageCount = _ctx.IntegerValue("CreateSet.ImageCount");
			createSetResponse.VideoCount = _ctx.IntegerValue("CreateSet.VideoCount");
			createSetResponse.VideoLength = _ctx.IntegerValue("CreateSet.VideoLength");
        
			return createSetResponse;
        }
    }
}
