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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class RunNotifyComponentWithWebhookResponseUnmarshaller
    {
        public static RunNotifyComponentWithWebhookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RunNotifyComponentWithWebhookResponse runNotifyComponentWithWebhookResponse = new RunNotifyComponentWithWebhookResponse();

			runNotifyComponentWithWebhookResponse.HttpResponse = _ctx.HttpResponse;
			runNotifyComponentWithWebhookResponse.RequestId = _ctx.StringValue("RunNotifyComponentWithWebhook.RequestId");
			runNotifyComponentWithWebhookResponse.Data = _ctx.StringValue("RunNotifyComponentWithWebhook.Data");

			RunNotifyComponentWithWebhookResponse.RunNotifyComponentWithWebhook_Page page = new RunNotifyComponentWithWebhookResponse.RunNotifyComponentWithWebhook_Page();
			page.TotalCount = _ctx.IntegerValue("RunNotifyComponentWithWebhook.Page.TotalCount");
			page.PageNumber = _ctx.IntegerValue("RunNotifyComponentWithWebhook.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("RunNotifyComponentWithWebhook.Page.PageSize");
			runNotifyComponentWithWebhookResponse.Page = page;
        
			return runNotifyComponentWithWebhookResponse;
        }
    }
}
