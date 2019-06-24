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
    public class UpdateWatermarkResponseUnmarshaller
    {
        public static UpdateWatermarkResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateWatermarkResponse updateWatermarkResponse = new UpdateWatermarkResponse();

			updateWatermarkResponse.HttpResponse = context.HttpResponse;
			updateWatermarkResponse.RequestId = context.StringValue("UpdateWatermark.RequestId");

			UpdateWatermarkResponse.UpdateWatermark_WatermarkInfo watermarkInfo = new UpdateWatermarkResponse.UpdateWatermark_WatermarkInfo();
			watermarkInfo.CreationTime = context.StringValue("UpdateWatermark.WatermarkInfo.CreationTime");
			watermarkInfo.Type = context.StringValue("UpdateWatermark.WatermarkInfo.Type");
			watermarkInfo.IsDefault = context.StringValue("UpdateWatermark.WatermarkInfo.IsDefault");
			watermarkInfo.WatermarkId = context.StringValue("UpdateWatermark.WatermarkInfo.WatermarkId");
			watermarkInfo.Name = context.StringValue("UpdateWatermark.WatermarkInfo.Name");
			watermarkInfo.FileUrl = context.StringValue("UpdateWatermark.WatermarkInfo.FileUrl");
			watermarkInfo.WatermarkConfig = context.StringValue("UpdateWatermark.WatermarkInfo.WatermarkConfig");
			updateWatermarkResponse.WatermarkInfo = watermarkInfo;
        
			return updateWatermarkResponse;
        }
    }
}
