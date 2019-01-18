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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.rtc.Model.V20180111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class GetTemplateInfoResponseUnmarshaller
    {
        public static GetTemplateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetTemplateInfoResponse getTemplateInfoResponse = new GetTemplateInfoResponse();

			getTemplateInfoResponse.HttpResponse = context.HttpResponse;
			getTemplateInfoResponse.RequestId = context.StringValue("GetTemplateInfo.RequestId");
			getTemplateInfoResponse.MixMode = context.IntegerValue("GetTemplateInfo.MixMode");
			getTemplateInfoResponse.ServiceMode = context.IntegerValue("GetTemplateInfo.ServiceMode");
			getTemplateInfoResponse.CallBack = context.StringValue("GetTemplateInfo.CallBack");
			getTemplateInfoResponse.MaxMixStreamCount = context.IntegerValue("GetTemplateInfo.MaxMixStreamCount");
			getTemplateInfoResponse.MediaConfig = context.IntegerValue("GetTemplateInfo.MediaConfig");

			GetTemplateInfoResponse.GetTemplateInfo_LayOut layOut = new GetTemplateInfoResponse.GetTemplateInfo_LayOut();
			layOut.Color = context.StringValue("GetTemplateInfo.LayOut.Color");
			layOut.Cutmode = context.IntegerValue("GetTemplateInfo.LayOut.Cutmode");
			layOut.LayoutID = context.IntegerValue("GetTemplateInfo.LayOut.LayoutID");
			getTemplateInfoResponse.LayOut = layOut;

			GetTemplateInfoResponse.GetTemplateInfo_RecordConfig recordConfig = new GetTemplateInfoResponse.GetTemplateInfo_RecordConfig();
			recordConfig.StorageType = context.StringValue("GetTemplateInfo.RecordConfig.StorageType");
			recordConfig.FileFormat = context.IntegerValue("GetTemplateInfo.RecordConfig.FileFormat");
			recordConfig.OssEndpoint = context.StringValue("GetTemplateInfo.RecordConfig.OssEndpoint");
			recordConfig.OssBucket = context.StringValue("GetTemplateInfo.RecordConfig.OssBucket");
			recordConfig.VodTranscodeGroupId = context.IntegerValue("GetTemplateInfo.RecordConfig.VodTranscodeGroupId");
			getTemplateInfoResponse.RecordConfig = recordConfig;

			GetTemplateInfoResponse.GetTemplateInfo_LiveConfig liveConfig = new GetTemplateInfoResponse.GetTemplateInfo_LiveConfig();
			liveConfig.DomainName = context.StringValue("GetTemplateInfo.LiveConfig.DomainName");
			liveConfig.AppName = context.StringValue("GetTemplateInfo.LiveConfig.AppName");
			getTemplateInfoResponse.LiveConfig = liveConfig;
        
			return getTemplateInfoResponse;
        }
    }
}