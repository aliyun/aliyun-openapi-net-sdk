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
    public class DetectChefCapResponseUnmarshaller
    {
        public static DetectChefCapResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectChefCapResponse detectChefCapResponse = new DetectChefCapResponse();

			detectChefCapResponse.HttpResponse = _ctx.HttpResponse;
			detectChefCapResponse.RequestId = _ctx.StringValue("DetectChefCap.RequestId");

			DetectChefCapResponse.DetectChefCap_Data data = new DetectChefCapResponse.DetectChefCap_Data();

			List<DetectChefCapResponse.DetectChefCap_Data.DetectChefCap_ElementsItem> data_elements = new List<DetectChefCapResponse.DetectChefCap_Data.DetectChefCap_ElementsItem>();
			for (int i = 0; i < _ctx.Length("DetectChefCap.Data.Elements.Length"); i++) {
				DetectChefCapResponse.DetectChefCap_Data.DetectChefCap_ElementsItem elementsItem = new DetectChefCapResponse.DetectChefCap_Data.DetectChefCap_ElementsItem();
				elementsItem.Category = _ctx.StringValue("DetectChefCap.Data.Elements["+ i +"].Category");
				elementsItem.Confidence = _ctx.FloatValue("DetectChefCap.Data.Elements["+ i +"].Confidence");

				List<string> elementsItem_box = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectChefCap.Data.Elements["+ i +"].Box.Length"); j++) {
					elementsItem_box.Add(_ctx.StringValue("DetectChefCap.Data.Elements["+ i +"].Box["+ j +"]"));
				}
				elementsItem.Box = elementsItem_box;

				data_elements.Add(elementsItem);
			}
			data.Elements = data_elements;
			detectChefCapResponse.Data = data;
        
			return detectChefCapResponse;
        }
    }
}
