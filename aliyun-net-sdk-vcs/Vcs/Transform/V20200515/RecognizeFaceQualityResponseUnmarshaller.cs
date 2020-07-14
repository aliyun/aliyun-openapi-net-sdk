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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class RecognizeFaceQualityResponseUnmarshaller
    {
        public static RecognizeFaceQualityResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeFaceQualityResponse recognizeFaceQualityResponse = new RecognizeFaceQualityResponse();

			recognizeFaceQualityResponse.HttpResponse = context.HttpResponse;
			recognizeFaceQualityResponse.Code = context.StringValue("RecognizeFaceQuality.Code");
			recognizeFaceQualityResponse.Message = context.StringValue("RecognizeFaceQuality.Message");
			recognizeFaceQualityResponse.RequestId = context.StringValue("RecognizeFaceQuality.RequestId");

			RecognizeFaceQualityResponse.RecognizeFaceQuality_Data data = new RecognizeFaceQualityResponse.RecognizeFaceQuality_Data();
			data.QualityScore = context.StringValue("RecognizeFaceQuality.Data.QualityScore");
			data.Description = context.StringValue("RecognizeFaceQuality.Data.Description");

			RecognizeFaceQualityResponse.RecognizeFaceQuality_Data.RecognizeFaceQuality_Attributes attributes = new RecognizeFaceQualityResponse.RecognizeFaceQuality_Data.RecognizeFaceQuality_Attributes();
			attributes.LeftTopX = context.IntegerValue("RecognizeFaceQuality.Data.Attributes.LeftTopX");
			attributes.LeftTopY = context.IntegerValue("RecognizeFaceQuality.Data.Attributes.LeftTopY");
			attributes.RightBottomX = context.IntegerValue("RecognizeFaceQuality.Data.Attributes.RightBottomX");
			attributes.RightBottomY = context.IntegerValue("RecognizeFaceQuality.Data.Attributes.RightBottomY");
			attributes.TargetImageStoragePath = context.StringValue("RecognizeFaceQuality.Data.Attributes.TargetImageStoragePath");
			attributes.FaceStyle = context.StringValue("RecognizeFaceQuality.Data.Attributes.FaceStyle");
			attributes.FaceQuality = context.StringValue("RecognizeFaceQuality.Data.Attributes.FaceQuality");
			attributes.FaceScore = context.StringValue("RecognizeFaceQuality.Data.Attributes.FaceScore");
			data.Attributes = attributes;
			recognizeFaceQualityResponse.Data = data;
        
			return recognizeFaceQualityResponse;
        }
    }
}
