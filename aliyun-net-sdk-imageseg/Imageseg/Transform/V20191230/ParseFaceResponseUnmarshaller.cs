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
    public class ParseFaceResponseUnmarshaller
    {
        public static ParseFaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ParseFaceResponse parseFaceResponse = new ParseFaceResponse();

			parseFaceResponse.HttpResponse = _ctx.HttpResponse;
			parseFaceResponse.RequestId = _ctx.StringValue("ParseFace.RequestId");

			ParseFaceResponse.ParseFace_Data data = new ParseFaceResponse.ParseFace_Data();
			data.OriginImageURL = _ctx.StringValue("ParseFace.Data.OriginImageURL");

			List<ParseFaceResponse.ParseFace_Data.ParseFace_Element> data_elements = new List<ParseFaceResponse.ParseFace_Data.ParseFace_Element>();
			for (int i = 0; i < _ctx.Length("ParseFace.Data.Elements.Length"); i++) {
				ParseFaceResponse.ParseFace_Data.ParseFace_Element element = new ParseFaceResponse.ParseFace_Data.ParseFace_Element();
				element.Name = _ctx.StringValue("ParseFace.Data.Elements["+ i +"].Name");
				element.ImageURL = _ctx.StringValue("ParseFace.Data.Elements["+ i +"].ImageURL");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			parseFaceResponse.Data = data;
        
			return parseFaceResponse;
        }
    }
}
