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
        public static UpgradeEngineVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpgradeEngineVersionResponse upgradeEngineVersionResponse = new UpgradeEngineVersionResponse();

			upgradeEngineVersionResponse.HttpResponse = _ctx.HttpResponse;
			upgradeEngineVersionResponse.RequestId = _ctx.StringValue("UpgradeEngineVersion.RequestId");

			List<UpgradeEngineVersionResponse.UpgradeEngineVersion_ResultItem> upgradeEngineVersionResponse_result = new List<UpgradeEngineVersionResponse.UpgradeEngineVersion_ResultItem>();
			for (int i = 0; i < _ctx.Length("UpgradeEngineVersion.Result.Length"); i++) {
				UpgradeEngineVersionResponse.UpgradeEngineVersion_ResultItem resultItem = new UpgradeEngineVersionResponse.UpgradeEngineVersion_ResultItem();
				resultItem.ValidateType = _ctx.StringValue("UpgradeEngineVersion.Result["+ i +"].validateType");
				resultItem.Status = _ctx.StringValue("UpgradeEngineVersion.Result["+ i +"].status");

				List<UpgradeEngineVersionResponse.UpgradeEngineVersion_ResultItem.UpgradeEngineVersion_ValidateResultItem> resultItem_validateResult = new List<UpgradeEngineVersionResponse.UpgradeEngineVersion_ResultItem.UpgradeEngineVersion_ValidateResultItem>();
				for (int j = 0; j < _ctx.Length("UpgradeEngineVersion.Result["+ i +"].ValidateResult.Length"); j++) {
					UpgradeEngineVersionResponse.UpgradeEngineVersion_ResultItem.UpgradeEngineVersion_ValidateResultItem validateResultItem = new UpgradeEngineVersionResponse.UpgradeEngineVersion_ResultItem.UpgradeEngineVersion_ValidateResultItem();
					validateResultItem.ErrorType = _ctx.StringValue("UpgradeEngineVersion.Result["+ i +"].ValidateResult["+ j +"].errorType");
					validateResultItem.ErrorCode = _ctx.StringValue("UpgradeEngineVersion.Result["+ i +"].ValidateResult["+ j +"].errorCode");
					validateResultItem.ErrorMsg = _ctx.StringValue("UpgradeEngineVersion.Result["+ i +"].ValidateResult["+ j +"].errorMsg");

					resultItem_validateResult.Add(validateResultItem);
				}
				resultItem.ValidateResult = resultItem_validateResult;

				upgradeEngineVersionResponse_result.Add(resultItem);
			}
			upgradeEngineVersionResponse.Result = upgradeEngineVersionResponse_result;
        
			return upgradeEngineVersionResponse;
        }
    }
}
