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
using Aliyun.Acs.mseap.Model.V20210118;

namespace Aliyun.Acs.mseap.Transform.V20210118
{
    public class PullRpaModelResponseUnmarshaller
    {
        public static PullRpaModelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PullRpaModelResponse pullRpaModelResponse = new PullRpaModelResponse();

			pullRpaModelResponse.HttpResponse = _ctx.HttpResponse;
			pullRpaModelResponse.AllowRetry = _ctx.BooleanValue("PullRpaModel.AllowRetry");
			pullRpaModelResponse.RequestId = _ctx.StringValue("PullRpaModel.RequestId");
			pullRpaModelResponse.ErrorMsg = _ctx.StringValue("PullRpaModel.ErrorMsg");
			pullRpaModelResponse.HttpStatusCode = _ctx.IntegerValue("PullRpaModel.HttpStatusCode");
			pullRpaModelResponse.DynamicCode = _ctx.StringValue("PullRpaModel.DynamicCode");
			pullRpaModelResponse.ErrorCode = _ctx.StringValue("PullRpaModel.ErrorCode");
			pullRpaModelResponse.DynamicMessage = _ctx.StringValue("PullRpaModel.DynamicMessage");
			pullRpaModelResponse.Module = _ctx.StringValue("PullRpaModel.Module");
			pullRpaModelResponse.Success = _ctx.BooleanValue("PullRpaModel.Success");
			pullRpaModelResponse.AppName = _ctx.StringValue("PullRpaModel.AppName");
        
			return pullRpaModelResponse;
        }
    }
}
