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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class ReplaceInstanceResponseUnmarshaller
    {
        public static ReplaceInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReplaceInstanceResponse replaceInstanceResponse = new ReplaceInstanceResponse();

			replaceInstanceResponse.HttpResponse = _ctx.HttpResponse;
			replaceInstanceResponse.Code = _ctx.StringValue("ReplaceInstance.Code");
			replaceInstanceResponse.DynamicMessage = _ctx.StringValue("ReplaceInstance.DynamicMessage");
			replaceInstanceResponse.ErrCode = _ctx.StringValue("ReplaceInstance.ErrCode");
			replaceInstanceResponse.ErrMessage = _ctx.StringValue("ReplaceInstance.ErrMessage");
			replaceInstanceResponse.HttpStatusCode = _ctx.IntegerValue("ReplaceInstance.HttpStatusCode");
			replaceInstanceResponse.RequestId = _ctx.StringValue("ReplaceInstance.RequestId");
			replaceInstanceResponse.Success = _ctx.BooleanValue("ReplaceInstance.Success");
			replaceInstanceResponse.DtsJobId = _ctx.StringValue("ReplaceInstance.DtsJobId");
			replaceInstanceResponse.InstanceId = _ctx.StringValue("ReplaceInstance.InstanceId");
			replaceInstanceResponse.ChargeType = _ctx.StringValue("ReplaceInstance.ChargeType");
			replaceInstanceResponse.EndTime = _ctx.StringValue("ReplaceInstance.EndTime");
        
			return replaceInstanceResponse;
        }
    }
}
