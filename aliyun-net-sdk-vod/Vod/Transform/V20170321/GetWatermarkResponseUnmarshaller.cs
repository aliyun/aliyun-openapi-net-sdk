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
        public static GetWatermarkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetWatermarkResponse getWatermarkResponse = new GetWatermarkResponse();

			getWatermarkResponse.HttpResponse = _ctx.HttpResponse;
			getWatermarkResponse.RequestId = _ctx.StringValue("GetWatermark.RequestId");

			GetWatermarkResponse.GetWatermark_WatermarkInfo watermarkInfo = new GetWatermarkResponse.GetWatermark_WatermarkInfo();
			watermarkInfo.CreationTime = _ctx.StringValue("GetWatermark.WatermarkInfo.CreationTime");
			watermarkInfo.Type = _ctx.StringValue("GetWatermark.WatermarkInfo.Type");
			watermarkInfo.IsDefault = _ctx.StringValue("GetWatermark.WatermarkInfo.IsDefault");
			watermarkInfo.FileUrl = _ctx.StringValue("GetWatermark.WatermarkInfo.FileUrl");
			watermarkInfo.AppId = _ctx.StringValue("GetWatermark.WatermarkInfo.AppId");
			watermarkInfo.WatermarkConfig = _ctx.StringValue("GetWatermark.WatermarkInfo.WatermarkConfig");
			watermarkInfo.Name = _ctx.StringValue("GetWatermark.WatermarkInfo.Name");
			watermarkInfo.WatermarkId = _ctx.StringValue("GetWatermark.WatermarkInfo.WatermarkId");
			getWatermarkResponse.WatermarkInfo = watermarkInfo;
        
			return getWatermarkResponse;
        }
    }
}
