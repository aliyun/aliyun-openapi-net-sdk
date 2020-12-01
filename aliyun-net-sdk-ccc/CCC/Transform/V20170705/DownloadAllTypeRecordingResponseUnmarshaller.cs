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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class DownloadAllTypeRecordingResponseUnmarshaller
    {
        public static DownloadAllTypeRecordingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DownloadAllTypeRecordingResponse downloadAllTypeRecordingResponse = new DownloadAllTypeRecordingResponse();

			downloadAllTypeRecordingResponse.HttpResponse = _ctx.HttpResponse;
			downloadAllTypeRecordingResponse.RequestId = _ctx.StringValue("DownloadAllTypeRecording.RequestId");
			downloadAllTypeRecordingResponse.Success = _ctx.BooleanValue("DownloadAllTypeRecording.Success");
			downloadAllTypeRecordingResponse.Code = _ctx.StringValue("DownloadAllTypeRecording.Code");
			downloadAllTypeRecordingResponse.Message = _ctx.StringValue("DownloadAllTypeRecording.Message");
			downloadAllTypeRecordingResponse.HttpStatusCode = _ctx.IntegerValue("DownloadAllTypeRecording.HttpStatusCode");

			List<DownloadAllTypeRecordingResponse.DownloadAllTypeRecording_MediaDownloadParam> downloadAllTypeRecordingResponse_mediaDownloadParamList = new List<DownloadAllTypeRecordingResponse.DownloadAllTypeRecording_MediaDownloadParam>();
			for (int i = 0; i < _ctx.Length("DownloadAllTypeRecording.MediaDownloadParamList.Length"); i++) {
				DownloadAllTypeRecordingResponse.DownloadAllTypeRecording_MediaDownloadParam mediaDownloadParam = new DownloadAllTypeRecordingResponse.DownloadAllTypeRecording_MediaDownloadParam();
				mediaDownloadParam.SignatureUrl = _ctx.StringValue("DownloadAllTypeRecording.MediaDownloadParamList["+ i +"].SignatureUrl");
				mediaDownloadParam.FileName = _ctx.StringValue("DownloadAllTypeRecording.MediaDownloadParamList["+ i +"].FileName");

				downloadAllTypeRecordingResponse_mediaDownloadParamList.Add(mediaDownloadParam);
			}
			downloadAllTypeRecordingResponse.MediaDownloadParamList = downloadAllTypeRecordingResponse_mediaDownloadParamList;
        
			return downloadAllTypeRecordingResponse;
        }
    }
}
