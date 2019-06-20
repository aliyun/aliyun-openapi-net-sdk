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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class ModifyInstanceResponseUnmarshaller
    {
        public static ModifyInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyInstanceResponse modifyInstanceResponse = new ModifyInstanceResponse();

			modifyInstanceResponse.HttpResponse = context.HttpResponse;
			modifyInstanceResponse.RequestId = context.StringValue("ModifyInstance.RequestId");
			modifyInstanceResponse.Code = context.StringValue("ModifyInstance.Code");
			modifyInstanceResponse.Message = context.StringValue("ModifyInstance.Message");

			ModifyInstanceResponse.ModifyInstance_Result result = new ModifyInstanceResponse.ModifyInstance_Result();
			result.InstanceId = context.StringValue("ModifyInstance.Result.InstanceId");
			result.ChargeType = context.StringValue("ModifyInstance.Result.ChargeType");
			result.RegionId = context.StringValue("ModifyInstance.Result.RegionId");
			result.Name = context.StringValue("ModifyInstance.Result.Name");
			result.Type = context.StringValue("ModifyInstance.Result.Type");
			result.ExpiredTime = context.StringValue("ModifyInstance.Result.ExpiredTime");
			result.GmtCreate = context.StringValue("ModifyInstance.Result.GmtCreate");
			result.GmtModified = context.StringValue("ModifyInstance.Result.GmtModified");
			result.Status = context.StringValue("ModifyInstance.Result.Status");
			result.Industry = context.StringValue("ModifyInstance.Result.Industry");
			result.Scene = context.StringValue("ModifyInstance.Result.Scene");
			result.DataSetVersion = context.StringValue("ModifyInstance.Result.DataSetVersion");
			result.CommodityCode = context.StringValue("ModifyInstance.Result.CommodityCode");
			result.LockMode = context.StringValue("ModifyInstance.Result.LockMode");
			modifyInstanceResponse.Result = result;
        
			return modifyInstanceResponse;
        }
    }
}
