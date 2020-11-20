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
using Aliyun.Acs.imageenhan.Model.V20190930;

namespace Aliyun.Acs.imageenhan.Transform.V20190930
{
    public class IntelligentCompositionResponseUnmarshaller
    {
        public static IntelligentCompositionResponse Unmarshall(UnmarshallerContext context)
        {
			IntelligentCompositionResponse intelligentCompositionResponse = new IntelligentCompositionResponse();

			intelligentCompositionResponse.HttpResponse = context.HttpResponse;
			intelligentCompositionResponse.RequestId = context.StringValue("IntelligentComposition.RequestId");

			IntelligentCompositionResponse.IntelligentComposition_Data data = new IntelligentCompositionResponse.IntelligentComposition_Data();

			List<IntelligentCompositionResponse.IntelligentComposition_Data.IntelligentComposition_Element> data_elements = new List<IntelligentCompositionResponse.IntelligentComposition_Data.IntelligentComposition_Element>();
			for (int i = 0; i < context.Length("IntelligentComposition.Data.Elements.Length"); i++) {
				IntelligentCompositionResponse.IntelligentComposition_Data.IntelligentComposition_Element element = new IntelligentCompositionResponse.IntelligentComposition_Data.IntelligentComposition_Element();
				element.MinX = context.IntegerValue("IntelligentComposition.Data.Elements["+ i +"].MinX");
				element.MinY = context.IntegerValue("IntelligentComposition.Data.Elements["+ i +"].MinY");
				element.MaxX = context.IntegerValue("IntelligentComposition.Data.Elements["+ i +"].MaxX");
				element.MaxY = context.IntegerValue("IntelligentComposition.Data.Elements["+ i +"].MaxY");
				element.Score = context.FloatValue("IntelligentComposition.Data.Elements["+ i +"].Score");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			intelligentCompositionResponse.Data = data;
        
			return intelligentCompositionResponse;
        }
    }
}
