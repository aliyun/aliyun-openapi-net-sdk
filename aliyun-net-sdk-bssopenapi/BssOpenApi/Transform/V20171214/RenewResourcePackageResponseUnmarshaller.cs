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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class RenewResourcePackageResponseUnmarshaller
    {
        public static RenewResourcePackageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RenewResourcePackageResponse renewResourcePackageResponse = new RenewResourcePackageResponse();

			renewResourcePackageResponse.HttpResponse = _ctx.HttpResponse;
			renewResourcePackageResponse.RequestId = _ctx.StringValue("RenewResourcePackage.RequestId");
			renewResourcePackageResponse.OrderId = _ctx.LongValue("RenewResourcePackage.OrderId");
			renewResourcePackageResponse.Success = _ctx.BooleanValue("RenewResourcePackage.Success");
			renewResourcePackageResponse.Code = _ctx.StringValue("RenewResourcePackage.Code");
			renewResourcePackageResponse.Message = _ctx.StringValue("RenewResourcePackage.Message");

			RenewResourcePackageResponse.RenewResourcePackage_Data data = new RenewResourcePackageResponse.RenewResourcePackage_Data();
			data.OrderId = _ctx.LongValue("RenewResourcePackage.Data.OrderId");
			data.InstanceId = _ctx.StringValue("RenewResourcePackage.Data.InstanceId");
			renewResourcePackageResponse.Data = data;
        
			return renewResourcePackageResponse;
        }
    }
}
