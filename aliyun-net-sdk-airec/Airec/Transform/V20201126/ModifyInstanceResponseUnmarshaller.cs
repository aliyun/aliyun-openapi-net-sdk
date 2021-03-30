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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ModifyInstanceResponseUnmarshaller
    {
        public static ModifyInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyInstanceResponse modifyInstanceResponse = new ModifyInstanceResponse();

			modifyInstanceResponse.HttpResponse = _ctx.HttpResponse;
			modifyInstanceResponse.Code = _ctx.StringValue("ModifyInstance.code");
			modifyInstanceResponse.Message = _ctx.StringValue("ModifyInstance.message");
			modifyInstanceResponse.RequestId = _ctx.StringValue("ModifyInstance.requestId");

			ModifyInstanceResponse.ModifyInstance_Result result = new ModifyInstanceResponse.ModifyInstance_Result();
			result.ChargeType = _ctx.StringValue("ModifyInstance.Result.chargeType");
			result.CommodityCode = _ctx.StringValue("ModifyInstance.Result.commodityCode");
			result.DataSetVersion = _ctx.StringValue("ModifyInstance.Result.dataSetVersion");
			result.ExpiredTime = _ctx.StringValue("ModifyInstance.Result.expiredTime");
			result.GmtCreate = _ctx.StringValue("ModifyInstance.Result.gmtCreate");
			result.GmtModified = _ctx.StringValue("ModifyInstance.Result.gmtModified");
			result.Industry = _ctx.StringValue("ModifyInstance.Result.industry");
			result.InstanceId = _ctx.StringValue("ModifyInstance.Result.instanceId");
			result.LockMode = _ctx.StringValue("ModifyInstance.Result.lockMode");
			result.Name = _ctx.StringValue("ModifyInstance.Result.name");
			result.RegionId = _ctx.StringValue("ModifyInstance.Result.regionId");
			result.Status = _ctx.StringValue("ModifyInstance.Result.status");
			result.Type = _ctx.StringValue("ModifyInstance.Result.type");
			modifyInstanceResponse.Result = result;
        
			return modifyInstanceResponse;
        }
    }
}
