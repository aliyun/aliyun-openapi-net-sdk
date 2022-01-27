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
using Aliyun.Acs.ocr.Model.V20191230;

namespace Aliyun.Acs.ocr.Transform.V20191230
{
    public class DetectCardScreenshotResponseUnmarshaller
    {
        public static DetectCardScreenshotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectCardScreenshotResponse detectCardScreenshotResponse = new DetectCardScreenshotResponse();

			detectCardScreenshotResponse.HttpResponse = _ctx.HttpResponse;
			detectCardScreenshotResponse.RequestId = _ctx.StringValue("DetectCardScreenshot.RequestId");

			DetectCardScreenshotResponse.DetectCardScreenshot_Data data = new DetectCardScreenshotResponse.DetectCardScreenshot_Data();
			data.IsCard = _ctx.BooleanValue("DetectCardScreenshot.Data.IsCard");
			data.IsBlur = _ctx.BooleanValue("DetectCardScreenshot.Data.IsBlur");

			DetectCardScreenshotResponse.DetectCardScreenshot_Data.DetectCardScreenshot_SpoofResult spoofResult = new DetectCardScreenshotResponse.DetectCardScreenshot_Data.DetectCardScreenshot_SpoofResult();
			spoofResult.IsSpoof = _ctx.BooleanValue("DetectCardScreenshot.Data.SpoofResult.IsSpoof");

			DetectCardScreenshotResponse.DetectCardScreenshot_Data.DetectCardScreenshot_SpoofResult.DetectCardScreenshot_ResultMap resultMap = new DetectCardScreenshotResponse.DetectCardScreenshot_Data.DetectCardScreenshot_SpoofResult.DetectCardScreenshot_ResultMap();
			resultMap.ScreenScore = _ctx.FloatValue("DetectCardScreenshot.Data.SpoofResult.ResultMap.ScreenScore");
			resultMap.ScreenThreshold = _ctx.FloatValue("DetectCardScreenshot.Data.SpoofResult.ResultMap.ScreenThreshold");
			spoofResult.ResultMap = resultMap;
			data.SpoofResult = spoofResult;
			detectCardScreenshotResponse.Data = data;
        
			return detectCardScreenshotResponse;
        }
    }
}
