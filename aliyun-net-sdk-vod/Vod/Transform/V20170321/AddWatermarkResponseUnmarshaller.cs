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
    public class AddWatermarkResponseUnmarshaller
    {
        public static AddWatermarkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddWatermarkResponse addWatermarkResponse = new AddWatermarkResponse();

			addWatermarkResponse.HttpResponse = _ctx.HttpResponse;
			addWatermarkResponse.RequestId = _ctx.StringValue("AddWatermark.RequestId");

			AddWatermarkResponse.AddWatermark_WatermarkInfo watermarkInfo = new AddWatermarkResponse.AddWatermark_WatermarkInfo();
			watermarkInfo.CreationTime = _ctx.StringValue("AddWatermark.WatermarkInfo.CreationTime");
			watermarkInfo.Type = _ctx.StringValue("AddWatermark.WatermarkInfo.Type");
			watermarkInfo.IsDefault = _ctx.StringValue("AddWatermark.WatermarkInfo.IsDefault");
			watermarkInfo.WatermarkId = _ctx.StringValue("AddWatermark.WatermarkInfo.WatermarkId");
			watermarkInfo.Name = _ctx.StringValue("AddWatermark.WatermarkInfo.Name");
			watermarkInfo.FileUrl = _ctx.StringValue("AddWatermark.WatermarkInfo.FileUrl");
			watermarkInfo.WatermarkConfig = _ctx.StringValue("AddWatermark.WatermarkInfo.WatermarkConfig");
			addWatermarkResponse.WatermarkInfo = watermarkInfo;
        
			return addWatermarkResponse;
        }
    }
}
