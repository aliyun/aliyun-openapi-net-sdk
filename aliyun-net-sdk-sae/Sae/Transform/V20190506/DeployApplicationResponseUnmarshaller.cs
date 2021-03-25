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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DeployApplicationResponseUnmarshaller
    {
        public static DeployApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeployApplicationResponse deployApplicationResponse = new DeployApplicationResponse();

			deployApplicationResponse.HttpResponse = _ctx.HttpResponse;
			deployApplicationResponse.Message = _ctx.StringValue("DeployApplication.Message");
			deployApplicationResponse.RequestId = _ctx.StringValue("DeployApplication.RequestId");
			deployApplicationResponse.TraceId = _ctx.StringValue("DeployApplication.TraceId");
			deployApplicationResponse.ErrorCode = _ctx.StringValue("DeployApplication.ErrorCode");
			deployApplicationResponse.Code = _ctx.StringValue("DeployApplication.Code");
			deployApplicationResponse.Success = _ctx.BooleanValue("DeployApplication.Success");

			DeployApplicationResponse.DeployApplication_Data data = new DeployApplicationResponse.DeployApplication_Data();
			data.AppId = _ctx.StringValue("DeployApplication.Data.AppId");
			data.ChangeOrderId = _ctx.StringValue("DeployApplication.Data.ChangeOrderId");
			deployApplicationResponse.Data = data;
        
			return deployApplicationResponse;
        }
    }
}
