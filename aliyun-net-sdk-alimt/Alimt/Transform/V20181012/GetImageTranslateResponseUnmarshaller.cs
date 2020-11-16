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
using Aliyun.Acs.alimt.Model.V20181012;

namespace Aliyun.Acs.alimt.Transform.V20181012
{
    public class GetImageTranslateResponseUnmarshaller
    {
        public static GetImageTranslateResponse Unmarshall(UnmarshallerContext context)
        {
			GetImageTranslateResponse getImageTranslateResponse = new GetImageTranslateResponse();

			getImageTranslateResponse.HttpResponse = context.HttpResponse;
			getImageTranslateResponse.RequestId = context.StringValue("GetImageTranslate.RequestId");
			getImageTranslateResponse.Code = context.IntegerValue("GetImageTranslate.Code");
			getImageTranslateResponse.Message = context.StringValue("GetImageTranslate.Message");

			GetImageTranslateResponse.GetImageTranslate_Data data = new GetImageTranslateResponse.GetImageTranslate_Data();
			data.Url = context.StringValue("GetImageTranslate.Data.Url");
			data.Orc = context.StringValue("GetImageTranslate.Data.Orc");
			data.PictureEditor = context.StringValue("GetImageTranslate.Data.PictureEditor");
			getImageTranslateResponse.Data = data;
        
			return getImageTranslateResponse;
        }
    }
}
