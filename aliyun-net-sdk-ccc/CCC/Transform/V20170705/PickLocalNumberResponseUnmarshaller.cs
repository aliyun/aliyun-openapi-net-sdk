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
        public static PickLocalNumberResponse Unmarshall(UnmarshallerContext context)
        {
			PickLocalNumberResponse pickLocalNumberResponse = new PickLocalNumberResponse();

			pickLocalNumberResponse.HttpResponse = context.HttpResponse;
			pickLocalNumberResponse.RequestId = context.StringValue("PickLocalNumber.RequestId");
			pickLocalNumberResponse.Success = context.BooleanValue("PickLocalNumber.Success");
			pickLocalNumberResponse.Code = context.StringValue("PickLocalNumber.Code");
			pickLocalNumberResponse.Message = context.StringValue("PickLocalNumber.Message");

			PickLocalNumberResponse.PickLocalNumber_Data data = new PickLocalNumberResponse.PickLocalNumber_Data();

			PickLocalNumberResponse.PickLocalNumber_Data.PickLocalNumber_Callee callee = new PickLocalNumberResponse.PickLocalNumber_Data.PickLocalNumber_Callee();
			callee.Number = context.StringValue("PickLocalNumber.Data.Callee.Number");
			callee.Province = context.StringValue("PickLocalNumber.Data.Callee.Province");
			callee.City = context.StringValue("PickLocalNumber.Data.Callee.City");
			data.Callee = callee;

			PickLocalNumberResponse.PickLocalNumber_Data.PickLocalNumber_Caller caller = new PickLocalNumberResponse.PickLocalNumber_Data.PickLocalNumber_Caller();
			caller.Number = context.StringValue("PickLocalNumber.Data.Caller.Number");
			caller.Province = context.StringValue("PickLocalNumber.Data.Caller.Province");
			caller.City = context.StringValue("PickLocalNumber.Data.Caller.City");
			data.Caller = caller;
			pickLocalNumberResponse.Data = data;
        
			return pickLocalNumberResponse;
        }
    }
}
