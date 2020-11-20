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
    public class TranslateGeneralResponseUnmarshaller
    {
        public static TranslateGeneralResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TranslateGeneralResponse translateGeneralResponse = new TranslateGeneralResponse();

			translateGeneralResponse.HttpResponse = _ctx.HttpResponse;
			translateGeneralResponse.RequestId = _ctx.StringValue("TranslateGeneral.RequestId");
			translateGeneralResponse.Code = _ctx.IntegerValue("TranslateGeneral.Code");
			translateGeneralResponse.Message = _ctx.StringValue("TranslateGeneral.Message");

			TranslateGeneralResponse.TranslateGeneral_Data data = new TranslateGeneralResponse.TranslateGeneral_Data();
			data.Translated = _ctx.StringValue("TranslateGeneral.Data.Translated");
			data.WordCount = _ctx.StringValue("TranslateGeneral.Data.WordCount");
			translateGeneralResponse.Data = data;
        
			return translateGeneralResponse;
        }
    }
}
