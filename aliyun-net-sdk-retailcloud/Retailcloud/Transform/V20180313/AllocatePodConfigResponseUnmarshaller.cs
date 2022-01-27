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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class AllocatePodConfigResponseUnmarshaller
    {
        public static AllocatePodConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AllocatePodConfigResponse allocatePodConfigResponse = new AllocatePodConfigResponse();

			allocatePodConfigResponse.HttpResponse = _ctx.HttpResponse;
			allocatePodConfigResponse.Code = _ctx.IntegerValue("AllocatePodConfig.Code");
			allocatePodConfigResponse.ErrMsg = _ctx.StringValue("AllocatePodConfig.ErrMsg");
			allocatePodConfigResponse.RequestId = _ctx.StringValue("AllocatePodConfig.RequestId");
			allocatePodConfigResponse.Success = _ctx.BooleanValue("AllocatePodConfig.Success");

			AllocatePodConfigResponse.AllocatePodConfig_Result result = new AllocatePodConfigResponse.AllocatePodConfig_Result();
			result.ConfigData = _ctx.StringValue("AllocatePodConfig.Result.ConfigData");
			allocatePodConfigResponse.Result = result;
        
			return allocatePodConfigResponse;
        }
    }
}
