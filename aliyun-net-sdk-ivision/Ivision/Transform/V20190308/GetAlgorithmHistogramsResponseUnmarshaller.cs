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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class GetAlgorithmHistogramsResponseUnmarshaller
    {
        public static GetAlgorithmHistogramsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAlgorithmHistogramsResponse getAlgorithmHistogramsResponse = new GetAlgorithmHistogramsResponse();

			getAlgorithmHistogramsResponse.HttpResponse = _ctx.HttpResponse;
			getAlgorithmHistogramsResponse.Message = _ctx.StringValue("GetAlgorithmHistograms.Message");
			getAlgorithmHistogramsResponse.RequestId = _ctx.StringValue("GetAlgorithmHistograms.RequestId");
			getAlgorithmHistogramsResponse.Code = _ctx.StringValue("GetAlgorithmHistograms.Code");
			getAlgorithmHistogramsResponse.Success = _ctx.BooleanValue("GetAlgorithmHistograms.Success");

			GetAlgorithmHistogramsResponse.GetAlgorithmHistograms_Data data = new GetAlgorithmHistogramsResponse.GetAlgorithmHistograms_Data();
			data.FailureCount = _ctx.IntegerValue("GetAlgorithmHistograms.Data.FailureCount");
			data.SuccessCount = _ctx.IntegerValue("GetAlgorithmHistograms.Data.SuccessCount");

			List<GetAlgorithmHistogramsResponse.GetAlgorithmHistograms_Data.GetAlgorithmHistograms_HistogramsItem> data_histograms = new List<GetAlgorithmHistogramsResponse.GetAlgorithmHistograms_Data.GetAlgorithmHistograms_HistogramsItem>();
			for (int i = 0; i < _ctx.Length("GetAlgorithmHistograms.Data.Histograms.Length"); i++) {
				GetAlgorithmHistogramsResponse.GetAlgorithmHistograms_Data.GetAlgorithmHistograms_HistogramsItem histogramsItem = new GetAlgorithmHistogramsResponse.GetAlgorithmHistograms_Data.GetAlgorithmHistograms_HistogramsItem();
				histogramsItem.Time = _ctx.StringValue("GetAlgorithmHistograms.Data.Histograms["+ i +"].Time");
				histogramsItem.FailureCount = _ctx.IntegerValue("GetAlgorithmHistograms.Data.Histograms["+ i +"].FailureCount");
				histogramsItem.SuccessCount = _ctx.IntegerValue("GetAlgorithmHistograms.Data.Histograms["+ i +"].SuccessCount");

				data_histograms.Add(histogramsItem);
			}
			data.Histograms = data_histograms;
			getAlgorithmHistogramsResponse.Data = data;
        
			return getAlgorithmHistogramsResponse;
        }
    }
}
