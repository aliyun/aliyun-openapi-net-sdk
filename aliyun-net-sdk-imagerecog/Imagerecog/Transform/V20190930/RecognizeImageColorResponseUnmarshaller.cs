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
using Aliyun.Acs.imagerecog.Model.V20190930;

namespace Aliyun.Acs.imagerecog.Transform.V20190930
{
    public class RecognizeImageColorResponseUnmarshaller
    {
        public static RecognizeImageColorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeImageColorResponse recognizeImageColorResponse = new RecognizeImageColorResponse();

			recognizeImageColorResponse.HttpResponse = _ctx.HttpResponse;
			recognizeImageColorResponse.RequestId = _ctx.StringValue("RecognizeImageColor.RequestId");

			RecognizeImageColorResponse.RecognizeImageColor_Data data = new RecognizeImageColorResponse.RecognizeImageColor_Data();

			List<RecognizeImageColorResponse.RecognizeImageColor_Data.RecognizeImageColor_ColorTemplate> data_colorTemplateList = new List<RecognizeImageColorResponse.RecognizeImageColor_Data.RecognizeImageColor_ColorTemplate>();
			for (int i = 0; i < _ctx.Length("RecognizeImageColor.Data.ColorTemplateList.Length"); i++) {
				RecognizeImageColorResponse.RecognizeImageColor_Data.RecognizeImageColor_ColorTemplate colorTemplate = new RecognizeImageColorResponse.RecognizeImageColor_Data.RecognizeImageColor_ColorTemplate();
				colorTemplate.Color = _ctx.StringValue("RecognizeImageColor.Data.ColorTemplateList["+ i +"].Color");
				colorTemplate.Label = _ctx.StringValue("RecognizeImageColor.Data.ColorTemplateList["+ i +"].Label");
				colorTemplate.Percentage = _ctx.FloatValue("RecognizeImageColor.Data.ColorTemplateList["+ i +"].Percentage");

				data_colorTemplateList.Add(colorTemplate);
			}
			data.ColorTemplateList = data_colorTemplateList;
			recognizeImageColorResponse.Data = data;
        
			return recognizeImageColorResponse;
        }
    }
}
