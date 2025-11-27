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
    public class RunNotifyComponentWithMessageCenterResponseUnmarshaller
    {
        public static RunNotifyComponentWithMessageCenterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RunNotifyComponentWithMessageCenterResponse runNotifyComponentWithMessageCenterResponse = new RunNotifyComponentWithMessageCenterResponse();

			runNotifyComponentWithMessageCenterResponse.HttpResponse = _ctx.HttpResponse;
			runNotifyComponentWithMessageCenterResponse.RequestId = _ctx.StringValue("RunNotifyComponentWithMessageCenter.RequestId");
			runNotifyComponentWithMessageCenterResponse.Data = _ctx.StringValue("RunNotifyComponentWithMessageCenter.Data");

			RunNotifyComponentWithMessageCenterResponse.RunNotifyComponentWithMessageCenter_Page page = new RunNotifyComponentWithMessageCenterResponse.RunNotifyComponentWithMessageCenter_Page();
			page.TotalCount = _ctx.IntegerValue("RunNotifyComponentWithMessageCenter.Page.TotalCount");
			page.PageNumber = _ctx.IntegerValue("RunNotifyComponentWithMessageCenter.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("RunNotifyComponentWithMessageCenter.Page.PageSize");
			runNotifyComponentWithMessageCenterResponse.Page = page;
        
			return runNotifyComponentWithMessageCenterResponse;
        }
    }
}
