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
    public class DetectPedestrianResponseUnmarshaller
    {
        public static DetectPedestrianResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectPedestrianResponse detectPedestrianResponse = new DetectPedestrianResponse();

			detectPedestrianResponse.HttpResponse = _ctx.HttpResponse;
			detectPedestrianResponse.RequestId = _ctx.StringValue("DetectPedestrian.RequestId");

			DetectPedestrianResponse.DetectPedestrian_Data data = new DetectPedestrianResponse.DetectPedestrian_Data();
			data.Height = _ctx.IntegerValue("DetectPedestrian.Data.Height");
			data.Width = _ctx.IntegerValue("DetectPedestrian.Data.Width");

			List<DetectPedestrianResponse.DetectPedestrian_Data.DetectPedestrian_Element> data_elements = new List<DetectPedestrianResponse.DetectPedestrian_Data.DetectPedestrian_Element>();
			for (int i = 0; i < _ctx.Length("DetectPedestrian.Data.Elements.Length"); i++) {
				DetectPedestrianResponse.DetectPedestrian_Data.DetectPedestrian_Element element = new DetectPedestrianResponse.DetectPedestrian_Data.DetectPedestrian_Element();
				element.Score = _ctx.FloatValue("DetectPedestrian.Data.Elements["+ i +"].Score");
				element.Type = _ctx.StringValue("DetectPedestrian.Data.Elements["+ i +"].Type");

				List<string> element_boxes = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectPedestrian.Data.Elements["+ i +"].Boxes.Length"); j++) {
					element_boxes.Add(_ctx.StringValue("DetectPedestrian.Data.Elements["+ i +"].Boxes["+ j +"]"));
				}
				element.Boxes = element_boxes;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			detectPedestrianResponse.Data = data;
        
			return detectPedestrianResponse;
        }
    }
}
