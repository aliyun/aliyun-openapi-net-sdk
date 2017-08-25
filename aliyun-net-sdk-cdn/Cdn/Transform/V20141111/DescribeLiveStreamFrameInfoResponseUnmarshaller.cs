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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveStreamFrameInfoResponseUnmarshaller
    {
        public static DescribeLiveStreamFrameInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamFrameInfoResponse describeLiveStreamFrameInfoResponse = new DescribeLiveStreamFrameInfoResponse();

			describeLiveStreamFrameInfoResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamFrameInfoResponse.RequestId = context.StringValue("DescribeLiveStreamFrameInfo.RequestId");

			List<DescribeLiveStreamFrameInfoResponse.DescribeLiveStreamFrameInfo_FrameDataModel> describeLiveStreamFrameInfoResponse_frameDataInfos = new List<DescribeLiveStreamFrameInfoResponse.DescribeLiveStreamFrameInfo_FrameDataModel>();
			for (int i = 0; i < context.Length("DescribeLiveStreamFrameInfo.FrameDataInfos.Length"); i++) {
				DescribeLiveStreamFrameInfoResponse.DescribeLiveStreamFrameInfo_FrameDataModel frameDataModel = new DescribeLiveStreamFrameInfoResponse.DescribeLiveStreamFrameInfo_FrameDataModel();
				frameDataModel.Time = context.StringValue("DescribeLiveStreamFrameInfo.FrameDataInfos["+ i +"].Time");
				frameDataModel.Stream = context.StringValue("DescribeLiveStreamFrameInfo.FrameDataInfos["+ i +"].Stream");
				frameDataModel.ClientAddr = context.StringValue("DescribeLiveStreamFrameInfo.FrameDataInfos["+ i +"].ClientAddr");
				frameDataModel.Server = context.StringValue("DescribeLiveStreamFrameInfo.FrameDataInfos["+ i +"].Server");
				frameDataModel.AudioRate = context.FloatValue("DescribeLiveStreamFrameInfo.FrameDataInfos["+ i +"].AudioRate");
				frameDataModel.AudioByte = context.FloatValue("DescribeLiveStreamFrameInfo.FrameDataInfos["+ i +"].AudioByte");
				frameDataModel.FrameRate = context.FloatValue("DescribeLiveStreamFrameInfo.FrameDataInfos["+ i +"].FrameRate");
				frameDataModel.FrameByte = context.FloatValue("DescribeLiveStreamFrameInfo.FrameDataInfos["+ i +"].FrameByte");

				describeLiveStreamFrameInfoResponse_frameDataInfos.Add(frameDataModel);
			}
			describeLiveStreamFrameInfoResponse.FrameDataInfos = describeLiveStreamFrameInfoResponse_frameDataInfos;
        
			return describeLiveStreamFrameInfoResponse;
        }
    }
}