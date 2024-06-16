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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveMessageAppResponseUnmarshaller
    {
        public static DescribeLiveMessageAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveMessageAppResponse describeLiveMessageAppResponse = new DescribeLiveMessageAppResponse();

			describeLiveMessageAppResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveMessageAppResponse.RequestId = _ctx.StringValue("DescribeLiveMessageApp.RequestId");
			describeLiveMessageAppResponse.AppId = _ctx.StringValue("DescribeLiveMessageApp.AppId");
			describeLiveMessageAppResponse.AppName = _ctx.StringValue("DescribeLiveMessageApp.AppName");
			describeLiveMessageAppResponse.AppKey = _ctx.StringValue("DescribeLiveMessageApp.AppKey");
			describeLiveMessageAppResponse.AppSign = _ctx.StringValue("DescribeLiveMessageApp.AppSign");
			describeLiveMessageAppResponse.AuditType = _ctx.IntegerValue("DescribeLiveMessageApp.AuditType");
			describeLiveMessageAppResponse.AuditUrl = _ctx.StringValue("DescribeLiveMessageApp.AuditUrl");
			describeLiveMessageAppResponse.EventCallbackUrl = _ctx.StringValue("DescribeLiveMessageApp.EventCallbackUrl");
			describeLiveMessageAppResponse.CallbackUrl = _ctx.StringValue("DescribeLiveMessageApp.CallbackUrl");
			describeLiveMessageAppResponse.Disable = _ctx.BooleanValue("DescribeLiveMessageApp.Disable");
			describeLiveMessageAppResponse.CreateTime = _ctx.LongValue("DescribeLiveMessageApp.CreateTime");
			describeLiveMessageAppResponse.ModifyTime = _ctx.LongValue("DescribeLiveMessageApp.ModifyTime");
			describeLiveMessageAppResponse.DataCenter = _ctx.StringValue("DescribeLiveMessageApp.DataCenter");
        
			return describeLiveMessageAppResponse;
        }
    }
}
