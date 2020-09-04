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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetImageQualityResponseUnmarshaller
    {
        public static GetImageQualityResponse Unmarshall(UnmarshallerContext context)
        {
			GetImageQualityResponse getImageQualityResponse = new GetImageQualityResponse();

			getImageQualityResponse.HttpResponse = context.HttpResponse;
			getImageQualityResponse.RequestId = context.StringValue("GetImageQuality.RequestId");
			getImageQualityResponse.ImageUri = context.StringValue("GetImageQuality.ImageUri");

			GetImageQualityResponse.GetImageQuality_ImageQuality imageQuality = new GetImageQualityResponse.GetImageQuality_ImageQuality();
			imageQuality.OverallScore = context.FloatValue("GetImageQuality.ImageQuality.OverallScore");
			imageQuality.ClarityScore = context.FloatValue("GetImageQuality.ImageQuality.ClarityScore");
			imageQuality.Clarity = context.FloatValue("GetImageQuality.ImageQuality.Clarity");
			imageQuality.ExposureScore = context.FloatValue("GetImageQuality.ImageQuality.ExposureScore");
			imageQuality.Exposure = context.FloatValue("GetImageQuality.ImageQuality.Exposure");
			imageQuality.ContrastScore = context.FloatValue("GetImageQuality.ImageQuality.ContrastScore");
			imageQuality.Contrast = context.FloatValue("GetImageQuality.ImageQuality.Contrast");
			imageQuality.ColorScore = context.FloatValue("GetImageQuality.ImageQuality.ColorScore");
			imageQuality.Color = context.FloatValue("GetImageQuality.ImageQuality.Color");
			imageQuality.CompositionScore = context.FloatValue("GetImageQuality.ImageQuality.CompositionScore");
			getImageQualityResponse.ImageQuality = imageQuality;
        
			return getImageQualityResponse;
        }
    }
}
