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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class GetMultiChannelRecordingResponseUnmarshaller
    {
        public static GetMultiChannelRecordingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMultiChannelRecordingResponse getMultiChannelRecordingResponse = new GetMultiChannelRecordingResponse();

			getMultiChannelRecordingResponse.HttpResponse = _ctx.HttpResponse;
			getMultiChannelRecordingResponse.Code = _ctx.StringValue("GetMultiChannelRecording.Code");
			getMultiChannelRecordingResponse.HttpStatusCode = _ctx.IntegerValue("GetMultiChannelRecording.HttpStatusCode");
			getMultiChannelRecordingResponse.Message = _ctx.StringValue("GetMultiChannelRecording.Message");
			getMultiChannelRecordingResponse.RequestId = _ctx.StringValue("GetMultiChannelRecording.RequestId");

			GetMultiChannelRecordingResponse.GetMultiChannelRecording_Data data = new GetMultiChannelRecordingResponse.GetMultiChannelRecording_Data();
			data.FileName = _ctx.StringValue("GetMultiChannelRecording.Data.FileName");
			data.FileUrl = _ctx.StringValue("GetMultiChannelRecording.Data.FileUrl");
			getMultiChannelRecordingResponse.Data = data;
        
			return getMultiChannelRecordingResponse;
        }
    }
}
