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
    public class ClassifyingRubbishResponseUnmarshaller
    {
        public static ClassifyingRubbishResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ClassifyingRubbishResponse classifyingRubbishResponse = new ClassifyingRubbishResponse();

			classifyingRubbishResponse.HttpResponse = _ctx.HttpResponse;
			classifyingRubbishResponse.RequestId = _ctx.StringValue("ClassifyingRubbish.RequestId");

			ClassifyingRubbishResponse.ClassifyingRubbish_Data data = new ClassifyingRubbishResponse.ClassifyingRubbish_Data();
			data.Sensitive = _ctx.BooleanValue("ClassifyingRubbish.Data.Sensitive");

			List<ClassifyingRubbishResponse.ClassifyingRubbish_Data.ClassifyingRubbish_Element> data_elements = new List<ClassifyingRubbishResponse.ClassifyingRubbish_Data.ClassifyingRubbish_Element>();
			for (int i = 0; i < _ctx.Length("ClassifyingRubbish.Data.Elements.Length"); i++) {
				ClassifyingRubbishResponse.ClassifyingRubbish_Data.ClassifyingRubbish_Element element = new ClassifyingRubbishResponse.ClassifyingRubbish_Data.ClassifyingRubbish_Element();
				element.Category = _ctx.StringValue("ClassifyingRubbish.Data.Elements["+ i +"].Category");
				element.CategoryScore = _ctx.FloatValue("ClassifyingRubbish.Data.Elements["+ i +"].CategoryScore");
				element.Rubbish = _ctx.StringValue("ClassifyingRubbish.Data.Elements["+ i +"].Rubbish");
				element.RubbishScore = _ctx.FloatValue("ClassifyingRubbish.Data.Elements["+ i +"].RubbishScore");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			classifyingRubbishResponse.Data = data;
        
			return classifyingRubbishResponse;
        }
    }
}
