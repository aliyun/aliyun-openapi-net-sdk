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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class CheckRawPlanJsonResponseUnmarshaller
    {
        public static CheckRawPlanJsonResponse Unmarshall(UnmarshallerContext context)
        {
			CheckRawPlanJsonResponse checkRawPlanJsonResponse = new CheckRawPlanJsonResponse();

			checkRawPlanJsonResponse.HttpResponse = context.HttpResponse;
			checkRawPlanJsonResponse.RequestId = context.StringValue("CheckRawPlanJson.RequestId");

			CheckRawPlanJsonResponse.CheckRawPlanJson_PlanJsonInfo planJsonInfo = new CheckRawPlanJsonResponse.CheckRawPlanJson_PlanJsonInfo();
			planJsonInfo.Status = context.StringValue("CheckRawPlanJson.PlanJsonInfo.Status");
			planJsonInfo.PlanJson = context.StringValue("CheckRawPlanJson.PlanJsonInfo.PlanJson");
			planJsonInfo.ErrorMessage = context.StringValue("CheckRawPlanJson.PlanJsonInfo.ErrorMessage");
			checkRawPlanJsonResponse.PlanJsonInfo = planJsonInfo;
        
			return checkRawPlanJsonResponse;
        }
    }
}
