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
    public class PrintByTemplateResponseUnmarshaller
    {
        public static PrintByTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PrintByTemplateResponse printByTemplateResponse = new PrintByTemplateResponse();

			printByTemplateResponse.HttpResponse = _ctx.HttpResponse;
			printByTemplateResponse.RequestId = _ctx.StringValue("PrintByTemplate.RequestId");
			printByTemplateResponse.Success = _ctx.BooleanValue("PrintByTemplate.Success");
			printByTemplateResponse.Code = _ctx.StringValue("PrintByTemplate.Code");
			printByTemplateResponse.ErrorMessage = _ctx.StringValue("PrintByTemplate.ErrorMessage");

			PrintByTemplateResponse.PrintByTemplate_Data data = new PrintByTemplateResponse.PrintByTemplate_Data();
			data.Success = _ctx.BooleanValue("PrintByTemplate.Data.Success");
			data.DeviceErrorCode = _ctx.StringValue("PrintByTemplate.Data.DeviceErrorCode");
			data.DeviceErrorMessage = _ctx.StringValue("PrintByTemplate.Data.DeviceErrorMessage");
			data.Id = _ctx.StringValue("PrintByTemplate.Data.Id");
			data.RetryCount = _ctx.IntegerValue("PrintByTemplate.Data.RetryCount");
			data.MaxRetryCount = _ctx.IntegerValue("PrintByTemplate.Data.MaxRetryCount");
			printByTemplateResponse.Data = data;
        
			return printByTemplateResponse;
        }
    }
}
