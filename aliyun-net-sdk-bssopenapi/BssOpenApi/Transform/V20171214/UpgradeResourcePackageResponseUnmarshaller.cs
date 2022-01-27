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
    public class UpgradeResourcePackageResponseUnmarshaller
    {
        public static UpgradeResourcePackageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpgradeResourcePackageResponse upgradeResourcePackageResponse = new UpgradeResourcePackageResponse();

			upgradeResourcePackageResponse.HttpResponse = _ctx.HttpResponse;
			upgradeResourcePackageResponse.RequestId = _ctx.StringValue("UpgradeResourcePackage.RequestId");
			upgradeResourcePackageResponse.OrderId = _ctx.LongValue("UpgradeResourcePackage.OrderId");
			upgradeResourcePackageResponse.Success = _ctx.BooleanValue("UpgradeResourcePackage.Success");
			upgradeResourcePackageResponse.Code = _ctx.StringValue("UpgradeResourcePackage.Code");
			upgradeResourcePackageResponse.Message = _ctx.StringValue("UpgradeResourcePackage.Message");

			UpgradeResourcePackageResponse.UpgradeResourcePackage_Data data = new UpgradeResourcePackageResponse.UpgradeResourcePackage_Data();
			data.OrderId = _ctx.LongValue("UpgradeResourcePackage.Data.OrderId");
			data.InstanceId = _ctx.StringValue("UpgradeResourcePackage.Data.InstanceId");
			upgradeResourcePackageResponse.Data = data;
        
			return upgradeResourcePackageResponse;
        }
    }
}
