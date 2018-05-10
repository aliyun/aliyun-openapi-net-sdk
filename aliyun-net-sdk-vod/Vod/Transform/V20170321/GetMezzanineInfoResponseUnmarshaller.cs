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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetMezzanineInfoResponseUnmarshaller
    {
        public static GetMezzanineInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetMezzanineInfoResponse getMezzanineInfoResponse = new GetMezzanineInfoResponse();

			getMezzanineInfoResponse.HttpResponse = context.HttpResponse;
			getMezzanineInfoResponse.RequestId = context.StringValue("GetMezzanineInfo.RequestId");

			GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine mezzanine = new GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine();
			mezzanine.VideoId = context.StringValue("GetMezzanineInfo.Mezzanine.VideoId");
			mezzanine.Bitrate = context.StringValue("GetMezzanineInfo.Mezzanine.Bitrate");
			mezzanine.CreationTime = context.StringValue("GetMezzanineInfo.Mezzanine.CreationTime");
			mezzanine.Duration = context.StringValue("GetMezzanineInfo.Mezzanine.Duration");
			mezzanine.Fps = context.StringValue("GetMezzanineInfo.Mezzanine.Fps");
			mezzanine.Height = context.LongValue("GetMezzanineInfo.Mezzanine.Height");
			mezzanine.Width = context.LongValue("GetMezzanineInfo.Mezzanine.Width");
			mezzanine.Size = context.LongValue("GetMezzanineInfo.Mezzanine.Size");
			mezzanine.Status = context.StringValue("GetMezzanineInfo.Mezzanine.Status");
			mezzanine.FileURL = context.StringValue("GetMezzanineInfo.Mezzanine.FileURL");
			mezzanine.FileName = context.StringValue("GetMezzanineInfo.Mezzanine.FileName");
			mezzanine.CRC64 = context.StringValue("GetMezzanineInfo.Mezzanine.CRC64");
			mezzanine.PreprocessStatus = context.StringValue("GetMezzanineInfo.Mezzanine.PreprocessStatus");
			getMezzanineInfoResponse.Mezzanine = mezzanine;
        
			return getMezzanineInfoResponse;
        }
    }
}