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
    public class GetSpeechDeviceDetailResponseUnmarshaller
    {
        public static GetSpeechDeviceDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSpeechDeviceDetailResponse getSpeechDeviceDetailResponse = new GetSpeechDeviceDetailResponse();

			getSpeechDeviceDetailResponse.HttpResponse = _ctx.HttpResponse;
			getSpeechDeviceDetailResponse.RequestId = _ctx.StringValue("GetSpeechDeviceDetail.RequestId");
			getSpeechDeviceDetailResponse.Success = _ctx.BooleanValue("GetSpeechDeviceDetail.Success");
			getSpeechDeviceDetailResponse.Code = _ctx.StringValue("GetSpeechDeviceDetail.Code");
			getSpeechDeviceDetailResponse.ErrorMessage = _ctx.StringValue("GetSpeechDeviceDetail.ErrorMessage");

			GetSpeechDeviceDetailResponse.GetSpeechDeviceDetail_Data data = new GetSpeechDeviceDetailResponse.GetSpeechDeviceDetail_Data();
			data.ProductKey = _ctx.StringValue("GetSpeechDeviceDetail.Data.ProductKey");
			data.DeviceName = _ctx.StringValue("GetSpeechDeviceDetail.Data.DeviceName");
			data.IotId = _ctx.StringValue("GetSpeechDeviceDetail.Data.IotId");
			data.Status = _ctx.StringValue("GetSpeechDeviceDetail.Data.Status");
			data.AvailableSpace = _ctx.FloatValue("GetSpeechDeviceDetail.Data.AvailableSpace");
			data.TotalSpace = _ctx.FloatValue("GetSpeechDeviceDetail.Data.TotalSpace");
			data.SpeechListUpdateTime = _ctx.LongValue("GetSpeechDeviceDetail.Data.SpeechListUpdateTime");
			getSpeechDeviceDetailResponse.Data = data;
        
			return getSpeechDeviceDetailResponse;
        }
    }
}
