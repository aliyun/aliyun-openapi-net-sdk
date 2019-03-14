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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class GetLogHistogramResponseUnmarshaller
    {
        public static GetLogHistogramResponse Unmarshall(UnmarshallerContext context)
        {
			GetLogHistogramResponse getLogHistogramResponse = new GetLogHistogramResponse();

			getLogHistogramResponse.HttpResponse = context.HttpResponse;
			getLogHistogramResponse.RequestId = context.StringValue("GetLogHistogram.RequestId");
			getLogHistogramResponse.Completed = context.BooleanValue("GetLogHistogram.Completed");
			getLogHistogramResponse.TotalCount = context.LongValue("GetLogHistogram.TotalCount");

			List<GetLogHistogramResponse.GetLogHistogram_SlsLogHistogram> getLogHistogramResponse_slsLogHistogramList = new List<GetLogHistogramResponse.GetLogHistogram_SlsLogHistogram>();
			for (int i = 0; i < context.Length("GetLogHistogram.SlsLogHistogramList.Length"); i++) {
				GetLogHistogramResponse.GetLogHistogram_SlsLogHistogram slsLogHistogram = new GetLogHistogramResponse.GetLogHistogram_SlsLogHistogram();
				slsLogHistogram.FromTime = context.IntegerValue("GetLogHistogram.SlsLogHistogramList["+ i +"].FromTime");
				slsLogHistogram.ToTime = context.IntegerValue("GetLogHistogram.SlsLogHistogramList["+ i +"].ToTime");
				slsLogHistogram.Count = context.LongValue("GetLogHistogram.SlsLogHistogramList["+ i +"].Count");
				slsLogHistogram.Completed = context.BooleanValue("GetLogHistogram.SlsLogHistogramList["+ i +"].Completed");

				getLogHistogramResponse_slsLogHistogramList.Add(slsLogHistogram);
			}
			getLogHistogramResponse.SlsLogHistogramList = getLogHistogramResponse_slsLogHistogramList;
        
			return getLogHistogramResponse;
        }
    }
}
