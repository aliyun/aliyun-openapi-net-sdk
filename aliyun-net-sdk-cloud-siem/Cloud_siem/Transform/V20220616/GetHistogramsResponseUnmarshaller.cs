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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class GetHistogramsResponseUnmarshaller
    {
        public static GetHistogramsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetHistogramsResponse getHistogramsResponse = new GetHistogramsResponse();

			getHistogramsResponse.HttpResponse = _ctx.HttpResponse;
			getHistogramsResponse.Success = _ctx.BooleanValue("GetHistograms.Success");
			getHistogramsResponse.Code = _ctx.IntegerValue("GetHistograms.Code");
			getHistogramsResponse.Message = _ctx.StringValue("GetHistograms.Message");
			getHistogramsResponse.ErrCode = _ctx.StringValue("GetHistograms.ErrCode");
			getHistogramsResponse.RequestId = _ctx.StringValue("GetHistograms.RequestId");
			getHistogramsResponse.DyCode = _ctx.StringValue("GetHistograms.DyCode");
			getHistogramsResponse.DyMessage = _ctx.StringValue("GetHistograms.DyMessage");

			GetHistogramsResponse.GetHistograms_Data data = new GetHistogramsResponse.GetHistograms_Data();
			data.Server = _ctx.StringValue("GetHistograms.Data.Server");
			data.TotalCount = _ctx.LongValue("GetHistograms.Data.TotalCount");

			List<GetHistogramsResponse.GetHistograms_Data.GetHistograms_Histogram> data_histograms = new List<GetHistogramsResponse.GetHistograms_Data.GetHistograms_Histogram>();
			for (int i = 0; i < _ctx.Length("GetHistograms.Data.Histograms.Length"); i++) {
				GetHistogramsResponse.GetHistograms_Data.GetHistograms_Histogram histogram = new GetHistogramsResponse.GetHistograms_Data.GetHistograms_Histogram();
				histogram.From = _ctx.IntegerValue("GetHistograms.Data.Histograms["+ i +"].From");
				histogram.To = _ctx.IntegerValue("GetHistograms.Data.Histograms["+ i +"].To");
				histogram.Count = _ctx.LongValue("GetHistograms.Data.Histograms["+ i +"].Count");
				histogram.CompletedOrNot = _ctx.BooleanValue("GetHistograms.Data.Histograms["+ i +"].CompletedOrNot");

				data_histograms.Add(histogram);
			}
			data.Histograms = data_histograms;
			getHistogramsResponse.Data = data;
        
			return getHistogramsResponse;
        }
    }
}
