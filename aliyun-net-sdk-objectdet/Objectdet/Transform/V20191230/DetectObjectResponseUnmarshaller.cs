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
using Aliyun.Acs.objectdet.Model.V20191230;

namespace Aliyun.Acs.objectdet.Transform.V20191230
{
    public class DetectObjectResponseUnmarshaller
    {
        public static DetectObjectResponse Unmarshall(UnmarshallerContext context)
        {
			DetectObjectResponse detectObjectResponse = new DetectObjectResponse();

			detectObjectResponse.HttpResponse = context.HttpResponse;
			detectObjectResponse.RequestId = context.StringValue("DetectObject.RequestId");

			DetectObjectResponse.DetectObject_Data data = new DetectObjectResponse.DetectObject_Data();
			data.Width = context.IntegerValue("DetectObject.Data.Width");
			data.Height = context.IntegerValue("DetectObject.Data.Height");

			List<DetectObjectResponse.DetectObject_Data.DetectObject_Element> data_elements = new List<DetectObjectResponse.DetectObject_Data.DetectObject_Element>();
			for (int i = 0; i < context.Length("DetectObject.Data.Elements.Length"); i++) {
				DetectObjectResponse.DetectObject_Data.DetectObject_Element element = new DetectObjectResponse.DetectObject_Data.DetectObject_Element();
				element.Score = context.FloatValue("DetectObject.Data.Elements["+ i +"].Score");
				element.Type = context.StringValue("DetectObject.Data.Elements["+ i +"].Type");

				List<string> element_boxes = new List<string>();
				for (int j = 0; j < context.Length("DetectObject.Data.Elements["+ i +"].Boxes.Length"); j++) {
					element_boxes.Add(context.StringValue("DetectObject.Data.Elements["+ i +"].Boxes["+ j +"]"));
				}
				element.Boxes = element_boxes;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			detectObjectResponse.Data = data;
        
			return detectObjectResponse;
        }
    }
}
