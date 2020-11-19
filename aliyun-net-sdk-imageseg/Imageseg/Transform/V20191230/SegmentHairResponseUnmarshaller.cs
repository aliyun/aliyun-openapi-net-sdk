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
    public class SegmentHairResponseUnmarshaller
    {
        public static SegmentHairResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SegmentHairResponse segmentHairResponse = new SegmentHairResponse();

			segmentHairResponse.HttpResponse = _ctx.HttpResponse;
			segmentHairResponse.RequestId = _ctx.StringValue("SegmentHair.RequestId");

			SegmentHairResponse.SegmentHair_Data data = new SegmentHairResponse.SegmentHair_Data();

			List<SegmentHairResponse.SegmentHair_Data.SegmentHair_Element> data_elements = new List<SegmentHairResponse.SegmentHair_Data.SegmentHair_Element>();
			for (int i = 0; i < _ctx.Length("SegmentHair.Data.Elements.Length"); i++) {
				SegmentHairResponse.SegmentHair_Data.SegmentHair_Element element = new SegmentHairResponse.SegmentHair_Data.SegmentHair_Element();
				element.ImageURL = _ctx.StringValue("SegmentHair.Data.Elements["+ i +"].ImageURL");
				element.X = _ctx.IntegerValue("SegmentHair.Data.Elements["+ i +"].X");
				element.Y = _ctx.IntegerValue("SegmentHair.Data.Elements["+ i +"].Y");
				element.Width = _ctx.IntegerValue("SegmentHair.Data.Elements["+ i +"].Width");
				element.Height = _ctx.IntegerValue("SegmentHair.Data.Elements["+ i +"].Height");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			segmentHairResponse.Data = data;
        
			return segmentHairResponse;
        }
    }
}
