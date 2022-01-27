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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class CreateRemindResponseUnmarshaller
    {
        public static CreateRemindResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateRemindResponse createRemindResponse = new CreateRemindResponse();

			createRemindResponse.HttpResponse = _ctx.HttpResponse;
			createRemindResponse.Success = _ctx.BooleanValue("CreateRemind.Success");
			createRemindResponse.ErrorCode = _ctx.StringValue("CreateRemind.ErrorCode");
			createRemindResponse.ErrorMessage = _ctx.StringValue("CreateRemind.ErrorMessage");
			createRemindResponse.HttpStatusCode = _ctx.IntegerValue("CreateRemind.HttpStatusCode");
			createRemindResponse.RequestId = _ctx.StringValue("CreateRemind.RequestId");
			createRemindResponse.Data = _ctx.LongValue("CreateRemind.Data");
        
			return createRemindResponse;
        }
    }
}
