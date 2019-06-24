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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetWatermarkResponseUnmarshaller
    {
        public static GetWatermarkResponse Unmarshall(UnmarshallerContext context)
        {
			GetWatermarkResponse getWatermarkResponse = new GetWatermarkResponse();

			getWatermarkResponse.HttpResponse = context.HttpResponse;
			getWatermarkResponse.RequestId = context.StringValue("GetWatermark.RequestId");

			GetWatermarkResponse.GetWatermark_WatermarkInfo watermarkInfo = new GetWatermarkResponse.GetWatermark_WatermarkInfo();
			watermarkInfo.CreationTime = context.StringValue("GetWatermark.WatermarkInfo.CreationTime");
			watermarkInfo.Type = context.StringValue("GetWatermark.WatermarkInfo.Type");
			watermarkInfo.IsDefault = context.StringValue("GetWatermark.WatermarkInfo.IsDefault");
			watermarkInfo.WatermarkId = context.StringValue("GetWatermark.WatermarkInfo.WatermarkId");
			watermarkInfo.Name = context.StringValue("GetWatermark.WatermarkInfo.Name");
			watermarkInfo.FileUrl = context.StringValue("GetWatermark.WatermarkInfo.FileUrl");
			watermarkInfo.WatermarkConfig = context.StringValue("GetWatermark.WatermarkInfo.WatermarkConfig");
			watermarkInfo.AppId = context.StringValue("GetWatermark.WatermarkInfo.AppId");
			getWatermarkResponse.WatermarkInfo = watermarkInfo;
        
			return getWatermarkResponse;
        }
    }
}
