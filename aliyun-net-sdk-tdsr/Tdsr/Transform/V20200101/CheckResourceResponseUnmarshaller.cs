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
using Aliyun.Acs.tdsr.Model.V20200101;

namespace Aliyun.Acs.tdsr.Transform.V20200101
{
    public class CheckResourceResponseUnmarshaller
    {
        public static CheckResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckResourceResponse checkResourceResponse = new CheckResourceResponse();

			checkResourceResponse.HttpResponse = _ctx.HttpResponse;
			checkResourceResponse.Interrupt = _ctx.BooleanValue("CheckResource.Interrupt");
			checkResourceResponse.Invoker = _ctx.StringValue("CheckResource.Invoker");
			checkResourceResponse.Pk = _ctx.StringValue("CheckResource.Pk");
			checkResourceResponse.Bid = _ctx.StringValue("CheckResource.Bid");
			checkResourceResponse.Hid = _ctx.LongValue("CheckResource.Hid");
			checkResourceResponse.Country = _ctx.StringValue("CheckResource.Country");
			checkResourceResponse.TaskIdentifier = _ctx.StringValue("CheckResource.TaskIdentifier");
			checkResourceResponse.TaskExtraData = _ctx.StringValue("CheckResource.TaskExtraData");
			checkResourceResponse.GmtWakeup = _ctx.StringValue("CheckResource.GmtWakeup");
			checkResourceResponse.Success = _ctx.BooleanValue("CheckResource.Success");
			checkResourceResponse.Message = _ctx.StringValue("CheckResource.Message");
			checkResourceResponse.Level = _ctx.LongValue("CheckResource.Level");
			checkResourceResponse.Url = _ctx.StringValue("CheckResource.Url");
			checkResourceResponse.Prompt = _ctx.StringValue("CheckResource.Prompt");
			checkResourceResponse.RequestId = _ctx.StringValue("CheckResource.RequestId");
        
			return checkResourceResponse;
        }
    }
}
