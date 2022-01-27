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
    public class UpdateAppResponseUnmarshaller
    {
        public static UpdateAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateAppResponse updateAppResponse = new UpdateAppResponse();

			updateAppResponse.HttpResponse = _ctx.HttpResponse;
			updateAppResponse.RequestId = _ctx.StringValue("UpdateApp.RequestId");
			updateAppResponse.Code = _ctx.IntegerValue("UpdateApp.Code");
			updateAppResponse.ErrMsg = _ctx.StringValue("UpdateApp.ErrMsg");

			UpdateAppResponse.UpdateApp_Result result = new UpdateAppResponse.UpdateApp_Result();
			result.Success = _ctx.BooleanValue("UpdateApp.Result.Success");
			updateAppResponse.Result = result;
        
			return updateAppResponse;
        }
    }
}
