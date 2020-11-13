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
    public class DetectLivingFaceResponseUnmarshaller
    {
        public static DetectLivingFaceResponse Unmarshall(UnmarshallerContext context)
        {
			DetectLivingFaceResponse detectLivingFaceResponse = new DetectLivingFaceResponse();

			detectLivingFaceResponse.HttpResponse = context.HttpResponse;
			detectLivingFaceResponse.RequestId = context.StringValue("DetectLivingFace.RequestId");

			DetectLivingFaceResponse.DetectLivingFace_Data data = new DetectLivingFaceResponse.DetectLivingFace_Data();

			List<DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element> data_elements = new List<DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element>();
			for (int i = 0; i < context.Length("DetectLivingFace.Data.Elements.Length"); i++) {
				DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element element = new DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element();
				element.TaskId = context.StringValue("DetectLivingFace.Data.Elements["+ i +"].TaskId");
				element.ImageURL = context.StringValue("DetectLivingFace.Data.Elements["+ i +"].ImageURL");

				List<DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element.DetectLivingFace_Result> element_results = new List<DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element.DetectLivingFace_Result>();
				for (int j = 0; j < context.Length("DetectLivingFace.Data.Elements["+ i +"].Results.Length"); j++) {
					DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element.DetectLivingFace_Result result = new DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element.DetectLivingFace_Result();
					result.Label = context.StringValue("DetectLivingFace.Data.Elements["+ i +"].Results["+ j +"].Label");
					result.Suggestion = context.StringValue("DetectLivingFace.Data.Elements["+ i +"].Results["+ j +"].Suggestion");
					result.Rate = context.FloatValue("DetectLivingFace.Data.Elements["+ i +"].Results["+ j +"].Rate");

					List<DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element.DetectLivingFace_Result.DetectLivingFace_Frame> result_frames = new List<DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element.DetectLivingFace_Result.DetectLivingFace_Frame>();
					for (int k = 0; k < context.Length("DetectLivingFace.Data.Elements["+ i +"].Results["+ j +"].Frames.Length"); k++) {
						DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element.DetectLivingFace_Result.DetectLivingFace_Frame frame = new DetectLivingFaceResponse.DetectLivingFace_Data.DetectLivingFace_Element.DetectLivingFace_Result.DetectLivingFace_Frame();
						frame.Rate = context.FloatValue("DetectLivingFace.Data.Elements["+ i +"].Results["+ j +"].Frames["+ k +"].Rate");
						frame.Url = context.StringValue("DetectLivingFace.Data.Elements["+ i +"].Results["+ j +"].Frames["+ k +"].Url");

						result_frames.Add(frame);
					}
					result.Frames = result_frames;

					element_results.Add(result);
				}
				element.Results = element_results;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			detectLivingFaceResponse.Data = data;
        
			return detectLivingFaceResponse;
        }
    }
}
