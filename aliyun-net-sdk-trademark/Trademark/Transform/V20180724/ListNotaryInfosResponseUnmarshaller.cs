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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class ListNotaryInfosResponseUnmarshaller
    {
        public static ListNotaryInfosResponse Unmarshall(UnmarshallerContext context)
        {
			ListNotaryInfosResponse listNotaryInfosResponse = new ListNotaryInfosResponse();

			listNotaryInfosResponse.HttpResponse = context.HttpResponse;
			listNotaryInfosResponse.RequestId = context.StringValue("ListNotaryInfos.RequestId");
			listNotaryInfosResponse.TotalItemNum = context.IntegerValue("ListNotaryInfos.TotalItemNum");
			listNotaryInfosResponse.CurrentPageNum = context.IntegerValue("ListNotaryInfos.CurrentPageNum");
			listNotaryInfosResponse.PageSize = context.IntegerValue("ListNotaryInfos.PageSize");
			listNotaryInfosResponse.TotalPageNum = context.IntegerValue("ListNotaryInfos.TotalPageNum");
			listNotaryInfosResponse.PrePage = context.BooleanValue("ListNotaryInfos.PrePage");
			listNotaryInfosResponse.NextPage = context.BooleanValue("ListNotaryInfos.NextPage");
			listNotaryInfosResponse.Success = context.BooleanValue("ListNotaryInfos.Success");
			listNotaryInfosResponse.ErrorMsg = context.StringValue("ListNotaryInfos.ErrorMsg");
			listNotaryInfosResponse.ErrorCode = context.StringValue("ListNotaryInfos.ErrorCode");

			List<ListNotaryInfosResponse.ListNotaryInfos_NotaryInfo> listNotaryInfosResponse_data = new List<ListNotaryInfosResponse.ListNotaryInfos_NotaryInfo>();
			for (int i = 0; i < context.Length("ListNotaryInfos.Data.Length"); i++) {
				ListNotaryInfosResponse.ListNotaryInfos_NotaryInfo notaryInfo = new ListNotaryInfosResponse.ListNotaryInfos_NotaryInfo();
				notaryInfo.BizOrderNo = context.StringValue("ListNotaryInfos.Data["+ i +"].BizOrderNo");
				notaryInfo.Token = context.StringValue("ListNotaryInfos.Data["+ i +"].Token");
				notaryInfo.NotaryStatus = context.IntegerValue("ListNotaryInfos.Data["+ i +"].NotaryStatus");
				notaryInfo.TmRegisterNo = context.StringValue("ListNotaryInfos.Data["+ i +"].TmRegisterNo");
				notaryInfo.TmClassification = context.StringValue("ListNotaryInfos.Data["+ i +"].TmClassification");
				notaryInfo.GmtModified = context.LongValue("ListNotaryInfos.Data["+ i +"].GmtModified");
				notaryInfo.NotaryFailedReason = context.StringValue("ListNotaryInfos.Data["+ i +"].NotaryFailedReason");

				listNotaryInfosResponse_data.Add(notaryInfo);
			}
			listNotaryInfosResponse.Data = listNotaryInfosResponse_data;
        
			return listNotaryInfosResponse;
        }
    }
}
