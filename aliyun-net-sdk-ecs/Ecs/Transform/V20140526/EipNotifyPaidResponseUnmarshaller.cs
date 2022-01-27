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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class EipNotifyPaidResponseUnmarshaller
    {
        public static EipNotifyPaidResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EipNotifyPaidResponse eipNotifyPaidResponse = new EipNotifyPaidResponse();

			eipNotifyPaidResponse.HttpResponse = _ctx.HttpResponse;
			eipNotifyPaidResponse.Code = _ctx.StringValue("EipNotifyPaid.code");
			eipNotifyPaidResponse.Success = _ctx.BooleanValue("EipNotifyPaid.success");
			eipNotifyPaidResponse.Message = _ctx.StringValue("EipNotifyPaid.message");
			eipNotifyPaidResponse.Data = _ctx.StringValue("EipNotifyPaid.data");
			eipNotifyPaidResponse.RequestId = _ctx.StringValue("EipNotifyPaid.requestId");
        
			return eipNotifyPaidResponse;
        }
    }
}
