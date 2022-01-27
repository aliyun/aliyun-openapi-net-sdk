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
using Aliyun.Acs.Dyvmsapi.Model.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Transform.V20170525
{
    public class ClickToDialResponseUnmarshaller
    {
        public static ClickToDialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ClickToDialResponse clickToDialResponse = new ClickToDialResponse();

			clickToDialResponse.HttpResponse = _ctx.HttpResponse;
			clickToDialResponse.RequestId = _ctx.StringValue("ClickToDial.RequestId");
			clickToDialResponse.CallId = _ctx.StringValue("ClickToDial.CallId");
			clickToDialResponse.Code = _ctx.StringValue("ClickToDial.Code");
			clickToDialResponse.Message = _ctx.StringValue("ClickToDial.Message");
        
			return clickToDialResponse;
        }
    }
}
