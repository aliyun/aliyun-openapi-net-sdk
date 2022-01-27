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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class CreateAppGroupResponseUnmarshaller
    {
        public static CreateAppGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAppGroupResponse createAppGroupResponse = new CreateAppGroupResponse();

			createAppGroupResponse.HttpResponse = _ctx.HttpResponse;
			createAppGroupResponse.Code = _ctx.IntegerValue("CreateAppGroup.Code");
			createAppGroupResponse.RequestId = _ctx.StringValue("CreateAppGroup.RequestId");
			createAppGroupResponse.ErrMsg = _ctx.StringValue("CreateAppGroup.ErrMsg");

			CreateAppGroupResponse.CreateAppGroup_Result result = new CreateAppGroupResponse.CreateAppGroup_Result();
			result.AppGroupId = _ctx.LongValue("CreateAppGroup.Result.AppGroupId");
			createAppGroupResponse.Result = result;
        
			return createAppGroupResponse;
        }
    }
}
