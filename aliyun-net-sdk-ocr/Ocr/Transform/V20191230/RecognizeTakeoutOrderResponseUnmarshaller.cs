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
using Aliyun.Acs.ocr.Model.V20191230;

namespace Aliyun.Acs.ocr.Transform.V20191230
{
    public class RecognizeTakeoutOrderResponseUnmarshaller
    {
        public static RecognizeTakeoutOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeTakeoutOrderResponse recognizeTakeoutOrderResponse = new RecognizeTakeoutOrderResponse();

			recognizeTakeoutOrderResponse.HttpResponse = _ctx.HttpResponse;
			recognizeTakeoutOrderResponse.RequestId = _ctx.StringValue("RecognizeTakeoutOrder.RequestId");

			RecognizeTakeoutOrderResponse.RecognizeTakeoutOrder_Data data = new RecognizeTakeoutOrderResponse.RecognizeTakeoutOrder_Data();

			List<RecognizeTakeoutOrderResponse.RecognizeTakeoutOrder_Data.RecognizeTakeoutOrder_Element> data_elements = new List<RecognizeTakeoutOrderResponse.RecognizeTakeoutOrder_Data.RecognizeTakeoutOrder_Element>();
			for (int i = 0; i < _ctx.Length("RecognizeTakeoutOrder.Data.Elements.Length"); i++) {
				RecognizeTakeoutOrderResponse.RecognizeTakeoutOrder_Data.RecognizeTakeoutOrder_Element element = new RecognizeTakeoutOrderResponse.RecognizeTakeoutOrder_Data.RecognizeTakeoutOrder_Element();
				element.Score = _ctx.FloatValue("RecognizeTakeoutOrder.Data.Elements["+ i +"].Score");
				element.Name = _ctx.StringValue("RecognizeTakeoutOrder.Data.Elements["+ i +"].Name");
				element._Value = _ctx.StringValue("RecognizeTakeoutOrder.Data.Elements["+ i +"].Value");

				List<string> element_boxes = new List<string>();
				for (int j = 0; j < _ctx.Length("RecognizeTakeoutOrder.Data.Elements["+ i +"].Boxes.Length"); j++) {
					element_boxes.Add(_ctx.StringValue("RecognizeTakeoutOrder.Data.Elements["+ i +"].Boxes["+ j +"]"));
				}
				element.Boxes = element_boxes;

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			recognizeTakeoutOrderResponse.Data = data;
        
			return recognizeTakeoutOrderResponse;
        }
    }
}
