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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class RecognizePublicFaceResponseUnmarshaller
    {
        public static RecognizePublicFaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizePublicFaceResponse recognizePublicFaceResponse = new RecognizePublicFaceResponse();

			recognizePublicFaceResponse.HttpResponse = _ctx.HttpResponse;
			recognizePublicFaceResponse.RequestId = _ctx.StringValue("RecognizePublicFace.RequestId");

			RecognizePublicFaceResponse.RecognizePublicFace_Data data = new RecognizePublicFaceResponse.RecognizePublicFace_Data();

			List<RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element> data_elements = new List<RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element>();
			for (int i = 0; i < _ctx.Length("RecognizePublicFace.Data.Elements.Length"); i++) {
				RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element element = new RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element();
				element.TaskId = _ctx.StringValue("RecognizePublicFace.Data.Elements["+ i +"].TaskId");
				element.ImageURL = _ctx.StringValue("RecognizePublicFace.Data.Elements["+ i +"].ImageURL");

				List<RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result> element_results = new List<RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result>();
				for (int j = 0; j < _ctx.Length("RecognizePublicFace.Data.Elements["+ i +"].Results.Length"); j++) {
					RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result result = new RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result();
					result.Label = _ctx.StringValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].Label");
					result.Suggestion = _ctx.StringValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].Suggestion");
					result.Rate = _ctx.FloatValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].Rate");

					List<RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result.RecognizePublicFace_SubResult> result_subResults = new List<RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result.RecognizePublicFace_SubResult>();
					for (int k = 0; k < _ctx.Length("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].SubResults.Length"); k++) {
						RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result.RecognizePublicFace_SubResult subResult = new RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result.RecognizePublicFace_SubResult();
						subResult.H = _ctx.FloatValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].SubResults["+ k +"].H");
						subResult.W = _ctx.FloatValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].SubResults["+ k +"].W");
						subResult.X = _ctx.FloatValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].SubResults["+ k +"].X");
						subResult.Y = _ctx.FloatValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].SubResults["+ k +"].Y");

						List<RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result.RecognizePublicFace_SubResult.RecognizePublicFace_Face> subResult_faces = new List<RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result.RecognizePublicFace_SubResult.RecognizePublicFace_Face>();
						for (int l = 0; l < _ctx.Length("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].SubResults["+ k +"].Faces.Length"); l++) {
							RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result.RecognizePublicFace_SubResult.RecognizePublicFace_Face face = new RecognizePublicFaceResponse.RecognizePublicFace_Data.RecognizePublicFace_Element.RecognizePublicFace_Result.RecognizePublicFace_SubResult.RecognizePublicFace_Face();
							face.Id = _ctx.StringValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].SubResults["+ k +"].Faces["+ l +"].Id");
							face.Name = _ctx.StringValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].SubResults["+ k +"].Faces["+ l +"].Name");
							face.Rate = _ctx.FloatValue("RecognizePublicFace.Data.Elements["+ i +"].Results["+ j +"].SubResults["+ k +"].Faces["+ l +"].Rate");

							subResult_faces.Add(face);
						}
						subResult.Faces = subResult_faces;

						result_subResults.Add(subResult);
					}
					result.SubResults = result_subResults;

					element_results.Add(result);
				}
				element.Results = element_results;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			recognizePublicFaceResponse.Data = data;
        
			return recognizePublicFaceResponse;
        }
    }
}
