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
    public class ListPersonVisitCountResponseUnmarshaller
    {
        public static ListPersonVisitCountResponse Unmarshall(UnmarshallerContext context)
        {
			ListPersonVisitCountResponse listPersonVisitCountResponse = new ListPersonVisitCountResponse();

			listPersonVisitCountResponse.HttpResponse = context.HttpResponse;
			listPersonVisitCountResponse.Code = context.StringValue("ListPersonVisitCount.Code");
			listPersonVisitCountResponse.Message = context.StringValue("ListPersonVisitCount.Message");
			listPersonVisitCountResponse.PageNo = context.StringValue("ListPersonVisitCount.PageNo");
			listPersonVisitCountResponse.PageSize = context.StringValue("ListPersonVisitCount.PageSize");
			listPersonVisitCountResponse.RequestId = context.StringValue("ListPersonVisitCount.RequestId");
			listPersonVisitCountResponse.Success = context.StringValue("ListPersonVisitCount.Success");
			listPersonVisitCountResponse.TotalCount = context.StringValue("ListPersonVisitCount.TotalCount");

			List<ListPersonVisitCountResponse.ListPersonVisitCount_Datas> listPersonVisitCountResponse_data = new List<ListPersonVisitCountResponse.ListPersonVisitCount_Datas>();
			for (int i = 0; i < context.Length("ListPersonVisitCount.Data.Length"); i++) {
				ListPersonVisitCountResponse.ListPersonVisitCount_Datas datas = new ListPersonVisitCountResponse.ListPersonVisitCount_Datas();
				datas.CorpId = context.StringValue("ListPersonVisitCount.Data["+ i +"].CorpId");
				datas.DeviceId = context.StringValue("ListPersonVisitCount.Data["+ i +"].DeviceId");
				datas.GroupId = context.StringValue("ListPersonVisitCount.Data["+ i +"].GroupId");
				datas.PersonId = context.StringValue("ListPersonVisitCount.Data["+ i +"].PersonId");
				datas.TagCode = context.StringValue("ListPersonVisitCount.Data["+ i +"].TagCode");
				datas.TagMetrics = context.StringValue("ListPersonVisitCount.Data["+ i +"].TagMetrics");
				datas.HourId = context.StringValue("ListPersonVisitCount.Data["+ i +"].HourId");
				datas.DayId = context.StringValue("ListPersonVisitCount.Data["+ i +"].DayId");

				listPersonVisitCountResponse_data.Add(datas);
			}
			listPersonVisitCountResponse.Data = listPersonVisitCountResponse_data;
        
			return listPersonVisitCountResponse;
        }
    }
}
