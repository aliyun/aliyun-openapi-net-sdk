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
    public class ListDataStatisticsByDayResponseUnmarshaller
    {
        public static ListDataStatisticsByDayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataStatisticsByDayResponse listDataStatisticsByDayResponse = new ListDataStatisticsByDayResponse();

			listDataStatisticsByDayResponse.HttpResponse = _ctx.HttpResponse;
			listDataStatisticsByDayResponse.Code = _ctx.StringValue("ListDataStatisticsByDay.Code");
			listDataStatisticsByDayResponse.Message = _ctx.StringValue("ListDataStatisticsByDay.Message");
			listDataStatisticsByDayResponse.RequestId = _ctx.StringValue("ListDataStatisticsByDay.RequestId");
			listDataStatisticsByDayResponse.PageNumber = _ctx.LongValue("ListDataStatisticsByDay.PageNumber");
			listDataStatisticsByDayResponse.PageSize = _ctx.LongValue("ListDataStatisticsByDay.PageSize");
			listDataStatisticsByDayResponse.TotalCount = _ctx.LongValue("ListDataStatisticsByDay.TotalCount");

			List<ListDataStatisticsByDayResponse.ListDataStatisticsByDay_Datas> listDataStatisticsByDayResponse_data = new List<ListDataStatisticsByDayResponse.ListDataStatisticsByDay_Datas>();
			for (int i = 0; i < _ctx.Length("ListDataStatisticsByDay.Data.Length"); i++) {
				ListDataStatisticsByDayResponse.ListDataStatisticsByDay_Datas datas = new ListDataStatisticsByDayResponse.ListDataStatisticsByDay_Datas();
				datas.Date = _ctx.StringValue("ListDataStatisticsByDay.Data["+ i +"].Date");
				datas.CorpId = _ctx.StringValue("ListDataStatisticsByDay.Data["+ i +"].CorpId");
				datas.FaceNumber = _ctx.IntegerValue("ListDataStatisticsByDay.Data["+ i +"].FaceNumber");
				datas.BodyNumber = _ctx.IntegerValue("ListDataStatisticsByDay.Data["+ i +"].BodyNumber");
				datas.MotorNumber = _ctx.IntegerValue("ListDataStatisticsByDay.Data["+ i +"].MotorNumber");
				datas.NonMotorNumber = _ctx.IntegerValue("ListDataStatisticsByDay.Data["+ i +"].NonMotorNumber");
				datas.TotalNumber = _ctx.IntegerValue("ListDataStatisticsByDay.Data["+ i +"].TotalNumber");

				listDataStatisticsByDayResponse_data.Add(datas);
			}
			listDataStatisticsByDayResponse.Data = listDataStatisticsByDayResponse_data;
        
			return listDataStatisticsByDayResponse;
        }
    }
}
