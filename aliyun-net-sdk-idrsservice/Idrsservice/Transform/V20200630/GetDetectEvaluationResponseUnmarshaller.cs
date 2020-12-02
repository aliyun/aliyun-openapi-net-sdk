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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class GetDetectEvaluationResponseUnmarshaller
    {
        public static GetDetectEvaluationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDetectEvaluationResponse getDetectEvaluationResponse = new GetDetectEvaluationResponse();

			getDetectEvaluationResponse.HttpResponse = _ctx.HttpResponse;
			getDetectEvaluationResponse.Code = _ctx.StringValue("GetDetectEvaluation.Code");
			getDetectEvaluationResponse.Message = _ctx.StringValue("GetDetectEvaluation.Message");
			getDetectEvaluationResponse.RequestId = _ctx.StringValue("GetDetectEvaluation.RequestId");

			List<GetDetectEvaluationResponse.GetDetectEvaluation_DataItem> getDetectEvaluationResponse_data = new List<GetDetectEvaluationResponse.GetDetectEvaluation_DataItem>();
			for (int i = 0; i < _ctx.Length("GetDetectEvaluation.Data.Length"); i++) {
				GetDetectEvaluationResponse.GetDetectEvaluation_DataItem dataItem = new GetDetectEvaluationResponse.GetDetectEvaluation_DataItem();
				dataItem.Day = _ctx.StringValue("GetDetectEvaluation.Data["+ i +"].Day");

				List<GetDetectEvaluationResponse.GetDetectEvaluation_DataItem.GetDetectEvaluation_EvaluationItemListItem> dataItem_evaluationItemList = new List<GetDetectEvaluationResponse.GetDetectEvaluation_DataItem.GetDetectEvaluation_EvaluationItemListItem>();
				for (int j = 0; j < _ctx.Length("GetDetectEvaluation.Data["+ i +"].EvaluationItemList.Length"); j++) {
					GetDetectEvaluationResponse.GetDetectEvaluation_DataItem.GetDetectEvaluation_EvaluationItemListItem evaluationItemListItem = new GetDetectEvaluationResponse.GetDetectEvaluation_DataItem.GetDetectEvaluation_EvaluationItemListItem();
					evaluationItemListItem.Name = _ctx.StringValue("GetDetectEvaluation.Data["+ i +"].EvaluationItemList["+ j +"].Name");
					evaluationItemListItem.HandleCount = _ctx.IntegerValue("GetDetectEvaluation.Data["+ i +"].EvaluationItemList["+ j +"].HandleCount");
					evaluationItemListItem.SuccessCount = _ctx.IntegerValue("GetDetectEvaluation.Data["+ i +"].EvaluationItemList["+ j +"].SuccessCount");
					evaluationItemListItem.SuccessRate = _ctx.StringValue("GetDetectEvaluation.Data["+ i +"].EvaluationItemList["+ j +"].SuccessRate");

					dataItem_evaluationItemList.Add(evaluationItemListItem);
				}
				dataItem.EvaluationItemList = dataItem_evaluationItemList;

				getDetectEvaluationResponse_data.Add(dataItem);
			}
			getDetectEvaluationResponse.Data = getDetectEvaluationResponse_data;
        
			return getDetectEvaluationResponse;
        }
    }
}
