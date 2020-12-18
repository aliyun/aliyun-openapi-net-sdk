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
    public class DetectFruitsResponseUnmarshaller
    {
        public static DetectFruitsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectFruitsResponse detectFruitsResponse = new DetectFruitsResponse();

			detectFruitsResponse.HttpResponse = _ctx.HttpResponse;
			detectFruitsResponse.RequestId = _ctx.StringValue("DetectFruits.RequestId");

			DetectFruitsResponse.DetectFruits_Data data = new DetectFruitsResponse.DetectFruits_Data();

			List<DetectFruitsResponse.DetectFruits_Data.DetectFruits_Element> data_elements = new List<DetectFruitsResponse.DetectFruits_Data.DetectFruits_Element>();
			for (int i = 0; i < _ctx.Length("DetectFruits.Data.Elements.Length"); i++) {
				DetectFruitsResponse.DetectFruits_Data.DetectFruits_Element element = new DetectFruitsResponse.DetectFruits_Data.DetectFruits_Element();
				element.Name = _ctx.StringValue("DetectFruits.Data.Elements["+ i +"].Name");
				element.Score = _ctx.FloatValue("DetectFruits.Data.Elements["+ i +"].Score");

				List<string> element_box = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectFruits.Data.Elements["+ i +"].Box.Length"); j++) {
					element_box.Add(_ctx.StringValue("DetectFruits.Data.Elements["+ i +"].Box["+ j +"]"));
				}
				element.Box = element_box;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			detectFruitsResponse.Data = data;
        
			return detectFruitsResponse;
        }
    }
}
