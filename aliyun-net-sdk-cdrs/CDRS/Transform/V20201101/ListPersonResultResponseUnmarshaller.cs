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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListPersonResultResponseUnmarshaller
    {
        public static ListPersonResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersonResultResponse listPersonResultResponse = new ListPersonResultResponse();

			listPersonResultResponse.HttpResponse = _ctx.HttpResponse;
			listPersonResultResponse.Code = _ctx.StringValue("ListPersonResult.Code");
			listPersonResultResponse.Message = _ctx.StringValue("ListPersonResult.Message");
			listPersonResultResponse.RequestId = _ctx.StringValue("ListPersonResult.RequestId");
			listPersonResultResponse.PageNumber = _ctx.LongValue("ListPersonResult.PageNumber");
			listPersonResultResponse.PageSize = _ctx.LongValue("ListPersonResult.PageSize");
			listPersonResultResponse.TotalCount = _ctx.LongValue("ListPersonResult.TotalCount");

			List<ListPersonResultResponse.ListPersonResult_Datas> listPersonResultResponse_data = new List<ListPersonResultResponse.ListPersonResult_Datas>();
			for (int i = 0; i < _ctx.Length("ListPersonResult.Data.Length"); i++) {
				ListPersonResultResponse.ListPersonResult_Datas datas = new ListPersonResultResponse.ListPersonResult_Datas();
				datas.PersonId = _ctx.StringValue("ListPersonResult.Data["+ i +"].PersonId");
				datas.Gender = _ctx.StringValue("ListPersonResult.Data["+ i +"].Gender");
				datas.Age = _ctx.StringValue("ListPersonResult.Data["+ i +"].Age");
				datas.Profession = _ctx.StringValue("ListPersonResult.Data["+ i +"].Profession");
				datas.Address = _ctx.StringValue("ListPersonResult.Data["+ i +"].Address");
				datas.Transportation = _ctx.StringValue("ListPersonResult.Data["+ i +"].Transportation");
				datas.PersonType = _ctx.StringValue("ListPersonResult.Data["+ i +"].PersonType");
				datas.HotSpotAddress = _ctx.StringValue("ListPersonResult.Data["+ i +"].HotSpotAddress");
				datas.UpdateTime = _ctx.StringValue("ListPersonResult.Data["+ i +"].UpdateTime");
				datas.TargetUrl = _ctx.StringValue("ListPersonResult.Data["+ i +"].TargetUrl");
				datas.SourceUrl = _ctx.StringValue("ListPersonResult.Data["+ i +"].SourceUrl");

				listPersonResultResponse_data.Add(datas);
			}
			listPersonResultResponse.Data = listPersonResultResponse_data;
        
			return listPersonResultResponse;
        }
    }
}
