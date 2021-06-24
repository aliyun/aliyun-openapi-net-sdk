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
    public class ConfigureSubscriptionResponseUnmarshaller
    {
        public static ConfigureSubscriptionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ConfigureSubscriptionResponse configureSubscriptionResponse = new ConfigureSubscriptionResponse();

			configureSubscriptionResponse.HttpResponse = _ctx.HttpResponse;
			configureSubscriptionResponse.ErrCode = _ctx.StringValue("ConfigureSubscription.ErrCode");
			configureSubscriptionResponse.ErrMessage = _ctx.StringValue("ConfigureSubscription.ErrMessage");
			configureSubscriptionResponse.RequestId = _ctx.StringValue("ConfigureSubscription.RequestId");
			configureSubscriptionResponse.Success = _ctx.StringValue("ConfigureSubscription.Success");
			configureSubscriptionResponse.DtsJobId = _ctx.StringValue("ConfigureSubscription.DtsJobId");
			configureSubscriptionResponse.DtsInstanceId = _ctx.StringValue("ConfigureSubscription.DtsInstanceId");
			configureSubscriptionResponse.HttpStatusCode = _ctx.StringValue("ConfigureSubscription.HttpStatusCode");
        
			return configureSubscriptionResponse;
        }
    }
}
