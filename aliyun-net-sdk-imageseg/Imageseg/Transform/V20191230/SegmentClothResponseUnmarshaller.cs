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
    public class SegmentClothResponseUnmarshaller
    {
        public static SegmentClothResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SegmentClothResponse segmentClothResponse = new SegmentClothResponse();

			segmentClothResponse.HttpResponse = _ctx.HttpResponse;
			segmentClothResponse.RequestId = _ctx.StringValue("SegmentCloth.RequestId");

			SegmentClothResponse.SegmentCloth_Data data = new SegmentClothResponse.SegmentCloth_Data();

			List<SegmentClothResponse.SegmentCloth_Data.SegmentCloth_Element> data_elements = new List<SegmentClothResponse.SegmentCloth_Data.SegmentCloth_Element>();
			for (int i = 0; i < _ctx.Length("SegmentCloth.Data.Elements.Length"); i++) {
				SegmentClothResponse.SegmentCloth_Data.SegmentCloth_Element element = new SegmentClothResponse.SegmentCloth_Data.SegmentCloth_Element();
				element.ImageURL = _ctx.StringValue("SegmentCloth.Data.Elements["+ i +"].ImageURL");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			segmentClothResponse.Data = data;
        
			return segmentClothResponse;
        }
    }
}
