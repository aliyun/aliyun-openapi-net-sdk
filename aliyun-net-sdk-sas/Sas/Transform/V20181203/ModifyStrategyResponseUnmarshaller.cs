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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class ModifyStrategyResponseUnmarshaller
    {
        public static ModifyStrategyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyStrategyResponse modifyStrategyResponse = new ModifyStrategyResponse();

			modifyStrategyResponse.HttpResponse = _ctx.HttpResponse;
			modifyStrategyResponse.HttpStatusCode = _ctx.IntegerValue("ModifyStrategy.HttpStatusCode");
			modifyStrategyResponse.RequestId = _ctx.StringValue("ModifyStrategy.RequestId");
			modifyStrategyResponse.TotalCount = _ctx.IntegerValue("ModifyStrategy.TotalCount");
			modifyStrategyResponse.Success = _ctx.BooleanValue("ModifyStrategy.Success");

			ModifyStrategyResponse.ModifyStrategy_Result result = new ModifyStrategyResponse.ModifyStrategy_Result();
			result.StrategyId = _ctx.IntegerValue("ModifyStrategy.Result.StrategyId");
			modifyStrategyResponse.Result = result;
        
			return modifyStrategyResponse;
        }
    }
}
