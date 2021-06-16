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
using Aliyun.Acs.imageaudit.Model.V20191230;

namespace Aliyun.Acs.imageaudit.Transform.V20191230
{
    public class ScanTextResponseUnmarshaller
    {
        public static ScanTextResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ScanTextResponse scanTextResponse = new ScanTextResponse();

			scanTextResponse.HttpResponse = _ctx.HttpResponse;
			scanTextResponse.RequestId = _ctx.StringValue("ScanText.RequestId");

			ScanTextResponse.ScanText_Data data = new ScanTextResponse.ScanText_Data();

			List<ScanTextResponse.ScanText_Data.ScanText_Element> data_elements = new List<ScanTextResponse.ScanText_Data.ScanText_Element>();
			for (int i = 0; i < _ctx.Length("ScanText.Data.Elements.Length"); i++) {
				ScanTextResponse.ScanText_Data.ScanText_Element element = new ScanTextResponse.ScanText_Data.ScanText_Element();
				element.TaskId = _ctx.StringValue("ScanText.Data.Elements["+ i +"].TaskId");

				List<ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result> element_results = new List<ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result>();
				for (int j = 0; j < _ctx.Length("ScanText.Data.Elements["+ i +"].Results.Length"); j++) {
					ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result result = new ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result();
					result.Suggestion = _ctx.StringValue("ScanText.Data.Elements["+ i +"].Results["+ j +"].Suggestion");
					result.Rate = _ctx.FloatValue("ScanText.Data.Elements["+ i +"].Results["+ j +"].Rate");
					result.Label = _ctx.StringValue("ScanText.Data.Elements["+ i +"].Results["+ j +"].Label");

					List<ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result.ScanText_Detail> result_details = new List<ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result.ScanText_Detail>();
					for (int k = 0; k < _ctx.Length("ScanText.Data.Elements["+ i +"].Results["+ j +"].Details.Length"); k++) {
						ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result.ScanText_Detail detail = new ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result.ScanText_Detail();
						detail.Label = _ctx.StringValue("ScanText.Data.Elements["+ i +"].Results["+ j +"].Details["+ k +"].Label");

						List<ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result.ScanText_Detail.ScanText_Context> detail_contexts = new List<ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result.ScanText_Detail.ScanText_Context>();
						for (int l = 0; l < _ctx.Length("ScanText.Data.Elements["+ i +"].Results["+ j +"].Details["+ k +"].Contexts.Length"); l++) {
							ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result.ScanText_Detail.ScanText_Context context = new ScanTextResponse.ScanText_Data.ScanText_Element.ScanText_Result.ScanText_Detail.ScanText_Context();
							context.Context = _ctx.StringValue("ScanText.Data.Elements["+ i +"].Results["+ j +"].Details["+ k +"].Contexts["+ l +"].Context");

							detail_contexts.Add(context);
						}
						detail.Contexts = detail_contexts;

						result_details.Add(detail);
					}
					result.Details = result_details;

					element_results.Add(result);
				}
				element.Results = element_results;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			scanTextResponse.Data = data;
        
			return scanTextResponse;
        }
    }
}
