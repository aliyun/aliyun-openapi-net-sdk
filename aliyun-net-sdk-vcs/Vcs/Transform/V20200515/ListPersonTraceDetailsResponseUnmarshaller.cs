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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListPersonTraceDetailsResponseUnmarshaller
    {
        public static ListPersonTraceDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPersonTraceDetailsResponse listPersonTraceDetailsResponse = new ListPersonTraceDetailsResponse();

			listPersonTraceDetailsResponse.HttpResponse = context.HttpResponse;
			listPersonTraceDetailsResponse.Code = context.StringValue("ListPersonTraceDetails.Code");
			listPersonTraceDetailsResponse.Message = context.StringValue("ListPersonTraceDetails.Message");
			listPersonTraceDetailsResponse.RequestId = context.StringValue("ListPersonTraceDetails.RequestId");
			listPersonTraceDetailsResponse.PageNumber = context.LongValue("ListPersonTraceDetails.PageNumber");
			listPersonTraceDetailsResponse.PageSize = context.LongValue("ListPersonTraceDetails.PageSize");
			listPersonTraceDetailsResponse.TotalCount = context.LongValue("ListPersonTraceDetails.TotalCount");

			List<ListPersonTraceDetailsResponse.ListPersonTraceDetails_Datas> listPersonTraceDetailsResponse_data = new List<ListPersonTraceDetailsResponse.ListPersonTraceDetails_Datas>();
			for (int i = 0; i < context.Length("ListPersonTraceDetails.Data.Length"); i++) {
				ListPersonTraceDetailsResponse.ListPersonTraceDetails_Datas datas = new ListPersonTraceDetailsResponse.ListPersonTraceDetails_Datas();
				datas.TargetPicUrlPath = context.StringValue("ListPersonTraceDetails.Data["+ i +"].TargetPicUrlPath");
				datas.DataSourceId = context.StringValue("ListPersonTraceDetails.Data["+ i +"].DataSourceId");
				datas.PersonId = context.StringValue("ListPersonTraceDetails.Data["+ i +"].PersonId");
				datas.PicUrlPath = context.StringValue("ListPersonTraceDetails.Data["+ i +"].PicUrlPath");
				datas.RightBottomY = context.StringValue("ListPersonTraceDetails.Data["+ i +"].RightBottomY");
				datas.RightBottomX = context.StringValue("ListPersonTraceDetails.Data["+ i +"].RightBottomX");
				datas.ShotTime = context.StringValue("ListPersonTraceDetails.Data["+ i +"].ShotTime");
				datas.CorpId = context.StringValue("ListPersonTraceDetails.Data["+ i +"].CorpId");
				datas.SubId = context.StringValue("ListPersonTraceDetails.Data["+ i +"].SubId");
				datas.LeftTopY = context.StringValue("ListPersonTraceDetails.Data["+ i +"].LeftTopY");
				datas.LeftTopX = context.StringValue("ListPersonTraceDetails.Data["+ i +"].LeftTopX");

				listPersonTraceDetailsResponse_data.Add(datas);
			}
			listPersonTraceDetailsResponse.Data = listPersonTraceDetailsResponse_data;
        
			return listPersonTraceDetailsResponse;
        }
    }
}
