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
    public class RecognizeQrCodeResponseUnmarshaller
    {
        public static RecognizeQrCodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeQrCodeResponse recognizeQrCodeResponse = new RecognizeQrCodeResponse();

			recognizeQrCodeResponse.HttpResponse = _ctx.HttpResponse;
			recognizeQrCodeResponse.RequestId = _ctx.StringValue("RecognizeQrCode.RequestId");

			RecognizeQrCodeResponse.RecognizeQrCode_Data data = new RecognizeQrCodeResponse.RecognizeQrCode_Data();

			List<RecognizeQrCodeResponse.RecognizeQrCode_Data.RecognizeQrCode_Element> data_elements = new List<RecognizeQrCodeResponse.RecognizeQrCode_Data.RecognizeQrCode_Element>();
			for (int i = 0; i < _ctx.Length("RecognizeQrCode.Data.Elements.Length"); i++) {
				RecognizeQrCodeResponse.RecognizeQrCode_Data.RecognizeQrCode_Element element = new RecognizeQrCodeResponse.RecognizeQrCode_Data.RecognizeQrCode_Element();
				element.TaskId = _ctx.StringValue("RecognizeQrCode.Data.Elements["+ i +"].TaskId");
				element.ImageURL = _ctx.StringValue("RecognizeQrCode.Data.Elements["+ i +"].ImageURL");

				List<RecognizeQrCodeResponse.RecognizeQrCode_Data.RecognizeQrCode_Element.RecognizeQrCode_Result> element_results = new List<RecognizeQrCodeResponse.RecognizeQrCode_Data.RecognizeQrCode_Element.RecognizeQrCode_Result>();
				for (int j = 0; j < _ctx.Length("RecognizeQrCode.Data.Elements["+ i +"].Results.Length"); j++) {
					RecognizeQrCodeResponse.RecognizeQrCode_Data.RecognizeQrCode_Element.RecognizeQrCode_Result result = new RecognizeQrCodeResponse.RecognizeQrCode_Data.RecognizeQrCode_Element.RecognizeQrCode_Result();
					result.Label = _ctx.StringValue("RecognizeQrCode.Data.Elements["+ i +"].Results["+ j +"].Label");
					result.Suggestion = _ctx.StringValue("RecognizeQrCode.Data.Elements["+ i +"].Results["+ j +"].Suggestion");
					result.Rate = _ctx.FloatValue("RecognizeQrCode.Data.Elements["+ i +"].Results["+ j +"].Rate");

					List<string> result_qrCodesData = new List<string>();
					for (int k = 0; k < _ctx.Length("RecognizeQrCode.Data.Elements["+ i +"].Results["+ j +"].QrCodesData.Length"); k++) {
						result_qrCodesData.Add(_ctx.StringValue("RecognizeQrCode.Data.Elements["+ i +"].Results["+ j +"].QrCodesData["+ k +"]"));
					}
					result.QrCodesData = result_qrCodesData;

					element_results.Add(result);
				}
				element.Results = element_results;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			recognizeQrCodeResponse.Data = data;
        
			return recognizeQrCodeResponse;
        }
    }
}
