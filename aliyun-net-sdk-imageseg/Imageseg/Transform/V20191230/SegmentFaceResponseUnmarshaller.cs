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
using Aliyun.Acs.imageseg.Model.V20191230;

namespace Aliyun.Acs.imageseg.Transform.V20191230
{
    public class SegmentFaceResponseUnmarshaller
    {
        public static SegmentFaceResponse Unmarshall(UnmarshallerContext context)
        {
			SegmentFaceResponse segmentFaceResponse = new SegmentFaceResponse();

			segmentFaceResponse.HttpResponse = context.HttpResponse;
			segmentFaceResponse.RequestId = context.StringValue("SegmentFace.RequestId");

			SegmentFaceResponse.SegmentFace_Data data = new SegmentFaceResponse.SegmentFace_Data();

			List<SegmentFaceResponse.SegmentFace_Data.SegmentFace_Element> data_elements = new List<SegmentFaceResponse.SegmentFace_Data.SegmentFace_Element>();
			for (int i = 0; i < context.Length("SegmentFace.Data.Elements.Length"); i++) {
				SegmentFaceResponse.SegmentFace_Data.SegmentFace_Element element = new SegmentFaceResponse.SegmentFace_Data.SegmentFace_Element();
				element.ImageURL = context.StringValue("SegmentFace.Data.Elements["+ i +"].ImageURL");
				element.X = context.IntegerValue("SegmentFace.Data.Elements["+ i +"].X");
				element.Y = context.IntegerValue("SegmentFace.Data.Elements["+ i +"].Y");
				element.Width = context.IntegerValue("SegmentFace.Data.Elements["+ i +"].Width");
				element.Height = context.IntegerValue("SegmentFace.Data.Elements["+ i +"].Height");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			segmentFaceResponse.Data = data;
        
			return segmentFaceResponse;
        }
    }
}
