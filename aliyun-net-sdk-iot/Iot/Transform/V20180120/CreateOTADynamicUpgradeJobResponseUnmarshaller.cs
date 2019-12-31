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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class CreateOTADynamicUpgradeJobResponseUnmarshaller
    {
        public static CreateOTADynamicUpgradeJobResponse Unmarshall(UnmarshallerContext context)
        {
			CreateOTADynamicUpgradeJobResponse createOTADynamicUpgradeJobResponse = new CreateOTADynamicUpgradeJobResponse();

			createOTADynamicUpgradeJobResponse.HttpResponse = context.HttpResponse;
			createOTADynamicUpgradeJobResponse.RequestId = context.StringValue("CreateOTADynamicUpgradeJob.RequestId");
			createOTADynamicUpgradeJobResponse.Success = context.BooleanValue("CreateOTADynamicUpgradeJob.Success");
			createOTADynamicUpgradeJobResponse.Code = context.StringValue("CreateOTADynamicUpgradeJob.Code");
			createOTADynamicUpgradeJobResponse.ErrorMessage = context.StringValue("CreateOTADynamicUpgradeJob.ErrorMessage");

			CreateOTADynamicUpgradeJobResponse.CreateOTADynamicUpgradeJob_Data data = new CreateOTADynamicUpgradeJobResponse.CreateOTADynamicUpgradeJob_Data();
			data.JobId = context.StringValue("CreateOTADynamicUpgradeJob.Data.JobId");
			data.UtcCreate = context.StringValue("CreateOTADynamicUpgradeJob.Data.UtcCreate");
			createOTADynamicUpgradeJobResponse.Data = data;
        
			return createOTADynamicUpgradeJobResponse;
        }
    }
}
