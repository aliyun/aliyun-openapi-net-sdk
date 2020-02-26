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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class UpgradeEngineVersionResponseUnmarshaller
    {
        public static UpgradeEngineVersionResponse Unmarshall(UnmarshallerContext context)
        {
			UpgradeEngineVersionResponse upgradeEngineVersionResponse = new UpgradeEngineVersionResponse();

			upgradeEngineVersionResponse.HttpResponse = context.HttpResponse;
			upgradeEngineVersionResponse.RequestId = context.StringValue("UpgradeEngineVersion.RequestId");

			UpgradeEngineVersionResponse.UpgradeEngineVersion_Result result = new UpgradeEngineVersionResponse.UpgradeEngineVersion_Result();
			result.ValidateType = context.StringValue("UpgradeEngineVersion.Result.validateType");
			result.Status = context.StringValue("UpgradeEngineVersion.Result.status");

			UpgradeEngineVersionResponse.UpgradeEngineVersion_Result.UpgradeEngineVersion_ValidateResult validateResult = new UpgradeEngineVersionResponse.UpgradeEngineVersion_Result.UpgradeEngineVersion_ValidateResult();
			validateResult.ErrorType = context.StringValue("UpgradeEngineVersion.Result.ValidateResult.errorType");
			validateResult.ErrorCode = context.StringValue("UpgradeEngineVersion.Result.ValidateResult.errorCode");
			validateResult.ErrorMsg = context.StringValue("UpgradeEngineVersion.Result.ValidateResult.errorMsg");
			result.ValidateResult = validateResult;
			upgradeEngineVersionResponse.Result = result;
        
			return upgradeEngineVersionResponse;
        }
    }
}
