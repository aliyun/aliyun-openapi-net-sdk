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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class UpdateLocalitySettingResponseUnmarshaller
    {
        public static UpdateLocalitySettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateLocalitySettingResponse updateLocalitySettingResponse = new UpdateLocalitySettingResponse();

			updateLocalitySettingResponse.HttpResponse = _ctx.HttpResponse;
			updateLocalitySettingResponse.Code = _ctx.IntegerValue("UpdateLocalitySetting.Code");
			updateLocalitySettingResponse.HttpStatusCode = _ctx.IntegerValue("UpdateLocalitySetting.HttpStatusCode");
			updateLocalitySettingResponse.Message = _ctx.StringValue("UpdateLocalitySetting.Message");
			updateLocalitySettingResponse.RequestId = _ctx.StringValue("UpdateLocalitySetting.RequestId");
			updateLocalitySettingResponse.Success = _ctx.BooleanValue("UpdateLocalitySetting.Success");

			UpdateLocalitySettingResponse.UpdateLocalitySetting_Data data = new UpdateLocalitySettingResponse.UpdateLocalitySetting_Data();
			data.Enabled = _ctx.BooleanValue("UpdateLocalitySetting.Data.Enabled");
			data.Threshold = _ctx.FloatValue("UpdateLocalitySetting.Data.Threshold");
			updateLocalitySettingResponse.Data = data;
        
			return updateLocalitySettingResponse;
        }
    }
}
