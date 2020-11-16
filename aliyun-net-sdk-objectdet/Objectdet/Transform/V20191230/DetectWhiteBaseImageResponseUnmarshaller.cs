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
    public class DetectWhiteBaseImageResponseUnmarshaller
    {
        public static DetectWhiteBaseImageResponse Unmarshall(UnmarshallerContext context)
        {
			DetectWhiteBaseImageResponse detectWhiteBaseImageResponse = new DetectWhiteBaseImageResponse();

			detectWhiteBaseImageResponse.HttpResponse = context.HttpResponse;
			detectWhiteBaseImageResponse.RequestId = context.StringValue("DetectWhiteBaseImage.RequestId");

			DetectWhiteBaseImageResponse.DetectWhiteBaseImage_Data data = new DetectWhiteBaseImageResponse.DetectWhiteBaseImage_Data();

			List<DetectWhiteBaseImageResponse.DetectWhiteBaseImage_Data.DetectWhiteBaseImage_Element> data_elements = new List<DetectWhiteBaseImageResponse.DetectWhiteBaseImage_Data.DetectWhiteBaseImage_Element>();
			for (int i = 0; i < context.Length("DetectWhiteBaseImage.Data.Elements.Length"); i++) {
				DetectWhiteBaseImageResponse.DetectWhiteBaseImage_Data.DetectWhiteBaseImage_Element element = new DetectWhiteBaseImageResponse.DetectWhiteBaseImage_Data.DetectWhiteBaseImage_Element();
				element.WhiteBase = context.IntegerValue("DetectWhiteBaseImage.Data.Elements["+ i +"].WhiteBase");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			detectWhiteBaseImageResponse.Data = data;
        
			return detectWhiteBaseImageResponse;
        }
    }
}
