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
using Aliyun.Acs.hiknoengine.Model.V20190625;

namespace Aliyun.Acs.hiknoengine.Transform.V20190625
{
    public class TranslateTextResponseUnmarshaller
    {
        public static TranslateTextResponse Unmarshall(UnmarshallerContext context)
        {
			TranslateTextResponse translateTextResponse = new TranslateTextResponse();

			translateTextResponse.HttpResponse = context.HttpResponse;
			translateTextResponse.RequestId = context.StringValue("TranslateText.RequestId");
			translateTextResponse.Code = context.StringValue("TranslateText.Code");
			translateTextResponse.Message = context.StringValue("TranslateText.Message");

			TranslateTextResponse.TranslateText_Data data = new TranslateTextResponse.TranslateText_Data();
			data.Text = context.StringValue("TranslateText.Data.Text");
			translateTextResponse.Data = data;
        
			return translateTextResponse;
        }
    }
}
