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
    public class DetectVideoLivingFaceResponseUnmarshaller
    {
        public static DetectVideoLivingFaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectVideoLivingFaceResponse detectVideoLivingFaceResponse = new DetectVideoLivingFaceResponse();

			detectVideoLivingFaceResponse.HttpResponse = _ctx.HttpResponse;
			detectVideoLivingFaceResponse.RequestId = _ctx.StringValue("DetectVideoLivingFace.RequestId");

			DetectVideoLivingFaceResponse.DetectVideoLivingFace_Data data = new DetectVideoLivingFaceResponse.DetectVideoLivingFace_Data();

			List<DetectVideoLivingFaceResponse.DetectVideoLivingFace_Data.DetectVideoLivingFace_Element> data_elements = new List<DetectVideoLivingFaceResponse.DetectVideoLivingFace_Data.DetectVideoLivingFace_Element>();
			for (int i = 0; i < _ctx.Length("DetectVideoLivingFace.Data.Elements.Length"); i++) {
				DetectVideoLivingFaceResponse.DetectVideoLivingFace_Data.DetectVideoLivingFace_Element element = new DetectVideoLivingFaceResponse.DetectVideoLivingFace_Data.DetectVideoLivingFace_Element();
				element.LiveConfidence = _ctx.FloatValue("DetectVideoLivingFace.Data.Elements["+ i +"].LiveConfidence");
				element.FaceConfidence = _ctx.FloatValue("DetectVideoLivingFace.Data.Elements["+ i +"].FaceConfidence");

				List<string> element_rect = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectVideoLivingFace.Data.Elements["+ i +"].Rect.Length"); j++) {
					element_rect.Add(_ctx.StringValue("DetectVideoLivingFace.Data.Elements["+ i +"].Rect["+ j +"]"));
				}
				element.Rect = element_rect;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			detectVideoLivingFaceResponse.Data = data;
        
			return detectVideoLivingFaceResponse;
        }
    }
}
