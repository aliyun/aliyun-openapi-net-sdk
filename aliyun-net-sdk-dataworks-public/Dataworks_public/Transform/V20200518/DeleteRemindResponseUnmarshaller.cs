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
    public class DeleteRemindResponseUnmarshaller
    {
        public static DeleteRemindResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRemindResponse deleteRemindResponse = new DeleteRemindResponse();

			deleteRemindResponse.HttpResponse = _ctx.HttpResponse;
			deleteRemindResponse.Success = _ctx.BooleanValue("DeleteRemind.Success");
			deleteRemindResponse.ErrorCode = _ctx.StringValue("DeleteRemind.ErrorCode");
			deleteRemindResponse.ErrorMessage = _ctx.StringValue("DeleteRemind.ErrorMessage");
			deleteRemindResponse.HttpStatusCode = _ctx.IntegerValue("DeleteRemind.HttpStatusCode");
			deleteRemindResponse.RequestId = _ctx.StringValue("DeleteRemind.RequestId");
			deleteRemindResponse.Data = _ctx.BooleanValue("DeleteRemind.Data");
        
			return deleteRemindResponse;
        }
    }
}
