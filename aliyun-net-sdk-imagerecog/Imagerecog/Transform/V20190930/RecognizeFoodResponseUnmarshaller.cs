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
    public class RecognizeFoodResponseUnmarshaller
    {
        public static RecognizeFoodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeFoodResponse recognizeFoodResponse = new RecognizeFoodResponse();

			recognizeFoodResponse.HttpResponse = _ctx.HttpResponse;
			recognizeFoodResponse.Message = _ctx.StringValue("RecognizeFood.Message");
			recognizeFoodResponse.RequestId = _ctx.StringValue("RecognizeFood.RequestId");
			recognizeFoodResponse.Code = _ctx.StringValue("RecognizeFood.Code");

			RecognizeFoodResponse.RecognizeFood_Data data = new RecognizeFoodResponse.RecognizeFood_Data();

			List<RecognizeFoodResponse.RecognizeFood_Data.RecognizeFood_TopFivesItem> data_topFives = new List<RecognizeFoodResponse.RecognizeFood_Data.RecognizeFood_TopFivesItem>();
			for (int i = 0; i < _ctx.Length("RecognizeFood.Data.TopFives.Length"); i++) {
				RecognizeFoodResponse.RecognizeFood_Data.RecognizeFood_TopFivesItem topFivesItem = new RecognizeFoodResponse.RecognizeFood_Data.RecognizeFood_TopFivesItem();
				topFivesItem.Calorie = _ctx.StringValue("RecognizeFood.Data.TopFives["+ i +"].Calorie");
				topFivesItem.Score = _ctx.FloatValue("RecognizeFood.Data.TopFives["+ i +"].Score");
				topFivesItem.Category = _ctx.StringValue("RecognizeFood.Data.TopFives["+ i +"].Category");

				data_topFives.Add(topFivesItem);
			}
			data.TopFives = data_topFives;
			recognizeFoodResponse.Data = data;
        
			return recognizeFoodResponse;
        }
    }
}
