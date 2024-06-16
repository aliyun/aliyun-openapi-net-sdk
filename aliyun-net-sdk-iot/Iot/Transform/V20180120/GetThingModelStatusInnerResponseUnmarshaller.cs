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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GetThingModelStatusInnerResponseUnmarshaller
    {
        public static GetThingModelStatusInnerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetThingModelStatusInnerResponse getThingModelStatusInnerResponse = new GetThingModelStatusInnerResponse();

			getThingModelStatusInnerResponse.HttpResponse = _ctx.HttpResponse;
			getThingModelStatusInnerResponse.RequestId = _ctx.StringValue("GetThingModelStatusInner.RequestId");
			getThingModelStatusInnerResponse.Message = _ctx.StringValue("GetThingModelStatusInner.Message");
			getThingModelStatusInnerResponse.Code = _ctx.IntegerValue("GetThingModelStatusInner.Code");
			getThingModelStatusInnerResponse.LocalizedMsg = _ctx.StringValue("GetThingModelStatusInner.LocalizedMsg");

			GetThingModelStatusInnerResponse.GetThingModelStatusInner_Data data = new GetThingModelStatusInnerResponse.GetThingModelStatusInner_Data();
			data.ModifiedTime = _ctx.LongValue("GetThingModelStatusInner.Data.ModifiedTime");
			data.ProductKey = _ctx.StringValue("GetThingModelStatusInner.Data.ProductKey");
			data.InstanceId = _ctx.StringValue("GetThingModelStatusInner.Data.InstanceId");
			data.RbacTenantId = _ctx.StringValue("GetThingModelStatusInner.Data.RbacTenantId");
			data.Status = _ctx.IntegerValue("GetThingModelStatusInner.Data.Status");
			data.Info = _ctx.StringValue("GetThingModelStatusInner.Data.Info");
			data.OutTime = _ctx.LongValue("GetThingModelStatusInner.Data.OutTime");
			getThingModelStatusInnerResponse.Data = data;
        
			return getThingModelStatusInnerResponse;
        }
    }
}
