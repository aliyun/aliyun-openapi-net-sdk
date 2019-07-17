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
    public class DownloadCabRecordingResponseUnmarshaller
    {
        public static DownloadCabRecordingResponse Unmarshall(UnmarshallerContext context)
        {
			DownloadCabRecordingResponse downloadCabRecordingResponse = new DownloadCabRecordingResponse();

			downloadCabRecordingResponse.HttpResponse = context.HttpResponse;
			downloadCabRecordingResponse.RequestId = context.StringValue("DownloadCabRecording.RequestId");
			downloadCabRecordingResponse.Success = context.BooleanValue("DownloadCabRecording.Success");
			downloadCabRecordingResponse.Code = context.StringValue("DownloadCabRecording.Code");
			downloadCabRecordingResponse.Message = context.StringValue("DownloadCabRecording.Message");
			downloadCabRecordingResponse.HttpStatusCode = context.IntegerValue("DownloadCabRecording.HttpStatusCode");

			DownloadCabRecordingResponse.DownloadCabRecording_MediaDownloadParam mediaDownloadParam = new DownloadCabRecordingResponse.DownloadCabRecording_MediaDownloadParam();
			mediaDownloadParam.SignatureUrl = context.StringValue("DownloadCabRecording.MediaDownloadParam.SignatureUrl");
			mediaDownloadParam.FileName = context.StringValue("DownloadCabRecording.MediaDownloadParam.FileName");
			downloadCabRecordingResponse.MediaDownloadParam = mediaDownloadParam;
        
			return downloadCabRecordingResponse;
        }
    }
}
