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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListBizChainDataResponseUnmarshaller
    {
        public static ListBizChainDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBizChainDataResponse listBizChainDataResponse = new ListBizChainDataResponse();

			listBizChainDataResponse.HttpResponse = _ctx.HttpResponse;
			listBizChainDataResponse.Code = _ctx.StringValue("ListBizChainData.Code");
			listBizChainDataResponse.HttpStatusCode = _ctx.IntegerValue("ListBizChainData.HttpStatusCode");
			listBizChainDataResponse.Message = _ctx.StringValue("ListBizChainData.Message");
			listBizChainDataResponse.RequestId = _ctx.StringValue("ListBizChainData.RequestId");
			listBizChainDataResponse.Success = _ctx.BooleanValue("ListBizChainData.Success");

			ListBizChainDataResponse.ListBizChainData_Data data = new ListBizChainDataResponse.ListBizChainData_Data();
			data.Num = _ctx.IntegerValue("ListBizChainData.Data.Num");
			data.Total = _ctx.IntegerValue("ListBizChainData.Data.Total");
			data.Size = _ctx.IntegerValue("ListBizChainData.Data.Size");

			List<ListBizChainDataResponse.ListBizChainData_Data.ListBizChainData_BizChainDataInfo> data_pageData = new List<ListBizChainDataResponse.ListBizChainData_Data.ListBizChainData_BizChainDataInfo>();
			for (int i = 0; i < _ctx.Length("ListBizChainData.Data.PageData.Length"); i++) {
				ListBizChainDataResponse.ListBizChainData_Data.ListBizChainData_BizChainDataInfo bizChainDataInfo = new ListBizChainDataResponse.ListBizChainData_Data.ListBizChainData_BizChainDataInfo();
				bizChainDataInfo.BlockNum = _ctx.StringValue("ListBizChainData.Data.PageData["+ i +"].BlockNum");
				bizChainDataInfo.ProductKey = _ctx.StringValue("ListBizChainData.Data.PageData["+ i +"].ProductKey");
				bizChainDataInfo.MemberName = _ctx.StringValue("ListBizChainData.Data.PageData["+ i +"].MemberName");
				bizChainDataInfo.DeviceName = _ctx.StringValue("ListBizChainData.Data.PageData["+ i +"].DeviceName");
				bizChainDataInfo.BlockHash = _ctx.StringValue("ListBizChainData.Data.PageData["+ i +"].BlockHash");
				bizChainDataInfo.TxHash = _ctx.StringValue("ListBizChainData.Data.PageData["+ i +"].TxHash");
				bizChainDataInfo.Timestamp = _ctx.LongValue("ListBizChainData.Data.PageData["+ i +"].Timestamp");
				bizChainDataInfo.IotDataDID = _ctx.StringValue("ListBizChainData.Data.PageData["+ i +"].IotDataDID");

				data_pageData.Add(bizChainDataInfo);
			}
			data.PageData = data_pageData;
			listBizChainDataResponse.Data = data;
        
			return listBizChainDataResponse;
        }
    }
}
