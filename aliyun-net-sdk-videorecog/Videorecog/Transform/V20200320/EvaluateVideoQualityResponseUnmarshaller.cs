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
using Aliyun.Acs.videorecog.Model.V20200320;

namespace Aliyun.Acs.videorecog.Transform.V20200320
{
    public class EvaluateVideoQualityResponseUnmarshaller
    {
        public static EvaluateVideoQualityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EvaluateVideoQualityResponse evaluateVideoQualityResponse = new EvaluateVideoQualityResponse();

			evaluateVideoQualityResponse.HttpResponse = _ctx.HttpResponse;
			evaluateVideoQualityResponse.RequestId = _ctx.StringValue("EvaluateVideoQuality.RequestId");
			evaluateVideoQualityResponse.Code = _ctx.StringValue("EvaluateVideoQuality.Code");
			evaluateVideoQualityResponse.Message = _ctx.StringValue("EvaluateVideoQuality.Message");

			EvaluateVideoQualityResponse.EvaluateVideoQuality_Data data = new EvaluateVideoQualityResponse.EvaluateVideoQuality_Data();
			data.JsonUrl = _ctx.StringValue("EvaluateVideoQuality.Data.JsonUrl");
			data.PdfUrl = _ctx.StringValue("EvaluateVideoQuality.Data.PdfUrl");

			EvaluateVideoQualityResponse.EvaluateVideoQuality_Data.EvaluateVideoQuality_VideoQualityInfo videoQualityInfo = new EvaluateVideoQualityResponse.EvaluateVideoQuality_Data.EvaluateVideoQuality_VideoQualityInfo();
			videoQualityInfo.CompressiveStrength = _ctx.FloatValue("EvaluateVideoQuality.Data.VideoQualityInfo.CompressiveStrength");
			videoQualityInfo.NoiseIntensity = _ctx.FloatValue("EvaluateVideoQuality.Data.VideoQualityInfo.NoiseIntensity");
			videoQualityInfo.Blurriness = _ctx.FloatValue("EvaluateVideoQuality.Data.VideoQualityInfo.Blurriness");
			videoQualityInfo.ColorContrast = _ctx.FloatValue("EvaluateVideoQuality.Data.VideoQualityInfo.ColorContrast");
			videoQualityInfo.ColorSaturation = _ctx.FloatValue("EvaluateVideoQuality.Data.VideoQualityInfo.ColorSaturation");
			videoQualityInfo.Luminance = _ctx.FloatValue("EvaluateVideoQuality.Data.VideoQualityInfo.Luminance");
			videoQualityInfo.Colorfulness = _ctx.FloatValue("EvaluateVideoQuality.Data.VideoQualityInfo.Colorfulness");
			videoQualityInfo.MosScore = _ctx.FloatValue("EvaluateVideoQuality.Data.VideoQualityInfo.MosScore");
			data.VideoQualityInfo = videoQualityInfo;
			evaluateVideoQualityResponse.Data = data;
        
			return evaluateVideoQualityResponse;
        }
    }
}
