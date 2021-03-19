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
using Aliyun.Acs.Ons.Model.V20190214;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OpenOnsServiceResponseUnmarshaller
    {
        public static OpenOnsServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OpenOnsServiceResponse openOnsServiceResponse = new OpenOnsServiceResponse();

			openOnsServiceResponse.HttpResponse = _ctx.HttpResponse;
			openOnsServiceResponse.RequestId = _ctx.StringValue("OpenOnsService.RequestId");
			openOnsServiceResponse.OrderId = _ctx.StringValue("OpenOnsService.OrderId");
        
			return openOnsServiceResponse;
        }
    }
}
