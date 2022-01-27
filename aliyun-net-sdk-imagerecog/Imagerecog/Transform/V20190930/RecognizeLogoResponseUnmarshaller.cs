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
    public class RecognizeLogoResponseUnmarshaller
    {
        public static RecognizeLogoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeLogoResponse recognizeLogoResponse = new RecognizeLogoResponse();

			recognizeLogoResponse.HttpResponse = _ctx.HttpResponse;
			recognizeLogoResponse.RequestId = _ctx.StringValue("RecognizeLogo.RequestId");

			RecognizeLogoResponse.RecognizeLogo_Data data = new RecognizeLogoResponse.RecognizeLogo_Data();

			List<RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element> data_elements = new List<RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element>();
			for (int i = 0; i < _ctx.Length("RecognizeLogo.Data.Elements.Length"); i++) {
				RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element element = new RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element();
				element.TaskId = _ctx.StringValue("RecognizeLogo.Data.Elements["+ i +"].TaskId");
				element.ImageURL = _ctx.StringValue("RecognizeLogo.Data.Elements["+ i +"].ImageURL");

				List<RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element.RecognizeLogo_Result> element_results = new List<RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element.RecognizeLogo_Result>();
				for (int j = 0; j < _ctx.Length("RecognizeLogo.Data.Elements["+ i +"].Results.Length"); j++) {
					RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element.RecognizeLogo_Result result = new RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element.RecognizeLogo_Result();
					result.Label = _ctx.StringValue("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].Label");
					result.Suggestion = _ctx.StringValue("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].Suggestion");
					result.Rate = _ctx.FloatValue("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].Rate");

					List<RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element.RecognizeLogo_Result.RecognizeLogo_LogoData> result_logosData = new List<RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element.RecognizeLogo_Result.RecognizeLogo_LogoData>();
					for (int k = 0; k < _ctx.Length("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].LogosData.Length"); k++) {
						RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element.RecognizeLogo_Result.RecognizeLogo_LogoData logoData = new RecognizeLogoResponse.RecognizeLogo_Data.RecognizeLogo_Element.RecognizeLogo_Result.RecognizeLogo_LogoData();
						logoData.Name = _ctx.StringValue("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].LogosData["+ k +"].Name");
						logoData.Type = _ctx.StringValue("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].LogosData["+ k +"].Type");
						logoData.X = _ctx.FloatValue("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].LogosData["+ k +"].X");
						logoData.Y = _ctx.FloatValue("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].LogosData["+ k +"].Y");
						logoData.H = _ctx.FloatValue("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].LogosData["+ k +"].H");
						logoData.W = _ctx.FloatValue("RecognizeLogo.Data.Elements["+ i +"].Results["+ j +"].LogosData["+ k +"].W");

						result_logosData.Add(logoData);
					}
					result.LogosData = result_logosData;

					element_results.Add(result);
				}
				element.Results = element_results;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			recognizeLogoResponse.Data = data;
        
			return recognizeLogoResponse;
        }
    }
}
