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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class PickLocalNumberResponseUnmarshaller
    {
        public static PickLocalNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PickLocalNumberResponse pickLocalNumberResponse = new PickLocalNumberResponse();

			pickLocalNumberResponse.HttpResponse = _ctx.HttpResponse;
			pickLocalNumberResponse.RequestId = _ctx.StringValue("PickLocalNumber.RequestId");
			pickLocalNumberResponse.Success = _ctx.BooleanValue("PickLocalNumber.Success");
			pickLocalNumberResponse.Code = _ctx.StringValue("PickLocalNumber.Code");
			pickLocalNumberResponse.Message = _ctx.StringValue("PickLocalNumber.Message");

			PickLocalNumberResponse.PickLocalNumber_Data data = new PickLocalNumberResponse.PickLocalNumber_Data();

			PickLocalNumberResponse.PickLocalNumber_Data.PickLocalNumber_Callee callee = new PickLocalNumberResponse.PickLocalNumber_Data.PickLocalNumber_Callee();
			callee.Number = _ctx.StringValue("PickLocalNumber.Data.Callee.Number");
			callee.Province = _ctx.StringValue("PickLocalNumber.Data.Callee.Province");
			callee.City = _ctx.StringValue("PickLocalNumber.Data.Callee.City");
			data.Callee = callee;

			PickLocalNumberResponse.PickLocalNumber_Data.PickLocalNumber_Caller caller = new PickLocalNumberResponse.PickLocalNumber_Data.PickLocalNumber_Caller();
			caller.Number = _ctx.StringValue("PickLocalNumber.Data.Caller.Number");
			caller.Province = _ctx.StringValue("PickLocalNumber.Data.Caller.Province");
			caller.City = _ctx.StringValue("PickLocalNumber.Data.Caller.City");
			data.Caller = caller;
			pickLocalNumberResponse.Data = data;
        
			return pickLocalNumberResponse;
        }
    }
}
