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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class PageQuerySharedSpeechOpenResponseUnmarshaller
    {
        public static PageQuerySharedSpeechOpenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PageQuerySharedSpeechOpenResponse pageQuerySharedSpeechOpenResponse = new PageQuerySharedSpeechOpenResponse();

			pageQuerySharedSpeechOpenResponse.HttpResponse = _ctx.HttpResponse;
			pageQuerySharedSpeechOpenResponse.RequestId = _ctx.StringValue("PageQuerySharedSpeechOpen.RequestId");
			pageQuerySharedSpeechOpenResponse.Success = _ctx.BooleanValue("PageQuerySharedSpeechOpen.Success");
			pageQuerySharedSpeechOpenResponse.Code = _ctx.StringValue("PageQuerySharedSpeechOpen.Code");
			pageQuerySharedSpeechOpenResponse.ErrorMessage = _ctx.StringValue("PageQuerySharedSpeechOpen.ErrorMessage");

			PageQuerySharedSpeechOpenResponse.PageQuerySharedSpeechOpen_Data data = new PageQuerySharedSpeechOpenResponse.PageQuerySharedSpeechOpen_Data();
			data.PageId = _ctx.IntegerValue("PageQuerySharedSpeechOpen.Data.PageId");
			data.PageSize = _ctx.IntegerValue("PageQuerySharedSpeechOpen.Data.PageSize");
			data.Total = _ctx.IntegerValue("PageQuerySharedSpeechOpen.Data.Total");

			List<PageQuerySharedSpeechOpenResponse.PageQuerySharedSpeechOpen_Data.PageQuerySharedSpeechOpen_Data1> data_resultData = new List<PageQuerySharedSpeechOpenResponse.PageQuerySharedSpeechOpen_Data.PageQuerySharedSpeechOpen_Data1>();
			for (int i = 0; i < _ctx.Length("PageQuerySharedSpeechOpen.Data.ResultData.Length"); i++) {
				PageQuerySharedSpeechOpenResponse.PageQuerySharedSpeechOpen_Data.PageQuerySharedSpeechOpen_Data1 data1 = new PageQuerySharedSpeechOpenResponse.PageQuerySharedSpeechOpen_Data.PageQuerySharedSpeechOpen_Data1();
				data1.Code = _ctx.StringValue("PageQuerySharedSpeechOpen.Data.ResultData["+ i +"].Code");
				data1.BizCode = _ctx.StringValue("PageQuerySharedSpeechOpen.Data.ResultData["+ i +"].BizCode");
				data1.Text = _ctx.StringValue("PageQuerySharedSpeechOpen.Data.ResultData["+ i +"].Text");
				data1.Voice = _ctx.StringValue("PageQuerySharedSpeechOpen.Data.ResultData["+ i +"].Voice");
				data1.SpeechRate = _ctx.IntegerValue("PageQuerySharedSpeechOpen.Data.ResultData["+ i +"].SpeechRate");
				data1.Volume = _ctx.IntegerValue("PageQuerySharedSpeechOpen.Data.ResultData["+ i +"].Volume");
				data1.AudioFormat = _ctx.StringValue("PageQuerySharedSpeechOpen.Data.ResultData["+ i +"].AudioFormat");
				data1.Status = _ctx.IntegerValue("PageQuerySharedSpeechOpen.Data.ResultData["+ i +"].Status");

				data_resultData.Add(data1);
			}
			data.ResultData = data_resultData;
			pageQuerySharedSpeechOpenResponse.Data = data;
        
			return pageQuerySharedSpeechOpenResponse;
        }
    }
}
