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
    public class CreateOTAStaticUpgradeJobResponseUnmarshaller
    {
        public static CreateOTAStaticUpgradeJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateOTAStaticUpgradeJobResponse createOTAStaticUpgradeJobResponse = new CreateOTAStaticUpgradeJobResponse();

			createOTAStaticUpgradeJobResponse.HttpResponse = _ctx.HttpResponse;
			createOTAStaticUpgradeJobResponse.RequestId = _ctx.StringValue("CreateOTAStaticUpgradeJob.RequestId");
			createOTAStaticUpgradeJobResponse.Success = _ctx.BooleanValue("CreateOTAStaticUpgradeJob.Success");
			createOTAStaticUpgradeJobResponse.Code = _ctx.StringValue("CreateOTAStaticUpgradeJob.Code");
			createOTAStaticUpgradeJobResponse.ErrorMessage = _ctx.StringValue("CreateOTAStaticUpgradeJob.ErrorMessage");

			CreateOTAStaticUpgradeJobResponse.CreateOTAStaticUpgradeJob_Data data = new CreateOTAStaticUpgradeJobResponse.CreateOTAStaticUpgradeJob_Data();
			data.JobId = _ctx.StringValue("CreateOTAStaticUpgradeJob.Data.JobId");
			data.UtcCreate = _ctx.StringValue("CreateOTAStaticUpgradeJob.Data.UtcCreate");
			createOTAStaticUpgradeJobResponse.Data = data;
        
			return createOTAStaticUpgradeJobResponse;
        }
    }
}
