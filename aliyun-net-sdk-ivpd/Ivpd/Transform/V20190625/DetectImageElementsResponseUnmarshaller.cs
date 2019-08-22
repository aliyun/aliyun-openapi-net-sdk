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
using Aliyun.Acs.ivpd.Model.V20190625;

namespace Aliyun.Acs.ivpd.Transform.V20190625
{
    public class DetectImageElementsResponseUnmarshaller
    {
        public static DetectImageElementsResponse Unmarshall(UnmarshallerContext context)
        {
			DetectImageElementsResponse detectImageElementsResponse = new DetectImageElementsResponse();

			detectImageElementsResponse.HttpResponse = context.HttpResponse;
			detectImageElementsResponse.RequestId = context.StringValue("DetectImageElements.RequestId");
			detectImageElementsResponse.Code = context.StringValue("DetectImageElements.Code");
			detectImageElementsResponse.Message = context.StringValue("DetectImageElements.Message");

			DetectImageElementsResponse.DetectImageElements_Data data = new DetectImageElementsResponse.DetectImageElements_Data();

			List<DetectImageElementsResponse.DetectImageElements_Data.DetectImageElements_Element> data_elements = new List<DetectImageElementsResponse.DetectImageElements_Data.DetectImageElements_Element>();
			for (int i = 0; i < context.Length("DetectImageElements.Data.Elements.Length"); i++) {
				DetectImageElementsResponse.DetectImageElements_Data.DetectImageElements_Element element = new DetectImageElementsResponse.DetectImageElements_Data.DetectImageElements_Element();
				element.Type = context.StringValue("DetectImageElements.Data.Elements["+ i +"].Type");
				element.X = context.IntegerValue("DetectImageElements.Data.Elements["+ i +"].X");
				element.Y = context.IntegerValue("DetectImageElements.Data.Elements["+ i +"].Y");
				element.Width = context.IntegerValue("DetectImageElements.Data.Elements["+ i +"].Width");
				element.Height = context.IntegerValue("DetectImageElements.Data.Elements["+ i +"].Height");
				element.Score = context.FloatValue("DetectImageElements.Data.Elements["+ i +"].Score");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			detectImageElementsResponse.Data = data;
        
			return detectImageElementsResponse;
        }
    }
}
